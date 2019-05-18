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
    public partial class Log_in : Form
    {
        private const string _path = @"DataBase\users.txt";
        public Log_in()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

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
                        User user = new User(temp[0], temp[1], temp[2]);
                        this.Hide();
                        CashboxForm cashbox = new CashboxForm(user);
                        cashbox.Show();
                        break;
                    }
                    else
                    {
                        if (temp[1] == loginBox.Text && temp[2] == passwordBox.Text)
                        {
                            this.Hide();
                            MessageBox.Show(temp[0]);
                            CashboxForm cashbox = new CashboxForm(temp[0], temp[1]);
                            cashbox.Show();
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
