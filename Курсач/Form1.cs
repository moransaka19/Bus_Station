using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowTicket(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Show();
        }

        private void BuyTicket(object sender, EventArgs e)
        {
            Cashbox cashbox = new Cashbox();
            cashbox.Show();
            buttonShowTicket.Enabled = true;
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
