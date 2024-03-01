namespace ConsultationManagementUI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.facultyAndStaffLabel = new System.Windows.Forms.Label();
            this.ConsultationAppointmentLabel = new System.Windows.Forms.Label();
            this.MakeApptButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1544, 69);
            this.topPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsultationManagementUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(45, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(45, -30);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(238, 134);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // facultyAndStaffLabel
            // 
            this.facultyAndStaffLabel.AutoSize = true;
            this.facultyAndStaffLabel.BackColor = System.Drawing.Color.Transparent;
            this.facultyAndStaffLabel.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyAndStaffLabel.ForeColor = System.Drawing.Color.White;
            this.facultyAndStaffLabel.Location = new System.Drawing.Point(63, 212);
            this.facultyAndStaffLabel.Name = "facultyAndStaffLabel";
            this.facultyAndStaffLabel.Size = new System.Drawing.Size(343, 43);
            this.facultyAndStaffLabel.TabIndex = 3;
            this.facultyAndStaffLabel.Text = "FACULTY AND STAFF";
            // 
            // ConsultationAppointmentLabel
            // 
            this.ConsultationAppointmentLabel.AutoSize = true;
            this.ConsultationAppointmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConsultationAppointmentLabel.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultationAppointmentLabel.ForeColor = System.Drawing.Color.White;
            this.ConsultationAppointmentLabel.Location = new System.Drawing.Point(63, 281);
            this.ConsultationAppointmentLabel.Name = "ConsultationAppointmentLabel";
            this.ConsultationAppointmentLabel.Size = new System.Drawing.Size(491, 43);
            this.ConsultationAppointmentLabel.TabIndex = 4;
            this.ConsultationAppointmentLabel.Text = "CONSULTATION APPOINTMENT";
            // 
            // MakeApptButton
            // 
            this.MakeApptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(238)))), ((int)(((byte)(155)))));
            this.MakeApptButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(238)))), ((int)(((byte)(155)))));
            this.MakeApptButton.FlatAppearance.BorderSize = 0;
            this.MakeApptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeApptButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeApptButton.ForeColor = System.Drawing.Color.White;
            this.MakeApptButton.Location = new System.Drawing.Point(400, 361);
            this.MakeApptButton.Name = "MakeApptButton";
            this.MakeApptButton.Size = new System.Drawing.Size(193, 55);
            this.MakeApptButton.TabIndex = 5;
            this.MakeApptButton.Text = "Make Appointment";
            this.MakeApptButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(238)))), ((int)(((byte)(155)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(238)))), ((int)(((byte)(155)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(400, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Make Appointment";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MakeApptButton);
            this.Controls.Add(this.ConsultationAppointmentLabel);
            this.Controls.Add(this.facultyAndStaffLabel);
            this.Controls.Add(this.topPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label facultyAndStaffLabel;
        private System.Windows.Forms.Label ConsultationAppointmentLabel;
        private System.Windows.Forms.Button MakeApptButton;
        private System.Windows.Forms.Button button1;
    }
}