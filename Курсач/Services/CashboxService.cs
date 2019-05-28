using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.Models;

namespace BusStation.Services
{
    class CashboxService
    {
        private string _dbPath;

        public CashboxService()
        {
            _dbPath = @"DataBase\";
        }
    }
}
