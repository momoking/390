using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.HouseholdModel;
using Prototype1_1.UI.Views.HouseholdTab.Household;
using System.ComponentModel;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Presenters.HouseholdTab.Household
{
    public class UpdateHouseholdInfoPresenter
    {
        #region Attributes

        private static UpdateHouseholdInfoPresenter _instance;

        private HouseholdCRUD _model;
        private HouseholdAPI _api;
        private UpdateHouseholdInfoView _view;

        #endregion

        #region Properties
        public UpdateHouseholdInfoView View
        {
            get { return _view; }
        }
        #endregion

        #region Constructor

        private UpdateHouseholdInfoPresenter()
        {
          
        }

        public static UpdateHouseholdInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new UpdateHouseholdInfoPresenter();
            }

            return _instance;
        }

        public void attachView(UpdateHouseholdInfoView aView)
        {
            _api = new HouseholdAPI();
            _model = new HouseholdCRUD();
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

            _view.txtStreetNumber.Validating += new CancelEventHandler(handleTxtStreetNumberValid);
            _view.txtStreetName.Validating += new CancelEventHandler(handleTxtStreetNameValid);
            _view.txtApt.Validating += new CancelEventHandler(handleTxtAptValid);
            _view.txtPostal.Validating += new CancelEventHandler(handleTxtPostalValid);
            _view.txtPhone.Validating += new CancelEventHandler(handleTxtPhoneValid);

        }

        private void initializeView()
        {
            //populate dropdown boxes.
            //soen390Entities entityInstance = new soen390Entities();

            _view.cmbRegion.DataSource = EntityModel.getInstance()._soen390Entities.region.Select(r => r.RegionName).Distinct().ToList();
           
        }
        #endregion

        #region Handlers

        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            //Reload the household information
            //get the active household
            household activeHousehold = HouseholdInfoPresenter.getInstance().ActiveHousehold;

            if (activeHousehold != null)
            {
                loadHouseholdInfo(activeHousehold);
            }
        }
        
        private void handleSaveHouseholdInfo(object sender, EventArgs e)
        {
            bool saveConfirmation;
            //no need for a new form since we only want a confirmation.
            if (isFieldIncomplete())
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

                household activeHousehold = HouseholdInfoPresenter.getInstance().ActiveHousehold;

                if (_api.isHouseholdNeedToUpdate(activeHousehold) == true)
                {
                    activeHousehold.NextUpdate = DateTime.Today.AddMonths(6);
                }

                household updatedHousehold = _model.updateHousehold(activeHousehold.HouseholdID,
                                                                        _view.txtStreetNumber.Text,
                                                                        _view.txtStreetName.Text,
                                                                        _view.txtApt.Text,
                                                                        _view.txtPostal.Text,
                                                                        _view.cmbRegion.SelectedItem.ToString(),
                                                                        _view.txtPhone.Text,
                                                                        _view.dtpFirstVisit.Value,
                                                                        DateTime.Today,
                                                                        activeHousehold.NextUpdate.Value,
                                                                        0);
                if (updatedHousehold == null)
                {
                    MessageBox.Show("Unable to update this household...");
                }
                else
                {
                    HouseholdInfoPresenter.getInstance().loadHouseholdInfo(updatedHousehold);
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
                FSA = _api.getZipWithFSA(_view.txtPostal.Text.Substring(0, 3));

                _view.cmbRegion.SelectedItem = FSA;
            }
            if (_view.txtPostal.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtPostal, "Postal Code should not be empty");
            }
            if (_api.isZipCodeValid(_view.txtPostal.Text) == false)
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
            if (_api.isPhoneNumberValid(_view.txtPostal.Text) == false)
            {
                _view.erp1.SetError(_view.txtPhone, "Phone Number should have this format 450-698-8987");
            }
            else
            {
                _view.erp1.SetError(_view.txtPhone, "");
            }
        }
        #endregion

        #region Public Api
        public void loadHouseholdInfo(household ahousehold)
        {
       
            _view.txtHouseholdID.Text = ahousehold.HouseholdID.ToString();
            _view.txtStreetNumber.Text = ahousehold.StreetNumber;
            _view.txtStreetName.Text = ahousehold.StreetName;
            _view.txtApt.Text = ahousehold.AppartmentNumber;
            _view.txtPostal.Text = ahousehold.PostalCode;
            _view.cmbRegion.SelectedItem = ahousehold.Region.ToString(); ;
            _view.txtPhone.Text = ahousehold.PhoneNumber;
            _view.dtpFirstVisit.Value = ahousehold.FirstVisit.Value;

        }

        private bool isFieldIncomplete()
        {
            if (_view.erp1.GetError(_view.txtStreetNumber) != "" &&
                 _view.erp1.GetError(_view.txtStreetName) != "" &&
                 _view.erp1.GetError(_view.txtApt) != "" &&
                 _view.erp1.GetError(_view.txtPostal) != "" &&
                 _view.erp1.GetError(_view.txtPhone) != "")
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
