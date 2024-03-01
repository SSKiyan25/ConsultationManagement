namespace ConsultationManagementUI
{
    partial class HomeUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUI));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ConsultationAppointmentLabel = new System.Windows.Forms.Label();
            this.facultyAndStaffLabel = new System.Windows.Forms.Label();
            this.MakeApptButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1386, 69);
            this.topPanel.TabIndex = 3;
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
            // ConsultationAppointmentLabel
            // 
            this.ConsultationAppointmentLabel.AutoSize = true;
            this.ConsultationAppointmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConsultationAppointmentLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultationAppointmentLabel.ForeColor = System.Drawing.Color.White;
            this.ConsultationAppointmentLabel.Location = new System.Drawing.Point(78, 289);
            this.ConsultationAppointmentLabel.Name = "ConsultationAppointmentLabel";
            this.ConsultationAppointmentLabel.Size = new System.Drawing.Size(944, 115);
            this.ConsultationAppointmentLabel.TabIndex = 6;
            this.ConsultationAppointmentLabel.Text = "CONSULTATION APPOINTMENT";
            // 
            // facultyAndStaffLabel
            // 
            this.facultyAndStaffLabel.AutoSize = true;
            this.facultyAndStaffLabel.BackColor = System.Drawing.Color.Transparent;
            this.facultyAndStaffLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyAndStaffLabel.ForeColor = System.Drawing.Color.White;
            this.facultyAndStaffLabel.Location = new System.Drawing.Point(78, 188);
            this.facultyAndStaffLabel.Name = "facultyAndStaffLabel";
            this.facultyAndStaffLabel.Size = new System.Drawing.Size(647, 115);
            this.facultyAndStaffLabel.TabIndex = 5;
            this.facultyAndStaffLabel.Text = "FACULTY AND STAFF";
            // 
            // MakeApptButton
            // 
            this.MakeApptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeApptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(163)))), ((int)(((byte)(94)))));
            this.MakeApptButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(238)))), ((int)(((byte)(155)))));
            this.MakeApptButton.FlatAppearance.BorderSize = 0;
            this.MakeApptButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeApptButton.ForeColor = System.Drawing.Color.White;
            this.MakeApptButton.Location = new System.Drawing.Point(476, 481);
            this.MakeApptButton.Name = "MakeApptButton";
            this.MakeApptButton.Size = new System.Drawing.Size(435, 120);
            this.MakeApptButton.TabIndex = 7;
            this.MakeApptButton.Text = "Make Appointment";
            this.MakeApptButton.UseVisualStyleBackColor = false;
            this.MakeApptButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MakeApptButton_MouseClick);
            this.MakeApptButton.MouseEnter += new System.EventHandler(this.MakeApptButton_MouseEnter);
            this.MakeApptButton.MouseLeave += new System.EventHandler(this.MakeApptButton_MouseLeave);
            // 
            // HomeUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.MakeApptButton);
            this.Controls.Add(this.ConsultationAppointmentLabel);
            this.Controls.Add(this.facultyAndStaffLabel);
            this.Controls.Add(this.topPanel);
            this.DoubleBuffered = true;
            this.Name = "HomeUI";
            this.Size = new System.Drawing.Size(1386, 788);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logo;
        public System.Windows.Forms.Label ConsultationAppointmentLabel;
        public System.Windows.Forms.Label facultyAndStaffLabel;
        public System.Windows.Forms.Button MakeApptButton;
    }
}
