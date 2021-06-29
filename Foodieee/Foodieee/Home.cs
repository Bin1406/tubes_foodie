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
        }

        private void labelLemonade_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLemon_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailMakanan Dm = new DetailMakanan();
            Dm.Show();
        }
    }
}
