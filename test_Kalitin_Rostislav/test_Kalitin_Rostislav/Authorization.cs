using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_Kalitin_Rostislav
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string login = "user1";
            string password = "1234";
            if (logText.Text == "" || passText.Text == "")
            {
                MessageBox.Show("Поля не должны быть пустыми");
            }
            else
            {
                if (logText.Text == login && passText.Text == password)
                {
                    MessageBox.Show($"Добро пожаловать в программу, {logText.Text}!");
                }

                else
                {
                    MessageBox.Show("Пароль или логин введены не верно!");
                }
            }
        }

    }
}
