using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using DataAccess;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RatingTest()
        {           
            Vehicle vh = new Vehicle();
            for (int i = 0; i < 10; i++)
                vh.AddRating(3);
            Assert.AreEqual(3, vh.Rating);
        }
        [TestMethod]
        public void RateReservationTest()
        {
            Vehicle veh = new Vehicle();
            User cli = new User();
            Reservation res = new Reservation(veh,cli,DateTime.Now,DateTime.Now);
            res.RateReservation(4);
            res.RateReservation(3);
            Assert.AreEqual(true,res.Rated);
            Assert.AreEqual(4, res.Vehicle.Rating);
        }
        [TestMethod]
        public void RatingBelowZero()
        {
            Vehicle veh = new Vehicle();
            veh.AddRating(-5);
            Assert.AreEqual(0, veh.Rating);
        }
        [TestMethod]
        public void CalculatePrice()
        {
            DateTime since = new DateTime(2016, 11, 13, 23, 00, 00);
            DateTime till = new DateTime(2016, 11, 14, 2, 00, 00);
            Reservation rv = new Reservation(new Vehicle() { PricePerHour = 10 }, null, since, till);
            Assert.AreEqual(40, rv.Cost);
        }
        [TestMethod]
        public void HoursLeft()
        {
            DateTime since = new DateTime(2016, 11, 13, 23, 00, 00);
            DateTime till = new DateTime(2016, 11, 14, 2, 00, 00);
            Reservation rv = new Reservation(new Vehicle(), null, since, till);
            Assert.AreEqual(rv.ReservationLeft(DateTime.Now),(int)(till-DateTime.Now).TotalHours + 1);
        }        
    }
}
