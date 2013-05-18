using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.ClientModel;
using Prototype1_1.UI.Forms.HouseholdTab.Client;
using Prototype1_1.UI.Views.HouseholdTab.Client;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Presenters.HouseholdTab.Client
{
    public class ClientInfoPresenter
    {
        #region Attributes
        
        private static ClientInfoPresenter _instance;
     
        private ClientCRUD _model;
        private ClientAPI _api;
        private ClientInfoView _view;

        private client _activeClient;

        #endregion

        #region Properties
        public ClientInfoView View
        {
            get { return _view; }
        }

        public client ActiveClient
        {
            get { return _activeClient; }
        }
        #endregion

        #region Constructor

        private ClientInfoPresenter()
        {
          
        }

        public static ClientInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new ClientInfoPresenter();
            }

            return _instance;
        }

        public void attachView(ClientInfoView aView)
        {
            _api = new ClientAPI();
            _model = new ClientCRUD();
            _view = aView;

            attachEventHandlers();
            initializeView();   
        }

        #endregion

        #region Methods
        private void attachEventHandlers()
        {
            _view.Load += new EventHandler(handleOnLoadEvent);
            _view.picAdd.Click += new EventHandler(handleNewClientInfo);
            _view.picEdit.Click += new EventHandler(handleEditClientInfo);
            _view.picClear.Click += new EventHandler(handleClearClientInfo);

            
        }
        
        private void initializeView()
        {
            //populate dropdown boxes.
            //soen390Entities entityInstance = new soen390Entities();

           
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
            if (_activeClient != null)
            {
                loadClientInfo(_activeClient);
            }
        }


        private void handleNewClientInfo(object sender, EventArgs e)
        {
            //CreateClientForm cf = new CreateClientForm();
            //CreateClientInfoPresenter.getInstance().attachView(cf.createClientInfoView1);
            //cf.ShowDialog();
        }

        private void handleEditClientInfo(object sender, EventArgs e)
        {
            //UpdateClientForm cf = new UpdateClientForm();
            //UpdateClientInfoPresenter.getInstance().attachView(cf.updateClientInfoView1);
            //cf.ShowDialog();            

        }

        private void handleClearClientInfo(object sender, EventArgs e)
        {
            _view.clearAllControls();

        }
        #endregion

        #region Public API

        public void loadClientInfo(client aClient)
        {
            _activeClient = aClient;

            _view.txtLastname.Text = aClient.LastName.ToString();
            _view.txtFirstname.Text = aClient.FirstName.ToString();
            _view.txtMedicare.Text = aClient.Medicare.ToString();
            _view.txtAge.Text = _api.getAgeFromDOB(_api.getDOBFromMcare(aClient.Medicare)).ToString();
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
