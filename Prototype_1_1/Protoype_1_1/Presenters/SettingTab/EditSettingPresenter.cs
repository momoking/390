using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.Data.SettingModel;
using Prototype1_1.UI;
using Prototype1_1.UI.Forms;
using Prototype1_1.UI.Views.SettingTab;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.EntityModel;
using System.Windows.Forms;

namespace Prototype1_1.Presenters.SettingTab
{
    class EditSettingPresenter
    {
        private static EditSettingPresenter _instance;
        private soen390Entities _entities;
        private SettingCRUDView _view;
        private SettingCRUD _model;

        private EditSettingPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
            _model = new SettingCRUD();
        }

        public static EditSettingPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new EditSettingPresenter();
            }
            return _instance;
        }

        public void initializeView(SettingCRUDView aView)
        {
            _view = aView;
            attachEventHandlers();
        }

        private void attachEventHandlers()
        {
            _view.btnOK.Click += new EventHandler(handleEditOK);
            _view.btnCancel.Click += new EventHandler(handleCancelOK);
        }

        private void handleCancelOK(object sender, EventArgs e)
        {
            _view.ParentForm.Close();
        }

        private void handleEditOK(object sender, EventArgs e)
        {


            // get old value
            String oldvalue = _view.lblItem.Text;

            // get new value
            String userinput = _view.txtSettingInput.Text;

            bool updated = false;
            try
            {
                if (_view.ParentForm.Text == "Edit current Origin")
                {
                    updated = _model.updateOrigin(oldvalue, userinput);
                }
                else if (_view.ParentForm.Text == "Edit current Citizenship")
                {
                    updated = _model.updateCitizenship(oldvalue, userinput);
                }
                else if (_view.ParentForm.Text == "Edit current Mother Tongue")
                {
                    updated = _model.updateMothertongue(oldvalue, userinput);
                }
                else if (_view.ParentForm.Text == "Edit current Marital Status")
                {
                    updated = _model.updateMaritalstatus(oldvalue, userinput);
                }
                else if (_view.ParentForm.Text == "Edit current Work Status")
                {
                    updated = _model.updateWorkstatus(oldvalue, userinput);
                }
                else if (_view.ParentForm.Text == "Edit current Income Type")
                {
                    updated = _model.updateIncometype(oldvalue, userinput);
                }
                else if (_view.ParentForm.Text == "Edit current Service Language")
                {
                    updated = _model.updateServicelang(oldvalue, userinput);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The system prevents you from editing the item as it is already being used by clients");
            }
           

            SettingPresenter.getInstance().loadSettings();
            _view.ParentForm.Close();
            
           

        }


    }
}