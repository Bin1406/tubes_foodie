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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            // Mengubah ke panel Recommended jika Pertama kali masik ke Home tombol "Recomended"
            SidePanel.Height = buttonRecom.Height;
            SidePanel.Top = buttonRecom.Top;
            firstControl1.BringToFront();
        }

        private void labelLemonade_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLemon_Click(object sender, EventArgs e)
        {
            // Me redirect ke Detail Makanan apabila user melakukan klik pada menu Lemonade
            this.Hide();
            DetailMakanan Dm = new DetailMakanan();
            Dm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Menampilkan popup error karena menu dalam kondisi "Stok Kosong"
            MessageBox.Show("Maaf Nasigoreng habis");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Menampilkan popup error karena menu dalam kondisi "Stok Kosong"
            MessageBox.Show("Maaf Martabak habis");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Menampilkan popup error karena menu dalam kondisi "Stok Kosong"
            MessageBox.Show("Maaf Jus Anggur habis");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Menampilkan popup error karena menu dalam kondisi "Stok Kosong"
            MessageBox.Show("Maaf Ice Cream habis");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Menampilkan popup error karena menu dalam kondisi "Stok Kosong"
            MessageBox.Show("Maaf Sangpisang habis");
        }

        private void buttonRecom_Click(object sender, EventArgs e)
        {
           // Mengubah ke panel Recommended jika user menekan tombol "Recomended"
            SidePanel.Height = buttonRecom.Height;
            SidePanel.Top = buttonRecom.Top;
            firstControl1.BringToFront();
           
        }

        private void buttonNear_Click(object sender, EventArgs e)
        {
            // Mengubah ke panel Near You jika user menekan tombol "Near You"
            SidePanel.Height = buttonNear.Height;
            SidePanel.Top = buttonNear.Top;
            secondControl1.BringToFront();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void secondControl1_Load(object sender, EventArgs e)
        {

        }

        private void hargaMakanan1_Click(object sender, EventArgs e)
        {

        }
    }
}
