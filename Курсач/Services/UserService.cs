using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.Models;

namespace BusStation.Services
{
    class UserService
    {
        private User _user;

        private string _dpPath;

        public UserService()
        {
            _dpPath = @"DataBase\";
        }

        public void CreateUserFile(User user)
        {
            _user = user;
            _dpPath = @"DataBase\";

            if (!(File.Exists(_dpPath + _user.Id + _user.Username + ".txt")))
            {
                using (FileStream fs = File.Create(_dpPath + _user.Id + _user.Username + ".txt"));
            }
            else
            {
                using (StreamReader sr = new StreamReader($"{_dpPath}{_user.Id}{_user.Username}.txt", Encoding.Default))
                {
                    string ticket;

                    while ((ticket = sr.ReadLine()) != null)
                    {
                        string[] ticketInfo = ticket.Split(' ');
                        _user.Tickets.Add(new Ticket(int.Parse(ticketInfo[0]), new DateTime(long.Parse(ticketInfo[2])), int.Parse(ticketInfo[1]), ticketInfo[3]));
                    }
                }
            }
        }

        public void Save(Ticket ticket)
        {
            _user.Tickets.Add(ticket);

            using (StreamWriter sw = new StreamWriter($"{_dpPath}{_user.Id}{_user.Username}.txt",
                                                false,
                                                Encoding.Default))
            {
                foreach (var i in _user.Tickets)
                {
                    sw.WriteLine($"{i.Id} {i.FlightNumber} {i.DepartureTime.Ticks} {i.Point}");
                }
            }
            
            FlightService flightService = new FlightService();

            var flights = flightService
                .GetAll()
                .Select(f =>
                {
                    if (f.Id == ticket.FlightNumber)
                        f.CountSeats--;

                    return f;
                });

            using (StreamWriter sw = new StreamWriter($"{_dpPath}flights.txt", false, Encoding.Default))
            {
                foreach (var f in flights)
                {
                    sw.WriteLine($"{f.Id} {f.Point} {f.DepartureTime.Ticks} {f.CountSeats}");
                }
            }
        }

        public bool RemoveTicket(int id, int numberOfFlight)
        {
            var checkTicket = _user.Tickets.Where(t => t.Id == id && t.DepartureTime < DateTime.Now).ToList();

            _user.Tickets = _user.Tickets.Where(i => id != i.Id).ToList();

            using (StreamWriter sw = new StreamWriter($"{_dpPath}{_user.Id}{_user.Username}.txt",
                                                false,
                                                Encoding.Default))
            {
                foreach (var i in _user.Tickets)
                {
                    sw.WriteLine($"{i.FlightNumber} {i.DepartureTime.Ticks} {i.Point}");
                }
            }

            FlightService flightService = new FlightService();

            var flights = flightService
                .GetAll()
                .Select(f =>
                {
                    if (numberOfFlight == f.Id)
                        f.CountSeats++;

                    return f;
                });
        
            using (StreamWriter sw = new StreamWriter($"{_dpPath}flights.txt", false, Encoding.Default))
            {
                foreach (var f in flights)
                {
                    sw.WriteLine($"{f.Id} {f.Point} {f.DepartureTime.Ticks} {f.CountSeats}");
                }
            }

            if (checkTicket.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUsername(string username)
        {
            List<User> users = new List<User>();
            using (StreamReader sr = new StreamReader($"{_dpPath}users.txt", Encoding.Default))
            {
                string user;

                while ((user = sr.ReadLine()) != null)
                {
                    string[] ticketInfo = user.Split(' ');
                    users.Add(new User(int.Parse(ticketInfo[0]), ticketInfo[1]));
                }
            }

            return users.Any(u => u.Username.ToUpper() == username.ToUpper());
        }

        public int CheckTicketsCount(ICollection<Ticket> tickets)
        {
            if (tickets.Count == 0)
            {
                return 0;
            }
            else
            {
                return tickets.Last().Id + 1;
            }
        }
    }
}
