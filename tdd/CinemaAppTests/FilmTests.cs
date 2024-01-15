using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemaApp
{
    [TestClass]
    public class FilmTests
    {
        [TestMethod]
        public void ConstructorFilmTest()
        {
            Film movie1;

            movie1 = new Film("4", "Oppenheimer", "Christopher Nolan");

            Assert.IsNotNull(movie1, "Test konstruktora Film");
        }

        [TestMethod]
        public void showFilmTester()
        {
            Film filmTester = new Film("4", "Oppenheimer", "Christopher Nolan");

            filmTester.showFilm();

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            string result = stringWriter.ToString().Trim();

            string expectedOutput = "4\nFilm: Oppenheimer\nRezyser: Christopher Nolan";
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
