using ConsultationManagementUI.Properties;
using System;
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
    public partial class Step2 : UserControl
    {
        public Home Home;
        public Step2(Home home)
        {
            InitializeComponent();
            this.Home = home;
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
            Step3Appointment step3 = new Step3Appointment(Home);
            Home.Controls.Clear();
            Home.Controls.Add(step3);
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
            Step1Appointment step1 = new Step1Appointment(Home);
            Home.Controls.Clear();
            Home.Controls.Add(step1);
        }
    }
}
