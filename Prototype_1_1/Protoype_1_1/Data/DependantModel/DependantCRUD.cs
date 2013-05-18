using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Data.DependantModel
{
    public class DependantCRUD
    {
        private soen390Entities _soen390Entities;

        public DependantCRUD()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }

        #region CRUD Dependant
        public dependant createDependant(long id, string firstName, string lastName,
                                   string mediacare, string gender, string workStatus, string welfareNumber)
        {
            try
            {
                dependant aDependant = new dependant
                {
                    DependantID = id,
                    FirstName = firstName,
                    LastName = lastName,                    
                    Medicare = mediacare,
                    Gender = gender,                    
                    WorkStatus = workStatus,                
                    WelfareNumber = welfareNumber               

                };

                _soen390Entities.dependant.Add(aDependant);
                _soen390Entities.SaveChanges();

                return aDependant;
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

        public dependant updateDependant(   long id, string firstName, string lastName,
                                            string mediacare, string gender, string workStatus, string welfareNumber)
        {

            try
            {
                dependant aDependant = _soen390Entities.dependant.Find(id);
                {
                    aDependant.DependantID = id;
                    aDependant.FirstName = firstName;
                    aDependant.LastName = lastName;
                    aDependant.Medicare = mediacare;
                    aDependant.Gender = gender;                    
                    aDependant.WorkStatus = workStatus;                   
                    aDependant.WelfareNumber = welfareNumber;

                };
                _soen390Entities.SaveChanges();

                return aDependant;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }

        }

        public dependant retreiveDependant(long ID)
        {
            try
            {
                dependant aDependant;

                aDependant = _soen390Entities.dependant.Find(ID);

                return aDependant;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }

        }

        public dependant deleteDependant(decimal ID)
        {
            try
            {
                dependant aDependant = _soen390Entities.dependant.Find(ID);
             
                if (aDependant == null)
                {
                    return null;
                }
                else
                {
                    _soen390Entities.dependant.Remove(aDependant);
                    _soen390Entities.SaveChanges();
                }

                return aDependant;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }

        #endregion

    }
}
