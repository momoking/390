using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prototype1_1.Data.EntityModel;

namespace Prototype1_1.Data.ClientModel
{
    class ClientCRUD
    {
        private soen390Entities _soen390Entities;

        public ClientCRUD()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }

        #region CRUD client
        public client createClient(long id, string firstName, string lastName, DateTime dob,
                                   string mediacare, string gender, string origin,
                                   string citizenship, string motherTongue, string serviceLanguage,
                                   string maritalStatus, string workStatus, decimal annualIncome, string referral, 
                                   string reasonForServiceUsage, string welfareNumber)
        {
            try
            {               
                client aClient = new client
                {
                    ID = id,
                    FirstName = firstName,
                    LastName = lastName,
                    DoB = dob,
                    Medicare = mediacare,
                    Gender = gender,
                    Origin = origin,
                    Citizenship = citizenship,
                    MotherTongue = motherTongue,
                    ServiceLanguage = serviceLanguage,
                    MaritalStatus = maritalStatus,
                    WorkStatus = workStatus,
                    AnnualIncome = annualIncome,
                    Referral = referral,
                    ReasonForServiceUsage = reasonForServiceUsage,
                    WelfareNumber = welfareNumber               

                };

               /* if (linkedHousehold != null)
                {
                    aClient.household.Add(linkedHousehold);
                }*/

                _soen390Entities.client.Add(aClient);
                _soen390Entities.SaveChanges();

                return aClient;
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

        public client updateClient(long id, string firstName, string lastName, DateTime dob,
                    string mediacare, string gender, string origin,
                    string citizenship, string motherTongue, string serviceLanguage,
                    string maritalStatus, string workStatus, decimal annualIncome, string referral, string reasonForServiceUsage, string welfareNumber)
        {

            try
            {
                client aClient = _soen390Entities.client.Find(id);
                {
                    aClient.ID = id;
                    aClient.FirstName = firstName;
                    aClient.LastName = lastName;
                    aClient.DoB = dob;
                    aClient.Medicare = mediacare;
                    aClient.Gender = gender;
                    aClient.Origin = origin;
                    aClient.Citizenship = citizenship;
                    aClient.MotherTongue = motherTongue;
                    aClient.ServiceLanguage = serviceLanguage;
                    aClient.MaritalStatus = maritalStatus;
                    aClient.WorkStatus = workStatus;
                    aClient.AnnualIncome = annualIncome;
                    aClient.Referral = referral;
                    aClient.ReasonForServiceUsage = reasonForServiceUsage;
                    aClient.WelfareNumber = welfareNumber;

                };
                _soen390Entities.SaveChanges();

                return aClient;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }

        }

        public client retreiveClient(long ID)
        {
            try
            {
                client aclient;

                aclient = _soen390Entities.client.Find(ID);

                return aclient;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.ToString()));
            }

        }

        public bool deleteClient(decimal ID)
        {
            try
            {
                client aclient = _soen390Entities.client.Find(ID);
                if (aclient == null)
                {
                    return false;
                }
                else
                {
                    _soen390Entities.client.Remove(aclient);
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
