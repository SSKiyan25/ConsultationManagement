namespace ConsultationManagementUI
{
    partial class Step3Appointment
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.step2PictureBox = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.step2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1386, 69);
            this.topPanel.TabIndex = 1;
            // 
            // step2PictureBox
            // 
            this.step2PictureBox.Image = global::ConsultationManagementUI.Properties.Resources.stepProcess2;
            this.step2PictureBox.Location = new System.Drawing.Point(225, 113);
            this.step2PictureBox.Name = "step2PictureBox";
            this.step2PictureBox.Size = new System.Drawing.Size(937, 72);
            this.step2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.step2PictureBox.TabIndex = 31;
            this.step2PictureBox.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::ConsultationManagementUI.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(45, -30);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(238, 134);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsultationManagementUI.Properties.Resources.imageListBackground;
            this.pictureBox1.Location = new System.Drawing.Point(225, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Step3Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.step2PictureBox);
            this.Controls.Add(this.topPanel);
            this.Name = "Step3Appointment";
            this.Size = new System.Drawing.Size(1386, 788);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.step2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox step2PictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
