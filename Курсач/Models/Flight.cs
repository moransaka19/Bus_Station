using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.Models
{
    class Flight
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Point { get; set; }
        public int CountSeats { get; set; }

        public Flight(int id, DateTime departureTime, string point, int countSeats)
        {
            Id = id;
            DepartureTime = departureTime;
            Point = point;
            CountSeats = countSeats;
        }
    }
}
