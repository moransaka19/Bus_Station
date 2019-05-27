using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Models;

namespace Курсач.Services
{
    class TicketService
    {
        private string _dbPath;

        public TicketService()
        {
            _dbPath = @"DataBase\";
        }

        public Ticket Create(int id, string point, DateTime departureTime)
        {
            Ticket ticket = new Ticket(departureTime, id, point);
            return ticket;
        }
    }
}
