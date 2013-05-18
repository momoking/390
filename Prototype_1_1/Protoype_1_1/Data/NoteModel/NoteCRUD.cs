using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Data.NoteModel
{
    public class NoteCRUD
    {
        private soen390Entities _soen390Entities;

        public NoteCRUD()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }

        #region CRUD Dependant
        public note createNote(long id,DateTime datestamp, string modifier, string noteinfo)
        {
            try
            {
                note anote = new note
                {
                  NoteID = id,
                  DateStamp = datestamp,
                  ModifiedBy = modifier,
                  NoteInfo = noteinfo

                };

                _soen390Entities.note.Add(anote);
                _soen390Entities.SaveChanges();

                return anote;
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw (new Exception(dbEx.ToString()));
            }

        }

        public note updateNote(long id, DateTime datestamp, string modifier, string noteinfo)
        {

            try
            {
                note anote =  _soen390Entities.note.Find(id);
                {
                    anote.NoteID = id;
                    anote.DateStamp = datestamp;
                    anote.ModifiedBy = modifier;
                    anote.NoteInfo = noteinfo;

                };
                _soen390Entities.SaveChanges();

                return anote;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }

        }

        public note retreivenote(long ID)
        {
            try
            {
                note anote;

                anote = _soen390Entities.note.Find(ID);

                return anote;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }

        }

        public note deletenote(long ID)
        {
            try
            {
                note anote = _soen390Entities.note.Find(ID);
               
                if (anote == null)
                {
                    return null;
                }
                else
                {
                    _soen390Entities.note.Remove(anote);
                    _soen390Entities.SaveChanges();
                }

                return anote;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }

        #endregion
    }
}
