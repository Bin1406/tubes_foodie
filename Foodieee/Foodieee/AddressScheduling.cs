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
        DataTable table;
        public AddressScheduling()
        {
            InitializeComponent();
        }
        //Runtime Configuration Dhafin
        public void GetSettings()
        {
            addressName.Text = Properties.Settings.Default.Address;
            dateName.Text = Properties.Settings.Default.Date;
        }

        public void AddSettings()
        {
            Properties.Settings.Default.Address = textAddress.Text;
            Properties.Settings.Default.Date = textDate.Text;

            Properties.Settings.Default.Save();
        }

      

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            MetodePembayaran Mp = new MetodePembayaran();
            Mp.Show();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailMakanan Dm = new DetailMakanan();
            Dm.Show();
        }

        private void AddressScheduling_(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddSettings();
            GetSettings();
        }

        private void textDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
