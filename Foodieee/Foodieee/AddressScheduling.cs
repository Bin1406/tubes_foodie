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
    public partial class AddressScheduling : Form
    {
        public AddressScheduling()
        {
            InitializeComponent();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodePembayaran Mp = new MetodePembayaran();
            Mp.Show();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailMakanan Dm = new DetailMakanan();
            Dm.Show();
        }

        private void AddressScheduling_Load(object sender, EventArgs e)
        {

        }
    }
}
