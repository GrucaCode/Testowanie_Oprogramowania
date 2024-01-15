using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemaApp
{
    [TestClass]
    class CinemaHallTests
    {
        [TestMethod]
        public void ConstructorCinemaHallTest()
        {
            CinemaHall hall = new CinemaHall("Średnia sala");
            Assert.AreEqual("Średnia sala", hall.hallType);
        }

        [TestMethod]
        public void fillSmallHallTest()
        {
            CinemaHall hall = new CinemaHall("Mała sala");
            List<List<int>> expectedSeats = new List<List<int>>
            {
                new List<int> { 1, 1 },
                new List<int> { 1, 2 },
                new List<int> { 2, 1 },
                new List<int> { 2, 2 }
            };
            hall.fillSmallHall();

            Assert.AreEqual(expectedSeats.Count, hall.freeSeats.Count);
            for (int i = 0; i < expectedSeats.Count; i++)
            {
                CollectionAssert.AreEqual(expectedSeats[i], hall.freeSeats[i]);
            }
        }

        [TestMethod]
        public void fillLargeHallTest()
        {
            CinemaHall hall = new CinemaHall("Duża sala");
            List<List<int>> expectedSeats = new List<List<int>>
            {
                new List<int> { 1, 1 },
                new List<int> { 1, 2 },
                new List<int> { 1, 3 },
                new List<int> { 2, 1 },
                new List<int> { 2, 2 },
                new List<int> { 2, 3 },
                new List<int> { 3, 1 },
                new List<int> { 3, 2 },
                new List<int> { 3, 3 }
            };
            hall.fillLargeHall();

            Assert.AreEqual(expectedSeats.Count, hall.freeSeats.Count);
            for (int i = 0; i < expectedSeats.Count; i++)
            {
                CollectionAssert.AreEqual(expectedSeats[i], hall.freeSeats[i]);
            }
        }

        [TestMethod]
        public void showfreeSeatsTest()
        {
            CinemaHall hall = new CinemaHall("Mała sala");
            hall.fillSmallHall();

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                hall.showfreeSeats();

                string expectedOutput = "Rząd: 1, Miejsce: 1 \r\nRząd: 1, Miejsce: 2 \r\nRząd: 2, Miejsce: 1 \r\nRząd: 2, Miejsce: 2 \r\n";
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void showReservedSeatsTest()
        {
            CinemaHall hall = new CinemaHall("Mała sala");
            hall.fillSmallHall();
            hall.reserveSeats(0);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                hall.showReservedSeats();

                string expectedOutput = "Rząd: 1, Miejsce: 1\r\n";
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }


    }
}
