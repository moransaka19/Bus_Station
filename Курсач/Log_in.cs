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
                string[] user;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    user = line.Split(' ');
                    if (user[0] == "admin" && user[1] == loginBox.Text &&
                        user[2] == passwordBox.Text)
                    {
                        this.Hide();
                        MessageBox.Show(user[0]);
                        Cashbox cashbox = new Cashbox();
                        cashbox.Show();
                        break;
                    }
                    else
                    {
                        if (user[1] == loginBox.Text && user[2] == passwordBox.Text)
                        {
                            this.Hide();
                            MessageBox.Show(user[0]);
                            Cashbox cashbox = new Cashbox();
                            cashbox.Show();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Аккаунта нахой НеТу");
                        }
                    }
                }
            }
        }
    }
}
