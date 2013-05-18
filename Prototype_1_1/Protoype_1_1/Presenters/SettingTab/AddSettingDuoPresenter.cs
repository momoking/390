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
    class AddSettingDuoPresenter
    {
        private static AddSettingDuoPresenter _instance;
        private soen390Entities _entities;
        private SettingCRUDViewDuo _view;
        private SettingCRUD _model;



        private AddSettingDuoPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
            _model = new SettingCRUD();
        }

        public static AddSettingDuoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new AddSettingDuoPresenter();
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
            _view.btnOK.Click += new EventHandler(handleNewSettingOK);
            _view.btnCancel.Click += new EventHandler(handleCancelOK);        
        }

        private void handleCancelOK(object sender, EventArgs e)
        {
            _view.ParentForm.Close();
        }

        private void handleNewSettingOK(object sender, EventArgs e)
        {

            String userinputPrimary = _view.txtFieldPrimary.Text;
            String userinputSecondary = _view.txtFieldSecondary.Text;


            // to do : data validation: null, exist, etc...

            if (_view.ParentForm.Text == "Add a New Flag Type")
            {
                flagtype aFlagtype = _model.addFlagtype(userinputPrimary, userinputSecondary);

            }else if (_view.ParentForm.Text == "Add a New Region")
            {
                region aRegion = _model.addRegion(userinputPrimary, userinputSecondary);
            }

            SettingPresenter.getInstance().loadSettings();
            _view.ParentForm.Close();

        }


    }
}