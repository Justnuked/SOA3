using Microsoft.VisualStudio.TestTools.UnitTesting;
using CinemaCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCalc.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void CalculatePriceTestWithOnePremiumTicket()
        {
            //arrange
            Movie movie = new Movie("Movie test");
            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2019, 1, 1), 5);
            Order o = new Order(1, false);
            var expected = 8;

            MovieTicket ticket1 = new MovieTicket(movieScreening, true, 1, 1);


            o.AddSeatReservation(ticket1);

            //act
            var actual = o.CalculatePrice();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTestWithOnePremiumTicketForStudent()
        {
            //arrange
            Movie movie = new Movie("Movie test");
            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2019, 1, 1), 5);
            Order o = new Order(1, true);
            var expected = 6.30;

            MovieTicket ticket1 = new MovieTicket(movieScreening, true, 1, 1);


            o.AddSeatReservation(ticket1);

            //act
            var actual = o.CalculatePrice();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTestFreeTicketOnFriday()
        {
            //arrange
            Movie movie = new Movie("Movie test");
            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2019, 1, 6), 5);
            Order o = new Order(1, false);
            var expected = 10;

            MovieTicket ticket1 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket ticket2 = new MovieTicket(movieScreening, false, 1, 1);


            o.AddSeatReservation(ticket1);
            o.AddSeatReservation(ticket2);

            //act
            var actual = o.CalculatePrice();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTestWithZeroTickets()
        {
            //arrange
            Movie movie = new Movie("Movie test");
            MovieScreening movieScreening = new MovieScreening(movie, DateTime.Now, 5);
            Order o = new Order(1, true);
            var expected = 0;

            //act
            var actual = o.CalculatePrice();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTestWith6StudentTickets()
        {
            Movie movie = new Movie("Movie test");

            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2019, 1, 1), 5);

            Order o = new Order(1, true);

            MovieTicket ticket1 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket ticket2 = new MovieTicket(movieScreening, false, 2, 1);
            MovieTicket ticket3 = new MovieTicket(movieScreening, false, 3, 1);
            MovieTicket ticket4 = new MovieTicket(movieScreening, false, 4, 1);
            MovieTicket ticket5 = new MovieTicket(movieScreening, false, 5, 1);
            MovieTicket ticket6 = new MovieTicket(movieScreening, false, 6, 1);

            o.AddSeatReservation(ticket1);
            o.AddSeatReservation(ticket2);
            o.AddSeatReservation(ticket3);
            o.AddSeatReservation(ticket4);
            o.AddSeatReservation(ticket5);
            o.AddSeatReservation(ticket6);

            var expected = 13.5;

            var actual = o.CalculatePrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTestWithGroupDiscount()
        {
            Movie movie = new Movie("Movie test");

            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2019, 1, 6), 5);

            Order o = new Order(1, false);

            MovieTicket ticket1 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket ticket2 = new MovieTicket(movieScreening, false, 2, 1);
            MovieTicket ticket3 = new MovieTicket(movieScreening, false, 3, 1);
            MovieTicket ticket4 = new MovieTicket(movieScreening, false, 4, 1);
            MovieTicket ticket5 = new MovieTicket(movieScreening, false, 5, 1);
            MovieTicket ticket6 = new MovieTicket(movieScreening, false, 6, 1);

            o.AddSeatReservation(ticket1);
            o.AddSeatReservation(ticket2);
            o.AddSeatReservation(ticket3);
            o.AddSeatReservation(ticket4);
            o.AddSeatReservation(ticket5);
            o.AddSeatReservation(ticket6);

            var expected = 27;

            var actual = o.CalculatePrice();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTestWithPremiumChair()
        {
            Movie movie = new Movie("Movie test");

            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2019, 1, 1), 5);

            Order o = new Order(1, true);

            MovieTicket ticket1 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket ticket2 = new MovieTicket(movieScreening, true, 2, 1);
            MovieTicket ticket3 = new MovieTicket(movieScreening, false, 3, 1);
            MovieTicket ticket4 = new MovieTicket(movieScreening, true, 4, 1);
            MovieTicket ticket5 = new MovieTicket(movieScreening, false, 5, 1);

            o.AddSeatReservation(ticket1);
            o.AddSeatReservation(ticket2);
            o.AddSeatReservation(ticket3);
            o.AddSeatReservation(ticket4);
            o.AddSeatReservation(ticket5);


            var expected = 13.50;

            var actual = o.CalculatePrice();

            Assert.AreEqual(expected, actual);
        }
    }
}