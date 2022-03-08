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
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
            lblname.Text = Model.name;
            lbltime.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy");
        }

        private void panel_vehicle_Click(object sender, EventArgs e)
        {
            MasterVehicle master = new MasterVehicle();
            this.Hide();
            master.ShowDialog();
        }

        private void panel_type_Click(object sender, EventArgs e)
        {
            MasterVehicleType master = new MasterVehicleType();
            this.Hide();
            master.ShowDialog();
        }

        private void panel_route_Click(object sender, EventArgs e)
        {
            MasterRoute master = new MasterRoute();
            this.Hide();
            master.ShowDialog();
        }

        private void panel_employee_Click(object sender, EventArgs e)
        {
            MasterEmployee master = new MasterEmployee();
            this.Hide();
            master.ShowDialog();
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
