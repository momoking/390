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
    class DeleteSettingPresenter
    {
        private static DeleteSettingPresenter _instance;
        private soen390Entities _entities;
        private SettingCRUDView _view;
        private SettingCRUD _model;

        private DeleteSettingPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
            _model = new SettingCRUD();
        }

        public static DeleteSettingPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new DeleteSettingPresenter();
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
            _view.btnOK.Click += new EventHandler(handleDeleteOK);
            _view.btnCancel.Click += new EventHandler(handleCancelOK);
        }

        private void handleCancelOK(object sender, EventArgs e)
        {
            _view.ParentForm.Close();
        }

        private void handleDeleteOK(object sender, EventArgs e)
        {


            // get old value
            String oldvalue = _view.txtSettingInput.Text;

            bool updated = false;

            try
            {
                if (_view.ParentForm.Text == "Remove current Origin")
                {
                    updated = _model.deleteOrigin(oldvalue);
                }
                else if (_view.ParentForm.Text == "Remove current Citizenship")
                {
                    updated = _model.deleteCitizenship(oldvalue);
                }
                else if (_view.ParentForm.Text == "Remove current Mother Tongue")
                {
                    updated = _model.deleteMothertongue(oldvalue);
                }
                else if (_view.ParentForm.Text == "Remove current Marital Status")
                {
                    updated = _model.deleteMaritalstatus(oldvalue);
                }
                else if (_view.ParentForm.Text == "Remove current Work Status")
                {
                    updated = _model.deleteWorkstatus(oldvalue);
                }
                else if (_view.ParentForm.Text == "Remove current Income Type")
                {
                    updated = _model.deleteIncometype(oldvalue);
                }
                else if (_view.ParentForm.Text == "Remove current Service Language")
                {
                    updated = _model.deleteServicelang(oldvalue);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("The system prevents you from deleting the item as it is already being used by clients");
            }

            SettingPresenter.getInstance().loadSettings();
            _view.ParentForm.Close();
            
           

        }
    }
}
