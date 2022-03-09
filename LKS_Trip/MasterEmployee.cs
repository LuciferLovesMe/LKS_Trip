using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Trip
{
    public partial class MasterEmployee : Form
    {
        int cond, id;
        SqlConnection connection = new SqlConnection(Utils.conn);
        SqlCommand command;
        SqlDataReader reader;

        public MasterEmployee()
        {
            InitializeComponent();
            dis();
            loadgrid("");
            loadjob();
            lblname.Text = Model.name;
            lbltime.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy");
        }

        void dis()
        {
            btn_submit.Enabled = true;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            comboBox1.Enabled = false;
            button3.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            dateTimePicker1.Enabled = false;
            checkBox1.Enabled = false;
        }

        void enable()
        {
            btn_submit.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            comboBox1.Enabled = true;
            button3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            dateTimePicker1.Enabled = true;
            checkBox1.Enabled = true;
        }

        void loadjob()
        {
            string com = "select * from job";
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = Command.getdata(com);
        }

        void loadgrid(string s)
        {
            string com = "select * from employee join job on job.id = employee.jobId" + s;
            dataGridView1.DataSource = Command.getdata(com);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        bool val()
        {
            if (textBox2.TextLength < 1 || textBox3.TextLength < 1 || textBox4.TextLength < 1 || textBox5.TextLength < 1 || textBox6.TextLength < 1 || dateTimePicker1.Value == null || comboBox1.Text.Length < 1 || !radioButton1.Checked && !radioButton2.Checked || pictureBox1.Image == null)
            {
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Insert a correct datetime", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox2.TextLength != 16)
            {
                MessageBox.Show("NIK must be 16 digit characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox6.Text != textBox5.Text)
            {
                MessageBox.Show("Confirm password doesn't correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            command = new SqlCommand("select * from employee where nik = '" + textBox2.Text + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                connection.Close();
                MessageBox.Show("NIK was already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            connection.Close();
            command = new SqlCommand("select * from employee where username = @name", connection);
            command.Parameters.AddWithValue("@name", textBox4.Text);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows )
            {
                connection.Close();
                MessageBox.Show("Username was already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            connection.Close();
            return true;
        }

        bool valUp()
        {
            if (textBox2.TextLength < 1 || textBox3.TextLength < 1 || textBox4.TextLength < 1 || dateTimePicker1.Value == null || comboBox1.Text.Length < 1 || !radioButton1.Checked && !radioButton2.Checked || pictureBox1.Image == null)
            {
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Insert a correct datetime", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox2.TextLength != 16)
            {
                MessageBox.Show("NIK must be 16 digit characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            command = new SqlCommand("select * from employee where nik = '" + textBox2.Text + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows && reader.GetInt32(0) != id)
            {
                connection.Close();
                MessageBox.Show("NIK was already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            connection.Close();
            command = new SqlCommand("select * from employee where username = @name", connection);
            command.Parameters.AddWithValue("@name", textBox4.Text);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows && reader.GetInt32(0) != id)
            {
                connection.Close();
                MessageBox.Show("Username was already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            connection.Close();
            return true;
        }

        void clear()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = null;
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

        private void btn_submit_Click(object sender, EventArgs e)
        {
            enable();
            cond = 1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                cond = 2;
                enable();
                textBox5.Enabled = false;
                textBox6.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select an item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string com = "delete from employee where id = " + id;
                    try
                    {
                        Command.exec(com);
                        loadgrid("");
                        dis();
                        clear();
                        MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dis();
            clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(cond == 1 && val())
            {
                string g = "";
                if (radioButton1.Checked)
                    g = "Male";
                else
                    g = "Female";
                int age = 0;
                age = Convert.ToInt32(DateTime.Now.ToString("yyyy")) - Convert.ToInt32(dateTimePicker1.Value.ToString("yyyy"));
                command = new SqlCommand("insert into employee values(@name, '" + textBox2.Text + "', '" + g + "', '" + dateTimePicker1.Value.Date + "', " + age + ", @img, " + comboBox1.SelectedValue + ", @username, @pass)", connection);
                command.Parameters.AddWithValue("@name", textBox3.Text);
                command.Parameters.AddWithValue("@img", Encrypt.encode(pictureBox1.Image));
                command.Parameters.AddWithValue("@username", textBox4.Text);
                command.Parameters.AddWithValue("@pass", Encrypt.enc(textBox5.Text));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    loadgrid("");
                    dis();
                    clear();
                    MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else if (cond == 2 && valUp())
            {
                string g = "";
                if (radioButton1.Checked)
                    g = "Male";
                else
                    g = "Female";
                int age = 0;
                age = Convert.ToInt32(DateTime.Now.ToString("yyyy")) - Convert.ToInt32(dateTimePicker1.Value.ToString("yyyy"));
                command = new SqlCommand("update employee set nik = '"+textBox2.Text+"', name = @name, dateofBirth = '"+dateTimePicker1.Value.Date+"', gender = '"+g+"', age = "+age+", photo = @img, username = @username where id = " + id, connection);
                command.Parameters.AddWithValue("@name", textBox3.Text);
                command.Parameters.AddWithValue("@img", Encrypt.encode(pictureBox1.Image));
                command.Parameters.AddWithValue("@username", textBox4.Text);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    loadgrid("");
                    dis();
                    clear();
                    MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.png;*jpg;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                Bitmap bmp = (Bitmap)img;
                pictureBox1.Image = bmp;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value);
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value);
            if(dataGridView1.SelectedRows[0].Cells[6].Value == System.DBNull.Value)
            {
                pictureBox1.Image = null;
            }
            else
            {
                byte[] b = (byte[])dataGridView1.SelectedRows[0].Cells[6].Value;
                MemoryStream stream = new MemoryStream(b);
                pictureBox1.Image = Image.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if(dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Male")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox5.PasswordChar = '\0';
            else
                textBox5.PasswordChar = '*';
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadgrid(" where name like '%" + textBox1.Text + "%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
