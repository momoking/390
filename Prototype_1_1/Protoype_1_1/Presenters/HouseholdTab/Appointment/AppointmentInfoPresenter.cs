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


using Prototype1_1.Data.EntityModel;
using Prototype1_1.Presenters.HouseholdTab.Appointment;
using Prototype1_1.UI.Forms.HouseholdTab.Appointment;
using Prototype1_1.Utilities;
using System.Data;

namespace Prototype1_1.Presenters.HouseholdTab.Appointment
{
    public class AppointmentInfoPresenter
    {
        #region Attributes
        
        private static AppointmentInfoPresenter _instance;

        private soen390Entities _entities;

        private AppointmentCRUD _model;
        private AppointmentAPI _api;
        private AppointmentInfoView _view;

        private List<slot> _slotList;
        private DataTable _slotTable;

        #endregion

        #region Properties
        public AppointmentInfoView View
        {
            get { return _view; }
        }

         
        public List<slot> ActiveAppointments
        {
            get { return _slotList; }
        }

        #endregion

        #region Constructor

        private AppointmentInfoPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
            _model = new AppointmentCRUD();
            _api = new AppointmentAPI();
            _slotList = new List<slot>(10);
            _slotTable = new DataTable();
            _slotTable.Columns.Add("Date");
            _slotTable.Columns.Add("Time");
            _slotTable.Columns.Add("Event");
        }

        public static AppointmentInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new AppointmentInfoPresenter();
            }

            return _instance;
        }

        public void attachView(AppointmentInfoView aView)
        {
            _view = aView;
            AttachEventHandlers();
        }

        #endregion

        #region Methods
        private void AttachEventHandlers()
        {
            _view.Load += new EventHandler(handleOnLoadEvent);
            _view.picAdd.Click += new EventHandler(handleNewAppointmentInfo);
            _view.picDelete.Click += new EventHandler(handleDeleteAppointmentInfo);

        }
        
        #endregion

        #region Handlers
        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            if (_slotList.Count > 0)
            {
                loadAppointmentInfo(_slotList);
            }

            _view.picAdd.Image = ImageAPI.makeIconOpaque(_view.picAdd.Image);
            _view.picDelete.Image = ImageAPI.makeIconOpaque(_view.picDelete.Image);
        }

        private void handleNewAppointmentInfo(object sender, EventArgs e)
        {
            CreateAppointmentForm cf = new CreateAppointmentForm();
            CreateAppointmentInfoPresenter.getInstance().attachView(cf.createAppointmentInfoView1);
            cf.ShowDialog();
        }

        private void handleDeleteAppointmentInfo(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this appointment?", "Remove appointment confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (_view.dgvAppointments.SelectedRows.Count > 0 && _slotList.Count > 0)
                {
                    slot selectedSlot = _slotList[_view.dgvAppointments.SelectedRows[0].Index];
                    household activeHousehold = HouseholdAndClient.HouseholdAndClientPresenter.getInstance().ActiveHousehold;
                    if (activeHousehold.slot.Remove(selectedSlot))
                    {
                        selectedSlot.Booked = selectedSlot.Booked - 1;
                        loadAppointmentInfo(activeHousehold.slot.ToList());
                        _entities.SaveChanges();
                    }

                    else
                    {
                        MessageBox.Show("Failed to remove appointment", "Invalid Database/List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        #region Public API

        public void loadAppointmentInfo(List<slot> appointments)
        {
            _slotList = appointments;
            _slotTable.Clear();
            foreach (slot s in appointments)
            {
                var row = _slotTable.NewRow();
                row["Date"] = s.@event.First().Start.Value.ToShortDateString();
                row["Time"] = s.StartTime.Value.ToShortTimeString();
                row["Event"] = s.@event.First().Name;
                _slotTable.Rows.Add(row);
            }

            _view.dgvAppointments.DataSource = _slotTable;
        }

        #endregion
    }
}
