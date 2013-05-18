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
using Prototype1_1.UI.Views.HouseholdTab.HouseholdAndClient;
using System.ComponentModel;
using System.Windows.Forms;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient
{
    public class CreateHouseholdAndClientPresenter
    {
        #region Attributes

        private static CreateHouseholdAndClientPresenter _instance;

        private HouseholdCRUD _householdmodel;
        private HouseholdAPI _householdapi;
        private ClientCRUD _clientmodel;
        private ClientAPI _clientapi;
        private CreateHouseholdAndClientView _view;

        #endregion

        #region Properties
        public CreateHouseholdAndClientView View
        {
            get { return _view; }
        }
        #endregion

        #region Constructor
        private CreateHouseholdAndClientPresenter()
        {
          
        }

        public static CreateHouseholdAndClientPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new CreateHouseholdAndClientPresenter();
            }

            return _instance;
        }

        public void attachView(CreateHouseholdAndClientView aView)
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
            _view.btnSave.Click += new EventHandler(handleSaveHouseholdInfo);
            _view.btnCancel.Click += new EventHandler(handleCancelHouseholdInfo);
            
           // _view.txtStreetNumber.Validating += new CancelEventHandler(handleTxtStreetNumberValid);
           // _view.txtStreetName.Validating += new CancelEventHandler(handleTxtStreetNameValid);
           // _view.txtApt.Validating += new CancelEventHandler(handleTxtAptValid);
            _view.txtPostal.Validating += new CancelEventHandler(handleTxtPostalValid);
            _view.txtPhone.Validating += new CancelEventHandler(handleTxtPhoneValid);
            
            _view.txtFirstname.Validating += new CancelEventHandler(handleTxtFirstNameValid);
            _view.txtLastname.Validating += new CancelEventHandler(handleTxtLastNameValid);
            _view.txtMedicare.Validating += new CancelEventHandler(handleTxtMedicareValid);

           // _view.txtWelfare.Validating += new CancelEventHandler(handletxtWelfare);
           // _view.txtReferral.Validating += new CancelEventHandler(handletxtReferral);
           // _view.txtReasonForService.Validating += new CancelEventHandler(handletxtReasonForService);

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
          
        }

        private void handleSaveHouseholdInfo(object sender, EventArgs e)
        {
            bool saveConfirmation;
            //no need for a new form since we only want a confirmation.
            if (isAllFieldValid())
            {
                if (MessageBox.Show("This households contains incomplete fields, save anyway?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    saveConfirmation = true;
                }
                else
                {
                    saveConfirmation = false;
                }

            }
            else
            {
                saveConfirmation = true;
            }

            if (saveConfirmation)
            {
                household createdHousehold = _householdmodel.createHousehold(0,
                                                                     _view.txtStreetNumber.Text,
                                                                     _view.txtStreetName.Text,
                                                                     _view.txtApt.Text,
                                                                     _view.txtPostal.Text,
                                                                     _view.cmbRegion.Text,
                                                                     _view.txtPhone.Text,
                                                                     _view.dtpFirstVisit.Value,
                                                                     _view.dtpFirstVisit.Value,
                                                                     _view.dtpFirstVisit.Value.AddMonths(6),
                                                                     0);

                client createdClient = _clientmodel.createClient(0,
                                                                    _view.txtFirstname.Text,
                                                                    _view.txtLastname.Text,
                                                                    _view.dtpDOB.Value,
                                                                    _view.txtMedicare.Text,
                                                                   _view.cmbGender.SelectedItem.ToString(),
                                                                   _view.cmbOrigin.SelectedItem.ToString(),
                                                                   _view.cmbCitizenship.SelectedItem.ToString(),
                                                                   _view.cmbMotherTongue.SelectedItem.ToString(),
                                                                   _view.cmbSpokenLanguage.SelectedItem.ToString(),
                                                                   _view.cmbMarital.SelectedItem.ToString(),
                                                                   _view.cmbWorkStatus.SelectedItem.ToString(),
                                                                   0,
                                                                   _view.txtReferral.Text,
                                                                   _view.txtReasonForService.Text,
                                                                   _view.txtWelfare.Text);



                if (createdClient == null || createdHousehold == null)
                {
                    MessageBox.Show("Unable to save this client...");
                }
                else
                {
                    createdClient.household.Add(createdHousehold);
                    EntityModel.getInstance().save();

                    HouseholdAndClientPresenter.getInstance().loadHouseholdInfo(createdHousehold);
                    HouseholdAndClientPresenter.getInstance().loadClientInfo(createdClient);
                }
                
                _view.ParentForm.Close();
            }

          

        }

        private void handleCancelHouseholdInfo(object sender, EventArgs e)
        {
            _view.ParentForm.Close();
        }
        #endregion

        #region Input Validation
        
        private void handleTxtStreetNumberValid(object sender, CancelEventArgs e)
        {
            if (_view.txtStreetNumber.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtStreetNumber, "Street Number should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.txtStreetNumber, "");
            }
        }

        private void handleTxtStreetNameValid(object sender, CancelEventArgs e)
        {
            if (_view.txtStreetName.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtStreetName, "Street Name should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.txtStreetName, "");
            }
        }

        private void handleTxtAptValid(object sender, CancelEventArgs e)
        {
            if (_view.txtApt.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtApt, "Appartment Number should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.txtApt, "");
            }
        }

        private void handleTxtPostalValid(object sender, CancelEventArgs e)
        {
            string FSA;

            //Translate ZIP to FSA
            if (_view.txtPostal.Text.CompareTo("") != 0)
            {
                FSA = _householdapi.getZipWithFSA(_view.txtPostal.Text.Substring(0, 3));

                _view.cmbRegion.SelectedItem = FSA;
            }
            if (_view.txtPostal.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtPostal, "Postal Code should not be empty");
            }
            if (_householdapi.isZipCodeValid(_view.txtPostal.Text) == false)
            {
                _view.erp1.SetError(_view.txtPostal, "Postal Code should have this format J8B0A2");
            }
            else
            {
                _view.erp1.SetError(_view.txtPostal, "");
            }

        }

        private void handleTxtPhoneValid(object sender, CancelEventArgs e)
        {
            if (_view.txtPhone.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtPhone, "Phone Number should not be empty");
            }
            if (_householdapi.isPhoneNumberValid(_view.txtPhone.Text) == false)
            {
                _view.erp1.SetError(_view.txtPhone, "Phone Number should have this format 450-698-8987");
            }
            else
            {
                _view.erp1.SetError(_view.txtPhone, "");
            }
        }

        private void handleTxtFirstNameValid(object sender, CancelEventArgs e)
        {
            if (_view.txtFirstname.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtFirstname, "First Name should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.txtFirstname, "");
            }
        }
     
        private void handleTxtLastNameValid(object sender, CancelEventArgs e)
        {
            if (_view.txtLastname.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtLastname, "Last Name should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.txtLastname, "");
            }
        }
        
        private void handleTxtMedicareValid(object sender, CancelEventArgs e)
        {
            if (_clientapi.isMedicareValid(_view.txtMedicare.Text) == false)
            {
                _view.erp1.SetError(_view.txtMedicare, "Mcare should not be empty and have this format NAJA86091307");
            }
            else
            {
                _view.erp1.SetError(_view.txtMedicare, "");

                // populate Dob, age and gender
                _view.dtpDOB.Value = _clientapi.getDOBFromMcare(_view.txtMedicare.Text);
                _view.txtAge.Text = _clientapi.getAgeFromDOB(_view.dtpDOB.Value).ToString();
                _view.cmbGender.SelectedItem = _clientapi.getSexFromMcare(_view.txtMedicare.Text);
            }

        }
        
        private void handletxtWelfare(object sender, CancelEventArgs e)
        {
            if (_view.txtWelfare.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtWelfare, "Welfare Number should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.txtWelfare, "");
            }
        }
    
        private void handletxtReferral(object sender, CancelEventArgs e)
        {
            if (_view.txtReferral.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtReferral, "Referral should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.txtReferral, "");
            }
        }
       
        private void handletxtReasonForService(object sender, CancelEventArgs e)
        {
            if (_view.txtReasonForService.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtReasonForService, "Reaon for referral Name should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.txtReasonForService, "");
            }
        }

        private void validateField()
        {
            handleTxtStreetNumberValid(this, null);
            handleTxtStreetNameValid(this, null);
            handleTxtAptValid(this, null);
            handleTxtPostalValid(this, null);
            handleTxtPhoneValid(this, null);
            handleTxtFirstNameValid(this, null);
            handleTxtLastNameValid(this, null);
            handleTxtMedicareValid(this, null);
            handletxtWelfare(this, null);
            handletxtReferral(this, null);
            handletxtReasonForService(this, null);
        }

        private bool isAllFieldValid()
        {
            validateField();

            if (_view.erp1.GetError(_view.txtStreetNumber)      != "" ||
                _view.erp1.GetError(_view.txtStreetName)        != "" ||
                _view.erp1.GetError(_view.txtApt)               != "" ||
                _view.erp1.GetError(_view.txtPostal)            != "" ||
                _view.erp1.GetError(_view.txtPhone)             != "" ||
                _view.erp1.GetError(_view.txtFirstname)         != "" ||
                _view.erp1.GetError(_view.txtLastname)          != "" ||
                _view.erp1.GetError(_view.txtMedicare)          != "" ||
                _view.erp1.GetError(_view.txtWelfare)           != "" ||
                _view.erp1.GetError(_view.txtReferral)          != "" ||
                _view.erp1.GetError(_view.txtReasonForService)  != ""  )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion


    }
}
