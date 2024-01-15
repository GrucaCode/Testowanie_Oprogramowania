using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemaAppTests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void ConstructorClientTest()
        {
            Client client = new Client("imie", "nazwisko");
            Assert.IsNotNull(client, "Test konstruktora Client");
        }

        [TestMethod]
        public void pickHallTestFor1()
        {
            Client newClient = new Client("imie", "nazwisko");
            string num = "1";
            string hall;
            CinemaHall small = new CinemaHall("mala");
            CinemaHall large = new CinemaHall("duza");

            hall = newClient.pickHall(num, small, large);

            Assert.AreEqual(hall, small.hallType);
        }

        [TestMethod]
        public void pickHallTestFor2()
        {
            Client newClient = new Client("imie", "nazwisko");
            string num = "2";
            string hall;
            CinemaHall small = new CinemaHall("mala");
            CinemaHall large = new CinemaHall("duza");

            hall = newClient.pickHall(num, small, large);

            Assert.AreEqual(hall, large.hallType);

        }

        [TestMethod]
        public void pickHallTestExp()
        {
            Client newClient = new Client("imie", "nazwisko");
            string num = "7";
            string hall;
            CinemaHall small = new CinemaHall("mala");
            CinemaHall large = new CinemaHall("duza");

            hall = newClient.pickHall(num, small, large);

            Assert.AreEqual(hall, "Wybrano zly numer");

        }

        [TestMethod]
        public void pickHallObjTestfor1()
        {
            Client newClient = new Client("imie", "nazwisko");
            string num = "1";
            CinemaHall small = new CinemaHall("Mala");
            CinemaHall large = new CinemaHall("Duza");

            CinemaHall hall = newClient.pickHallObj(num, small, large);

            Assert.AreEqual(hall, small);
        }

        [TestMethod]
        public void pickHallObjTestfor2()
        {
            Client newClient = new Client("imie", "nazwisko");
            string num = "2";
            CinemaHall small = new CinemaHall("Mala");
            CinemaHall large = new CinemaHall("Duza");

            CinemaHall hall = newClient.pickHallObj(num, small, large);

            Assert.AreEqual(hall, large);
        }

        [TestMethod]
        public void pickHallObjTestExp()
        {
            Client newClient = new Client("imie", "nazwisko");
            string num = "5";
            CinemaHall small = new CinemaHall("Mala");
            CinemaHall large = new CinemaHall("Duza");

            CinemaHall hall = newClient.pickHallObj(num, small, large);

            Assert.AreEqual(hall, null);
        }

        [TestMethod]
        [DataRow("1", "1", 0)]
        [DataRow("1", "2", 1)]
        [DataRow("2", "1", 2)]
        [DataRow("2", "2", 3)]
        [DataRow("3", "3", 100)]
        public void pickSeatTest(string rowNumber, string seatNumber, int expectedResult)
        {
            Client client = new Client("Jan", "Kowalski", "30");
            List<List<int>> checkList = new List<List<int>>
            {
                new List<int> { 1, 1 },
                new List<int> { 1, 2 },
                new List<int> { 2, 1 },
                new List<int> { 2, 2 }
            };
            int result = client.pickSeat(seatNumber, rowNumber, checkList);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
