using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Prototype1_1.Data.EventModel;
using Prototype1_1.UI.Views;
//using System.Windows.Forms;
//using System.Windows.Forms.Calendar;

namespace UnitTestsEvent_Prototype_1_1
{
    [TestFixture]
    public class TestEvent
    {
        private Event _event;

        //===============================================================================================================

        [Test]
        public void getDaysTest()
        {
            string day1 = "Monday";
            string day2 = "Monday";
            string day3 = "Monday";

            List<string> expected = new List<string>();
                      
            expected.Add(day1);
            expected.Add(day2);
            expected.Add(day3);
          
            List<string> results = _event.getDays();
            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.Event.getDays method test success");
        }

        //===============================================================================================================

        [Test]
        public void getEventDatesTest()
        {
            DateTime startdate1 = new DateTime(2013, 4, 10, 0, 0, 0);
            DateTime enddate1 = new DateTime(2013, 5, 10, 0, 0, 0);
            DateTime startdate2 = new DateTime(2013, 6, 10, 0, 0, 0);
            DateTime enddate2 = new DateTime(2013, 7, 10, 0, 0, 0);

            
            List<EventDate> expected = new List<EventDate>();
            EventDate date1 = new EventDate();
            EventDate date2 = new EventDate();

            date1.setDate(startdate1, enddate1, startdate1, enddate1);
            date2.setDate(startdate2, enddate2, startdate2, enddate2);

            expected.Add(date1);
            expected.Add(date2);

            List<EventDate> results = _event.getEventDates();
            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.Event.getEventDates method test succes");

        }

        //===============================================================================================================

        [Test]
        public void ToStringTest()
        {
            
            string expected = "FoodGiveAway";
            string results = _event.ToString();

            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.Event.ToString method test success");

        }

        //===============================================================================================================

        [Test]
        public void getDistanceTest()
        {
            DateTime date1 = new DateTime(2013, 4, 10, 0, 0, 0);
            DateTime date2 = new DateTime(2013, 6, 10, 0, 0, 0);

            int expected = date1.DayOfYear - date2.DayOfYear;
            int results = _event.GetDistance(date1, date2);

            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.Event.ToString method test success");

        }

        //===============================================================================================================

        [Test]
        public void GetDayXDistanceAway()
        {
            DateTime date = new DateTime(2013, 8, 10, 0, 0, 0);
            int distance = 5;

            DateTime expected = new DateTime();
            expected.AddDays(distance);

            DateTime results = _event.GetDayXDistanceAway(date, distance);

            Assert.AreEqual(expected, results, "Prototype1_1.Data.EventModel.Event.ToString method test success");

        }

        //===============================================================================================================
       
    }
}
