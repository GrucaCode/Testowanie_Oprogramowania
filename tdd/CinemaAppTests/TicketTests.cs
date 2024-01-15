using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CinemaApp
{
    [TestClass]
    public class TicketTests
    {
        public void ConstructorTicketTests()
        {
            Client client = new Client("Imie", "Nazwisko");
            Film film = new Film("7", "nowy film", "nowy reżyser");
            string hall = "Duza sala";
            Ticket ticket1 = new Ticket(client, film, hall);

            Assert.IsNotNull(ticket1, "Test konstruktora Ticket");
        }

        [TestMethod]
        public void showTicketTest()
        {
            Film film = new Film("4", "Oppenheimer", "Christopher Nolan");
            Client client = new Client("Imie", "Nazwisko");
            string hall = "Duza sala";

            Ticket ticket1 = new Ticket(client, film, "Duza sala", hall, priceOfTicket);
            ticket1.showTicket(); 

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            string result = stringWriter.ToString().Trim();
            string expectedOutput = "Imie Nazwisko\n4\nFilm: Oppenheimer\nRezyser: Christopher Nolan\nDuza sala";
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
}
