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

        private void AddressScheduling_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Date", typeof(String));
            table.Columns.Add("Address", typeof(String));

            dataGridView1.DataSource = table;
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
            table.Rows.Add(textDate.Text, textAddress.Text);

            textDate.Clear();
            textAddress.Clear();

        }
    }
}
