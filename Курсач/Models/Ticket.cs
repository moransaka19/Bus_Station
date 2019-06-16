using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.Models
{
    class Ticket
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public int FlightNumber { get; set; }
        public string Point { get; set; }

        public Ticket(int id, DateTime departureTime, int flightNumber, string point)
        {
            Id = id;
            DepartureTime = departureTime;
            FlightNumber = flightNumber;
            Point = point;
        }
    }
}
