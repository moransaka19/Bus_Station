using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    class Flight
    {
        public int FlightNumber { get; set; }
        public int DepartureTime { get; set; }
        public List<string> Points { get; set; }
        public string FinalPoint { get; set; }
        public Bus bus { get; set; }

        public Flight()
        {

        }
    }
}
