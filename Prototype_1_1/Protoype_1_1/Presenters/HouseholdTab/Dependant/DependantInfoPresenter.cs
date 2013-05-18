using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.DependantModel;
using Prototype1_1.UI.Views.HouseholdTab.Dependant;
using Prototype1_1.UI.Forms.HouseholdTab.Dependant;

using Prototype1_1.Data.EntityModel;
using Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient;
using System.Drawing.Imaging;
using System.Drawing;
using Prototype1_1.Utilities;

namespace Prototype1_1.Presenters.HouseholdTab.Dependant
{
    public class DependantInfoPresenter
    {
        #region Attributes
        
        private static DependantInfoPresenter _instance;
     
        private DependantCRUD _model;
        private DependantAPI _api;
        private DependantInfoView _view;

        private List<dependant> _activeDependants;
        private dependant _selectedDependant;

        private CreateDependantForm _createDependantForm;
        private UpdateDependantForm _updateDependantForm;

        #endregion

        #region Properties
        public DependantInfoView View
        {
            get { return _view; }
        }

        public List<dependant> ActiveDependants
        {
            get { return _activeDependants; }
        }
        
        public dependant SelectedDependant
        {
            get { return _selectedDependant; }
        }
        #endregion

        #region Constructor

        private DependantInfoPresenter()
        {
          
        }

        public static DependantInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new DependantInfoPresenter();
            }

            return _instance;
        }

        public void attachView(DependantInfoView aView)
        {
            _api = new DependantAPI();
            _model = new DependantCRUD();
            _view = aView;

            attachEventHandlers();
            initializeView();   
        }

        #endregion

        #region Methods
        private void attachEventHandlers()
        {
            _view.Load += new EventHandler(handleOnLoadEvent);
            _view.dgvDependants.CellEnter += new DataGridViewCellEventHandler(handleSelectedDependantEvent);
            _view.picAdd.Click += new EventHandler(handleNewDependantInfo);
            _view.picEdit.Click += new EventHandler(handleEditDependantInfo);
            _view.picDelete.Click += new EventHandler(handleDeleteDependantInfo);
            _view.dgvDependants.DoubleClick += new EventHandler(handleEditDependantInfo);

        }
        
        private void initializeView()
        {
           
        }

       
        #endregion

        #region Handlers
        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            if (_activeDependants != null)
            {
                loadDependantInfo(_activeDependants);
            }

            _view.picAdd.Image = ImageAPI.makeIconOpaque(_view.picAdd.Image);
            _view.picEdit.Image = ImageAPI.makeIconOpaque(_view.picEdit.Image);
            _view.picDelete.Image = ImageAPI.makeIconOpaque(_view.picDelete.Image);
        }

        private void handleSelectedDependantEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (_view.dgvDependants.SelectedRows.Count > 0)
            {
                _selectedDependant = _view.dgvDependants.SelectedRows[0].DataBoundItem as dependant;
            }
        }

        private void handleNewDependantInfo(object sender, EventArgs e)
        {
            _createDependantForm = new CreateDependantForm();
            CreateDependantInfoPresenter.getInstance().attachView(_createDependantForm.createDependantInfoView1);

            _createDependantForm.ShowDialog();
        }

        private void handleEditDependantInfo(object sender, EventArgs e)
        {
            _updateDependantForm = new UpdateDependantForm();
            UpdateDependantInfoPresenter.getInstance().attachView(_updateDependantForm.updateDependantInfoView1);
        
            _updateDependantForm.ShowDialog();            

        }

        private void handleDeleteDependantInfo(object sender, EventArgs e)
        {
            //no need for a new form since we only want a confirmation.
            if (MessageBox.Show("Are you sure you want to delete this dependant?","",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

               //unlink the dependant from the active client
               HouseholdAndClientPresenter.getInstance().ActiveClient.dependant.Remove(_selectedDependant);
               EntityModel.getInstance().save();
                  
               //remove the dependant from the db;
               dependant aDependant = _model.deleteDependant(_selectedDependant.DependantID);

               if (aDependant == null)
               {
                   MessageBox.Show("Unable to delete this Dependant...");
               }
               else
               {
                  
                   //get the updatd active dependant list
                   List<dependant> activeDependants = HouseholdAndClientPresenter.getInstance().ActiveClient.dependant.ToList();

                   if (activeDependants != null)
                   {
                       loadDependantInfo(activeDependants);
                   }
               }


            }
        }
        #endregion

        #region Public API

        public void loadDependantInfo(List<dependant> dependants)
        {
            _activeDependants = dependants;
           
            _view.dgvDependants.AutoGenerateColumns = false;

            _view.dgvDependants.DataSource = dependants;           
          
        }

        #endregion

    }
}
