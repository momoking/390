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
using Prototype1_1.UI.Views.HouseholdTab.Client;
using System.ComponentModel;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Presenters.HouseholdTab.Client
{
    public class CreateClientInfoPresenter
    {
        #region Attributes

        private static CreateClientInfoPresenter _instance;

        private ClientCRUD _model;
        private ClientAPI _api;
        private CreateClientInfoView _view;

        #endregion

        #region Properties
        public CreateClientInfoView View
        {
            get { return _view; }
        }
        #endregion

        #region Constructor
        private CreateClientInfoPresenter()
        {
          
        }

        public static CreateClientInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new CreateClientInfoPresenter();
            }

            return _instance;
        }

        public void attachView(CreateClientInfoView aView)
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

            _view.btnSave.Click += new EventHandler(handleSaveClientInfo);
            _view.btnCancel.Click += new EventHandler(handleCancelClientInfo);

            _view.txtFirstname.Validating += new CancelEventHandler(handleTxtFirstNameValid);
            _view.txtLastname.Validating += new CancelEventHandler(handleTxtLastNameValid);
            _view.txtMedicare.Validating += new CancelEventHandler(handleTxtMedicareValid);

            _view.txtWelfare.Validating += new CancelEventHandler(handletxtWelfare);
            _view.txtReferral.Validating += new CancelEventHandler(handletxtReferral);
            _view.txtReasonForService.Validating += new CancelEventHandler(handletxtReasonForService);
        }

        private void initializeView()
        {
            //populate dropdown boxes.
            //soen390Entities entityInstance = new EntityModel.getInstance()._soen390Entity;


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
        private void handleSaveClientInfo(object sender, EventArgs e)
        {
            bool saveConfirmation;
              //no need for a new form since we only want a confirmation.
            if (isFieldIncomplete())
            {
                if (MessageBox.Show("This client contains incomplete fields, save anyway?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
                client createdClient = _model.createClient(0,
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

                if (createdClient == null)
                {
                    MessageBox.Show("Unable to save this client...");
                }
                
                _view.ParentForm.Close();
            }
            
               
        }

        private void handleCancelClientInfo(object sender, EventArgs e)
        {
            _view.ParentForm.Close();
        }
        #endregion

        #region Input Validation

        
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
             if (_api.isMedicareValid(_view.txtMedicare.Text) == false)
             {
                 _view.erp1.SetError(_view.txtMedicare, "Mcare should not be empty and have this format NAJA86091307");
             }
             else
             {
                  _view.erp1.SetError(_view.txtMedicare, "");
             
                 // populate Dob, age and gender
                 _view.dtpDOB.Value = _api.getDOBFromMcare(_view.txtMedicare.Text);
                 _view.txtAge.Text = _api.getAgeFromDOB(_view.dtpDOB.Value).ToString();
                 _view.cmbGender.SelectedItem = _api.getSexFromMcare(_view.txtMedicare.Text);
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

        private bool isFieldIncomplete()
        {
               if(  _view.erp1.GetError(_view.txtFirstname) == "" &&
                    _view.erp1.GetError(_view.txtLastname)  == "" &&
                    _view.erp1.GetError(_view.txtMedicare)  == "" &&
                    _view.erp1.GetError(_view.txtWelfare)  == "" &&
                    _view.erp1.GetError(_view.txtReferral)  == "" &&
                    _view.erp1.GetError(_view.txtReasonForService)  == "")
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

