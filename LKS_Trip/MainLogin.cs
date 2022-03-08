using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Trip
{
    public partial class MainLogin : Form
    {

        public MainLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0';
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0 || textBox2.TextLength > 0)
            {
                SqlConnection connection = new SqlConnection(Utils.conn);
                SqlCommand command = new SqlCommand("select * from employee where username = @username and password = @pass", connection);
                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@pass", Encrypt.enc(textBox2.Text));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Model.id = reader.GetInt32(0);
                    Model.name = reader.GetString(1);
                    Model.jobId = reader.GetInt32(7);
                    connection.Close();

                    if(Model.jobId== 1)
                    {
                        MainAdmin main = new MainAdmin();
                        this.Hide();
                        main.ShowDialog();
                    }
                    else if (Model.jobId == 2)
                    {
                        MainCashier main = new MainCashier();
                        this.Hide();
                        main.ShowDialog();
                    }
                    else if (Model.jobId == 3)
                    {
                        MainDriver main = new MainDriver();
                        this.Hide();
                        main.ShowDialog();
                    }
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("User can't find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
