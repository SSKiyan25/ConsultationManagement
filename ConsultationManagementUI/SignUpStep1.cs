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
    public partial class SignUpStep1 : Form
    {
        public SignUpStep1()
        {
            InitializeComponent();
            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(tableLayoutPanel2);
            SetDoubleBuffered(tableLayoutPanel3);
            SetDoubleBuffered(tableLayoutPanel4);
            SetDoubleBuffered(tableLayoutPanel5);
            SetDoubleBuffered(tableLayoutPanel6);
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Email Address*")
            {
                this.textBox1.Text = "";
                this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText; // Set the color back to normal text color
            }
        }



        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "Password*")
            {
                this.textBox2.Text = "";
                this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (this.textBox3.Text == "Confirm Password")
            {
                this.textBox3.Text = "";
                this.textBox3.ForeColor = System.Drawing.SystemColors.ControlText; // Set the color back to normal text color
            }
        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                this.textBox1.Text = "Email Address*";
                this.textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                this.textBox2.Text = "Password*";
                this.textBox2.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                this.textBox3.Text = "Confirm Password";
                this.textBox3.ForeColor = System.Drawing.Color.Gray;
            }
        }


        private void tableLayoutPanel2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
           this.label2.Font = new System.Drawing.Font(label2.Font, label1.Font.Style | FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.label2.Font = new System.Drawing.Font(label2.Font, label1.Font.Style & ~FontStyle.Underline);
        }

        private void SignUpStep1_Load(object sender, EventArgs e)
        {

        }
    }
}
