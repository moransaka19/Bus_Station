using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Models;

namespace Курсач.Services
{
    class UserService
    {
        private User _user;

        private string _dpPath;

        public UserService(User user)
        {
            _user = user;
            _dpPath = @"DataBase\";
        }

        public void SaveTicket(Ticket ticket)
        {
            _user.Tickets.Add(ticket);

            using (StreamWriter sw = new StreamWriter($"{_dpPath}{_user.Id}{_user.UserName}.txt", 
                                                      true,
                                                      Encoding.Default))
            {
                foreach (var i in _user.Tickets)
                {
                    sw.WriteLine($"{i.FlightNumber.ToString()} {i.DepartureTime.ToShortTimeString()} {i.Point}");
                }
            }
        }
    }
}
