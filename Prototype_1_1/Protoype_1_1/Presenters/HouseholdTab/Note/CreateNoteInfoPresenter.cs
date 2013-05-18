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
using Prototype1_1.Presenters.HouseholdTab.HouseholdAndClient;
using System.ComponentModel;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Presenters.HouseholdTab.Note
{
    public class CreateNoteInfoPresenter
    {
        #region Attributes

        private static CreateNoteInfoPresenter _instance;

        private NoteCRUD _model;
        private NoteAPI _api;
        private CreateNoteInfoView _view;

        #endregion

        #region Properties
        public CreateNoteInfoView View
        {
            get { return _view; }
        }
        #endregion

        #region Constructor
        private CreateNoteInfoPresenter()
        {
          
        }

        public static CreateNoteInfoPresenter getInstance()
        {
            if (_instance == null)
            {
                _instance = new CreateNoteInfoPresenter();
            }

            return _instance;
        }

        public void attachView(CreateNoteInfoView aView)
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
                note createdNote = _model.createNote(0,
                                                     _view.dtpDate.Value,
                                                     _view.txtOperator.Text,
                                                     _view.rchNote.Text);

                if (createdNote == null)
                {
                    MessageBox.Show("Unable to save this Note...");
                }
                else
                {
                    createdNote.household.Add(HouseholdAndClientPresenter.getInstance().ActiveHousehold);
                    EntityModel.getInstance().save();


                    List<note> activeNotes = HouseholdAndClientPresenter.getInstance().ActiveHousehold.note.ToList();

                    if (activeNotes != null)
                    {
                        NoteInfoPresenter.getInstance().loadNoteInfo(activeNotes);
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
    }
}
