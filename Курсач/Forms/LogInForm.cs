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
            List<User> users = new List<User>();

            using (StreamReader sr = new StreamReader(_path, Encoding.Default))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split(' ');
                    users.Add(new User(int.Parse(temp[0]), temp[1], temp[2]));
                }

                bool userIsAvailable = false;

                foreach(var u in users)
                {
                    if(u.Username == loginBox.Text && u.Password == passwordBox.Text)
                    {
                        userIsAvailable = true;

                        CashboxForm cashboxForm = new CashboxForm(u);

                        this.Hide();
                        cashboxForm.Show();
                    }
                }

                if (!userIsAvailable)
                {
                    MessageBox.Show("Аккаунта не существует");
                }
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            
            this.Hide();
            registerForm.Show();
        }
    }
}