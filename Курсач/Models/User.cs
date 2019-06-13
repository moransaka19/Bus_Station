using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.Models
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public User(int id, string username)
        {
            Id = id;
            Username = username;

            Tickets = new List<Ticket>();
        }

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;

            Tickets = new List<Ticket>();
        }
    }
}
