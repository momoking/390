using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.Data.SettingModel;
using Prototype1_1.UI;
using Prototype1_1.UI.Forms.SettingTab;
using Prototype1_1.UI.Views.SettingTab;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.EntityModel;
using Prototype1_1.Presenters.SettingTab;
using System.Windows.Forms;

namespace Prototype1_1.Presenters.SettingTab
{
    class SettingPresenter
    {
        private static SettingPresenter _instance;
        private soen390Entities _entities;
        private SettingGeneralView _view;

        private SettingPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
        }

        public static SettingPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new SettingPresenter();
            }
            return _instance;
        }

        public SettingGeneralView View
        {
            get { return _view; }
        }

        public void initializeView(SettingGeneralView settingView)
        {
            _view = settingView;
            attachEventHandlers();
            loadSettings();
        }

        public void loadSettings()
        {
            //populate dropdown boxes
            _view.cmbOrigin.DataSource = EntityModel.getInstance()._soen390Entities.origin.Select(r => r.OriginName).ToList();
            _view.cmbCitizenship.DataSource = EntityModel.getInstance()._soen390Entities.citizenship.Select(r => r.CitizenshipName).ToList();
            _view.cmbMotherTongue.DataSource = EntityModel.getInstance()._soen390Entities.mothertongue.Select(r => r.LanguageName).ToList();

            _view.cmbMaritalStatus.DataSource = EntityModel.getInstance()._soen390Entities.maritalstatus.Select(r => r.MaritalStatusName).ToList();
            _view.cmbWorkStatus.DataSource = EntityModel.getInstance()._soen390Entities.workstatus.Select(r => r.WorkStatusName).ToList();
            _view.cmbIncomeType.DataSource = EntityModel.getInstance()._soen390Entities.incometype.Select(r => r.IncomeTypeName).ToList();

            _view.cmbServiceLang.DataSource = EntityModel.getInstance()._soen390Entities.servicelanguage.Select(r => r.LanguageName).ToList();
            _view.cmbFlagType.DataSource = EntityModel.getInstance()._soen390Entities.flagtype.Select(r => r.FlagTitle).ToList();
            _view.cmbPostalZone.DataSource = EntityModel.getInstance()._soen390Entities.region.Select(r => r.ForwardSortationArea).ToList();
            //_view.cmbPostalZone.DataSource = EntityModel.getInstance()._soen390Entities.region.Select(r => r.RegionName).ToList();
            _view.cmbEventTemplate.DataSource = EntityModel.getInstance()._soen390Entities.eventtemplate.Select(et => et.Name).ToList();

        }


        private void attachEventHandlers()
        {
            // add handler
            _view.picAddOrigin.Click += new EventHandler(handleNewOrigin);
            _view.picAddCitizenship.Click += new EventHandler(handleNewCitizenship);
            _view.picAddMotherTongue.Click += new EventHandler(handleNewMotherTongue);
            _view.picAddMaritalStatus.Click += new EventHandler(handleNewMaritalStatus);
            _view.picAddWorkStatus.Click += new EventHandler(handleNewWorkStatus);
            _view.picAddIncomeType.Click += new EventHandler(handleNewIncomeType);
            _view.picAddServiceLang.Click += new EventHandler(handleNewServiceLang);
            _view.picAddFlagType.Click += new EventHandler(handleNewFlagType);
            _view.picAddRegion.Click += new EventHandler(handleNewRegion);

            // edit handler
            _view.picEditOrigin.Click += new EventHandler(handleEditOrigin);
            _view.picEditCitizenship.Click += new EventHandler(handleEditCitizenship);
            _view.picEditMotherTongue.Click += new EventHandler(handleEditMotherTongue);
            _view.picEditMaritalStatus.Click += new EventHandler(handleEditMaritalStatus);
            _view.picEditWorkStatus.Click += new EventHandler(handleEditWorkStatus);
            _view.picEditIncomeType.Click += new EventHandler(handleEditIncomeType);
            _view.picEditServiceLang.Click += new EventHandler(handleEditServiceLang);
            _view.picEditFlagType.Click += new EventHandler(handleEditFlagType);
            _view.picEditRegion.Click += new EventHandler(handleEditRegion);

            // remove handler
            _view.picDeleteOrigin.Click += new EventHandler(handleDeleteOrigin);
            _view.picDeleteCitizenship.Click += new EventHandler(handleDeleteCitizenship);
            _view.picDeleteMotherTongue.Click += new EventHandler(handleDeleteMotherTongue);
            _view.picDeleteMaritalStatus.Click += new EventHandler(handleDeleteMaritalStatus);
            _view.picDeleteWorkStatus.Click += new EventHandler(handleDeleteWorkStatus);
            _view.picDeleteIncomeType.Click += new EventHandler(handleDeleteIncomeType);
            _view.picDeleteServiceLang.Click += new EventHandler(handleDeleteServiceLang);
            _view.picDeleteFlagType.Click += new EventHandler(handleDeleteFlagType);
            _view.picDeleteRegion.Click += new EventHandler(handleDeleteRegion);

            //Event Template Handling
            _view.cmbEventTemplate.DropDown += cmbEventTemplate_DropDown;
            _view.picAddEventTemplate.Click += picAddEventTemplate_Click;
            _view.picDeleteEventTemplate.Click += picDeleteEventTemplate_Click;

        }

        #region HANDLER NEW

        private void handleNewOrigin(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            AddSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Add a New Origin";
            _crudForm.crudView.lblItem.Visible = false;
            _crudForm.ShowDialog();
        }

        private void handleNewCitizenship(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            AddSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Add a New Citizenship";
            _crudForm.crudView.lblItem.Visible = false;
            _crudForm.ShowDialog();
        }

        private void handleNewMotherTongue(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            AddSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Add a New Mother Tongue";
            _crudForm.crudView.lblItem.Visible = false;
            _crudForm.ShowDialog();
        }

        private void handleNewMaritalStatus(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            AddSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Add a New Marital Status";
            _crudForm.crudView.lblItem.Visible = false;
            _crudForm.ShowDialog();
        }

        private void handleNewWorkStatus(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            AddSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Add a New Work Status";
            _crudForm.crudView.lblItem.Visible = false;
            _crudForm.ShowDialog();
        }

        private void handleNewIncomeType(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            AddSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Add a New Income Type";
            _crudForm.crudView.lblItem.Visible = false;
            _crudForm.ShowDialog();
        }

        private void handleNewServiceLang(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            AddSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Add a New Service Language";
            _crudForm.crudView.lblItem.Visible = false;
            _crudForm.ShowDialog();
        }


        private void handleNewFlagType(object sender, EventArgs e)
        {
            SettingCRUDFormDuo _crudFormDuo = new SettingCRUDFormDuo();
            AddSettingDuoPresenter.getInstance().initializeView(_crudFormDuo.crudViewDuo);
            _crudFormDuo.Text = "Add a New Flag Type";
            _crudFormDuo.crudViewDuo.lblItem.Text = "Flag Title";
            _crudFormDuo.crudViewDuo.lblItem2.Text = "Priority";

            _crudFormDuo.crudViewDuo.lblItem.Visible = true;
            _crudFormDuo.crudViewDuo.lblItem2.Visible = true;

            _crudFormDuo.ShowDialog();
        }

        private void handleNewRegion(object sender, EventArgs e)
        {
            SettingCRUDFormDuo _crudFormDuo = new SettingCRUDFormDuo();
            AddSettingDuoPresenter.getInstance().initializeView(_crudFormDuo.crudViewDuo);
            _crudFormDuo.Text = "Add a New Region";
            _crudFormDuo.crudViewDuo.lblItem.Text = "Region Name";
            _crudFormDuo.crudViewDuo.lblItem2.Text = "Code Prefix";

            _crudFormDuo.crudViewDuo.lblItem.Visible = true;
            _crudFormDuo.crudViewDuo.lblItem2.Visible = true;

            _crudFormDuo.ShowDialog();
        }
        

#endregion

        #region HANGLER EDIT

        private void handleEditOrigin(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            EditSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Edit current Origin";
            // display the selected value in lable
            _crudForm.crudView.lblItem.Text = _view.cmbOrigin.SelectedItem.ToString();
            _crudForm.crudView.lblItem.Visible = true;
            _crudForm.ShowDialog();
        }

        private void handleEditCitizenship(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            EditSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Edit current Citizenship";
            // display the selected value in lable
            _crudForm.crudView.lblItem.Text = _view.cmbCitizenship.SelectedItem.ToString();
            _crudForm.crudView.lblItem.Visible = true;
            _crudForm.ShowDialog();
        }

        private void handleEditMotherTongue(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            EditSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Edit current Mother Tongue";
            // display the selected value in lable
            _crudForm.crudView.lblItem.Text = _view.cmbMotherTongue.SelectedItem.ToString();
            _crudForm.crudView.lblItem.Visible = true;
            _crudForm.ShowDialog();
        }

        private void handleEditMaritalStatus(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            EditSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Edit current Marital Status";
            // display the selected value in lable
            _crudForm.crudView.lblItem.Text = _view.cmbMaritalStatus.SelectedItem.ToString();
            _crudForm.crudView.lblItem.Visible = true;
            _crudForm.ShowDialog();
        }

        private void handleEditWorkStatus(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            EditSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Edit current Marital Status";
            // display the selected value in lable
            _crudForm.crudView.lblItem.Text = _view.cmbWorkStatus.SelectedItem.ToString();
            _crudForm.crudView.lblItem.Visible = true;
            _crudForm.ShowDialog();
        }
        private void handleEditIncomeType(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            EditSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Edit current Income Type";
            // display the selected value in lable
            _crudForm.crudView.lblItem.Text = _view.cmbIncomeType.SelectedItem.ToString();
            _crudForm.crudView.lblItem.Visible = true;
            _crudForm.ShowDialog();
        }
        private void handleEditServiceLang(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            EditSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Edit current Service Language";
            // display the selected value in lable
            _crudForm.crudView.lblItem.Text = _view.cmbServiceLang.SelectedItem.ToString();
            _crudForm.crudView.lblItem.Visible = true;
            _crudForm.ShowDialog();
        }
        private void handleEditFlagType(object sender, EventArgs e)
        {
            SettingCRUDFormDuo _crudFormDuo = new SettingCRUDFormDuo();
            EditSettingDuoPresenter.getInstance().initializeView(_crudFormDuo.crudViewDuo);
            _crudFormDuo.Text = "Edit current Flag Type";

            SettingAPI _settingAPI = new SettingAPI();
            string flagTitle = _view.cmbFlagType.SelectedItem.ToString();
            // display the selected value in lable
            _crudFormDuo.crudViewDuo.lblItem.Text = _view.cmbFlagType.SelectedItem.ToString();
            _crudFormDuo.crudViewDuo.lblItem2.Text = _settingAPI.getPriority(flagTitle);
            _crudFormDuo.crudViewDuo.lblItem.Visible = true;
            _crudFormDuo.crudViewDuo.lblItem2.Visible = true;

            _crudFormDuo.ShowDialog();
        }

        private void handleEditRegion(object sender, EventArgs e)
        {
            SettingCRUDFormDuo _crudFormDuo = new SettingCRUDFormDuo();
            EditSettingDuoPresenter.getInstance().initializeView(_crudFormDuo.crudViewDuo);
            _crudFormDuo.Text = "Edit current Region";

            SettingAPI _settingAPI = new SettingAPI();
            string codePrefix = _view.cmbPostalZone.SelectedItem.ToString();
            // display the selected value in lable
            _crudFormDuo.crudViewDuo.lblItem.Text = _settingAPI.getRegionNameByCodePrefix(codePrefix);
            _crudFormDuo.crudViewDuo.lblItem2.Text =  _view.cmbPostalZone.SelectedItem.ToString();
            _crudFormDuo.crudViewDuo.lblItem.Visible = true;
            _crudFormDuo.crudViewDuo.lblItem2.Visible = true;

            _crudFormDuo.ShowDialog();
        }

        #endregion

        #region HANDLER DELETE

        private void handleDeleteOrigin(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            DeleteSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Remove current Origin";
            _crudForm.crudView.lblItem.Visible = false;
            // display the selected value
            _crudForm.crudView.txtSettingInput.Text = _view.cmbOrigin.SelectedItem.ToString();
            _crudForm.crudView.txtSettingInput.Enabled = false;
            _crudForm.ShowDialog();
        }

        private void handleDeleteCitizenship(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            DeleteSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Remove current Citizenship";
            _crudForm.crudView.lblItem.Visible = false;
            // display the selected value
            _crudForm.crudView.txtSettingInput.Text = _view.cmbCitizenship.SelectedItem.ToString();
            _crudForm.crudView.txtSettingInput.Enabled = false;
            _crudForm.ShowDialog();
        }

        private void handleDeleteMotherTongue(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            DeleteSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Remove current Mother Tongue";
            _crudForm.crudView.lblItem.Visible = false;
            // display the selected value
            _crudForm.crudView.txtSettingInput.Text = _view.cmbMotherTongue.SelectedItem.ToString();
            _crudForm.crudView.txtSettingInput.Enabled = false;
            _crudForm.ShowDialog();
        }


        private void handleDeleteMaritalStatus(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            DeleteSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Remove current Marital Status";
            _crudForm.crudView.lblItem.Visible = false;
            // display the selected value
            _crudForm.crudView.txtSettingInput.Text = _view.cmbMaritalStatus.SelectedItem.ToString();
            _crudForm.crudView.txtSettingInput.Enabled = false;
            _crudForm.ShowDialog();
        }


        private void handleDeleteWorkStatus(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            DeleteSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Remove current Work Status";
            _crudForm.crudView.lblItem.Visible = false;
            // display the selected value
            _crudForm.crudView.txtSettingInput.Text = _view.cmbWorkStatus.SelectedItem.ToString();
            _crudForm.crudView.txtSettingInput.Enabled = false;
            _crudForm.ShowDialog();
        }


        private void handleDeleteIncomeType(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            DeleteSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Remove current Income Type";
            _crudForm.crudView.lblItem.Visible = false;
            // display the selected value
            _crudForm.crudView.txtSettingInput.Text = _view.cmbIncomeType.SelectedItem.ToString();
            _crudForm.crudView.txtSettingInput.Enabled = false;
            _crudForm.ShowDialog();
        }


        private void handleDeleteServiceLang(object sender, EventArgs e)
        {
            SettingCRUDForm _crudForm = new SettingCRUDForm();
            DeleteSettingPresenter.getInstance().initializeView(_crudForm.crudView);
            _crudForm.Text = "Remove current Service Language";
            _crudForm.crudView.lblItem.Visible = false;
            // display the selected value
            _crudForm.crudView.txtSettingInput.Text = _view.cmbServiceLang.SelectedItem.ToString();
            _crudForm.crudView.txtSettingInput.Enabled = false;
            _crudForm.ShowDialog();
        }


        private void handleDeleteFlagType(object sender, EventArgs e)
        {
            SettingCRUDFormDuo _crudFormDuo = new SettingCRUDFormDuo();
            DeleteSettingDuoPresenter.getInstance().initializeView(_crudFormDuo.crudViewDuo);
            _crudFormDuo.Text = "Remove current Flag Type";
            _crudFormDuo.crudViewDuo.lblItem.Visible = false;
            _crudFormDuo.crudViewDuo.lblItem2.Visible = false;

             SettingAPI _settingAPI = new SettingAPI();
            string flagTitle = _view.cmbFlagType.SelectedItem.ToString();

            // display the selected value
            _crudFormDuo.crudViewDuo.txtFieldPrimary.Text = _view.cmbFlagType.SelectedItem.ToString();
            _crudFormDuo.crudViewDuo.txtFieldSecondary.Text = _settingAPI.getPriority(flagTitle);
            _crudFormDuo.ShowDialog();
        }

        private void handleDeleteRegion(object sender, EventArgs e)
        {
            SettingCRUDFormDuo _crudFormDuo = new SettingCRUDFormDuo();
            DeleteSettingDuoPresenter.getInstance().initializeView(_crudFormDuo.crudViewDuo);
            _crudFormDuo.Text = "Remove current Region";
            _crudFormDuo.crudViewDuo.lblItem.Visible = false;
            _crudFormDuo.crudViewDuo.lblItem2.Visible = false;

            SettingAPI _settingAPI = new SettingAPI();
            string codePrefix = _view.cmbPostalZone.SelectedItem.ToString();

            // display the selected value
            _crudFormDuo.crudViewDuo.txtFieldPrimary.Text = _settingAPI.getRegionNameByCodePrefix(codePrefix);
            _crudFormDuo.crudViewDuo.txtFieldSecondary.Text =  _view.cmbPostalZone.SelectedItem.ToString();
            _crudFormDuo.ShowDialog();
        }


        #endregion

        #region EVENT TEMPLATE HANDLING

        void cmbEventTemplate_DropDown(object sender, EventArgs e)
        {
            _view.cmbEventTemplate.DataSource = null;
            _view.cmbEventTemplate.DataSource = EntityModel.getInstance()._soen390Entities.eventtemplate.Select(et => et.Name).ToList();
        }

        void picAddEventTemplate_Click(object sender, EventArgs e)
        {
            AddEventTemplatePresenter presenter = new AddEventTemplatePresenter();
            presenter.ShowDialog();
        }
        void picDeleteEventTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                string eventTemplateName = _view.cmbEventTemplate.Text;
                eventtemplate toRemove = EntityModel.getInstance()._soen390Entities.eventtemplate.Where(et => et.Name == eventTemplateName).First();
                IEnumerable<slottemplate> slotsToRemove = toRemove.slottemplate.ToList(); ;
                foreach (slottemplate slottemp in slotsToRemove)
                    EntityModel.getInstance()._soen390Entities.slottemplate.Remove(slottemp);
                EntityModel.getInstance()._soen390Entities.eventtemplate.Remove(toRemove);
                EntityModel.getInstance()._soen390Entities.SaveChanges();
                List<string> eventTemplates = EntityModel.getInstance()._soen390Entities.eventtemplate.Select(et => et.Name).ToList();
                if (eventTemplates.Count > 0)
                {
                    _view.cmbEventTemplate.SelectedItem = eventTemplates.First();
                    _view.cmbEventTemplate.DataSource = eventTemplates;
                }

                else
                {
                    _view.cmbEventTemplate.Text = "";
                    _view.cmbEventTemplate.DataSource = eventTemplates;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't remove template", "Database/List Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}