using BusStation;
using BusStation.Models;
using BusStation.Services;
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
        private UserService _userService;
        private string _dbPath;
        private int _idCount;

        public RegisterForm()
        {
            _dbPath = @"DataBase\";

            _userService = new UserService();
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
            if (CheckInput())
            {

                User user = new User((_idCount + 1), LoginBox.Text);

                using (StreamWriter sw = new StreamWriter(_dbPath + "users.txt", true, Encoding.Default))
                {
                    sw.WriteLine($"{user.Id} {user.Username} {PasswordBox.Text}");
                }

                using (StreamWriter sw = new StreamWriter($"{_dbPath}countofusers.txt", false, Encoding.Default))
                {
                    sw.Write(_idCount + 1);
                }

                this.Hide();
                CashboxForm cashboxForm = new CashboxForm(user);

                cashboxForm.Show();
            }
        }

        private bool CheckInput()
        {
            if (LoginBox.Text == "" || PasswordBox.Text == "" || RetryPasswordBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return false;
            }

            if (_userService.CheckUsername(LoginBox.Text))
            {
                MessageBox.Show("Пользователь с таким именем уже существует, выбирите другое имя");
                return false;
            }

            if (PasswordBox.Text != RetryPasswordBox.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }

            return true;
        }

        private void UsernameValidating(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;
        }
    }
}
