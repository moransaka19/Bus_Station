using System;

namespace Курсач
{
    class Ticket
    {
        private string _departurTime;
        private int _numberOfFlight;
        //private int _numberOfSeat;
        private string _point;

        public Ticket(string departuteTime, string point, int numberOfFlight)
        {
            this._departurTime = departuteTime;
            this._point = point;
           // this._numberOfSeat = numberOfSeat;
            this._numberOfFlight = numberOfFlight;
        }

        public string GetStringTicket()
        {
            return $"{_numberOfFlight} {_point} {_departurTime}";
        }
    }
}
