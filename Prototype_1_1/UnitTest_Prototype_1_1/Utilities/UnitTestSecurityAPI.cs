using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype1_1.Utilities;

namespace UnitTest_Prototype_1_1.Utilities
{
    [TestClass]
    public class UnitTestSecurityAPI
    {
        [TestMethod]
        public void IsUserAdministrator_ReturnsTrue()
        {
            SecurityAPI _securityAPI = new SecurityAPI();

            bool result =  _securityAPI.IsUserAdministrator();

            Assert.IsTrue(result);
        }
    }
}
