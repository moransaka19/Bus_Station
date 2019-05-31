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
using BusStation.Models;
using Курсач.Forms;

namespace BusStation
{
    partial class LogInForm : Form
    {
        private const string _path = @"DataBase\users.txt";
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            bool accountIsTrue = false;
            using (StreamReader sr = new StreamReader(_path, Encoding.Default))
            {
                string[] temp;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    temp = line.Split(' ');


                    if (temp[0] == "admin" && temp[1] == loginBox.Text &&
                        temp[2] == passwordBox.Text)
                    {
                        accountIsTrue = true;
                        this.Hide();

                        User admin = new User(temp[0], temp[1]);
                        CashboxForm cashboxForm = new CashboxForm(admin);

                        cashboxForm.Show();

                        break;
                    }
                    else
                    {
                        if (temp[1] == loginBox.Text && temp[2] == passwordBox.Text)
                        {
                            accountIsTrue = true;
                            this.Hide();

                            User user = new User(temp[0], temp[1]);
                            CashboxForm cashboxForm = new CashboxForm(user);

                            cashboxForm.Show();

                            break;
                        }
                    }
                }

                if (!accountIsTrue)
                    MessageBox.Show("Аккаунта Нету");
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            /////////////
            this.Hide();
            registerForm.Show();
        }
    }
}