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
    public partial class HomeUI : UserControl
    {
        public Home Home;
        public HomeUI(Home home)
        {
            InitializeComponent();
            Home = home;
        }

        private void MakeApptButton_MouseEnter(object sender, EventArgs e)
        {
            MakeApptButton.BackColor = Color.FromArgb(0, 102, 15);
            //MakeApptButton.ForeColor = Color.Black;
        }

        private void MakeApptButton_MouseLeave(object sender, EventArgs e)
        {

            MakeApptButton.BackColor = Color.FromArgb(83, 163, 94);
            MakeApptButton.ForeColor = Color.White;
        }

        private void MakeApptButton_MouseClick(object sender, MouseEventArgs e)
        {
            Step1Appointment step1 = new Step1Appointment(Home);
            Home.Controls.Clear();
            Home.Controls.Add(step1);
        }
    }
}
