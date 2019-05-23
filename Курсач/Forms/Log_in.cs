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
using Курсач.Models;

namespace Курсач
{
    partial class Log_in : Form
    {
        private const string _path = @"DataBase\users.txt";
        public Log_in()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(_path);
            {
                string[] temp;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    temp = line.Split(' ');


                    if (temp[0] == "admin" && temp[1] == loginBox.Text &&
                        temp[2] == passwordBox.Text)
                    {
                        User admin = new User(temp[0], temp[1]);
                        this.Hide();
                        CashboxForm cashboxForm = new CashboxForm();
                        cashboxForm.Show();
                        break;
                    }
                    else
                    {
                        if (temp[1] == loginBox.Text && temp[2] == passwordBox.Text)
                        {
                            this.Hide();
                            User user = new User(temp[0], temp[1]);
                            CashboxForm cashboxForm = new CashboxForm();
                            cashboxForm.Show();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Аккаунта Нету");
                        }
                    }
                }
            }
        }
    }
}
