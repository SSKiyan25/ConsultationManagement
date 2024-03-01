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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(tableLayoutPanel2);
            SetDoubleBuffered(tableLayoutPanel3);
            SetDoubleBuffered(tableLayoutPanel4);
            SetDoubleBuffered(tableLayoutPanel5);
        }
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            // Check if the application is running in a Terminal Server session
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            // Use reflection to access the non-public "DoubleBuffered" property of the control
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);

            // Check if the property was found before dereferencing
            if (aProp != null)
            {
                // Set the "DoubleBuffered" property to true
                aProp.SetValue(c, true, null);
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
    }
}
