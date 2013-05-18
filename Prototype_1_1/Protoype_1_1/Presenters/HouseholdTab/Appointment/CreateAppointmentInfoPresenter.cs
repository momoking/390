using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.AppointmentModel;
using Prototype1_1.UI.Views.HouseholdTab.Appointment;
using Prototype1_1.Presenters.HouseholdTab.Appointment;
using Prototype1_1.Data.EntityModel;
using System.ComponentModel;
using Prototype1_1.Data.HouseholdModel;
using System.Data;

namespace Prototype1_1.Presenters.HouseholdTab.Appointment
{
    public class CreateAppointmentInfoPresenter
    {
        #region Attributes

        private static CreateAppointmentInfoPresenter _instance;

        private soen390Entities _entities;

        private AppointmentCRUD _model;
        private AppointmentAPI _api;
        private CreateAppointmentInfoView _view;

        private List<@event> _allFutureEvents;

        private DataTable _distinctEventsTable;
        private DataTable _eventsTable;
        private DataTable _slotsTable;

        private List<@event> _distinctEventList;
        private List<@event> _eventList;
        private List<slot> _slotList;

        private string _selectedEventName;

        #endregion

        #region Properties
        public CreateAppointmentInfoView View
        {
            get { return _view; }
        }
        #endregion

        #region Constructor
        private CreateAppointmentInfoPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
            _api = new AppointmentAPI();
            _model = new AppointmentCRUD();

            _allFutureEvents = new List<@event>(50);

            _distinctEventList = new List<@event>(50);
            _distinctEventsTable = new DataTable();
            _distinctEventsTable.Columns.Add("Name");
            _distinctEventsTable.Columns.Add("Location");
            _distinctEventsTable.Columns.Add("Description");

            _eventList = new List<@event>(50);
            _eventsTable = new DataTable();
            _eventsTable.Columns.Add("Date");
            _eventsTable.Columns.Add("Start Time");
            _eventsTable.Columns.Add("End Time");

            _slotList = new List<slot>(10);
            _slotsTable = new DataTable();
            _slotsTable.Columns.Add("Start Time");
            _slotsTable.Columns.Add("Places Left");
        }

        public static CreateAppointmentInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new CreateAppointmentInfoPresenter();
            }

            return _instance;
        }

        public void attachView(CreateAppointmentInfoView aView)
        {
            _view = aView;
            InitializeView();
            AttachEventHandlers();
        }

        private void InitializeView()
        {
            
        }


        #endregion

        #region Methods
        private void AttachEventHandlers()
        {
            _view.Load += new EventHandler(handleOnLoadEvent);
            _view.btnRegister.Click += new EventHandler(handleSaveAppointmentInfo);
            _view.btnCancel.Click += new EventHandler(handleCancelAppointmentInfo);

            _view.dgvDistinctEvents.CellClick += new DataGridViewCellEventHandler(handleEventSelected);
            _view.dgvEvents.CellClick += new DataGridViewCellEventHandler(handleEventDateSelected);

        }

        #endregion

        #region Handlers

        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            _allFutureEvents = _entities.@event.Where(ev => ev.Start >= DateTime.Now).ToList();
            _distinctEventList = _allFutureEvents.GroupBy(gr => gr.Name).Select(x => x.First()).ToList();
            loadEvents(_distinctEventList);
        }

        private void handleEventSelected(object sender, DataGridViewCellEventArgs e)
        {
            if (_view.dgvDistinctEvents.Rows.Count > 0 && e.RowIndex >= 0)
            {
                _selectedEventName = _view.dgvDistinctEvents.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                _eventList = _allFutureEvents.Where(ev => ev.Name == _selectedEventName).ToList();
                loadEventDates(_eventList);
            }
        }

        private void handleEventDateSelected(object sender, DataGridViewCellEventArgs e)
        {
            if (_eventList.Count > 0 && e.RowIndex >= 0)
            {
                loadEventSlots(_eventList[e.RowIndex].slot.ToList());
            }
        }

        private void handleSaveAppointmentInfo(object sender, EventArgs e)
        {
            if (_slotList.Count > 0 && _view.dgvSlots.SelectedRows[0].Index >= 0)
            {
                slot appointment = _slotList[_view.dgvSlots.SelectedRows[0].Index];
                if (appointment.Booked >= appointment.Capacity)
                {
                    MessageBox.Show("Sorry, this event's slot is full", "Event slot at capacity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    household activeHousehold = HouseholdAndClient.HouseholdAndClientPresenter.getInstance().ActiveHousehold;
                    if (activeHousehold.slot.Contains(appointment))
                    {
                        MessageBox.Show("This household is already registered for this event's slot", "Household already registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        appointment.Booked = appointment.Booked + 1;
                        activeHousehold.slot.Add(appointment);
                        _entities.SaveChanges();

                        List<slot> activeSlots = activeHousehold.slot.ToList();
                        if (activeSlots != null)
                        {
                            AppointmentInfoPresenter.getInstance().loadAppointmentInfo(activeSlots);
                        }

                        _view.ParentForm.Close();
                    }
                }
            }
        }

        private void handleCancelAppointmentInfo(object sender, EventArgs e)
        {
            _view.ParentForm.Close();
        }

        private void loadEvents(List<@event> eventList)
        {
            _distinctEventList = eventList;
            _distinctEventsTable.Rows.Clear();
            foreach (@event ev in _distinctEventList)
            {
                var row = _distinctEventsTable.NewRow();
                row["Name"] = ev.Name;
                row["Location"] = ev.Location;
                row["Description"] = ev.Description;
                _distinctEventsTable.Rows.Add(row);
            }

            _view.dgvDistinctEvents.DataSource = _distinctEventsTable;
        }

        private void loadEventDates(List<@event> eventList)
        {
            _eventList = eventList;
            _eventsTable.Rows.Clear();
            foreach (@event ev in _eventList)
            {
                var row = _eventsTable.NewRow();
                row["Date"] = ev.Start.Value.Date.ToShortDateString();
                row["Start Time"] = ev.Start.Value.ToShortTimeString();
                row["End Time"] = ev.End.Value.ToShortTimeString();
                _eventsTable.Rows.Add(row);
            }

            _view.dgvEvents.DataSource = _eventsTable;
        }

        private void loadEventSlots(List<slot> slotList)
        {
            _slotList = slotList;
            _slotsTable.Rows.Clear();
            foreach (slot s in _slotList)
            {
                var row = _slotsTable.NewRow();
                row["Start Time"] = s.StartTime.Value.ToShortTimeString();
                row["Places Left"] = (s.Capacity.Value - s.Booked.Value).ToString();
                _slotsTable.Rows.Add(row);
            }

            _view.dgvSlots.DataSource = _slotsTable;
        }

        #endregion
    }
}
