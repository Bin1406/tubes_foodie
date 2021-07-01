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
        static bintangtabledriven.pin id = bintangtabledriven.pin.binbin;
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
            this.Hide();
            Success Sc = new Success();
            Sc.Show();
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
