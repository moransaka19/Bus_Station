using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.Models
{
    class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public User(string id, string userName)
        {
            Id = id;
            UserName = userName;

            Tickets = new List<Ticket>();
        }
    }
}
