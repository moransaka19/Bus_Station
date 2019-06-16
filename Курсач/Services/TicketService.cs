using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.Models;

namespace BusStation.Services
{
    class TicketService
    {
        private string _dbPath;

        public TicketService()
        {
            _dbPath = @"DataBase\";
        }

        public Ticket Create(int id, int flightNumber, string point, DateTime departureTime)
        {
            return new Ticket(id, departureTime, flightNumber, point);
        }
    }
}
