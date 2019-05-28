using BusStation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач.Forms
{
     partial class TicketsForm : Form
     {
        private User _user;

        private int _id;
        private DateTime _departureTime;
        private string _point;

        public TicketsForm(User user)
        {
            _user = user;

            InitializeComponent();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
