using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class CashboxForm : Form
    {
        private User _user;

        private string _pathToCity = @"DataBase\city.txt";
        private string _pathToTime = @"DataBase\time.txt";
        private string _pathToSchedule = @"DataBase\flights.txt";

        private string _numberOfFlight;
        private string _point;
        private string _departureTime;
        private string _countOfEmptySeats;

        public CashboxForm(User user)
        {
            this._user = user;

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
            string selectedState = comboBox1.SelectedItem.ToString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox2.SelectedItem.ToString();
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.scheduleGridView.Rows[e.RowIndex];
                _numberOfFlight = row.Cells["NumberOfFlight"].Value.ToString();
                _point = row.Cells["Point"].Value.ToString();
                _departureTime = row.Cells["DepartureTime"].Value.ToString();
                _countOfEmptySeats = row.Cells["CountOfEmptySeats"].Value.ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(_pathToSchedule, System.Text.Encoding.Default))
            {
                string line;
                string[] flight;
                while ((line = sr.ReadLine()) != null)
                {
                    flight = line.Split(' ');
                    flight[3] += flight[4]; 
                    scheduleGridView.Rows.Add(flight);
                }
            }
        }
    }
}
