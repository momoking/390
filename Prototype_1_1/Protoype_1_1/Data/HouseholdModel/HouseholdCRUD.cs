using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prototype1_1.Data.EntityModel;
using Prototype1_1.Data;

namespace Prototype1_1.Data.HouseholdModel
{
    public class HouseholdCRUD
    {
        private soen390Entities _soen390Entities;

        public HouseholdCRUD()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }
        
        #region CRUD household

            public household createHousehold(long householdID, string streetNumber, string streetName, string appartmentNumber,
                                        string postalCode, string region, string phoneNumber, DateTime firstVisit, DateTime lastUpdate,
                                        DateTime nextUpdate, decimal householdIncome)
            {
                try
                {
                    household aHousehold = new household
                    {
                        HouseholdID = householdID,
                        StreetNumber = streetNumber,
                        StreetName = streetName,
                        AppartmentNumber = appartmentNumber,
                        PostalCode = postalCode,
                        Region = region,
                        PhoneNumber = phoneNumber,
                        FirstVisit = firstVisit,
                        LastUpdate = lastUpdate,
                        NextUpdate = nextUpdate,
                        HouseholdIncome = householdIncome,
                    };
                    _soen390Entities.household.Add(aHousehold);
                    _soen390Entities.SaveChanges();

                    return aHousehold;
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

            public household retreiveHousehold(long ID)
            {
                try
                {
                    household anHousehold;

                    anHousehold = _soen390Entities.household.Find(ID);

                    return anHousehold;
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.ToString()));
                }

            }

            public household updateHousehold(long householdID, string streetNumber, string streetName, string appartmentNumber,
                                        string postalCode, string region, string phoneNumber, DateTime firstVisit, DateTime lastUpdate,
                                        DateTime nextUpdate, decimal householdIncome)
            {

                try
                {
                    household anHousehold = _soen390Entities.household.Find(householdID);
                    {
                        anHousehold.HouseholdID = householdID;
                        anHousehold.StreetNumber = streetNumber;
                        anHousehold.StreetName = streetName;
                        anHousehold.AppartmentNumber = appartmentNumber;
                        anHousehold.PostalCode = postalCode;
                        anHousehold.Region = region;
                        anHousehold.PhoneNumber = phoneNumber;
                        anHousehold.FirstVisit = firstVisit;
                        anHousehold.LastUpdate = lastUpdate;
                        anHousehold.NextUpdate = nextUpdate;
                        anHousehold.HouseholdIncome = householdIncome;
                    };

                    _soen390Entities.SaveChanges();

                    return anHousehold;
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.ToString()));
                }

            }

            public bool deleteHousehold(long ID)
            {
                try
                {
                    household aHousehold = _soen390Entities.household.Find(ID);
                    if (aHousehold == null)
                    {
                        return false;
                    }
                    else
                    {
                        _soen390Entities.household.Remove(aHousehold);
                        _soen390Entities.SaveChanges();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.ToString()));
                }

            }

        #endregion
        
       

      
    }
}
