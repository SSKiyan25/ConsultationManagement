﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultationManagementUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Step2 step2 = new Step2();
            Step1Appointment step1 = new Step1Appointment();
            this.Controls.Add(step1);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
