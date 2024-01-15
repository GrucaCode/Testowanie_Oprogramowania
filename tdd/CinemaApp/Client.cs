using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class Client
    {
        public Client(string clientName, string clientSurname) { }
        public string pickHall(string number, CinemaHall small, CinemaHall large) { }
        public CinemaHall pickHallObj(string number, CinemaHall small, CinemaHall large) { }
        public int pickSeat(string seatNumber, string rowNumber, List<List<int>> freeSeats) { }
    }
}
