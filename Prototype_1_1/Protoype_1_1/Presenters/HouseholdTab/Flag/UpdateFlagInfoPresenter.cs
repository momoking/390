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
using Prototype1_1.UI.Views.HouseholdTab.Note;
using Prototype1_1.Presenters.HouseholdTab.Note;
using Prototype1_1.Data.EntityModel;
using Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient;

namespace Prototype1_1.Presenters.HouseholdTab.Flag
{
    public class UpdateFlagInfoPresenter
    {
        #region Attributes

        private static UpdateFlagInfoPresenter _instance;

        private FlagCRUD _model;
        private FlagAPI _api;
        private UpdateFlagInfoView _view;

        private flag _selectedFlag;
        #endregion

        #region Properties
        public UpdateFlagInfoView View
        {
            get { return _view; }
        }
        #endregion

        #region Constructor
        private UpdateFlagInfoPresenter()
        {
          
        }

        public static UpdateFlagInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new UpdateFlagInfoPresenter();
            }

            return _instance;
        }

        public void attachView(UpdateFlagInfoView aView)
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
            _view.Load += new EventHandler(handleOnLoadEvent);
            _view.btnSave.Click += new EventHandler(handleSaveFlagInfo);
            _view.btnCancel.Click += new EventHandler(handleCancelFlagInfo);

        }

        private void initializeView()
        {
            _view.cmbFlagType.DataSource = EntityModel.getInstance()._soen390Entities.flagtype.Select(r => r.FlagTitle).ToList();
          
        }
        #endregion

        #region Handlers
        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            _selectedFlag = FlagInfoPresenter.getInstance().View.dgvFlags.SelectedRows[0].DataBoundItem as flag;

            if (_selectedFlag != null)
            {
                loadFlagInfo(_selectedFlag);
            }

        }

        private void handleSaveFlagInfo(object sender, EventArgs e)
        {
            long ID = EntityModel.getInstance()._soen390Entities.flagtype.Where(r => r.FlagTitle == _view.cmbFlagType.SelectedItem).FirstOrDefault().FlagID;

            flag UpdatedFlag = _model.updateFlag(FlagInfoPresenter.getInstance().SelectedFlag.ID, ID, _view.rchFlag.Text, DateTime.Today);

            if (UpdatedFlag == null)
            {
                MessageBox.Show("Unable to save this Flag...");
            }
            else
            {
                            
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

        #region Public API

        public void loadFlagInfo(flag aFlags)
        {
            _view.dtpDate.Value = aFlags.DateStamp.Value;
            _view.cmbFlagType.SelectedItem = aFlags.flagtype.ToString();
            _view.rchFlag.Text = aFlags.FlagInfo;

        }


        #endregion
    }
}
