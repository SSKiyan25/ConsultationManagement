﻿using ConsultationManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ConsultationManagementUI
{
    public partial class Step1Appointment : UserControl
    {
        public Step1Appointment()
        {
            InitializeComponent();
            FromTimePicker.CustomFormat = "HH:mm";
            
            
        }

        private void Step1Appointment_Load(object sender, EventArgs e)
        {
            

        }

        private void nextButton_MouseEnter(object sender, EventArgs e)
        {
            nextButton.BackColor = Color.FromArgb(141, 238, 155);
        }

        private void nextButton_MouseLeave(object sender, EventArgs e)
        {
            nextButton.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void nextButton_MouseClick(object sender, MouseEventArgs e)
        {
            Step2 step2 = new Step2();
            this.Controls.Clear();
            this.Controls.Add(step2);
        }
    }
}