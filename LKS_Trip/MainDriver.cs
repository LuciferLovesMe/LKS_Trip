using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Trip
{
    public partial class MainDriver : Form
    {
        public MainDriver()
        {
            InitializeComponent();
            lblname.Text = Model.name;
            lbltime.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy");
        }

        private void panel_trip_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            this.Hide();
            trip.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MainAdmin main = new MainAdmin();
                this.Hide();
                main.ShowDialog();
            }
        }
    }
}
