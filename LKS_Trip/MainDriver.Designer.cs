
namespace LKS_Trip
{
    partial class MainDriver
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel_trip = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.panel_trip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label8.Text = "";
            // 
            // panel_trip
            // 
            this.panel_trip.Controls.Add(this.label7);
            this.panel_trip.Controls.Add(this.label8);
            this.panel_trip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_trip.Location = new System.Drawing.Point(0, 58);
            this.panel_trip.Name = "panel_trip";
            this.panel_trip.Size = new System.Drawing.Size(286, 86);
            this.panel_trip.TabIndex = 4;
            this.panel_trip.Click += new System.EventHandler(this.panel_trip_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(94, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Trip";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(960, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.panel_trip);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 604);
            this.panel1.TabIndex = 12;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.Location = new System.Drawing.Point(292, 10);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(51, 19);
            this.lbltime.TabIndex = 13;
            this.lbltime.Text = "label1";
            // 
            // MainDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltime);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDriver";
            this.panel_trip.ResumeLayout(false);
            this.panel_trip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_trip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltime;
    }
}