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
    public partial class SignUpStep3 : Form
    {
        public SignUpStep3()
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

        private void SignUpStep3_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font, this.label1.Font.Style | System.Drawing.FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.Font = new Font(this.label1.Font, this.label1.Font.Style & ~System.Drawing.FontStyle.Underline);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.label3.Font = new Font(this.label1.Font, this.label3.Font.Style | FontStyle.Underline);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.label3.Font = new Font(this.label3.Font, this.label3.Font.Style & ~FontStyle.Underline);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Enter Code")
            {
                this.textBox1.Text = "";
                this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    this.textBox1.Text = "Enter Code";
                    this.textBox1.ForeColor = Color.Gray;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // page 1 button
            // needs condition so that i cant go to other forms if this form or forms before this hasn't filled yet
            SignUpStep1 s1 = new SignUpStep1();
            DialogResult result = s1.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // page 2 button
            // needs condition so that i cant go to other forms if this form or forms before this hasn't filled yet
            SignUpStep2 s2 = new SignUpStep2();
            DialogResult result = s2.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            DialogResult result = l1.ShowDialog();
            this.Hide();
        }
    }
}
