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
            // Menambahkan variabel untuk meng capture inputan dari user
            string username, password;
            username = textUsername.Text;
            password = textPassword.Text;

            // Menerapkan kondisi apabila username dan password user terdaftar
            if (username == "Foodie" && password == "Foodie")
            {
                MessageBox.Show("Berhasil Login");
                this.Hide();
                Home Gg = new Home();
                Gg.Show();
            }
            // Menerapkan kondisi apabila username kosong
            else if (username == "")
            {
                MessageBox.Show("Username tidak boleh kosong");
            }
            // Menerapkan kondisi apabila password kosong
            else if (password == "")
            {
                MessageBox.Show("Password tidak boleh kosong");
            }
            // Menerapkan kondisi apabila username dan password user TIDAK terdaftar
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            // Menambahkan chechbox untuk menyembunyikan / memunculkan password
            if (checkBoxShow.Checked)
            {
                textPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textPassword.UseSystemPasswordChar = false;
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
