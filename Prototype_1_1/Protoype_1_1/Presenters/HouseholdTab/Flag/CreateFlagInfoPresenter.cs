using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.FlagModel;
using Prototype1_1.UI.Views.HouseholdTab.Flag;
using Prototype1_1.UI.Forms.HouseholdTab.Flag;

using Prototype1_1.Data.EntityModel;
using Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient;

namespace Prototype1_1.Presenters.HouseholdTab.Flag
{
    public class CreateFlagInfoPresenter
    {
        #region Attributes

        private static CreateFlagInfoPresenter _instance;

        private FlagCRUD _model;
        private FlagAPI _api;
        private CreateFlagInfoView _view;

        #endregion

        #region Properties
        public CreateFlagInfoView View
        {
            get { return _view; }
        }
        #endregion

        #region Constructor
        private CreateFlagInfoPresenter()
        {
          
        }

        public static CreateFlagInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new CreateFlagInfoPresenter();
            }

            return _instance;
        }

        public void attachView(CreateFlagInfoView aView)
        {
            _api = new FlagAPI();
            _model = new FlagCRUD();
            _view = aView;

            attachEventHandlers();
            initializeView();   
        }


        #endregion

        #region Methods
        private void attachEventHandlers()
        {

            _view.btnSave.Click += new EventHandler(handleSaveFlagInfo);
            _view.btnCancel.Click += new EventHandler(handleCancelFlagInfo);

        }

        private void initializeView()
        {
            _view.cmbFlagType.DataSource = EntityModel.getInstance()._soen390Entities.flagtype.Select(r => r.FlagTitle).ToList();
        }
        #endregion

        #region Handlers
        private void handleSaveFlagInfo(object sender, EventArgs e)
        {
            long ID = EntityModel.getInstance()._soen390Entities.flagtype.Where(r => r.FlagTitle == _view.cmbFlagType.SelectedItem).FirstOrDefault().FlagID;
            
            flag createdFlag = _model.createFlag(0,ID ,_view.rchFlag.Text, DateTime.Today);

            if (createdFlag == null)
            {
                MessageBox.Show("Unable to save this Flag...");
            }
            else
            {
             
                createdFlag.household.Add(HouseholdAndClientPresenter.getInstance().ActiveHousehold);

                EntityModel.getInstance().save();

                //get the active Flag list
                List<flag> activeFlags = HouseholdAndClientPresenter.getInstance().ActiveHousehold.flag.ToList();

                if (activeFlags != null)
                {
                    FlagInfoPresenter.getInstance().loadFlagInfo(activeFlags);
                }
            }

           _view.ParentForm.Close();
               
        }

        private void handleCancelFlagInfo(object sender, EventArgs e)
        {
            _view.ParentForm.Close();
        }


        #endregion
    }
}
