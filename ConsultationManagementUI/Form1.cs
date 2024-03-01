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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Step2 step2 = new Step2();
            Step1Appointment step1 = new Step1Appointment();
            Step1Continuation step11 = new Step1Continuation();
            Step3Appointment step3 = new Step3Appointment();
            this.Controls.Add(step1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Log-In 
            var db = FirestoreHelper.Database;
            var data = GetWriteData();
            DocumentReference docRef = db.Collection("UserData").Document(data.Username);
            docRef.SetAsync(data);
            MessageBox.Show("Success");
        }

        private UserData GetWriteData()
        {
            string username = textBox1.Text;
            return new UserData()
            {
                Username = username,
            };
        }
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
