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
    public partial class DetailMakanan : Form
    {
        public DetailMakanan()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Untuk me redirect ke page selanjutnya
            
            this.Hide();
            AddressScheduling As = new AddressScheduling();
            As.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Untuk me redirect ke page sebelumnya
            this.Hide();
            Home Gg = new Home();
            Gg.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
