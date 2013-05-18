using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Prototype1_1.Data.EventModel;
using Prototype1_1.UI.Views;

namespace UnitTestsEvent_Prototype_1_1
{
    [TestFixture]
    public class TestEventDate
    {
        private EventDate _eventDate;

        
        //===============================================================================================================
        [Test]
        public void getDayTest()
        {

            DateTime startDate = new DateTime(2013, 4, 10, 0, 0, 0);
           
            string expected = startDate.DayOfWeek.ToString();
            string results = _eventDate.getDay();
            
            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.EventDate.getDay method test success");
        }

        //===============================================================================================================

        [Test]
        public void getStartDateTimeTest()
        {
            DateTime expected = new DateTime(2013, 4, 10, 0, 0, 0);
            DateTime results = _eventDate.getStartDateTime();

            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.EventDate.getStartDateTime method test success");
        }

        //===============================================================================================================

        [Test]
        public void getEndDateTimeTest()
        {
            DateTime expected = new DateTime(2013, 5, 10, 0, 0, 0);
            DateTime results = _eventDate.getEndDateTime();

            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.EventDate.getEndDateTime method test succesы");

        }

        //===============================================================================================================

        [Test]
        public void GetRepeatingEventsTest_WeeklyTrue()
        {
            List<DateTime> expected = new List<DateTime>();
            DateTime time_start = new DateTime(2013, 4, 10, 10, 10, 0);
            DateTime time_end = new DateTime(2013, 6, 10, 10, 10, 0);
            const string interval = "Weekly";

            expected.Add(time_start);

            var tempDate = time_start;
            while (tempDate <= time_end) //Less than or Equals means the end date will be added as well
            {
                tempDate = tempDate.AddDays(7);
                expected.Add(tempDate);
            }
                                              

            List<DateTime> results = _eventDate.GetRepeatingEvents(interval);
            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.EventDate.GetRepeatingEventsWeekly method test success");
        }

        //===============================================================================================================

        [Test]
        public void GetRepeatingEventsTest_BiWeeklyTrue()
        {
            List<DateTime> expected = new List<DateTime>();
            DateTime time_start = new DateTime(2013, 4, 10, 10, 10, 0);
            DateTime time_end = new DateTime(2013, 6, 10, 10, 10, 0);
            const string interval = "Bi-Weekly";

            expected.Add(time_start);

            var tempDate = time_start;
            while (tempDate <= time_end) //Less than or Equals means the end date will be added as well
            {
                tempDate = tempDate.AddDays(7);
                expected.Add(tempDate);
            }


            List<DateTime> results = _eventDate.GetRepeatingEvents(interval);
            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.EventDate.GetRepeatingEventsBiWeekly method test success");
        }

        //===============================================================================================================

        [Test]
        public void GetRepeatingEventsTest_MonthlyTrue()
        {
            List<DateTime> expected = new List<DateTime>();
            DateTime time_start = new DateTime(2013, 4, 10, 10, 10, 0);
            DateTime time_end = new DateTime(2013, 6, 10, 10, 10, 0);
            const string interval = "Monthly";

            expected.Add(time_start);

            var tempDate = time_start;
            while (tempDate <= time_end) //Less than or Equals means the end date will be added as well
            {
                tempDate = tempDate.AddMonths(1);
                expected.Add(tempDate);
            }


            List<DateTime> results = _eventDate.GetRepeatingEvents(interval);
            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.EventDate.GetRepeatingEventsMonthly method test success");
        }

        //===============================================================================================================

        [Test]
        public void GetRepeatingEventsTest_YearlyTrue()
        {
            List<DateTime> expected = new List<DateTime>();
            DateTime time_start = new DateTime(2013, 4, 10, 10, 10, 0);
            DateTime time_end = new DateTime(2015, 4, 10, 10, 10, 0);
            const string interval = "Monthly";

            expected.Add(time_start);

            var tempDate = time_start;
            while (tempDate <= time_end) //Less than or Equals means the end date will be added as well
            {
                tempDate = tempDate.AddYears(1);
                expected.Add(tempDate);
            }


            List<DateTime> results = _eventDate.GetRepeatingEvents(interval);
            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.EventDate.GetRepeatingEventsYearly method test success");
        }

    }
}
