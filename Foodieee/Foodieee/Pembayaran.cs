﻿using System;
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
    public partial class Pembayaran : Form
    {
        public Pembayaran()
        {
            InitializeComponent();
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            // Me redirect ke halaman pembayaran sukses
            this.Hide();
            Success Sc = new Success();
            Sc.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Me redirect ke halaman sebelumnya
            this.Hide();
            DetailMakanan Dm = new DetailMakanan();
            Dm.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Memilih metode pembayaran yang akan digunakan user untuk melanjutkan pembayaran
            this.Hide();
            MetodePembayaran Mp = new MetodePembayaran();
            Mp.Show();
        }

        private void textBoxNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
