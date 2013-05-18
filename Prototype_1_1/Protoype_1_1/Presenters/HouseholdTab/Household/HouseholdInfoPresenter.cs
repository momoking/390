using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.HouseholdModel;
using Prototype1_1.UI.Forms.HouseholdTab.Household;
using Prototype1_1.UI.Views.HouseholdTab.Household;
using Prototype1_1.Data.EntityModel;
using Prototype1_1.UI.Utilities;

namespace Prototype1_1.Presenters.HouseholdTab.Household
{
    public class HouseholdInfoPresenter
    {
        #region Attributes
        
        private static HouseholdInfoPresenter _instance;
     
        private HouseholdCRUD _model;
        private HouseholdAPI _api;
        private HouseholdInfoView _view;

        private household _activeHousehold;

        #endregion

        #region Properties
        public HouseholdInfoView View
        {
            get { return _view; }
        }

        public household ActiveHousehold
        {
            get { return _activeHousehold; }
        }
        #endregion

        #region Constructor

        private HouseholdInfoPresenter()
        {
          
        }

        public static HouseholdInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new HouseholdInfoPresenter();
            }

            return _instance;
        }

        public void attachView(HouseholdInfoView aView)
        {
            _api = new HouseholdAPI();
            _model = new HouseholdCRUD();
            _view = aView;

            attachEventHandlers();
            initializeView();   
        }

        #endregion

        #region Methods
        private void attachEventHandlers()
        {
            _view.Load += new EventHandler(handleOnLoadEvent);
            _view.picAdd.Click += new EventHandler(handleNewHouseholdInfo);
            _view.picEdit.Click += new EventHandler(handleEditHouseholdInfo);
            _view.picClear.Click += new EventHandler(handleClearHouseholdInfo);

        }
        
        private void initializeView()
        {
            //populate dropdown boxes.
            //soen390Entities entityInstance = new soen390Entities();
           
            _view.cmbRegion.DataSource = EntityModel.getInstance()._soen390Entities.region.Select(r => r.RegionName).Distinct().ToList();                    
         
        }
        #endregion

        #region Handlers
        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            ImageAPI api = new ImageAPI();

            if (_activeHousehold != null)
            {
                loadHouseholdInfo(_activeHousehold);
            }

            _view.picAdd.Image = api.makeIconOpaque(_view.picAdd);
            _view.picEdit.Image = api.makeIconOpaque(_view.picEdit);
            
        }

        private void handleNewHouseholdInfo(object sender, EventArgs e)
        {
            //CreateHouseholdForm cf = new CreateHouseholdForm();
            //CreateHouseholdInfoPresenter.getInstance().attachView(cf.createHouseholdInfoView1);
            //cf.ShowDialog();
        }

        private void handleEditHouseholdInfo(object sender, EventArgs e)
        {
            //UpdateHouseholdForm cf = new UpdateHouseholdForm();
            //UpdateHouseholdInfoPresenter.getInstance().attachView(cf.updateHouseholdInfoView1);
            //cf.ShowDialog();            

        }

        private void handleClearHouseholdInfo(object sender, EventArgs e)
        {
            _view.clearAllControls();

        }
        #endregion

        #region Public API

        public void loadHouseholdInfo(household ahousehold)
        {
            _activeHousehold = ahousehold;

            _view.txtHouseholdID.Text = ahousehold.HouseholdID.ToString();
            _view.txtStreetNumber.Text = ahousehold.StreetNumber;
            _view.txtStreetName.Text = ahousehold.StreetName;
            _view.txtApt.Text = ahousehold.AppartmentNumber;
            _view.txtPostal.Text = ahousehold.PostalCode;
            _view.cmbRegion.SelectedItem = ahousehold.Region.ToString(); ;
            _view.txtPhone.Text = ahousehold.PhoneNumber;
            _view.dtpFirstVisit.Value = ahousehold.FirstVisit.Value;
            

            if (_api.isHouseholdNeedToUpdate(ahousehold))
            {
                _view.lblLastUpdate.Visible = true;
            }
            else
            {
                _view.lblLastUpdate.Visible = false;
            }
        }

        #endregion

    }
}
