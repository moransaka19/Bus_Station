using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Servises
{
    class Flight
    {
        private string _numberOfFlight;
        private string _point;
        private string _departureime;
        private string _countOfEmptySeats;

        public Flight(string stream)
        {
            string[] info = stream.Split(' ');

            _numberOfFlight = info[0];
            _point = info[1];
            _departureime = info[2];
            _countOfEmptySeats = info[3];
        }

        public string GetInfoForTicket()
        {
            tempStr = 

            return tempStr;
        }
    }
}
