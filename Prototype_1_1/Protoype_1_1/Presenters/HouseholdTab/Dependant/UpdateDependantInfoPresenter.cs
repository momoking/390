using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.DependantModel;
using Prototype1_1.UI.Views.HouseholdTab.Dependant;
using Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient;
using Prototype1_1.Data.EntityModel;
using System.ComponentModel;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Presenters.HouseholdTab.Dependant
{
    public class UpdateDependantInfoPresenter
    {
        #region Attributes

        private static UpdateDependantInfoPresenter _instance;

        private DependantCRUD _model;
        private DependantAPI _api;
        private UpdateDependantInfoView _view;

        #endregion

        #region Properties
        public UpdateDependantInfoView View
        {
            get { return _view; }
        }
        #endregion

        #region Constructor
        private UpdateDependantInfoPresenter()
        {
          
        }

        public static UpdateDependantInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new UpdateDependantInfoPresenter();
            }

            return _instance;
        }

        public void attachView(UpdateDependantInfoView aView)
        {
            _api = new DependantAPI();
            _model = new DependantCRUD();
            _view = aView;

            attachEventHandlers();
            initializeView();   
        }


        #endregion

        #region Methods
        private void attachEventHandlers()
        {
            _view.Load += new EventHandler(handleOnLoadEvent);
            _view.btnSave.Click += new EventHandler(handleSaveDependantInfo);
            _view.btnCancel.Click += new EventHandler(handleCancelDependantInfo);


            _view.txtFirstname.Validating += new CancelEventHandler(handleTxtFirstNameValid);
            _view.txtLastname.Validating += new CancelEventHandler(handleTxtLastNameValid);
            _view.txtMedicare.Validating += new CancelEventHandler(handleTxtMedicareValid);
           // _view.txtWelfare.Validating += new CancelEventHandler(handletxtWelfare);
        }

        private void initializeView()
        {
           
            _view.cmbGender.DataSource = EntityModel.getInstance()._soen390Entities.gender.Select(r => r.GenderName).ToList();
            _view.cmbMarital.DataSource = EntityModel.getInstance()._soen390Entities.maritalstatus.Select(r => r.MaritalStatusName).ToList();
            _view.cmbWorkStatus.DataSource = EntityModel.getInstance()._soen390Entities.workstatus.Select(r => r.WorkStatusName).ToList();        
             

        }
        #endregion

        #region Handlers
        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            
            if (DependantInfoPresenter.getInstance().SelectedDependant != null )
            {
                loadDependantInfo(DependantInfoPresenter.getInstance().SelectedDependant);
            }

        }

        private void handleSaveDependantInfo(object sender, EventArgs e)
        {
            bool saveConfirmation;
            //no need for a new form since we only want a confirmation.
            if (isAllFieldValid())
            {
                if (MessageBox.Show("This dependant contains incomplete fields, save anyway?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
                dependant updatedDependant = _model.updateDependant(DependantInfoPresenter.getInstance().SelectedDependant.DependantID,
                                                                     _view.txtFirstname.Text,
                                                                     _view.txtLastname.Text,
                                                                     _view.txtMedicare.Text,
                                                                     _view.cmbGender.SelectedItem.ToString(),
                                                                     _view.cmbWorkStatus.SelectedItem.ToString(),
                                                                     _view.txtWelfare.Text);

                if (updatedDependant == null)
                {
                    MessageBox.Show("Unable to save this Dependant...");
                }
                else
                {
                    //get the active dependant list
                    List<dependant> activeDependants = HouseholdAndClientPresenter.getInstance().ActiveClient.dependant.ToList();

                    if (activeDependants != null)
                    {
                        DependantInfoPresenter.getInstance().loadDependantInfo(activeDependants);
                    }
                }

                _view.ParentForm.Close();
            }
        
        }

        private void handleCancelDependantInfo(object sender, EventArgs e)
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
     
        
        #endregion
        
        #region Public API

        public void loadDependantInfo(dependant adependant)
        {
            _view.txtFirstname.Text = adependant.FirstName;
            _view.txtLastname.Text = adependant.LastName;
            _view.txtMedicare.Text = adependant.Medicare;
            _view.cmbGender.SelectedItem = adependant.Gender.ToString();
            _view.cmbWorkStatus.SelectedItem = adependant.WorkStatus.ToString();
            _view.txtWelfare.Text = adependant.WelfareNumber;
            
        }

        private void validateField()
        {
            handleTxtFirstNameValid(this, null);
            handleTxtLastNameValid(this, null);
            handleTxtMedicareValid(this, null);
            handletxtWelfare(this, null);
        }

        private bool isAllFieldValid()
        {
            validateField();

            if (_view.erp1.GetError(_view.txtFirstname) != "" ||
                 _view.erp1.GetError(_view.txtLastname) != "" ||
                 _view.erp1.GetError(_view.txtMedicare) != "" ||
                 _view.erp1.GetError(_view.txtWelfare) != "")
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
