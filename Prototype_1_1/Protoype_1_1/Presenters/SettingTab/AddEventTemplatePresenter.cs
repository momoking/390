using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI.Forms.SettingTab;
using System.Windows.Forms;
using Prototype1_1.Data;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Presenters.SettingTab
{
    class AddEventTemplatePresenter
    {
        #region Attributes

        AddEventTemplateForm _view;
        soen390Entities _entities;
        List<slot> _slotList;
        List<string> _eventTemplateNameList;
        DateTime _lastSlotEndTime;

        #endregion

        #region Constructor

        public AddEventTemplatePresenter()
        {
            _view = new AddEventTemplateForm();
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
            _view.btnSaveTemplate.Click += btnSaveTemplate_Click;
            _view.btnCancel.Click += btnCancel_Click;
            _view.chkRepeat.CheckedChanged += chkRepeat_CheckedChanged;
            _view.dtpTimeStart.ValueChanged += dtpTime_ValueChanged;
            _view.dtpTimeEnd.ValueChanged += dtpTimeEnd_ValueChanged;
            _view.dtpEnds.ValueChanged += dtpEnds_ValueChanged;

            _view.btnAddSlot.Click += btnAddSlot_Click;
            _view.btnRemoveSlot.Click += btnRemoveSlot_Click;
            _view.lstSlots.Click += lstSlots_Click;
        }

        void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            if (_view.txtName.Text != "")
            {
                DateTime startDate = _view.dtpStarts.Value;
                DateTime startTime = _view.dtpTimeStart.Value;
                DateTime endDate = _view.dtpEnds.Value;
                DateTime endTime = _view.dtpTimeEnd.Value;
                eventtemplate toCreate = new eventtemplate
                {
                    Name = _view.txtName.Text,
                    Location = _view.txtLocation.Text,
                    Description = _view.txtDescription.Text,
                    Start = new DateTime(startDate.Year, startDate.Month, startDate.Day, startTime.Hour, startTime.Minute, startTime.Second),
                    End = new DateTime(endDate.Year, endDate.Month, endDate.Day, endTime.Hour, endTime.Minute, endTime.Second),
                    EventPeriod = (_view.cmbRepeats.SelectedItem != null) ? _view.cmbRepeats.SelectedItem.ToString() : "",
                };

                List<slottemplate> slotTemplateList = new List<slottemplate>(_view.lstSlots.Items.Count);
                foreach (slot s in _slotList)
                {
                    slottemplate slottemp = new slottemplate
                    {
                        Capacity = s.Capacity,
                        Booked = s.Booked,
                        Duration = s.Duration,
                        StartTime = s.StartTime,
                    };
                    slotTemplateList.Add(slottemp);
                }

                _eventTemplateNameList = _entities.eventtemplate.Select(et => et.Name).Distinct().ToList();
                if (!_eventTemplateNameList.Contains(toCreate.Name))
                {
                    _entities.eventtemplate.Add(toCreate);
                    _entities.SaveChanges();

                    foreach (slottemplate s in slotTemplateList)
                        _entities.slottemplate.Add(s);
                    _entities.SaveChanges();

                    foreach (slottemplate s in slotTemplateList)
                        toCreate.slottemplate.Add(s);
                    _entities.SaveChanges();

                    _view.Close();
                }

                else
                {
                    MessageBox.Show("Another template with the same name already exists. Please choose another name", "Invalid template name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Name must not be empty", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
