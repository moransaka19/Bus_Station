using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач.Servises
{
    class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        private string _fileName;
        private Ticket ticket;

        public User(string id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
            _fileName = Id + Name + ".txt";
        }

        public BuyTicket(Flight flight)
        {

        }

        public void SaveTicket(Ticket ticket)
        {
            string[] filePath = Directory.GetDirectories(@"DataBase\");

            if (filePath.Contains(_fileName))
            {
                StreamWriter sw = new StreamWriter(@"DataBase\" + _fileName,
                    true, System.Text.Encoding.Default);

                sw.WriteLine(ticket.GetStringTicket());
            }
            else
            {
                File.Create(@"DataBase\" + _fileName);
            }
        }
    }
}
