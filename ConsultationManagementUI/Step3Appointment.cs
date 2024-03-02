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
    public partial class Step3Appointment : UserControl
    {
        public Home Home;
        public Step3Appointment(Home home)
        {
            InitializeComponent();
            this.Home = home;
        }

        private void HomeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home.Controls.Clear();
            HomeUI homeUI = new HomeUI(Home);
            Home.Controls.Add(homeUI);
        }
    }
}
