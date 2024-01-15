using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace CinemaApp
{
    [TestClass]
    public class FilmsTests
    {
        [TestMethod]
        public void addFilmTest()
        {
            Films films = new Films();
            Film film = new Film("5", "Jakis film", "jakis rezyser");

            films.addFilm(film);

            Assert.AreEqual(1, films.filmList.Count);
            Assert.AreEqual("Jakis film", films.filmList[0].filmName);
        }

        [TestMethod]

        public void showFilmsListTest()
        {
            Films films = new Films();
            Film film1 = new Film("5", "Jakis film", "jakis rezyser");
            Film film2 = new Film("6", "Drugi film", "inny rezyser");
            films.addFilm(film1);
            films.addFilm(film2);

            films.showFilmsList();

            //Pierwsza część testu metody
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            string result = stringWriter.ToString().Trim();
            string expectedOutput = "Lista filmów:";
            Assert.AreEqual(expectedOutput, result);
            // Druga część testu metody
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            string res = sw.ToString().Trim();
            string expOutput = "Lista filmów:\n1\nFilm: Jakis film\nRezyser: jakis rezyser\n2\nFilm: Drugi film\nRezyser: inny rezysert";
            Assert.AreEqual(expOutput, res);
        }

        [TestMethod]
        public void pickFilmTestforIndex0()
        {
            Films films = new Films();
            Film film1 = new Film("5", "Jakis film", "jakis rezyser");
            films.addFilm(film1);
            int index = 0;

            Film filmTester = films.pickFilm(index);

            Assert.IsNotNull(filmTester);
        }

        [TestMethod]
        public void pickFilmTestforIndexMinus1()
        {
            Films films = new Films();
            Film film1 = new Film("5", "Jakis film", "jakis rezyser");
            films.addFilm(film1);
            int index = -1;

            Film filmTester = films.pickFilm(index);

            Assert.IsNull(filmTester);
        }

        [TestMethod]
        public void pickFilmTestforIndexOutOfRange()
        {
            Films films = new Films();
            Film film1 = new Film("5", "Jakis film", "jakis rezyser");
            films.addFilm(film1);
            int index = 1000;

            Film filmTester = films.pickFilm(index);

            Assert.IsNull(filmTester);
        }


    }
}
