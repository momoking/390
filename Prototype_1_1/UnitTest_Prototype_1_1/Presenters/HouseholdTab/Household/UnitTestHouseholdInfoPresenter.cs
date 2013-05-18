using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using Prototype1_1.UI;
using Prototype1_1.UI.Views;


using Prototype1_1.Data.HouseholdModel;
using Prototype1_1.UI.Views.HouseholdTab.Household;
using Prototype1_1.Data;

namespace UnitTest_Prototype_1_1.Presenters.HouseholdTab.Household
{
    [TestClass]
    public class UnitTestHouseholdInfoPresenter
    {
        [TestMethod]
        public void loadHouseholdInfo_LoadHouseholdCorrectly_ReturnsTrue()
        {
            
           /* HouseholdCRUD amodel = new HouseholdCRUD();
            HouseholdInfoView aview = new HouseholdInfoView();
            HouseholdInfoPresenter hs = new HouseholdInfoPresenter(aview);

            household createdHousehold = amodel.createHousehold( 0, 
                                                                "1",
                                                                "A",
                                                                "5",
                                                                "H3H2M5",
                                                                "Verdun",
                                                                "456-987-8898",
                                                                DateTime.Today,
                                                                DateTime.Today,
                                                                DateTime.Today.AddMonths(6),
                                                                0);
            hs.loadHouseholdInfo(createdHousehold);

            amodel.deleteHousehold(createdHousehold.HouseholdID);

            //hs.*/

        }
    }
}
