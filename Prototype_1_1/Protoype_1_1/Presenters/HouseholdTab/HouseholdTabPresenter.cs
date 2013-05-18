using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prototype1_1.Data;
using Prototype1_1.Data.HouseholdModel;


using Prototype1_1.Presenters;
using Prototype1_1.Presenters.HouseholdTab;
using Prototype1_1.Presenters.HouseholdTab.Dependant;
using Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient;
using Prototype1_1.Presenters.HouseholdTab.Note;
using Prototype1_1.Presenters.HouseholdTab.Flag;
using Prototype1_1.Presenters.HouseholdTab.Appointment;
using Prototype1_1.UI;
using Prototype1_1.UI.Views;
using Prototype1_1.UI.Views.HouseholdTab;
using Prototype1_1.UI.Views.HouseholdTab.Household;
using Prototype1_1.UI.Views.HouseholdTab.Dependant;
using Prototype1_1.UI.Views.HouseholdTab.HouseholdAndClient;
using Prototype1_1.UI.Views.HouseholdTab.Note;
using Prototype1_1.UI.Views.HouseholdTab.Flag;
using Prototype1_1.UI.Views.HouseholdTab.Appointment;
using Prototype1_1.UI.Forms;
using Prototype1_1.UI.Forms.HouseholdTab;
using Prototype1_1.UI.Forms.HouseholdTab.Household;
using Prototype1_1.UI.Forms.HouseholdTab.HouseholdAndClient;
using Prototype1_1.UI.Forms.HouseholdTab.Note;
using Prototype1_1.UI.Forms.HouseholdTab.Flag;
using Prototype1_1.UI.Forms.HouseholdTab.Appointment;

using Prototype1_1.Data.EntityModel;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace Prototype1_1.Presenters
{
    public class HouseholdTabPresenter
    {
        #region Attributes

        static HouseholdTabPresenter _instance;
        private HouseholdTabView _view;       
       
       
        #endregion

        #region Constructor and getInstance() and Initializer

        private HouseholdTabPresenter()
        {                                          
       
        }

        public static HouseholdTabPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new HouseholdTabPresenter();
            }

            return _instance;
        }

        public void initializeView(HouseholdTabView aView)
        {
            _view = aView;

            HouseholdAndClientPresenter.getInstance().attachView(_view.householdAndClient1);           
            DependantInfoPresenter.getInstance().attachView(_view.dependantInfoView1);
            NoteInfoPresenter.getInstance().attachView(_view.noteInfoView1);
            FlagInfoPresenter.getInstance().attachView(_view.flagInfoView1);
            AppointmentInfoPresenter.getInstance().attachView(_view.appointmentInfoView1);

        }


        public void loadClient(client aClient)
        {
            HouseholdAndClientPresenter.getInstance().loadClientInfo(aClient);
            HouseholdAndClientPresenter.getInstance().loadHouseholdInfo(aClient.household.FirstOrDefault());
            DependantInfoPresenter.getInstance().loadDependantInfo(aClient.dependant.ToList());
            NoteInfoPresenter.getInstance().loadNoteInfo(aClient.household.FirstOrDefault().note.ToList());
            FlagInfoPresenter.getInstance().loadFlagInfo(aClient.household.FirstOrDefault().flag.ToList());
            AppointmentInfoPresenter.getInstance().loadAppointmentInfo(aClient.household.FirstOrDefault().slot.ToList());

            AllowGUIUpdateActions(aClient);
        }

        public void AllowGUIUpdateActions(client aClient)
        {
            HouseholdAndClientPresenter.getInstance().View.picEdit.Enabled = true;
            HouseholdAndClientPresenter.getInstance().View.picEdit.Image = global::Prototype1_1.Properties.Resources.edit_icon;


            DependantInfoPresenter.getInstance().View.picAdd.Enabled = true;
            DependantInfoPresenter.getInstance().View.picAdd.Image = global::Prototype1_1.Properties.Resources.add_dependandt_icon;
            DependantInfoPresenter.getInstance().View.picEdit.Enabled = true;
            DependantInfoPresenter.getInstance().View.picEdit.Image = global::Prototype1_1.Properties.Resources.edit_icon;
            DependantInfoPresenter.getInstance().View.picDelete.Image = global::Prototype1_1.Properties.Resources.remove_x_icon;
            DependantInfoPresenter.getInstance().View.picDelete.Enabled = true;


            NoteInfoPresenter.getInstance().View.picAdd.Enabled = true;
            NoteInfoPresenter.getInstance().View.picAdd.Image = global::Prototype1_1.Properties.Resources.note_add1;
            NoteInfoPresenter.getInstance().View.picEdit.Enabled = true;
            NoteInfoPresenter.getInstance().View.picEdit.Image = global::Prototype1_1.Properties.Resources.edit_icon;
            NoteInfoPresenter.getInstance().View.picDelete.Enabled = true;
            NoteInfoPresenter.getInstance().View.picDelete.Image = global::Prototype1_1.Properties.Resources.remove_x_icon;


            FlagInfoPresenter.getInstance().View.picAdd.Enabled = true;
            FlagInfoPresenter.getInstance().View.picAdd.Image = global::Prototype1_1.Properties.Resources.red_flag_icon1;
            FlagInfoPresenter.getInstance().View.picEdit.Enabled = true;
            FlagInfoPresenter.getInstance().View.picEdit.Image = global::Prototype1_1.Properties.Resources.edit_icon;
            FlagInfoPresenter.getInstance().View.picDelete.Enabled = true;
            FlagInfoPresenter.getInstance().View.picDelete.Image = global::Prototype1_1.Properties.Resources.remove_x_icon;

            AppointmentInfoPresenter.getInstance().View.picAdd.Enabled = true;
            AppointmentInfoPresenter.getInstance().View.picAdd.Image = global::Prototype1_1.Properties.Resources.calendar_add;
            AppointmentInfoPresenter.getInstance().View.picDelete.Enabled = true;
            AppointmentInfoPresenter.getInstance().View.picDelete.Image = global::Prototype1_1.Properties.Resources.remove_x_icon;
        }

       







        //        private void attachEventHandlers()
//        {
//            /*_view.householdInfoView1.txtStreetNumber.Validating += new CancelEventHandler(handleTxtStreetNumberValid);
//            _view.householdInfoView1.txtStreetName.Validating += new CancelEventHandler(handleTxtStreetNameValid);
//            _view.householdInfoView1.txtApt.Validating += new CancelEventHandler(handleTxtAptValid);
//            _view.householdInfoView1.txtPostal.Validating += new CancelEventHandler(handleTxtPostalValid);
//            _view.householdInfoView1.txtPhone.Validating += new CancelEventHandler(handleTxtPhoneValid);

//            _view.clientInfoView1.txtFirstname.Validating += new CancelEventHandler(handleTxtFirstNameValid);
//            _view.clientInfoView1.txtLastname.Validating += new CancelEventHandler(handleTxtLastNameValid);
//            _view.clientInfoView1.txtMedicare.Validating += new CancelEventHandler(handleTxtMedicareValid);

//            _view.clientInfoView1.txtWelfare.Validating += new CancelEventHandler(handletxtWelfare);
//            _view.clientInfoView1.txtReferral.Validating += new CancelEventHandler(handletxtReferral);
//            _view.clientInfoView1.txtReasonForService.Validating += new CancelEventHandler(handletxtReasonForService);
//*/
//           //Add a new household event
//           // _view.householdInfoView1.picAdd.Click += new EventHandler(handleNewHousehold);
           
            
//            //_view.householdInfoView1.picAdd.Click += new EventHandler(handleNewHousold);
            
//            // _view.btnNew.Click += new EventHandler(handleBtnNewClick);
//           // _view.btnUpdate.Click += new EventHandler(handleBtnUpateClick);
//           // _view.btnSave.Click += new EventHandler(handleBtnSaveClick);
//          //  _view.btnCancel.Click += new EventHandler(handleBtnCancelClick);

//           // _view.Load += new EventHandler(handleLoadEvent);
//            //_view.dependantInfoView1.lnkDependantDetail.Click += new EventHandler(handleLnkDependantDetailClick);
//           // _view.householdInfoView1.lnkHouseholdIncome.Click += new EventHandler(handleLnkHouseholdIncomeClick);
//           // _view.btnRegisterToEvent.Click += new EventHandler(handleBtnRegisterToEventClick);
//           // _view.appointmentInfoView1.lnkAppointmentDetail.Click += new EventHandler(handleLnkAppointmentDetailClick);



//        }
        



        //private void initializeView()
        //{
        //    //populate dropdown boxes.
        //   // soen390Entities entityInstance = new soen390Entities();
          

        //    //This line of code will generate an exception because the combo box has a public modifier,
        //    //If we put the modifier as private , we will not be able to access its properties.
        //    //The workaround is to bind the combo box display value to (ie RegionName) on the designer 
        //    //and to link the datasource to with an linq query.
        //    // _view.householdInfoView1.cmbRegion.ValueMember = "RegionName";

        //   // _view.householdInfoView1.cmbRegion.DataSource = entityInstance.region.Select(r => r.RegionName).Distinct().ToList();                    
        //   /* _view.clientInfoView1.cmbGender.DataSource = entityInstance.gender.Select(r => r.GenderName).ToList();
        //    _view.clientInfoView1.cmbOrigin.DataSource = entityInstance.origin.Select(r => r.OriginName).ToList();
        //    _view.clientInfoView1.cmbCitizenship.DataSource = entityInstance.citizenship.Select(r => r.CitizenshipName).ToList();
        //    _view.clientInfoView1.cmbMotherTongue.DataSource = entityInstance.mothertongue.Select(r => r.LanguageName).ToList();
        //    _view.clientInfoView1.cmbSpokenLanguage.DataSource = entityInstance.servicelanguage.Select(r => r.LanguageName).ToList();
        //    _view.clientInfoView1.cmbMarital.DataSource = entityInstance.maritalstatus.Select(r => r.MaritalStatusName).ToList();
        //    _view.clientInfoView1.cmbWorkStatus.DataSource = entityInstance.workstatus.Select(r => r.WorkStatusName).ToList();        
        //   */ 

        //}

        #endregion

        //public void loadDependants(client aClient)
        //{
        //   /* soen390Entities entities = new soen390Entities();
        //    IEnumerable<dependant> clientDependants = aClient.dependant;
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("First Name", typeof(string));
        //    dt.Columns.Add("Age", typeof(int));
        //    dt.Columns.Add("Gender", typeof(string));

        //    foreach (dependant dep in clientDependants)
        //    {
        //        var row = dt.NewRow();
        //        row["First Name"] = dep.FirstName;
        //        row["Age"] = _model.getAgeFromDOB(_model.getDOBFromMcare(dep.Medicare));
        //        row["Gender"] = dep.Gender;
        //        dt.Rows.Add(row);
        //    }

        //    _view.dependantInfoView1.dgvDependants.DataSource = dt;
        //    _view.dependantInfoView1.dgvDependants.Columns["First Name"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        //    _view.dependantInfoView1.dgvDependants.Columns["Age"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        //    _view.dependantInfoView1.dgvDependants.Columns["Gender"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        //    */
        //}

        //public void loadNotes(household aHousehold)
        //{
        //   /* soen390Entities entities = new soen390Entities();
        //    IEnumerable<note> householdNotes = aHousehold.note;
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Date", typeof(DateTime));
        //    dt.Columns.Add("Operator", typeof(string));
        //    dt.Columns.Add("Note", typeof(string));

        //    foreach (note note in householdNotes)
        //    {
        //        var row = dt.NewRow();
        //        row["Date"] = note.DateStamp;
        //        row["Operator"] = note.ModifiedBy;
        //        row["Note"] = note.NoteInfo;
        //        dt.Rows.Add(row);
                
        //    }

        //    _view.noteInfoView1.dgvNotes.DataSource = dt;
        //    _view.noteInfoView1.dgvNotes.Columns["Date"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        //    _view.noteInfoView1.dgvNotes.Columns["Operator"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        //    _view.noteInfoView1.dgvNotes.Columns["Note"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        //    */
        //}

        //public void loadFlags(household aHousehold)
        //{
        //   /* soen390Entities entities = new soen390Entities();
        //    IEnumerable<flag> householdFlags = aHousehold.flag;
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Type", typeof(string));
        //    dt.Columns.Add("Flag", typeof(string));

        //    foreach (flag flag in householdFlags)
        //    {
        //        var row = dt.NewRow();
        //        row["Type"] = flag.flagtype.FlagPriority;
        //        row["Flag"] = flag.FlagInfo;
        //        dt.Rows.Add(row);
        //    }

        //    _view.flagTypeInfoView1.dgvFlags.DataSource = dt;
        //    _view.flagTypeInfoView1.dgvFlags.Columns["Type"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        //    _view.flagTypeInfoView1.dgvFlags.Columns["Flag"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        // */

        //}
 
        //public void loadHouseholdInfo(household aHousehold)
        //{
        //    /*_view.householdInfoView1.txtHouseholdID.Text = aHousehold.HouseholdID.ToString();
        //    _view.householdInfoView1.txtStreetNumber.Text = aHousehold.StreetNumber.ToString();
        //    _view.householdInfoView1.txtStreetName.Text = aHousehold.StreetName.ToString();
        //    _view.householdInfoView1.txtApt.Text = aHousehold.AppartmentNumber.ToString();
        //    _view.householdInfoView1.txtPostal.Text = aHousehold.PostalCode.ToString();
        //    _view.householdInfoView1.cmbRegion.SelectedItem = aHousehold.Region.ToString();
        //    _view.householdInfoView1.txtPhone.Text = aHousehold.PhoneNumber.ToString();
        //    _view.householdInfoView1.dtpFirstVisit.Value = aHousehold.FirstVisit.Value;

        //    if (_model.isHouseholdNeedToUpdate(aHousehold))
        //    {
        //        _view.householdInfoView1.lblLastUpdate.Visible = true;
        //    }
        //    else
        //    {
        //        _view.householdInfoView1.lblLastUpdate.Visible = false;
        //    }*/
        //}

        //public void loadClientInfo(client aClient)
        //{
        //   /* _view.clientInfoView1.txtLastname.Text = aClient.LastName.ToString();
        //    _view.clientInfoView1.txtFirstname.Text = aClient.FirstName.ToString();
        //    _view.clientInfoView1.txtMedicare.Text = aClient.Medicare.ToString();
        //    _view.clientInfoView1.txtAge.Text = _model.getAgeFromDOB(_model.getDOBFromMcare(aClient.Medicare)).ToString();
        //    _view.clientInfoView1.cmbGender.SelectedItem = aClient.Gender.ToString();
        //    _view.clientInfoView1.cmbOrigin.SelectedItem = aClient.Origin.ToString();
        //    _view.clientInfoView1.cmbCitizenship.SelectedItem = aClient.Citizenship.ToString();
        //    _view.clientInfoView1.cmbMotherTongue.SelectedItem = aClient.MotherTongue.ToString();
        //    _view.clientInfoView1.cmbSpokenLanguage.SelectedItem = aClient.ServiceLanguage.ToString();
        //    _view.clientInfoView1.cmbMarital.SelectedItem = aClient.MaritalStatus.ToString();
        //    _view.clientInfoView1.cmbWorkStatus.SelectedItem = aClient.WorkStatus.ToString();
        //    _view.clientInfoView1.txtWelfare.Text = aClient.WelfareNumber.ToString();
            
        //    if (_view.clientInfoView1.txtReferral.Text != null)
        //    {
        //        _view.clientInfoView1.txtReferral.Text = aClient.Referral.ToString();
        //    }
        //    _view.clientInfoView1.txtReasonForService.Text = aClient.ReasonForServiceUsage.ToString();
        //    */

        //}
 
        //#region Event Handling Methods

        //  /*  #region Event Handling for Validity of field
        //        private void handleTxtStreetNumberValid(object sender, CancelEventArgs e)
        //        {
        //            if (_view.householdInfoView1.txtStreetNumber.Text.CompareTo("") == 0)
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.SetError(_view.householdInfoView1.txtStreetNumber, "Street Number should not be empty");
        //            }
        //            else
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.Clear();
        //            }
        //        }
        //        private void handleTxtStreetNameValid(object sender, CancelEventArgs e)
        //        {
        //            if (_view.householdInfoView1.txtStreetName.Text.CompareTo("") == 0)
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.SetError(_view.householdInfoView1.txtStreetName, "Street Name should not be empty");
        //            }
        //            else
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.Clear();
        //            }
        //        }
        //        private void handleTxtAptValid(object sender, CancelEventArgs e)
        //        {
        //            if (_view.householdInfoView1.txtApt.Text.CompareTo("") == 0)
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.SetError(_view.householdInfoView1.txtApt, "Appartment Number should not be empty");
        //            }
        //            else
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.Clear();
        //            }
        //        }
        //        private void handleTxtPostalValid(object sender, CancelEventArgs e)
        //        {
        //            string FSA;

        //            //Translate ZIP to FSA
        //            if (_view.householdInfoView1.txtPostal.Text.CompareTo("") != 0)
        //            {
        //                FSA = _model.getZipWithFSA(_view.householdInfoView1.txtPostal.Text.Substring(0, 3));

        //                _view.householdInfoView1.cmbRegion.SelectedItem = FSA;
        //            }

        //            if (_view.householdInfoView1.txtPostal.Text.CompareTo("") == 0)
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.SetError(_view.householdInfoView1.txtPostal, "Postal Code should not be empty");
        //            }
        //            else if (_model.isZipCodeValid(_view.householdInfoView1.txtPostal.Text) == false)
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.SetError(_view.householdInfoView1.txtPostal, "Postal Code should have this format J8B0A2");
        //            }
        //            else
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.Clear();
        //            }

        //        }
        //        private void handleTxtPhoneValid(object sender, CancelEventArgs e)
        //        {
        //            if (_view.householdInfoView1.txtPhone.Text.CompareTo("") == 0)
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.SetError(_view.householdInfoView1.txtPhone, "Phone Number should not be empty");
        //            }
        //            else if (_model.isZipCodeValid(_view.householdInfoView1.txtPostal.Text) == false)
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.SetError(_view.householdInfoView1.txtPhone, "Phone Number should have this format 450-698-8987");
        //            }
        //            else
        //            {
        //                _view.householdInfoView1.eprHouseholdInfoSubView.Clear();
        //            }
        //        }
        //        private void handleTxtFirstNameValid(object sender, CancelEventArgs e)
        //        {
        //            if (_view.clientInfoView1.txtFirstname.Text.CompareTo("") == 0)
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.SetError(_view.clientInfoView1.txtFirstname, "First Name should not be empty");
        //            }            
        //            else
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.Clear();
        //            }
        //        }
        //        private void handleTxtLastNameValid(object sender, CancelEventArgs e)
        //        {
        //            if (_view.clientInfoView1.txtLastname.Text.CompareTo("") == 0)
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.SetError(_view.clientInfoView1.txtLastname, "Last Name should not be empty");
        //            }
        //            else
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.Clear();
        //            }
        //        }
        //        private void handleTxtMedicareValid(object sender, CancelEventArgs e)
        //        {
        //            if (_model.isMedicareValid(_view.clientInfoView1.txtMedicare.Text) == false)
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.SetError(_view.clientInfoView1.txtMedicare, "Mcare should not be empty and have this format NAJA86091307");
        //            }
        //            else
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.Clear();
                   
        //                // populate Dob, age and gender
        //                _view.clientInfoView1.dtpDOB.Value = _model.getDOBFromMcare(_view.clientInfoView1.txtMedicare.Text);
        //                _view.clientInfoView1.txtAge.Text = _model.getAgeFromDOB(_view.clientInfoView1.dtpDOB.Value).ToString();
        //                _view.clientInfoView1.cmbGender.SelectedItem = _model.getSexFromMcare(_view.clientInfoView1.txtMedicare.Text);
        //            }

        //        }
        //        private void handletxtWelfare(object sender, CancelEventArgs e)
        //        {
        //            if (_view.clientInfoView1.txtWelfare.Text.CompareTo("") == 0)
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.SetError(_view.clientInfoView1.txtWelfare, "Welfare Number should not be empty");
        //            }
        //            else
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.Clear();
        //            }
        //        }
        //        private void handletxtReferral(object sender, CancelEventArgs e)
        //        {
        //            if (_view.clientInfoView1.txtReferral.Text.CompareTo("") == 0)
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.SetError(_view.clientInfoView1.txtReferral, "Referral should not be empty");
        //            }
        //            else
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.Clear();
        //            }
        //        }
        //        private void handletxtReasonForService(object sender, CancelEventArgs e)
        //        {
        //            if (_view.clientInfoView1.txtReasonForService.Text.CompareTo("") == 0)
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.SetError(_view.clientInfoView1.txtReasonForService, "Reaon for referral Name should not be empty");
        //            }
        //            else
        //            {
        //                _view.clientInfoView1.erpClientInfoSubView.Clear();
        //            }
        //        }
        //    #endregion
        //*/
        //    #region Event handling for adding a new household

        //    private void handleNewHousehold(object sender, EventArgs e)
        //    {
        //        //FormAddHousehold addHouseholdForm = new FormAddHousehold();

        //        //addHouseholdForm.ShowDialog();
        //    }

        //    #endregion

        //    #region Event handling for adding a new client

        //    private void handleNewClient(object sender, EventArgs e)
        //    {

        //    }

        //    #endregion
                
        //    #region Event Handling for Load

        //        private void handleLoadEvent(object sender, EventArgs e)
        //{
        //    //soen390Entities entityInstance = new soen390Entities();
        //    //populate drop boxes.

        //    //_view.householdInfoView1.cmbRegion.DataSource = entityInstance.region.Select(r => r.RegionName).Distinct().ToList();
        //    //_view.householdInfoView1.cmbRegion.ValueMember = "RegionName";

        //    /*_view.clientInfoView1.cmbOrigin.DataSource = entityInstance.origin.ToList();
        //    _view.clientInfoView1.cmbOrigin.ValueMember = "Origin";

        //    _view.clientInfoView1.cmbCitizenship.DataSource = entityInstance.citizenship.ToList();
        //    _view.clientInfoView1.cmbCitizenship.ValueMember = "Citizenship";

        //    _view.clientInfoView1.cmbMotherTongue.DataSource = entityInstance.mothertongue.ToList();
        //    _view.clientInfoView1.cmbMotherTongue.ValueMember = "MotherTongue";

        //    _view.clientInfoView1.cmbSpokenLanguage.DataSource = entityInstance.servicelanguage.ToList();
        //    _view.clientInfoView1.cmbSpokenLanguage.ValueMember = "ServiceLanguage";

        //    _view.clientInfoView1.cmbMarital.DataSource = entityInstance.maritalstatus.ToList();
        //    _view.clientInfoView1.cmbMarital.ValueMember = "MaritalStatus";

        //    _view.clientInfoView1.cmbWorkStatus.DataSource = entityInstance.workstatus.ToList();
        //    _view.clientInfoView1.cmbWorkStatus.ValueMember = "WorkStatus";
        //    */         
        //}
        
        //    #endregion
            
        //    #region Event Handling for BtnNew
        //    private void handleBtnNewClick(object sender, EventArgs e)
        //    {
        //        //Button new pressed
        //        //1) clear all the controls
        //        //2) unlock the controls
        //        //3)highligh new button
        //        //4)show save and cancel button
        //       // _view.clientInfoView1.clearAllControls();
        //       // _view.householdInfoView1.clearAllControls();

        //       //Get a new Household ID.
        //       /* string householdID = _model.getNewHouseholdID();

        //        _view.householdInfoView1.txtHouseholdID.Text = householdID;

        //        household createdHousehold= _model.createHousehold( long.Parse(householdID),
        //                                                            _view.householdInfoView1.txtStreetNumber.Text,
        //                                                            _view.householdInfoView1.txtStreetName.Text,
        //                                                            _view.householdInfoView1.txtApt.Text,
        //                                                            _view.householdInfoView1.txtPostal.Text,
        //                                                            _view.householdInfoView1.cmbRegion.SelectedItem.ToString(),
        //                                                            _view.householdInfoView1.txtPhone.Text,
        //                                                            _view.householdInfoView1.dtpFirstVisit.Value,
        //                                                            _view.householdInfoView1.dtpFirstVisit.Value,
        //                                                            _view.householdInfoView1.dtpFirstVisit.Value.AddMonths(6),
        //                                                            decimal.Parse(_view.householdInfoView1.txtHouseholdIncome.Text));


        //        client createdClient = _model.createClient(0,
        //                                                    _view.clientInfoView1.txtFirstname.Text, 
        //                                                    _view.clientInfoView1.txtLastname.Text,
        //                                                    _view.clientInfoView1.dtpDOB.Value,
        //                                                    _view.clientInfoView1.txtMedicare.Text,
        //                                                    _view.clientInfoView1.cmbGender.SelectedItem.ToString(),
        //                                                    _view.clientInfoView1.cmbOrigin.SelectedItem.ToString(),
        //                                                    _view.clientInfoView1.cmbCitizenship.SelectedItem.ToString(),
        //                                                    _view.clientInfoView1.cmbMotherTongue.SelectedItem.ToString(),
        //                                                    _view.clientInfoView1.cmbSpokenLanguage.SelectedItem.ToString(),
        //                                                    _view.clientInfoView1.cmbMarital.SelectedItem.ToString(),
        //                                                    _view.clientInfoView1.cmbWorkStatus.SelectedItem.ToString(),
        //                                                    0,
        //                                                   _view.clientInfoView1.txtReferral.Text,                                                         
        //                                                    _view.clientInfoView1.txtReasonForService.Text,
        //                                                    _view.clientInfoView1.txtWelfare.Text);

        //        //Link Client to household
        //        _model.linkHouseholdAndClient(createdClient, createdHousehold);

        //        //load back the client
        //        loadClient(createdClient);
        //        */
        //    }
        //    #endregion

        //    #region Event Handling for BtnUpate
        //    private void handleBtnUpateClick(object sender, EventArgs e)
        //    {

            
        //     /*  client updatedClient = _model.updateClient(_activeClient.ID,
        //                            _view.clientInfoView1.txtFirstname.Text,
        //                            _view.clientInfoView1.txtLastname.Text,
        //                            _view.clientInfoView1.dtpDOB.Value,
        //                            _view.clientInfoView1.txtMedicare.Text,
        //                            _view.clientInfoView1.cmbGender.SelectedItem.ToString(),
        //                            _view.clientInfoView1.cmbOrigin.SelectedItem.ToString(),
        //                            _view.clientInfoView1.cmbCitizenship.SelectedItem.ToString(),
        //                            _view.clientInfoView1.cmbMotherTongue.SelectedItem.ToString(),
        //                            _view.clientInfoView1.cmbSpokenLanguage.SelectedItem.ToString(),
        //                            _view.clientInfoView1.cmbMarital.SelectedItem.ToString(),
        //                            _view.clientInfoView1.cmbWorkStatus.SelectedItem.ToString(),
        //                            0,
        //                            _view.clientInfoView1.txtReferral.Text,
        //                            _view.clientInfoView1.txtReasonForService.Text,
        //                            _view.clientInfoView1.txtWelfare.Text);
               
        //        loadClient(updatedClient);
        //    */

        //    }
        //    #endregion

        //    #region Event Handling for BtnSave
        //    private void handleBtnSaveClick(object sender, EventArgs e)
        //    {
        //      //  _uiMode.setMode(ModeType.Viewing);
        //    }
        //    #endregion

        //    #region Event Handling for BtnCancel
        //    private void handleBtnCancelClick(object sender, EventArgs e)
        //    {
        //     //   _uiMode.setMode(ModeType.Viewing);
        //    }
        //    #endregion

        //    #region Event Handling for LnkDependantDetail
        //    private void handleLnkDependantDetailClick(object sender, EventArgs e)
        //    {
        //        FormDependantDetail formDependantDetail = new FormDependantDetail();

        //        formDependantDetail.ShowDialog();
        //    }
        //    #endregion

        //    #region Event Handling for handleLnkHouseholdIncomeClick
        //    private void handleLnkHouseholdIncomeClick(object sender, EventArgs e)
        //    {
        //        FormHouseholdIncome formHouseholdIncome = new FormHouseholdIncome();

        //        formHouseholdIncome.ShowDialog();
        //    }
        //    #endregion

        //    #region Event Handling for handleBtnRegisterToEventClick
        //    private void handleBtnRegisterToEventClick(object sender, EventArgs e)
        //    {
        //        FormRegisterToEvent formRegisterToEvent = new FormRegisterToEvent();

        //        formRegisterToEvent.ShowDialog();
        //    }
        //    #endregion

        //    #region Event Handling for handleLnkAppointmentDetailClick
        //    private void handleLnkAppointmentDetailClick(object sender, EventArgs e)
        //    {
        //        FormAppointmentDetail formAppointmentDetail = new FormAppointmentDetail();

        //        formAppointmentDetail.ShowDialog();
        //    }
        //    #endregion

        //#endregion

    }
}
