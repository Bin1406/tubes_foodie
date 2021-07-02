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
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void buttonSuccess_Click(object sender, EventArgs e)
        {
            // Mer redirect ke halaman utama karena transaksi atau flow dari user sudah selesai
            this.Hide();
            Home Hm = new Home();
            Hm.Show();
        }

        private void labelSucces_Click(object sender, EventArgs e)
        {

        }
    }
}
