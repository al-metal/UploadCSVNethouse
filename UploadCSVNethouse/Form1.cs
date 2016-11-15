using Bike18;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadCSVNethouse
{
    public partial class Form1 : Form
    {
        nethouse nethouse = new nethouse();

        public Form1()
        {
            InitializeComponent();
            tbLogin.Text = Properties.Settings.Default.login;
            tbPassword.Text = Properties.Settings.Default.password;
        }

        private void btnUploadCSV_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = tbLogin.Text;
            Properties.Settings.Default.password = tbPassword.Text;
            Properties.Settings.Default.Save();

            CookieContainer cookie = nethouse.CookieNethouse(tbLogin.Text, tbPassword.Text);
            if(cookie.Count != 4)
            {
                MessageBox.Show("Проверьте правильность ввода логина/пароля!", "Ошибка");
                return;
            }
            string file = "naSite.csv";
        }
    }
}
