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
    class DeleteSettingDuoPresenter
    {
        private static DeleteSettingDuoPresenter _instance;
        private soen390Entities _entities;
        private SettingCRUDViewDuo _view;
        private SettingCRUD _model;

        private DeleteSettingDuoPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
            _model = new SettingCRUD();
        }

        public static DeleteSettingDuoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new DeleteSettingDuoPresenter();
            }
            return _instance;
        }

        public void initializeView(SettingCRUDViewDuo aView)
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
            // get value
            String oldPrimary = _view.txtFieldPrimary.Text;
            String oldSecondary = _view.txtFieldSecondary.Text;

            bool updated = false;

            try
            {
                if (_view.ParentForm.Text == "Remove current Flag Type")
                {
                    updated = _model.deleteFlagtype(oldPrimary, oldSecondary);
                }
                else if (_view.ParentForm.Text == "Remove current Region")
                {
                    updated = _model.deleteRegion(oldPrimary, oldSecondary);
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
