using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Prototype1_1.Data.EntityModel;


namespace Prototype1_1.Data.HouseholdModel
{
    public class HouseholdAPI
    {
        private soen390Entities _soen390Entities;

        public HouseholdAPI()
        {
            _soen390Entities = EntityModel.EntityModel.getInstance()._soen390Entities;
        }

        public bool linkHouseholdAndClient(client aClient, household aHousehold)
        {
            try
            {
                _soen390Entities.client.Find(aClient.ID).household.Add(aHousehold);
                _soen390Entities.household.Find(aHousehold.HouseholdID).client.Add(aClient);

                _soen390Entities.SaveChanges();

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

        #region API


        public bool validateHouseholdID(string houseHoldID)
        {
            if (houseHoldID.Length != 8)
            {
                return false;
            }
            else if (houseHoldID.StartsWith("100") == false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// This method create a new household id base on the number of household in the database
        /// it return a string that starts with "100" followed by the number of household id's + 1
        /// since the household id must be 8 caracter long, it will pad the id with 0
        /// Ex if household number is 5, 10000005
        /// </summary>
        /// <returns>a household id string </returns>
        public string getNewHouseholdID()
        {
            int numberOfHousehold = _soen390Entities.household.Count();

            string houseHoldID = (numberOfHousehold + 1).ToString();

            houseHoldID = houseHoldID.PadLeft(5, '0');

            string houseHoldIDString = "100" + houseHoldID;

            return houseHoldIDString;

        }

        /// <summary>
        /// this method receives a zip code and find the forward sortation area that is linked to it.
        /// </summary>
        /// <param name="Zip"></param>
        /// <returns>returns the forward sortation area.</returns>
        public string getZipWithFSA(String Zip)
        {

            var FSA = _soen390Entities.region.Where(b => b.ForwardSortationArea.Equals(Zip) == true).FirstOrDefault();

            if (FSA == null)
            {
                return null;
            }
            else
            {
                return FSA.RegionName;
            }
        }

        /// <summary>
        /// this method determines if the household information must be updated, it should be updated
        /// if the next update date is greater than 6 months.
        /// </summary>
        /// <param name="aHousehold"></param>
        /// <returns>true is the household does not need to update , false if it does</returns>
        public bool isHouseholdNeedToUpdate(household aHousehold)
        {
            DateTime today = DateTime.Today;

            //More than todays date.
            if (today.CompareTo(aHousehold.NextUpdate) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isZipCodeValid(string zipCode)
        {
            string pattern = @"\w\d\w\d\w\d";
            Regex regex = new Regex(pattern);
            bool result;

            result = regex.IsMatch(zipCode);

            return result;
        }

        public bool isPhoneNumberValid(string phoneNb)
        {
            string pattern = @"\d\d\d-\d\d\d-\d\d\d\d";
            Regex regex = new Regex(pattern);
            bool result;

            result = regex.IsMatch(phoneNb);

            return result;
        }

        #endregion

    }
}
