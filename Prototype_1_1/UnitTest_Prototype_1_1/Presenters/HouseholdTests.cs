using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype1_1.Presenters;
using Prototype1_1.Data;
using Prototype1_1.Data.HouseholdModel;
using Prototype1_1.UI;

namespace UnitTest_Prototype_1_1.Presenters
{
    [TestClass]
    public class HouseholdTests
    {
        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            //  TODO: Add test initialization code
        }

        /// <summary>
        ///Cleanup() is called once during test execution after
        ///test methods in this class have executed unless
        ///this test class' Initialize() method throws an exception.
        ///</summary>
        [TestCleanup()]
        public void Cleanup()
        {

            //  TODO: Add test cleanup code
        }


      /*  [TestMethod]
        public void createHouseholdTest()
        {
           
            DateTime fistVisitDate = new DateTime(2013, 03, 02, 0, 0, 0);
            DateTime lastUpdateDate = new DateTime(2013, 03, 02, 0, 0, 0);
            DateTime nextUpdateDate = new DateTime(2013, 09, 02, 0, 0, 0);
            household aHousehold = HouseholdPresenter.getInstance().createHousehold("id0", "123", "asd", "apt5", "hrh3rt",
                                       "rg", "123465", fistVisitDate, lastUpdateDate, nextUpdateDate);

            if (aHousehold != null)
            {
                Assert.AreEqual<string>(aHousehold.HouseholdID, "id0");
                Assert.AreEqual<string>(aHousehold.StreetNumber, "123");
                Assert.AreEqual<string>(aHousehold.StreetName, "asd");
                Assert.AreEqual<string>(aHousehold.AppartmentNumber, "apt5");
                Assert.AreEqual<string>(aHousehold.PostalCode, "hrh3rt");
                Assert.AreEqual<string>(aHousehold.Region, "rg");
                Assert.AreEqual<string>(aHousehold.PhoneNumber, "132456");
                Assert.Equals(aHousehold.FirstVisit, fistVisitDate);
                Assert.Equals(aHousehold.LastUpdate, lastUpdateDate);
                Assert.Equals(aHousehold.NextUpdate, nextUpdateDate);

                //  aHouseholdCRUD.deleteHousehold(
            }
            else
            {
                Assert.Fail();
            }

        }
        */

        [TestMethod]
        public void validateHouseholdID_ValidLengthAndFormat_ReturnsTrue()
        {
            HouseholdAPI model = new HouseholdAPI();

            bool result = model.validateHouseholdID("10012345");

            Assert.AreEqual(result, true);

        }

        [TestMethod]
        public void validateHouseholdID_InvalidLength_ReturnsFalse()
        {
            HouseholdAPI model = new HouseholdAPI();

            bool result = model.validateHouseholdID("100");

            Assert.AreEqual(result, false);

        }

        [TestMethod]
        public void validateHouseholdID_InvalidFormat_ReturnsFalse()
        {
            HouseholdAPI model = new HouseholdAPI();

            bool result = model.validateHouseholdID("99912345");

            Assert.AreEqual(result, false);

        }

        [TestMethod]
        public void getNewHouseholdId_IsaNumberGreaterThan0_ReturnsHouseholdID()
        {
            bool result = false;

            HouseholdAPI model = new HouseholdAPI();

            string newHouseholdID = model.getNewHouseholdID();

            result = model.validateHouseholdID(newHouseholdID);

            Assert.AreEqual(result, true);

        }

        [TestMethod]
        public void getZipWithFSA_IsValid_ReturnsCartierville()
        {
            HouseholdCRUD model = new HouseholdCRUD();

            string ZipCode = model.getZipWithFSA("H4K");

            Assert.AreEqual(ZipCode, "Cartierville");
        }

        [TestMethod]
        public void getZipWithFSA_IsInvalid_ReturnsNull()
        {
            HouseholdAPI model = new HouseholdAPI();

            string ZipCode = model.getZipWithFSA("XXX");

            Assert.AreEqual(ZipCode, null);
        }


        [TestMethod]
        public void isHouseholdUpToDate_LessThanSixMonths_returnTure()
        {
            HouseholdAPI model = new HouseholdAPI();

            household aHousehold = new household
            {
                LastUpdate = DateTime.Today.AddMonths(1)
            };

            bool result = model.isHouseholdNeedToUpdate(aHousehold);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isHouseholdUpToDate_GreaterOrEqualToSixMonths_returnFalse()
        {
            HouseholdAPI model = new HouseholdAPI();

            household aHousehold = new household
            {
                LastUpdate = DateTime.Today.AddMonths(-6)
            };

            bool result = model.isHouseholdNeedToUpdate(aHousehold);
            
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void populateHousehold_ElementInComponent_returnTrue()
        {
            HouseholdAPI aHouseholdCRUD = new HouseholdAPI();

           /* household aHousehold = new household
            {
                HouseholdID = 10045678,
                StreetNumber= "123",
                StreetName = "St-Charles",
                AppartmentNumber = "6",
                PostalCode = "H4H4M2",
                Region = "Verdun",
                PhoneNumber="456-689-8989",
                FirstVisit = DateTime.Today,
                LastUpdate = DateTime.Today,
                NextUpdate = DateTime.Today.AddMonths(6)
            };

            HouseholdPresenter.getInstance().setHouseholdInfo(aHousehold);*/
        }

        [TestMethod]
        public void createANewClient_ClientInDB_returnTrue()
        {
            HouseholdCRUD aHouseholdCRUD = new HouseholdCRUD();
           
            long ID = aHouseholdCRUD.getNewClientdID();
          
            client createdClient = aHouseholdCRUD.createClient(ID, "Amine", "Najahi", DateTime.Today,
                                                                "NAJA86091307", "M", "African", "Citizen",
                                                                "Arab", "English", "Married", "Student",100, "Joe",
                                                                "Food", "We2343d");
            
           

            if (aHouseholdCRUD.deleteClient(createdClient.ID) == false)
            {
                Assert.Fail();
            }
             
        }

        [TestMethod]
        public void createANewHousehold_HouseHoldInDB_returnTrue()
        {
            //Get a new Household ID.
            HouseholdCRUD aHouseholdCRUD = new HouseholdCRUD();

            household createdHousehold = aHouseholdCRUD.createHousehold(0,
                                            "streetNumber",
                                            "streetName",
                                            "Apt5",
                                            "H4L3M2",
                                            "St-Laurent",
                                            "450-999-8989",
                                            DateTime.Today,
                                            DateTime.Today,
                                            DateTime.Today.AddMonths(6),
                                            12000);

            if (aHouseholdCRUD.deleteHousehold(createdHousehold.HouseholdID) == false)
            {
                Assert.Fail();
            }
    
        }

        [TestMethod]
        public void isZipCodeValid_ZipCodeValid_returnTrue()
        {
            HouseholdCRUD aHouseholdCRUD = new HouseholdCRUD();
            
            bool result = aHouseholdCRUD.isZipCodeValid("J7E5V3");
            
            Assert.AreEqual(result, true);
        }


        [TestMethod]
        public void isMedicareValid_ValidMedicare_returnTrue()
        {
            HouseholdCRUD aHouseholdCRUD = new HouseholdCRUD();

            bool result = aHouseholdCRUD.isMedicareValid("NAJA86091307");

            Assert.AreEqual(result, true);
       
        }

        [TestMethod]
        public void getDOBFromMcare_ValidDoBIn1900_returnDate()
        {
            bool result = false;

            HouseholdCRUD aHouseholdCRUD = new HouseholdCRUD();

            DateTime dOB = new DateTime(1986, 09, 13);

            DateTime doBfromMcare = aHouseholdCRUD.getDOBFromMcare("NAJA86091307");

            if (doBfromMcare.Equals(dOB))
            {
                result = true;
            }

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void getDOBFromMcare_ValidDoBIn2000_returnDate()
        {
            bool result = false;

            HouseholdCRUD aHouseholdCRUD = new HouseholdCRUD();

            DateTime dOB = new DateTime(2002, 09, 13);

            DateTime doBfromMcare = aHouseholdCRUD.getDOBFromMcare("NAJA02091307");

            if (doBfromMcare.Equals(dOB))
            {
                result = true;
            }

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void getSexFromMcare_isMale_returnString()
        {
            bool result = false;

            HouseholdCRUD aHouseholdCRUD = new HouseholdCRUD();

            string sex = aHouseholdCRUD.getSexFromMcare("NAJA86091307");

            Assert.AreEqual(sex, "M");
        }

        [TestMethod]
        public void getSexFromMcare_isFemale_returnString()
        {
            bool result = false;

            HouseholdCRUD aHouseholdCRUD = new HouseholdCRUD();

            string sex = aHouseholdCRUD.getSexFromMcare("NAJA86591307");

            Assert.AreEqual(sex, "F");
        }

    
    }
}
