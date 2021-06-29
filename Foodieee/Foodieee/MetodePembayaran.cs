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
            this.Hide();
            Pembayaran pm = new Pembayaran();
            pm.Show();
        }
    }
}
