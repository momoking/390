using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Data.FlagModel
{
    public class FlagCRUD
    {
        private soen390Entities _soen390Entities;

        public FlagCRUD()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }

        #region CRUD Flag
        public flag createFlag(long id, long flagtypeid, string flaginfo, DateTime datestamp)
        {
            try
            {
                flag aFlag = new flag
                {
                    ID= id,
                    FlagTypeID = flagtypeid,
                    FlagInfo = flaginfo,
                    DateStamp = datestamp
                };

                _soen390Entities.flag.Add(aFlag);
                _soen390Entities.SaveChanges();

                return aFlag;
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

        public flag updateFlag(long id, long flagtypeid, string flaginfo, DateTime datestamp)
        {

            try
            {
                flag aFlag = _soen390Entities.flag.Find(id);
                {
                    aFlag.ID= id;
                    aFlag.FlagTypeID = flagtypeid;
                    aFlag.FlagInfo = flaginfo;
                    aFlag.DateStamp = datestamp;

                };
                _soen390Entities.SaveChanges();

                return aFlag;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }

        }

        public flag retreiveFlag(long ID)
        {
            try
            {
                flag aFlag;

                aFlag = _soen390Entities.flag.Find(ID);

                return aFlag;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }

        }

        public flag deleteFlag(decimal ID)
        {
            try
            {
                flag aFlag = _soen390Entities.flag.Find(ID);
             
                if (aFlag == null)
                {
                    return null;
                }
                else
                {
                    _soen390Entities.flag.Remove(aFlag);
                    _soen390Entities.SaveChanges();
                }

                return aFlag;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }

        #endregion

    }
}
