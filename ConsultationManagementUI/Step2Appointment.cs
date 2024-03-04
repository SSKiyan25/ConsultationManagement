﻿using ConsultationManagement;
using ConsultationManagementUI.Properties;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultationManagement;

namespace ConsultationManagementUI
{
    public partial class Step2 : UserControl
    {
        public Step2()
        {
            InitializeComponent();
            
        }

        private void nextButton_MouseEnter(object sender, EventArgs e)
        {
            nextButton.BackColor = Color.FromArgb(141, 238, 155);
        }

        private void nextButton_MouseLeave(object sender, EventArgs e)
        {
            nextButton.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void Step2_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_MouseClick(object sender, MouseEventArgs e)
        {
            Step3Appointment step3 = new Step3Appointment();
            this.Controls.Clear();
            this.Controls.Add(step3);

            Request request = new Request();
            var db = FirestoreHelper.Database;
            DocumentReference requestDocRef = db.Collection("RequestData").Document(request.RequestID.ToString());
            Dictionary<string, object> requestField = new Dictionary<string, object>
            {
                {"Name", },
                {"", },
                {"", },
                {"", },
                {"", },
                {"", },
                {"", },
            };
            await requestDocRef.SetAsync(requestDocRef);
        }

        private void prevButton_MouseEnter(object sender, EventArgs e)
        {
            prevButton.BackColor = Color.FromArgb(141, 238, 155);
        }

        private void prevButton_MouseLeave(object sender, EventArgs e)
        {
            prevButton.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void prevButton_MouseClick(object sender, MouseEventArgs e)
        {
            Step1Appointment step1 = new Step1Appointment();
            this.Controls.Clear();
            this.Controls.Add(step1);
        }
    }
}
