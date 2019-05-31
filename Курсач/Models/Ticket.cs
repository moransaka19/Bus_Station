using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.Models
{
    class Ticket
    {
        public DateTime DepartureTime { get; set; }
        public int FlightNumber { get; set; }
        //public int NumberOfSeat { get; set; }
        public string Point { get; set; }

        public Ticket(DateTime departureTime, int flightNumber, string point)
        {
            DepartureTime = departureTime;
            FlightNumber = flightNumber;
            Point = point;
            //NumberOfSeat = numberOFSeat;
        }
    }
}
