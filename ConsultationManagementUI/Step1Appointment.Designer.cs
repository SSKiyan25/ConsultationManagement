namespace ConsultationManagementUI
{
    partial class Step1Appointment
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
            this.PurposeComboBox = new System.Windows.Forms.ComboBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.FromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.ToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.VerificationLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateTimeBG = new System.Windows.Forms.PictureBox();
            this.studentIDtbDesign = new System.Windows.Forms.PictureBox();
            this.step1PictureBox = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentIDtbDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step1PictureBox)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PurposeComboBox
            // 
            this.PurposeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PurposeComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurposeComboBox.ForeColor = System.Drawing.Color.Gray;
            this.PurposeComboBox.FormattingEnabled = true;
            this.PurposeComboBox.IntegralHeight = false;
            this.PurposeComboBox.Location = new System.Drawing.Point(291, 305);
            this.PurposeComboBox.Name = "PurposeComboBox";
            this.PurposeComboBox.Size = new System.Drawing.Size(806, 26);
            this.PurposeComboBox.TabIndex = 35;
            this.PurposeComboBox.Text = "Enter name or Department";
            
            this.PurposeComboBox.Leave += new System.EventHandler(this.PurposeComboBox_Leave);
            this.PurposeComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PurposeComboBox_MouseClick);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.White;
            this.DateLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(288, 387);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(40, 16);
            this.DateLabel.TabIndex = 37;
            this.DateLabel.Text = "Date:";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "MMMM- dd - yyyy";
            this.DatePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(289, 403);
            this.DatePicker.MinimumSize = new System.Drawing.Size(45, 45);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(248, 45);
            this.DatePicker.TabIndex = 38;
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.CustomFormat = "hh:mm";
            this.FromTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FromTimePicker.Location = new System.Drawing.Point(594, 404);
            this.FromTimePicker.MinimumSize = new System.Drawing.Size(45, 45);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.ShowUpDown = true;
            this.FromTimePicker.Size = new System.Drawing.Size(183, 45);
            this.FromTimePicker.TabIndex = 39;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.BackColor = System.Drawing.Color.White;
            this.FromLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(591, 387);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(44, 16);
            this.FromLabel.TabIndex = 40;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.BackColor = System.Drawing.Color.White;
            this.ToLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(855, 388);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(26, 16);
            this.ToLabel.TabIndex = 42;
            this.ToLabel.Text = "To:";
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.CustomFormat = "hh:mm";
            this.ToTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ToTimePicker.Location = new System.Drawing.Point(858, 405);
            this.ToTimePicker.MinimumSize = new System.Drawing.Size(45, 45);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.ShowUpDown = true;
            this.ToTimePicker.Size = new System.Drawing.Size(183, 45);
            this.ToTimePicker.TabIndex = 41;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(893, 639);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(190, 64);
            this.nextButton.TabIndex = 44;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nextButton_MouseClick);
            this.nextButton.MouseEnter += new System.EventHandler(this.nextButton_MouseEnter);
            this.nextButton.MouseLeave += new System.EventHandler(this.nextButton_MouseLeave);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(284, 639);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(190, 64);
            this.backButton.TabIndex = 45;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(238)))), ((int)(((byte)(155)))));
            this.VerificationLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationLabel.Location = new System.Drawing.Point(610, 225);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(159, 22);
            this.VerificationLabel.TabIndex = 47;
            this.VerificationLabel.Text = "Select Schedule";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsultationManagementUI.Properties.Resources.roundRectangle;
            this.pictureBox1.Location = new System.Drawing.Point(503, 203);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // DateTimeBG
            // 
            this.DateTimeBG.Image = global::ConsultationManagementUI.Properties.Resources.datePicker;
            this.DateTimeBG.Location = new System.Drawing.Point(274, 380);
            this.DateTimeBG.Name = "DateTimeBG";
            this.DateTimeBG.Size = new System.Drawing.Size(838, 85);
            this.DateTimeBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DateTimeBG.TabIndex = 36;
            this.DateTimeBG.TabStop = false;
            // 
            // studentIDtbDesign
            // 
            this.studentIDtbDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentIDtbDesign.Image = global::ConsultationManagementUI.Properties.Resources.textboxDesign;
            this.studentIDtbDesign.Location = new System.Drawing.Point(274, 290);
            this.studentIDtbDesign.Name = "studentIDtbDesign";
            this.studentIDtbDesign.Size = new System.Drawing.Size(838, 60);
            this.studentIDtbDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentIDtbDesign.TabIndex = 33;
            this.studentIDtbDesign.TabStop = false;
            // 
            // step1PictureBox
            // 
            this.step1PictureBox.Image = global::ConsultationManagementUI.Properties.Resources.stepProcess;
            this.step1PictureBox.Location = new System.Drawing.Point(225, 113);
            this.step1PictureBox.Name = "step1PictureBox";
            this.step1PictureBox.Size = new System.Drawing.Size(937, 72);
            this.step1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.step1PictureBox.TabIndex = 31;
            this.step1PictureBox.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(15)))));
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1386, 69);
            this.topPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ConsultationManagementUI.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(45, -29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
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
            // Step1Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.VerificationLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ToTimePicker);
            this.Controls.Add(this.FromTimePicker);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.DateTimeBG);
            this.Controls.Add(this.PurposeComboBox);
            this.Controls.Add(this.studentIDtbDesign);
            this.Controls.Add(this.step1PictureBox);
            this.Controls.Add(this.topPanel);
            this.Name = "Step1Appointment";
            this.Size = new System.Drawing.Size(1386, 788);
            this.Load += new System.EventHandler(this.Step1Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentIDtbDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step1PictureBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox step1PictureBox;
        private System.Windows.Forms.PictureBox studentIDtbDesign;
        private System.Windows.Forms.ComboBox PurposeComboBox;
        private System.Windows.Forms.PictureBox DateTimeBG;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker FromTimePicker;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.DateTimePicker ToTimePicker;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label VerificationLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
