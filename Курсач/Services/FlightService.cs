﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BusStation.Models;

namespace BusStation.Services
{
    class FlightService
    {
        private string _dbPath;

        public FlightService()
        {
            _dbPath = @"DataBase/";
        }

        public IEnumerable<Flight> GetAll()
        {
            ICollection<Flight> flights = new List<Flight>();

            using (StreamReader sr = new StreamReader($"{_dbPath}flights.txt", Encoding.Default))
            {
                string raw;
                while ((raw = sr.ReadLine()) != null)
                {
                    string[] flightInfo = raw.Split(' ');

                    flights.Add(new Flight(
                        int.Parse(flightInfo[0]),
                        new DateTime(long.Parse(flightInfo[2])),
                        flightInfo[1],
                        int.Parse(flightInfo[3])) 
                        );
                }
            }

            return flights.Where(f => f.CountSeats > 0);
        }

        public IEnumerable<Flight> GetAll(Func<Flight, bool> predicate)
        {
            return GetAll()
                .Where(predicate);
        }
    }
}
