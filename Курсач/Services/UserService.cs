using System;
using System.Collections.Generic;
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

        public UserService(User user)
        {
            _user = user;
            _dpPath = @"DataBase\";

            if (!(File.Exists(_dpPath + _user.Id + _user.UserName + ".txt")))
            {
                using (FileStream fs = File.Create(_dpPath + _user.Id + _user.UserName + ".txt"));
            }
            else
            {
                using (StreamReader sr = new StreamReader($"{_dpPath}{_user.Id}{_user.UserName}.txt", Encoding.Default))
                {
                    string ticket;

                    while ((ticket = sr.ReadLine()) != null)
                    {
                        string[] ticketInfo = ticket.Split(' ');
                        _user.Tickets.Add(new Ticket(DateTime.Parse(ticketInfo[1]), int.Parse(ticketInfo[0]), ticketInfo[2]));
                    }
                }
            }
        }

        public void SaveTicket(Ticket ticket)
        {
            _user.Tickets.Add(ticket);

            using (StreamWriter sw = new StreamWriter($"{_dpPath}{_user.Id}{_user.UserName}.txt",
                                                false,
                                                Encoding.Default))
            {
                foreach (var i in _user.Tickets)
                {
                    sw.WriteLine($"{i.FlightNumber.ToString()} {i.DepartureTime.ToShortDateString()} {i.DepartureTime.ToShortTimeString()} {i.Point}");
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
                    sw.WriteLine($"{f.Id.ToString()} {f.Point} {f.DepartureTime} {f.CountSeats}");
                }
            }
        }

        public void RemoveTicket(int id)
        {
             var ticket = _user.Tickets.Where(i => id != i.FlightNumber);
            _user.Tickets = ticket.ToList();

            using (StreamWriter sw = new StreamWriter($"{_dpPath}{_user.Id}{_user.UserName}.txt",
                                                false,
                                                Encoding.Default))
            {
                foreach (var i in _user.Tickets)
                {
                    sw.WriteLine($"{i.FlightNumber.ToString()} {i.DepartureTime.ToShortTimeString()} {i.Point}");
                }
            }
           
            FlightService flightService = new FlightService();

            var flights = flightService
                .GetAll()
                .Select(f =>
                {
                    if (id == f.Id)
                        f.CountSeats++;

                    return f;
                });

            using (StreamWriter sw = new StreamWriter($"{_dpPath}flights.txt", false, Encoding.Default))
            {


                foreach (var f in flights)
                {
                    sw.WriteLine($"{f.Id.ToString()} {f.Point} {f.DepartureTime} {f.CountSeats}");
                }
            }
        }
    }
}
