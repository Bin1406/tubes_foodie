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
    public partial class MetodePembayaran : Form
    {
        public MetodePembayaran()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Untuk me redirect ke page selanjutnya karena memilih metode pembayaran gopay (yang tersedia)
            this.Hide();
            Pembayaran Pm = new Pembayaran();
            Pm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Me redirect ke halaman sebelumnya
            this.Hide();
            AddressScheduling As = new AddressScheduling();
            As.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
