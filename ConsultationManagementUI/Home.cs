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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            HomeUI homeUI = new HomeUI(this);
            this.Controls.Add(homeUI);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        { 
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void MakeApptButton_MouseLeave(object sender, EventArgs e)
        {
           

        }
    }
}
