using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI.Forms.EventsTab;
using Prototype1_1.Data;
using System.Windows.Forms;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Presenters.EventsTab
{
    class CreateEventPresenter
    {
        #region Attributes

        FormCreateEvent _view;
        soen390Entities _entities;
        List<slot> _slotList;
        List<string> _eventTemplateNameList;
        DateTime _lastSlotEndTime;

        #endregion

        #region Constructor

        public CreateEventPresenter()
        {
            _view = new FormCreateEvent();
            _view.cmbRepeats.Items.Add("Weekly");
            _view.cmbRepeats.Items.Add("Bi-Weekly");
            _view.cmbRepeats.Items.Add("Monthly");
            _view.cmbRepeats.Items.Add("Yearly");
            _view.numCapacity.Value = 100;
            _view.cmbRepeats.Enabled = false;

            _entities = EntityModel.getInstance()._soen390Entities;

            _slotList = new List<slot>();

            DateTime now = DateTime.Now;
            _view.dtpTimeStart.Value = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0);
            _view.dtpTimeEnd.Value = _view.dtpTimeStart.Value.AddHours(1);
            _view.numDuration.Maximum = (decimal)(_view.dtpTimeEnd.Value - _view.dtpTimeStart.Value).TotalMinutes;
            _view.numDuration.Value = 5;

            _lastSlotEndTime = _view.dtpTimeStart.Value;

            AttachEventHandlers();
        }

        #endregion

        #region Methods

        private void AttachEventHandlers()
        {
            _view.btnSave.Click += btnSave_Click;
            _view.btnCancel.Click += btnCancel_Click;
            _view.cmbTemplate.DropDown += cmbTemplate_DropDown;
            _view.cmbTemplate.SelectionChangeCommitted += cmbTemplate_SelectionChangeCommitted;
            _view.chkRepeat.CheckedChanged += chkRepeat_CheckedChanged;
            _view.dtpTimeStart.ValueChanged += dtpTime_ValueChanged;
            _view.dtpTimeEnd.ValueChanged += dtpTimeEnd_ValueChanged;
            _view.dtpEnds.ValueChanged += dtpEnds_ValueChanged;

            _view.btnAddSlot.Click += btnAddSlot_Click;
            _view.btnRemoveSlot.Click += btnRemoveSlot_Click;
            _view.lstSlots.Click += lstSlots_Click;
        }

        void cmbTemplate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_view.cmbTemplate.SelectedItem != null)
            {
                string nameEventToLoad = _view.cmbTemplate.SelectedItem.ToString();
                eventtemplate toLoad = _entities.eventtemplate.Where(et => et.Name == nameEventToLoad).First();
                _view.txtName.Text = toLoad.Name;
                _view.txtLocation.Text = toLoad.Location;
                //To avoid error if end < start
                _view.dtpTimeStart.Value = toLoad.End.Value.AddYears(-1);
                _view.dtpTimeEnd.Value = toLoad.End.Value;
                _view.dtpTimeStart.Value = toLoad.Start.Value;
                _view.dtpStarts.Value = toLoad.Start.Value;
                _view.dtpEnds.Value = toLoad.End.Value;
                _view.cmbRepeats.SelectedItem = toLoad.EventPeriod;

                if (toLoad.EventPeriod == "")
                {
                    _view.chkRepeat.Checked = false;
                }
                else
                {
                    _view.chkRepeat.Checked = true;
                }

                List<slot> slotListToLoad = new List<slot>(toLoad.slottemplate.Count);
                foreach (slottemplate slottemp in toLoad.slottemplate.ToList())
                {
                    slot toAdd = new slot
                    {
                        Capacity = slottemp.Capacity,
                        Booked = slottemp.Booked,
                        Duration = slottemp.Duration,
                        StartTime = slottemp.StartTime,
                    };
                    slotListToLoad.Add(toAdd);
                }
                _slotList = slotListToLoad;
                if (_slotList.Count > 0)
                {
                    slot lastSlot = _slotList.Last();
                    _lastSlotEndTime = lastSlot.StartTime.Value.AddMinutes(lastSlot.Duration.Value);
                }
                _view.lstSlots.DataSource = slotListToLoad;
            }
        }

        void cmbTemplate_DropDown(object sender, EventArgs e)
        {
            _eventTemplateNameList = _entities.eventtemplate.Select(et => et.Name).Distinct().ToList();
            _view.cmbTemplate.DataSource = _eventTemplateNameList;
        }

        slot Clone(slot s)
        {
            slot clone = new slot
            {
                Booked = s.Booked,
                Capacity = s.Capacity,
                Duration = s.Duration,
                StartTime = s.StartTime,
                @event = s.@event,
                household = s.household,
            };
            return clone;
        }

        public void ShowDialog()
        {
            _view.ShowDialog();
        }

        #endregion

        #region Events Handling

        void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: Refactor
            List<@event> created = new List<@event>();
            if (_view.txtName.Text != "")
            {
                if (_view.chkRepeat.Checked && _view.cmbRepeats.SelectedItem != null)
                {
                    DateTime current = _view.dtpStarts.Value;
                    switch (_view.cmbRepeats.SelectedItem.ToString())
                    {
                        case "Weekly":
                            while (current.Date <= _view.dtpEnds.Value.Date)
                            {
                                DateTime startDate = current.Date;
                                DateTime startTime = _view.dtpTimeStart.Value;
                                DateTime endDate = current.Date;
                                DateTime endTime = _view.dtpTimeEnd.Value;
                                @event toCreate = new @event
                                {
                                    Name = _view.txtName.Text,
                                    Location = _view.txtLocation.Text,
                                    Description = _view.txtDescription.Text,
                                    Start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startTime.Hour, startTime.Minute, startTime.Second),
                                    End = new DateTime(endDate.Year, endDate.Month, endDate.Day, endTime.Hour, endTime.Minute, endTime.Second),
                                    EventPeriod = "Weekly",
                                };
                                created.Add(toCreate);
                                current = current.AddDays(7);
                            }
                            break;

                        case "Bi-Weekly":
                            while (current.Date <= _view.dtpEnds.Value.Date)
                            {
                                DateTime startDate = current.Date;
                                DateTime startTime = _view.dtpTimeStart.Value;
                                DateTime endDate = current.Date;
                                DateTime endTime = _view.dtpTimeEnd.Value;
                                @event toCreate = new @event
                                {
                                    Name = _view.txtName.Text,
                                    Location = _view.txtLocation.Text,
                                    Description = _view.txtDescription.Text,
                                    Start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startTime.Hour, startTime.Minute, startTime.Second),
                                    End = new DateTime(endDate.Year, endDate.Month, endDate.Day, endTime.Hour, endTime.Minute, endTime.Second),
                                    EventPeriod = "Bi-Weekly",
                                };
                                created.Add(toCreate);
                                current = current.AddDays(14);
                            }
                            break;

                        case "Monthly":
                            while (current.Date <= _view.dtpEnds.Value.Date)
                            {
                                DateTime startDate = current.Date;
                                DateTime startTime = _view.dtpTimeStart.Value;
                                DateTime endDate = current.Date;
                                DateTime endTime = _view.dtpTimeEnd.Value;
                                @event toCreate = new @event
                                {
                                    Name = _view.txtName.Text,
                                    Location = _view.txtLocation.Text,
                                    Description = _view.txtDescription.Text,
                                    Start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startTime.Hour, startTime.Minute, startTime.Second),
                                    End = new DateTime(endDate.Year, endDate.Month, endDate.Day, endTime.Hour, endTime.Minute, endTime.Second),
                                    EventPeriod = "Monthly",
                                };
                                created.Add(toCreate);
                                current = current.AddMonths(1);
                            }
                            break;

                        case "Yearly":
                            while (current.Date <= _view.dtpEnds.Value.Date)
                            {
                                DateTime startDate = current.Date;
                                DateTime startTime = _view.dtpTimeStart.Value;
                                DateTime endDate = current.Date;
                                DateTime endTime = _view.dtpTimeEnd.Value;
                                @event toCreate = new @event
                                {
                                    Name = _view.txtName.Text,
                                    Location = _view.txtLocation.Text,
                                    Description = _view.txtDescription.Text,
                                    Start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startTime.Hour, startTime.Minute, startTime.Second),
                                    End = new DateTime(endDate.Year, endDate.Month, endDate.Day, endTime.Hour, endTime.Minute, endTime.Second),
                                    EventPeriod = "Yearly",
                                };
                                created.Add(toCreate);
                                current = current.AddYears(1);
                            }
                            break;

                        default:
                            DateTime defaultStartDate = _view.dtpStarts.Value;
                            DateTime defaultStartTime = _view.dtpTimeStart.Value;
                            DateTime defaultEndDate = _view.dtpStarts.Value;
                            DateTime defaultEndTime = _view.dtpTimeEnd.Value;
                            @event defaultToCreate = new @event
                            {
                                Name = _view.txtName.Text,
                                Location = _view.txtLocation.Text,
                                Description = _view.txtDescription.Text,
                                Start = new DateTime(defaultStartDate.Year, defaultStartDate.Month, defaultStartDate.Day, defaultStartTime.Hour, defaultStartTime.Minute, defaultStartTime.Second),
                                End = new DateTime(defaultEndDate.Year, defaultEndDate.Month, defaultEndDate.Day, defaultEndTime.Hour, defaultEndTime.Minute, defaultEndTime.Second),
                                EventPeriod = "None",
                            };
                            created.Add(defaultToCreate);
                            break;
                    }
                }

                else
                {
                    DateTime startDate = _view.dtpStarts.Value;
                    DateTime startTime = _view.dtpTimeStart.Value;
                    DateTime endDate = _view.dtpStarts.Value;
                    DateTime endTime = _view.dtpTimeEnd.Value;
                    @event toCreate = new @event
                    {
                        Name = _view.txtName.Text,
                        Location = _view.txtLocation.Text,
                        Description = _view.txtDescription.Text,
                        Start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startTime.Hour, startTime.Minute, startTime.Second),
                        End = new DateTime(endDate.Year, endDate.Month, endDate.Day, endTime.Hour, endTime.Minute, endTime.Second),
                        EventPeriod = "None",
                    };
                    created.Add(toCreate);
                }

                List<slot> allSlots = new List<slot>(15);
                for (int i = 0; i < created.Count; i++)
                {
                    foreach (slot s in _slotList)
                        allSlots.Add(Clone(s));
                }

                foreach (slot s in allSlots)
                    _entities.slot.Add(s);
                _entities.SaveChanges();

                foreach (@event ev in created)
                    _entities.@event.Add(ev);
                _entities.SaveChanges();

                int lastSlotIndex = 0;
                foreach (@event ev in created)
                {
                    for (int i = 0; i < _slotList.Count; i++)
                    {
                        ev.slot.Add(allSlots[lastSlotIndex]);
                        lastSlotIndex++;
                    }
                }
                _entities.SaveChanges();

                EventsPresenter.GetInstance().AddEvents(created);
                _view.Close();
            }

            else
            {
                MessageBox.Show("Name must not be empty", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            _slotList.Clear();
            _view.lstSlots.DataSource = null;
            _view.lstSlots.DataSource = _slotList;
            _lastSlotEndTime = _view.dtpTimeStart.Value;
            _view.dtpTimeEnd.Value = _view.dtpTimeStart.Value.AddHours(1);
            _view.numDuration.Maximum = (decimal)(_view.dtpTimeEnd.Value - _view.dtpTimeStart.Value).TotalMinutes;
        }

        private void dtpTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            _slotList.Clear();
            _view.lstSlots.DataSource = null;
            _view.lstSlots.DataSource = _slotList;


            if (DateTime.Compare(_view.dtpTimeEnd.Value, _view.dtpTimeStart.Value) <= 0)
            {
                MessageBox.Show("End time must be greater than the Start time", "Invalid End Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _view.dtpTimeEnd.Value = _view.dtpTimeStart.Value.AddHours(1);
                _view.numDuration.Maximum = (decimal)(_view.dtpTimeEnd.Value - _view.dtpTimeStart.Value).TotalMinutes;
            }
        }


        void chkRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (_view.chkRepeat.Checked)
            {
                _view.dtpEnds.Enabled = true;
                _view.cmbRepeats.Enabled = true;
            }
            else
            {
                _view.dtpEnds.Enabled = false;
                _view.cmbRepeats.Text = "";
                _view.cmbRepeats.Enabled = false;
            }
        }

        void dtpEnds_ValueChanged(object sender, EventArgs e)
        {
            if (_view.dtpEnds.Value.Date < _view.dtpStarts.Value.Date)
            {
                MessageBox.Show("End Date must be equal or greater than Start Date", "Invalid End Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _view.dtpEnds.Value = _view.dtpStarts.Value;
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            _view.Close();
        }

        #endregion

        #region Slots Handling

        void lstSlots_Click(object sender, EventArgs e)
        {
            if (_view.lstSlots.Items.Count > 0)
                _view.lstSlots.SetSelected(_view.lstSlots.Items.Count - 1, true);
        }

        void btnAddSlot_Click(object sender, EventArgs e)
        {
            if (_view.numDuration.Value > 0)
            {
                slot toAdd = new slot();
                toAdd.Capacity = (long)_view.numCapacity.Value;
                toAdd.Duration = (long)_view.numDuration.Value;
                toAdd.StartTime = _lastSlotEndTime;
                toAdd.Booked = 0;



                if (DateTime.Compare(toAdd.StartTime.Value.AddMinutes(toAdd.Duration.Value), _view.dtpTimeEnd.Value) > 0)
                {
                    MessageBox.Show("Slot End Time is greater than its Event End Time", "Invalid slot duration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _slotList.Add(toAdd);
                    _lastSlotEndTime = _lastSlotEndTime.AddMinutes(toAdd.Duration.Value);
                    _view.lstSlots.DataSource = null;
                    _view.lstSlots.DataSource = _slotList;
                }
            }
        }

        void btnRemoveSlot_Click(object sender, EventArgs e)
        {
            int lastItemIndex = _slotList.Count - 1;
            try
            {
                int minutesToRemove = (int)_slotList[lastItemIndex].Duration.Value;
                _slotList.RemoveAt(lastItemIndex);
                _lastSlotEndTime = _lastSlotEndTime.AddMinutes(-minutesToRemove);
            }
            catch { }

            _view.lstSlots.DataSource = null;
            _view.lstSlots.DataSource = _slotList;
        }

        #endregion

    }
}
