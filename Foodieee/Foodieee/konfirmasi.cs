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
    public partial class konfirmasi : Form
    {
        //Memanggil dari class bintangtabledriven
        static bintangtabledriven.id id = bintangtabledriven.id.binbin;
        public string pin = id.ToString();
        public string Password = bintangtabledriven.getPassword(id);
        public konfirmasi()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void konfirmasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, password;
            id = textBoxpin.Text;
            password = textBoxpw.Text;

            Console.WriteLine(id.ToString());
            Console.WriteLine(password.ToString());
            if (textBoxpin.Text == id.ToString() && textBoxpw.Text == password.ToString())
            {
                MessageBox.Show("Pembayaran Berhasil");
                this.Hide();
                Success Sc = new Success();
                Sc.Show();
            }
            // Menerapkan kondisi apabila username kosong
            else if (id == "")
            {
                MessageBox.Show("id tidak boleh kosong");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pembayaran Pm = new Pembayaran();
            Pm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
