using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusStation.Models;
using BusStation.Services;

namespace BusStation
{
    partial class CashboxForm : Form
    {
        public User User { get; set; }

        private CashboxService _cashboxService;
        private FlightService _flightService;
        private UserService _userService;
        private TicketService _ticketService;


        private string _pathToCity = @"DataBase\city.txt";
        private string _pathToTime = @"DataBase\time.txt";

        private string _city;
        private string _time;

        private int _numberOfFlight;
        private string _point;
        private DateTime _departureTime;
        private int _countOfSeats;

        private int _id;

        public CashboxForm(User user)
        {
            User = user;

            _flightService = new FlightService();
            _cashboxService = new CashboxService();
            _userService = new UserService(User);
            _ticketService = new TicketService();

            InitializeComponent();
            using (StreamReader sr = new StreamReader(_pathToCity, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    comboBox1.Items.Add(line);
                }
            }

            using (StreamReader sr = new StreamReader(_pathToTime, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    comboBox2.Items.Add(line);
                }
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            Update();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _city = comboBox1.SelectedItem.ToString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _time = comboBox2.SelectedItem.ToString();
        }

        private void MakePurchase(object sender, EventArgs e)
        {
            _userService.SaveTicket(_ticketService.Create(_numberOfFlight, _point, _departureTime, _countOfSeats));
            MessageBox.Show("Покупка совершена");
            Update();
        }

        private void scheduleGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.scheduleGridView.Rows[e.RowIndex];
                _numberOfFlight = int.Parse(row.Cells["NumberOfFlight"].Value.ToString());
                _point = row.Cells["Point"].Value.ToString();
                _departureTime = DateTime.Parse(row.Cells["DepartureTime"].Value.ToString());
                _countOfSeats = int.Parse(row.Cells["CountOfEmptySeats"].Value.ToString());
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Update();
        }

        private new void Update()
        {
            scheduleGridView.Rows.Clear();
            ticketsGridView.Rows.Clear();

            foreach (var i in User.Tickets)
            {
                ticketsGridView.Rows.Add(i.FlightNumber, i.DepartureTime, i.Point);
            }

            var flights = _flightService.GetAll().Where(f =>
                f.Point == _city
                && f.DepartureTime > DateTime.Parse(_time));

            foreach (var i in flights)
            {
                scheduleGridView.Rows.Add(i.Id, i.Point, $"{i.DepartureTime:hh:mm}", i.CountSeats);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ticketsGridView.Rows[e.RowIndex];
                _id = int.Parse(row.Cells["NumberFlight2"].Value.ToString());
            }
        }

        private void ReturnTicket_Click(object sender, EventArgs e)
        {
            _userService.RemoveTicket(_id);
            Update();
        }
    }
}
