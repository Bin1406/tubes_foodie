using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodieee
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textUsername.Text;
            password = textPassword.Text;

            if (username == "Foodie" && password == "Foodie")
            {
                MessageBox.Show("Berhasil Login");
                this.Hide();
                Home Gg = new Home();
                Gg.Show();
            } else
            {
                MessageBox.Show("Username atau Password salah");
                this.Hide();
                Login Lg = new Login();
                Lg.Show();
            }
        }
    }
}
