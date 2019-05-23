using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Курсач.Models;
using Курсач.Services;

namespace Курсач
{
    partial class CashboxForm : Form
    {
        private FlightService _flightService;

        private string _pathToCity = @"DataBase\city.txt";
        private string _pathToTime = @"DataBase\time.txt";

        private string _city;
        private string _time;

        public CashboxForm()
        {
            _flightService = new FlightService();

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
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _city = comboBox1.SelectedItem.ToString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _time = comboBox2.SelectedItem.ToString();
        }

        private void CreditOrder(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonShowTicket_Click(object sender, EventArgs e)
        {
        }

        private void scheduleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.scheduleGridView.Rows[e.RowIndex];
            //    _numberOfFlight = row.Cells["NumberOfFlight"].Value.ToString();
            //    _point = row.Cells["Point"].Value.ToString();
            //    _departureTime = row.Cells["DepartureTime"].Value.ToString();
            //    _countOfEmptySeats = row.Cells["CountOfEmptySeats"].Value.ToString();
            //}
        }

        private void Update_Click(object sender, EventArgs e)
        {
            scheduleGridView.Rows.Clear();

            var flights = _flightService.GetAll().Where(f => 
                f.Point == _city 
                && f.DepartureTime > DateTime.Parse(_time));

            foreach (var i in flights)
            {
                scheduleGridView.Rows.Add(i.Id, $"{i.DepartureTime:hh:mm}", i.Point);
            }
        }
    }
}
