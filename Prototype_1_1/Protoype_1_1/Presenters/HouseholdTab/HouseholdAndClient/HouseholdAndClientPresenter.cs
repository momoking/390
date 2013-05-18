using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.HouseholdModel;
using Prototype1_1.Data.ClientModel;
using Prototype1_1.UI.Forms.HouseholdTab.Household;
using Prototype1_1.UI.Views.HouseholdTab.Household;
using Prototype1_1.UI.Forms.HouseholdTab.HouseholdAndClient;
using Prototype1_1.UI.Views.HouseholdTab.HouseholdAndClient;
using Prototype1_1.Data.EntityModel;
using Prototype1_1.Data.EntityModel;
using Prototype1_1.Utilities;

namespace Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient
{
    public class HouseholdAndClientPresenter
    {
        #region Attributes

        private static HouseholdAndClientPresenter _instance;

        private HouseholdCRUD _householdmodel;
        private HouseholdAPI _householdapi;
        private ClientCRUD _clientmodel;
        private ClientAPI _clientapi;
        private HouseholdAndClientView _view;

        private household _activeHousehold;
        private client _activeClient;

        private CreateHouseholdAndClientForm _createHouseholdAndClientForm;
        private UpdateHouseholdAndClientForm _updateHouseholdAndClientForm;
        #endregion

        #region Properties
        public HouseholdAndClientView View
        {
            get { return _view; }
        }

        public household ActiveHousehold
        {
            get { return _activeHousehold; }
        }

        public client ActiveClient
        {
            get { return _activeClient; }
        }
        #endregion

        #region Constructor

        private HouseholdAndClientPresenter()
        {
          
        }

        public static HouseholdAndClientPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new HouseholdAndClientPresenter();
            }

            return _instance;
        }

        public void attachView(HouseholdAndClientView aView)
        {
            _householdapi = new HouseholdAPI();
            _householdmodel = new HouseholdCRUD();
            _clientapi = new ClientAPI();
            _clientmodel = new ClientCRUD();

            _view = aView;

            attachEventHandlers();
           
            initializeView();   
        }

        #endregion

        #region Methods
        private void attachEventHandlers()
        {
            _view.Load += new EventHandler(handleOnLoadEvent);
            _view.picAdd.Click += new EventHandler(handleNewHouseholdInfo);
            _view.picEdit.Click += new EventHandler(handleEditHouseholdInfo);
          
        }

        private void initializeView()
        {
            
            _view.cmbRegion.DataSource = EntityModel.getInstance()._soen390Entities.region.Select(r => r.RegionName).Distinct().ToList();

            _view.cmbGender.DataSource = EntityModel.getInstance()._soen390Entities.gender.Select(r => r.GenderName).ToList();
            _view.cmbOrigin.DataSource = EntityModel.getInstance()._soen390Entities.origin.Select(r => r.OriginName).ToList();
            _view.cmbCitizenship.DataSource = EntityModel.getInstance()._soen390Entities.citizenship.Select(r => r.CitizenshipName).ToList();
            _view.cmbMotherTongue.DataSource = EntityModel.getInstance()._soen390Entities.mothertongue.Select(r => r.LanguageName).ToList();
            _view.cmbSpokenLanguage.DataSource = EntityModel.getInstance()._soen390Entities.servicelanguage.Select(r => r.LanguageName).ToList();
            _view.cmbMarital.DataSource = EntityModel.getInstance()._soen390Entities.maritalstatus.Select(r => r.MaritalStatusName).ToList();
            _view.cmbWorkStatus.DataSource = EntityModel.getInstance()._soen390Entities.workstatus.Select(r => r.WorkStatusName).ToList();

          
        }
        #endregion

        #region Handlers
        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            _view.picEdit.Image = ImageAPI.makeIconOpaque(_view.picEdit.Image);
        }

        private void handleNewHouseholdInfo(object sender, EventArgs e)
        {
            _createHouseholdAndClientForm = new CreateHouseholdAndClientForm();
            CreateHouseholdAndClientPresenter.getInstance().attachView(_createHouseholdAndClientForm.createHouseholdAndClientView1);
            _createHouseholdAndClientForm.ShowDialog();
        }

        private void handleEditHouseholdInfo(object sender, EventArgs e)
        {

            _updateHouseholdAndClientForm = new UpdateHouseholdAndClientForm();
            UpdateHouseholdAndClientPresenter.getInstance().attachView(_updateHouseholdAndClientForm.updateHouseholdAndClientView1);
            _updateHouseholdAndClientForm.ShowDialog();

        }

        #endregion

        #region Public API

        public void loadHouseholdInfo(household ahousehold)
        {
            _activeHousehold = ahousehold;
            _view.txtHouseholdID.Text = ahousehold.HouseholdID.ToString();
            _view.txtStreetNumber.Text = ahousehold.StreetNumber;
            _view.txtStreetName.Text = ahousehold.StreetName;
            _view.txtApt.Text = ahousehold.AppartmentNumber;
            _view.txtPostal.Text = ahousehold.PostalCode;
            _view.cmbRegion.SelectedItem = ahousehold.Region.ToString(); ;
            _view.txtPhone.Text = ahousehold.PhoneNumber;
            _view.dtpFirstVisit.Value = ahousehold.FirstVisit.Value;


            if (_householdapi.isHouseholdNeedToUpdate(ahousehold))
            {
                _view.lblLastUpdate.Visible = true;
            }
            else
            {
                _view.lblLastUpdate.Visible = false;
            }
        }


        public void loadClientInfo(client aClient)
        {
            _activeClient = aClient;
            
            HouseholdTabPresenter.getInstance().AllowGUIUpdateActions(aClient);
           
            _view.txtLastname.Text = aClient.LastName.ToString();
            _view.txtFirstname.Text = aClient.FirstName.ToString();
            _view.txtMedicare.Text = aClient.Medicare.ToString();
            _view.txtAge.Text = _clientapi.getAgeFromDOB(_clientapi.getDOBFromMcare(aClient.Medicare)).ToString();
            _view.cmbGender.SelectedItem = aClient.Gender.ToString();
            _view.cmbOrigin.SelectedItem = aClient.Origin.ToString();
            _view.cmbCitizenship.SelectedItem = aClient.Citizenship.ToString();
            _view.cmbMotherTongue.SelectedItem = aClient.MotherTongue.ToString();
            _view.cmbSpokenLanguage.SelectedItem = aClient.ServiceLanguage.ToString();
            _view.cmbMarital.SelectedItem = aClient.MaritalStatus.ToString();
            _view.cmbWorkStatus.SelectedItem = aClient.WorkStatus.ToString();
            _view.txtWelfare.Text = aClient.WelfareNumber.ToString();
            _view.txtReferral.Text = aClient.Referral.ToString();
            _view.txtReasonForService.Text = aClient.ReasonForServiceUsage.ToString();
        }


        #endregion
    }
}
