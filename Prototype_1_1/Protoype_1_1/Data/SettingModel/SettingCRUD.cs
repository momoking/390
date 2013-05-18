using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1_1.Data.SettingModel
{
    class SettingCRUD
    {
        private soen390Entities _soen390Entities;

        public SettingCRUD()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }


        // COUNTRY OF ORIGIN

        public origin addOrigin(string country)
        {
            try
            {
                origin anOrigin = new origin
                {
                    OriginName = country
                };

                _soen390Entities.origin.Add(anOrigin);
                _soen390Entities.SaveChanges();

                return anOrigin;
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

        public bool updateOrigin(string oldCountry, string newCountry)
        {
            try
            {
                origin anOrigin = _soen390Entities.origin.Find(oldCountry);
                if (anOrigin == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.origin.Remove(anOrigin);
                    origin newOrigin = new origin
                    {
                        OriginName = newCountry
                    };
                    _soen390Entities.origin.Add(newOrigin);
                    _soen390Entities.SaveChanges();
                }
                
                return true;
                
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

        public bool deleteOrigin(string country)
        {
            try
            {
                origin anOrigin = _soen390Entities.origin.Find(country);
                if (anOrigin == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.origin.Remove(anOrigin);
                    _soen390Entities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }



        // CITIZENSHIP 

        public citizenship addCitizenship(string citizenship)
        {
            try
            {
                citizenship aCitizenship = new citizenship
                {
                    CitizenshipName = citizenship
                };

                _soen390Entities.citizenship.Add(aCitizenship);
                _soen390Entities.SaveChanges();

                return aCitizenship;
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

        public bool updateCitizenship(string oldValue, string newValue)
        {
            try
            {
                citizenship aCitizenship = _soen390Entities.citizenship.Find(oldValue);
                if (aCitizenship == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.citizenship.Remove(aCitizenship);
                    citizenship newCiti = new citizenship
                    {
                        CitizenshipName = newValue
                    };
                    _soen390Entities.citizenship.Add(newCiti);
                    _soen390Entities.SaveChanges();
                }

                return true;

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

        public bool deleteCitizenship(string citizenship)
        {
            try
            {
                citizenship aCitizenship = _soen390Entities.citizenship.Find(citizenship);
                if (aCitizenship == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.citizenship.Remove(aCitizenship);
                    _soen390Entities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }



        // MOTHER TONGUE 

        public mothertongue addMothertongue(string mothertongue)
        {
            try
            {
                mothertongue aMothertongue = new mothertongue
                {
                    LanguageName = mothertongue
                };

                _soen390Entities.mothertongue.Add(aMothertongue);
                _soen390Entities.SaveChanges();

                return aMothertongue;
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

        public bool updateMothertongue(string oldValue, string newValue)
        {
            try
            {
                mothertongue aMothertongue = _soen390Entities.mothertongue.Find(oldValue);
                if (aMothertongue == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.mothertongue.Remove(aMothertongue);
                    mothertongue newMothertongue = new mothertongue
                    {
                        LanguageName = newValue
                    };
                    _soen390Entities.mothertongue.Add(newMothertongue);
                    _soen390Entities.SaveChanges();
                }

                return true;

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

        public bool deleteMothertongue(string mothertongue)
        {
            try
            {
                mothertongue aMothertongue = _soen390Entities.mothertongue.Find(mothertongue);
                if (aMothertongue == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.mothertongue.Remove(aMothertongue);
                    _soen390Entities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }



        // MARITAL STATUS

        public maritalstatus addMaritalstatus(string maritalstatus)
        {
            try
            {
                maritalstatus aMaritalstatus = new maritalstatus
                {
                    MaritalStatusName = maritalstatus
                };

                _soen390Entities.maritalstatus.Add(aMaritalstatus);
                _soen390Entities.SaveChanges();

                return aMaritalstatus;
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

        public bool updateMaritalstatus(string oldValue, string newValue)
        {
            try
            {
                maritalstatus aMaritalstatus = _soen390Entities.maritalstatus.Find(oldValue);
                if (aMaritalstatus == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.maritalstatus.Remove(aMaritalstatus);
                    maritalstatus newMaritalstatus = new maritalstatus
                    {
                        MaritalStatusName = newValue
                    };
                    _soen390Entities.maritalstatus.Add(newMaritalstatus);
                    _soen390Entities.SaveChanges();
                }

                return true;

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

        public bool deleteMaritalstatus(string maritalstatus)
        {
            try
            {
                maritalstatus aMaritalstatus = _soen390Entities.maritalstatus.Find(maritalstatus);
                if (aMaritalstatus == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.maritalstatus.Remove(aMaritalstatus);
                    _soen390Entities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }


        // WORK STATUS

        public workstatus addWorkstatus(string workstatus)
        {
            try
            {
                workstatus aWorkstatus = new workstatus
                {
                    WorkStatusName = workstatus
                };

                _soen390Entities.workstatus.Add(aWorkstatus);
                _soen390Entities.SaveChanges();

                return aWorkstatus;
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

        public bool updateWorkstatus(string oldValue, string newValue)
        {
            try
            {
                workstatus aWorkstatus = _soen390Entities.workstatus.Find(oldValue);
                if (aWorkstatus == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.workstatus.Remove(aWorkstatus);
                    workstatus newWorkstatus = new workstatus
                    {
                        WorkStatusName = newValue
                    };
                    _soen390Entities.workstatus.Add(newWorkstatus);
                    _soen390Entities.SaveChanges();
                }

                return true;

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

        public bool deleteWorkstatus(string workstatus)
        {
            try
            {
                workstatus aWorkstatus = _soen390Entities.workstatus.Find(workstatus);
                if (aWorkstatus == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.workstatus.Remove(aWorkstatus);
                    _soen390Entities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }



        // INCOME TYPE

        public incometype addIncometype(string incometype)
        {
            try
            {
                incometype anIncometype = new incometype
                {
                    IncomeTypeName = incometype
                };

                _soen390Entities.incometype.Add(anIncometype);
                _soen390Entities.SaveChanges();

                return anIncometype;
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

        public bool updateIncometype(string oldValue, string newValue)
        {
            try
            {
                incometype anIncometype = _soen390Entities.incometype.Find(oldValue);
                if (anIncometype == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.incometype.Remove(anIncometype);
                    incometype newIncometype = new incometype
                    {
                        IncomeTypeName = newValue
                    };
                    _soen390Entities.incometype.Add(newIncometype);
                    _soen390Entities.SaveChanges();
                }

                return true;

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

        public bool deleteIncometype(string incometype)
        {
            try
            {
                incometype anIncometype = _soen390Entities.incometype.Find(incometype);
                if (anIncometype == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.incometype.Remove(anIncometype);
                    _soen390Entities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }


        // SERVICE TONGUE

        public servicelanguage addServicelang(string servicelang)
        {
            try
            {
                servicelanguage aServicelang = new servicelanguage
                {
                    LanguageName = servicelang
                };

                _soen390Entities.servicelanguage.Add(aServicelang);
                _soen390Entities.SaveChanges();

                return aServicelang;
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

        public bool updateServicelang(string oldValue, string newValue)
        {
            try
            {
                servicelanguage aServicelang = _soen390Entities.servicelanguage.Find(oldValue);
                if (aServicelang == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.servicelanguage.Remove(aServicelang);
                    servicelanguage newServicelang = new servicelanguage
                    {
                        LanguageName = newValue
                    };
                    _soen390Entities.servicelanguage.Add(newServicelang);
                    _soen390Entities.SaveChanges();
                }

                return true;

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

        public bool deleteServicelang(string servicelang)
        {
            try
            {
                servicelanguage aServicelang = _soen390Entities.servicelanguage.Find(servicelang);
                if (aServicelang == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.servicelanguage.Remove(aServicelang);
                    _soen390Entities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }


        // FLAG TYPE

        public flagtype addFlagtype(string flagTitle, string flagPriority)
        {
            try
            {
                flagtype aFlagtype = new flagtype
                {
                    FlagTitle = flagTitle,
                    FlagPriority = flagPriority
                };

                _soen390Entities.flagtype.Add(aFlagtype);
                _soen390Entities.SaveChanges();

                return aFlagtype;
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

        public bool updateFlagtype(string oldTitle, string oldPriority, string newTitle, string newPriority)
        {
            string[] primaries = new string[2];
            primaries[0] = oldTitle;
            primaries[1] = oldPriority;
            
            try
            {
                //flagtype aFlagtype = _soen390Entities.flagtype.Find(oldTitle, oldPriority);                
                //flagtype aFlagtype = _soen390Entities.flagtype.Find(primaries);                
                flagtype aFlagtype = _soen390Entities.flagtype.First(f => f.FlagTitle == oldTitle && f.FlagPriority == oldPriority);
                if (aFlagtype == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.flagtype.Remove(aFlagtype);
                    flagtype newFlagtype = new flagtype
                    {
                        FlagTitle = newTitle,
                        FlagPriority = newPriority
                    };
                    _soen390Entities.flagtype.Add(newFlagtype);
                    _soen390Entities.SaveChanges();
                }

                return true;

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

        public bool deleteFlagtype(string oldTitle, string oldPriority)
        {
            string[] primaries = new string[2];
            primaries[0] = oldTitle;
            primaries[1] = oldPriority;

            try
            {
                flagtype aFlagtype = _soen390Entities.flagtype.First(f => f.FlagTitle == oldTitle && f.FlagPriority == oldPriority);
                if (aFlagtype == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.flagtype.Remove(aFlagtype);
                    _soen390Entities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }


        // REGION (POSTAL)

        public region addRegion(string regionName, string regionCode)
        {
            try
            {
                region aRegion = new region
                {
                    RegionName = regionName,
                    ForwardSortationArea = regionCode
                };

                _soen390Entities.region.Add(aRegion);
                _soen390Entities.SaveChanges();

                return aRegion;
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

        public bool updateRegion(string oldName, string oldCode, string newName, string newCode)
        {
            string[] primaries = new string[2];
            primaries[0] = oldName;
            primaries[1] = oldCode;

            try
            {
                region aRegion = _soen390Entities.region.First(r => r.ForwardSortationArea == oldCode && r.RegionName == oldName);
                if (aRegion == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.region.Remove(aRegion);
                    region newRegion = new region
                    {
                        RegionName = newName,
                        ForwardSortationArea = newCode
                    };
                    _soen390Entities.region.Add(newRegion);
                    _soen390Entities.SaveChanges();
                }

                return true;

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

        public bool deleteRegion(string regionName, string regionCode)
        {
            string[] primaries = new string[2];
            primaries[0] = regionName;
            primaries[1] = regionCode;

            try
            {
                region aRegion = _soen390Entities.region.First(r => r.ForwardSortationArea == regionCode && r.RegionName == regionName);
                if (aRegion == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.region.Remove(aRegion);
                    _soen390Entities.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }
        }
    
    }
}
