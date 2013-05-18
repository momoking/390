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
    class EditSettingDuoPresenter
    {
        private static EditSettingDuoPresenter _instance;
        private soen390Entities _entities;
        private SettingCRUDViewDuo _view;
        private SettingCRUD _model;

        private EditSettingDuoPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
            _model = new SettingCRUD();
        }

        public static EditSettingDuoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new EditSettingDuoPresenter();
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
            String oldPrimary = _view.lblItem.Text;
            String oldSecondary = _view.lblItem2.Text;

            // get new value
            String userinput1 = _view.txtFieldPrimary.Text;
            String userinput2= _view.txtFieldSecondary.Text;

            bool updated = false;

            try
            {

                if (_view.ParentForm.Text == "Edit current Flag Type")
                {
                    updated = _model.updateFlagtype(oldPrimary, oldSecondary, userinput1, userinput2);
                }
                else if (_view.ParentForm.Text == "Edit current Region")
                {
                    updated = _model.updateRegion(oldPrimary, oldSecondary, userinput1, userinput2);
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