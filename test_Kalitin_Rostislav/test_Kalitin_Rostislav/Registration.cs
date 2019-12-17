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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
        }

        private void btnReg2_Click(object sender, EventArgs e)
        {
            if (logText2.Text == "" || passText2.Text == "")
            {
                MessageBox.Show("Поля не были заполнены");
            }
            else
            {
                MessageBox.Show($"Регистрация успешно завершена!");
            }
        }
    }
}
