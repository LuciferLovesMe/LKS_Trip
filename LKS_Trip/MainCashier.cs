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
    public partial class MainCashier : Form
    {
        public MainCashier()
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

        private void panel_ticket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            this.Hide();
            ticket.ShowDialog();
        }

        private void panel_report_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
