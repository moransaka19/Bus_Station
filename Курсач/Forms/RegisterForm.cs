using BusStation;
using BusStation.Models;
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

namespace Курсач.Forms
{
    public partial class RegisterForm : Form
    {
        private string _dbPath;
        private int _idCount;

        public RegisterForm()
        {
            _dbPath = @"DataBase\";

            using (StreamReader sr = new StreamReader($"{_dbPath}countofuSers.txt", Encoding.Default))
            {
                _idCount = int.Parse(sr.ReadLine());
            }
            
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == RetryPasswordBox.Text)
            {
                User user = new User((_idCount + 1).ToString(), LoginBox.Text);

                using (StreamWriter sw = new StreamWriter(_dbPath + "users.txt", true, Encoding.Default))
                {
                    sw.WriteLine($"{user.Id} {user.UserName} {PasswordBox.Text}");
                }

                using (StreamWriter sw = new StreamWriter($"{_dbPath}countofusers.txt", false, Encoding.Default))
                {
                    sw.Write(_idCount + 1);
                }

                this.Hide();
                CashboxForm cashboxForm = new CashboxForm(user);

                cashboxForm.Show();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}
