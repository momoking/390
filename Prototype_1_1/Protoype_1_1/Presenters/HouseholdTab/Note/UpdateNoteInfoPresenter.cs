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
using Prototype1_1.Presenters.HouseholdTab.Note;
using Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient;
using Prototype1_1.Data.EntityModel;
using System.ComponentModel;

namespace Prototype1_1.Presenters.HouseholdTab.Note
{
    public class UpdateNoteInfoPresenter
    {
        #region Attributes

        private static UpdateNoteInfoPresenter _instance;

        private NoteCRUD _model;
        private NoteAPI _api;
        private UpdateNoteInfoView _view;

       // private note _selectedNote;

        #endregion

        #region Properties
        public UpdateNoteInfoView View
        {
            get { return _view; }
        }
        #endregion

        #region Constructor
        private UpdateNoteInfoPresenter()
        {
          
        }

        public static UpdateNoteInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new UpdateNoteInfoPresenter();
            }

            return _instance;
        }

        public void attachView(UpdateNoteInfoView aView)
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
            _view.btnSave.Click += new EventHandler(handleSaveNoteInfo);
            _view.btnCancel.Click += new EventHandler(handleCancelNoteInfo);


            _view.txtOperator.Validating += new CancelEventHandler(handleTxtOperator);
            _view.rchNote.Validating += new CancelEventHandler(handleRchNote);        
        }

        private void initializeView()
        {            

        }
        #endregion

        #region Handlers
        private void handleOnLoadEvent(object sender, EventArgs e)
        {
            //_selectedNote = NoteInfoPresenter.getInstance().View.dgvNotes.SelectedRows[0].DataBoundItem as note;

            if (NoteInfoPresenter.getInstance().SelectedNote != null )
            {
                loadNoteInfo(NoteInfoPresenter.getInstance().SelectedNote);
            }

        }

        private void handleSaveNoteInfo(object sender, EventArgs e)
        {
            bool saveConfirmation;
            //no need for a new form since we only want a confirmation.
            if (isAllFieldValid())
            {
                if (MessageBox.Show("This households contains incomplete fields, save anyway?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    saveConfirmation = true;
                }
                else
                {
                    saveConfirmation = false;
                }

            }
            else
            {
                saveConfirmation = true;
            }

            if (saveConfirmation)
            {
                note updatedNote = _model.updateNote(NoteInfoPresenter.getInstance().SelectedNote.NoteID,
                                                     _view.dtpDate.Value,
                                                     _view.txtOperator.Text,
                                                     _view.rchNote.Text);



                if (updatedNote == null)
                {
                    MessageBox.Show("Unable to save this Note...");
                }
                else
                {
                    //get the active note list
                    List<note> activenotes = HouseholdAndClientPresenter.getInstance().ActiveHousehold.note.ToList();

                    if (activenotes != null)
                    {
                        NoteInfoPresenter.getInstance().loadNoteInfo(activenotes);
                    }
                }

                _view.ParentForm.Close();
            }
               
        }

        private void handleCancelNoteInfo(object sender, EventArgs e)
        {
            _view.ParentForm.Close();
        }
        #endregion
       
        #region Input Validation

        private void handleTxtOperator(object sender, CancelEventArgs e)
        {
            if (_view.txtOperator.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.txtOperator, "Operator name should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.txtOperator, "");
            }
        }
        private void handleRchNote(object sender, CancelEventArgs e)
        {
            if (_view.rchNote.Text.CompareTo("") == 0)
            {
                _view.erp1.SetError(_view.rchNote, "Note should not be empty");
            }
            else
            {
                _view.erp1.SetError(_view.rchNote, "");
            }
        }


        private void validateField()
        {
            handleTxtOperator(this, null);
            handleRchNote(this, null);
        }

        private bool isAllFieldValid()
        {
            validateField();

            if (_view.erp1.GetError(_view.txtOperator) != "" ||
                 _view.erp1.GetError(_view.rchNote) != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region Public API

        public void loadNoteInfo(note anote)
        {
            _view.txtOperator.Text = anote.ModifiedBy;
            _view.dtpDate.Value = anote.DateStamp.Value;
            _view.rchNote.Text = anote.NoteInfo;
         
        }


        #endregion
    }
}
