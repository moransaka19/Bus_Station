using System.Collections.Generic;
using System.IO;

namespace Курсач.Servises
{
    class Cashbox
    {
        private User _user;
        List<Flight> flights;

        public Cashbox(User user)
        {
            _user = user;
        }

        public void Initialize()
        {
            StreamReader sr = new StreamReader(@"DataBase\flights.txt"
                , System.Text.Encoding.Default);

            string temp;

            while((temp = sr.ReadLine()) != null)
            {
                flights.Add(new Flight(temp));
            }
        }
    }
}
