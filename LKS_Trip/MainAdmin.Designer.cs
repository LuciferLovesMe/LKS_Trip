
namespace LKS_Trip
{
    partial class MainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_vehicle = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_route = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_employee = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_type = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_vehicle.SuspendLayout();
            this.panel_route.SuspendLayout();
            this.panel_employee.SuspendLayout();
            this.panel_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.panel_type);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel_employee);
            this.panel1.Controls.Add(this.panel_route);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.panel_vehicle);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 604);
            this.panel1.TabIndex = 0;
            // 
            // panel_vehicle
            // 
            this.panel_vehicle.Controls.Add(this.label2);
            this.panel_vehicle.Controls.Add(this.label1);
            this.panel_vehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_vehicle.Location = new System.Drawing.Point(0, 145);
            this.panel_vehicle.Name = "panel_vehicle";
            this.panel_vehicle.Size = new System.Drawing.Size(286, 86);
            this.panel_vehicle.TabIndex = 0;
            this.panel_vehicle.Click += new System.EventHandler(this.panel_vehicle_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(13, 12);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(58, 23);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "";
            this.label1.Click += new System.EventHandler(this.panel_vehicle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle";
            this.label2.Click += new System.EventHandler(this.panel_vehicle_Click);
            // 
            // panel_route
            // 
            this.panel_route.Controls.Add(this.label3);
            this.panel_route.Controls.Add(this.label4);
            this.panel_route.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_route.Location = new System.Drawing.Point(0, 231);
            this.panel_route.Name = "panel_route";
            this.panel_route.Size = new System.Drawing.Size(286, 86);
            this.panel_route.TabIndex = 4;
            this.panel_route.Click += new System.EventHandler(this.panel_route_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Route";
            this.label3.Click += new System.EventHandler(this.panel_route_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "";
            this.label4.Click += new System.EventHandler(this.panel_route_Click);
            // 
            // panel_employee
            // 
            this.panel_employee.Controls.Add(this.label5);
            this.panel_employee.Controls.Add(this.label6);
            this.panel_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_employee.Location = new System.Drawing.Point(0, 317);
            this.panel_employee.Name = "panel_employee";
            this.panel_employee.Size = new System.Drawing.Size(286, 86);
            this.panel_employee.TabIndex = 5;
            this.panel_employee.Click += new System.EventHandler(this.panel_employee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Employee";
            this.label5.Click += new System.EventHandler(this.panel_route_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "";
            this.label6.Click += new System.EventHandler(this.panel_route_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(960, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_type
            // 
            this.panel_type.Controls.Add(this.label7);
            this.panel_type.Controls.Add(this.label8);
            this.panel_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_type.Location = new System.Drawing.Point(0, 59);
            this.panel_type.Name = "panel_type";
            this.panel_type.Size = new System.Drawing.Size(286, 86);
            this.panel_type.TabIndex = 4;
            this.panel_type.Click += new System.EventHandler(this.panel_type_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(94, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vehicle Type";
            this.label7.Click += new System.EventHandler(this.panel_type_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 35);
            this.label8.TabIndex = 2;
            this.label8.Text = "";
            this.label8.Click += new System.EventHandler(this.panel_type_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.Location = new System.Drawing.Point(292, 9);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(51, 19);
            this.lbltime.TabIndex = 7;
            this.lbltime.Text = "label1";
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_vehicle.ResumeLayout(false);
            this.panel_vehicle.PerformLayout();
            this.panel_route.ResumeLayout(false);
            this.panel_route.PerformLayout();
            this.panel_employee.ResumeLayout(false);
            this.panel_employee.PerformLayout();
            this.panel_type.ResumeLayout(false);
            this.panel_type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_employee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_route;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel_vehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltime;
    }
}