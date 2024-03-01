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

        private void button2_Enter(object sender, EventArgs e)
        {
            ResetButtonStyles();
            this.button2.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
        }

        private void button2_Leave(object sender, EventArgs e)
        {

        }
        private void button3_Enter_1(object sender, EventArgs e)
        {
            ResetButtonStyles();
            this.button3.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
        }

        private void button3_Leave_1(object sender, EventArgs e)
        {

        }


        private void ResetButtonStyles()
        {
            // function to reset styles when faculty or staff is clicked
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackColor = System.Drawing.SystemColors.Control;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Enter Email")
            {
                this.textBox1.Text = "";
                this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    this.textBox1.Text = "Enter Email";
                    this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
                }
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                this.textBox2.Text = "Enter Password";
                this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "Enter Password")
            {
                this.textBox2.Text = "";
                this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Enter(object sender, EventArgs e)
        {
            //this.label1.Font = new System.Drawing.Font(label1.Font, label1.Font.Style | FontStyle.Underline);
        }

        private void label1_Leave(object sender, EventArgs e)
        {
            //this.label1.Font = new System.Drawing.Font(label1.Font, label1.Font.Style | ~FontStyle.Underline);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.Font = new System.Drawing.Font(label1.Font, label1.Font.Style | FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.Font = new System.Drawing.Font(label1.Font, label1.Font.Style | ~FontStyle.Underline);
        }
    }
}
