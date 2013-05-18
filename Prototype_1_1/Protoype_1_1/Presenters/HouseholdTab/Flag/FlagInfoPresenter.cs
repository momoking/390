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
using Prototype1_1.Utilities;

namespace Prototype1_1.Presenters.HouseholdTab.Flag
{
    public class FlagInfoPresenter
    {
        #region Attributes

        private static FlagInfoPresenter _instance;

        private FlagCRUD _model;
        private FlagAPI _api;
        private FlagInfoView _view;

        private List<flag> _activeFlags;
        private flag _selectedFlag;

        private CreateFlagForm _createFlagForm;
        private UpdateFlagForm _updateFlagForm;

        #endregion

        #region Properties
        public FlagInfoView View
        {
            get { return _view; }
        }

        public List<flag> ActiveFlags
        {
            get { return _activeFlags; }
        }

        public flag SelectedFlag
        {
            get { return _selectedFlag; }
        }
        #endregion

        #region Constructor

        private FlagInfoPresenter()
        {

        }

        public static FlagInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new FlagInfoPresenter();
            }

            return _instance;
        }

        public void attachView(FlagInfoView aView)
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
            _view.dgvFlags.CellEnter += new DataGridViewCellEventHandler(handleSelectedFlagEvent);
            _view.picAdd.Click += new EventHandler(handleNewFlagInfo);
            _view.picEdit.Click += new EventHandler(handleEditFlagInfo);
            _view.picDelete.Click += new EventHandler(handleDeleteFlagInfo);
            _view.dgvFlags.DoubleClick += new EventHandler(handleEditFlagInfo);

        }

        private void initializeView()
        {
          
        }
        #endregion

        #region Handlers
        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            if (_activeFlags != null)
            {
                loadFlagInfo(_activeFlags);
            }

            _view.picAdd.Image = ImageAPI.makeIconOpaque(_view.picAdd.Image);
            _view.picEdit.Image = ImageAPI.makeIconOpaque(_view.picEdit.Image);
            _view.picDelete.Image = ImageAPI.makeIconOpaque(_view.picDelete.Image);

        }

        private void handleSelectedFlagEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (_view.dgvFlags.SelectedRows.Count > 0)
            {
                _selectedFlag = _view.dgvFlags.SelectedRows[0].DataBoundItem as flag;
            }
        }

        private void handleNewFlagInfo(object sender, EventArgs e)
        {
            _createFlagForm = new CreateFlagForm();
            CreateFlagInfoPresenter.getInstance().attachView(_createFlagForm.createFlagInfoView1);
            _createFlagForm.ShowDialog();
        }

        private void handleEditFlagInfo(object sender, EventArgs e)
        {

            _updateFlagForm = new UpdateFlagForm();
            UpdateFlagInfoPresenter.getInstance().attachView(_updateFlagForm.updateFlagInfoView1);
            _updateFlagForm.ShowDialog();

        }

        private void handleDeleteFlagInfo(object sender, EventArgs e)
        {
            //no need for a new form since we only want a confirmation.
            if (MessageBox.Show("Are you sure you want to delete this Flag?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                //unlink the Flag from the active client
                HouseholdAndClientPresenter.getInstance().ActiveHousehold.flag.Remove(_selectedFlag);
                EntityModel.getInstance().save();

                //remove the Flag from the db;
                flag aFlag = _model.deleteFlag(_selectedFlag.ID);

                if (aFlag == null)
                {
                    MessageBox.Show("Unable to delete this Flag...");
                }
                else
                {
                    //get the updatd active Flag list
                    List<flag> activeFlags = HouseholdAndClientPresenter.getInstance().ActiveHousehold.flag.ToList();

                    if (activeFlags != null)
                    {
                        loadFlagInfo(activeFlags);
                    }
                }


            }
        }
        #endregion

        #region Public API

        public void loadFlagInfo(List<flag> Flags)
        {
            _activeFlags = Flags;

            _view.dgvFlags.AutoGenerateColumns = false;

            _view.dgvFlags.DataSource = Flags;

        }

        #endregion

    }
}
