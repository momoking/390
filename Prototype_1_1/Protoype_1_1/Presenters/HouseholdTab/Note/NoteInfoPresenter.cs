using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype1_1.UI;
using Prototype1_1.Data;
using Prototype1_1.Presenters;
using Prototype1_1.Data.NoteModel;
using Prototype1_1.UI.Views.HouseholdTab.Note;
using Prototype1_1.UI.Forms.HouseholdTab.Note;

using Prototype1_1.Data.EntityModel;
using Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient;
using Prototype1_1.Utilities;

namespace Prototype1_1.Presenters.HouseholdTab.Note
{
    public class NoteInfoPresenter
    {
        #region Attributes
        
        private static NoteInfoPresenter _instance;
     
        private NoteCRUD _model;
        private NoteAPI _api;
        private NoteInfoView _view;

        private note _selectedNote;
        private List<note> _activeNotes;

        CreateNoteInfoForm _createNoteInfoForm;
        UpdateNoteInfoForm _updateNoteInfoForm;
        #endregion

        #region Properties
        public NoteInfoView View
        {
            get { return _view; }
        }

        public List<note> ActiveNotes
        {
            get { return _activeNotes; }
        }

        public note SelectedNote
        {
            get { return _selectedNote; }
        }
        #endregion

        #region Constructor

        private NoteInfoPresenter()
        {
          
        }

        public static NoteInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new NoteInfoPresenter();
            }

            return _instance;
        }

        public void attachView(NoteInfoView aView)
        {
            _api = new NoteAPI();
            _model = new NoteCRUD();
            _view = aView;

            attachEventHandlers();
            initializeView();   
        }

        #endregion

        #region Methods
        private void attachEventHandlers()
        {
            _view.Load += new EventHandler(handleOnLoadEvent);
            _view.dgvNotes.CellEnter += new DataGridViewCellEventHandler(handleSelectedNoteEvent);
            _view.picAdd.Click += new EventHandler(handleNewNoteInfo);
            _view.picEdit.Click += new EventHandler(handleEditNoteInfo);
            _view.picDelete.Click += new EventHandler(handleDeleteNoteInfo);
            _view.dgvNotes.DoubleClick += new EventHandler(handleEditNoteInfo);
        }
        
        private void initializeView()
        {
            
        }
        #endregion

        #region Handlers

        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            if (_activeNotes != null)
            {
                loadNoteInfo(_activeNotes);
            }

            _view.picAdd.Image = ImageAPI.makeIconOpaque(_view.picAdd.Image);
            _view.picEdit.Image = ImageAPI.makeIconOpaque(_view.picEdit.Image);
            _view.picDelete.Image = ImageAPI.makeIconOpaque(_view.picDelete.Image);
        }

        private void handleSelectedNoteEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (_view.dgvNotes.SelectedRows.Count > 0)
            {
                _selectedNote = _view.dgvNotes.SelectedRows[0].DataBoundItem as note;
            }
        }


        private void handleNewNoteInfo(object sender, EventArgs e)
        {
            _createNoteInfoForm = new CreateNoteInfoForm();
            CreateNoteInfoPresenter.getInstance().attachView(_createNoteInfoForm.createNoteInfoView1);
        
            _createNoteInfoForm.ShowDialog();
        }

        private void handleEditNoteInfo(object sender, EventArgs e)
        {

            _updateNoteInfoForm = new UpdateNoteInfoForm();
            UpdateNoteInfoPresenter.getInstance().attachView(_updateNoteInfoForm.updateNoteInfoView1);
           
            _updateNoteInfoForm.ShowDialog();            

        }
        private void handleDeleteNoteInfo(object sender, EventArgs e)
        {
            //no need for a new form since we only want a confirmation.
            if (MessageBox.Show("Are you sure you want to delete this note?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                //unlink the dependant from the active client
                HouseholdAndClientPresenter.getInstance().ActiveHousehold.note.Remove(_selectedNote);
                EntityModel.getInstance().save();

                //remove the dependant from the db;
                note aNote = _model.deletenote(_selectedNote.NoteID);

                if (aNote == null)
                {
                    MessageBox.Show("Unable to delete this note...");
                }
                else
                {

                    //get the updatd active dependant list
                    List<note> activeNotes = HouseholdAndClientPresenter.getInstance().ActiveHousehold.note.ToList();

                    if (activeNotes != null)
                    {
                        loadNoteInfo(activeNotes);
                    }
                }


            }
        }
        #endregion

        #region Public API

        public void loadNoteInfo(List<note> notes)
        {
            _activeNotes = notes;
           
            _view.dgvNotes.AutoGenerateColumns = false;

            _view.dgvNotes.DataSource = notes;
           
          
        }

        #endregion
    }
}
