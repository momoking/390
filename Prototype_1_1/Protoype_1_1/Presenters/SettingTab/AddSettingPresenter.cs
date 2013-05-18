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
    class AddSettingPresenter
    {
        private static AddSettingPresenter _instance;
        private soen390Entities _entities;
        private SettingCRUDView _view;
        private SettingCRUD _model;



        private AddSettingPresenter()
        {
            _entities = EntityModel.getInstance()._soen390Entities;
            _model = new SettingCRUD();
        }

        public static AddSettingPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new AddSettingPresenter();
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
            _view.btnOK.Click += new EventHandler(handleNewSettingOK);
            _view.btnCancel.Click += new EventHandler(handleCancelOK);
        }

        private void handleCancelOK(object sender, EventArgs e)
        {
            _view.ParentForm.Close();
        }

        private void handleNewSettingOK(object sender, EventArgs e)
        {

            String userinput = _view.txtSettingInput.Text;

            // to do : data validation: null, exist, etc...

            if (_view.ParentForm.Text == "Add a New Origin")
            {
                origin anOrigin = _model.addOrigin(userinput);
            }
            else if (_view.ParentForm.Text == "Add a New Citizenship")
            {
                citizenship aCitizenship = _model.addCitizenship(userinput);
            }
            else if (_view.ParentForm.Text == "Add a New Mother Tongue")
            {
                mothertongue aMothertongue = _model.addMothertongue(userinput);
            }
            else if (_view.ParentForm.Text == "Add a New Marital Status")
            {
                maritalstatus aMaritalstatus = _model.addMaritalstatus(userinput);
            }
            else if (_view.ParentForm.Text == "Add a New Work Status")
            {
                workstatus aWorkstatus = _model.addWorkstatus(userinput);
            }
            else if (_view.ParentForm.Text == "Add a New Income Type")
            {
                incometype anIncometype = _model.addIncometype(userinput);
            }
            else if (_view.ParentForm.Text == "Add a New Service Language")
            {
                servicelanguage aServicelang = _model.addServicelang(userinput);
            }

            SettingPresenter.getInstance().loadSettings();
            _view.ParentForm.Close();
            
        }


    }
}