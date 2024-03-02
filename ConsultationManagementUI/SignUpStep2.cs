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
    public partial class SignUpStep2 : Form
    {
        public SignUpStep2()
        {
            InitializeComponent();
            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(tableLayoutPanel2);
            SetDoubleBuffered(tableLayoutPanel3);
            SetDoubleBuffered(tableLayoutPanel4);
            SetDoubleBuffered(tableLayoutPanel5);
            SetDoubleBuffered(tableLayoutPanel6);
            SetDoubleBuffered(tableLayoutPanel7);
            SetDoubleBuffered(tableLayoutPanel8);
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

        private void SignUpStep2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetButtonStyles();
            this.button1.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetButtonStyles();
            this.button2.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
        }

        private void ResetButtonStyles()
        {
            // function to reset styles when faculty or staff is clicked
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackColor = System.Drawing.SystemColors.Control;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "First Name*")
            {
                this.textBox1.Text = "";
                this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "Last Name*")
            {
                this.textBox2.Text = "";
                this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    this.textBox2.Text = "Last Name*";
                    this.textBox2.ForeColor = Color.Gray;
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    this.textBox1.Text = "First Name*";
                    this.textBox1.ForeColor = Color.Gray;
                }
            }
        }

        private void label2_Enter(object sender, EventArgs e)
        {
            //this.label2.Font = new Font(this.label2.Font, this.label2.Font.Style | System.Drawing.FontStyle.Underline);
        }

        private void label2_Leave(object sender, EventArgs e)
        {
            //this.label2.Font = new Font(label2.Font, label2.Font.Style & ~FontStyle.Underline);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.label2.Font = new Font(this.label2.Font, this.label2.Font.Style | System.Drawing.FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.label2.Font = new System.Drawing.Font(this.label2.Font, this.label2.Font.Style & ~System.Drawing.FontStyle.Underline);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // page 1 button
            // needs condition so that i cant go to other forms if this form hasn't filled yet
            SignUpStep1 s1 = new SignUpStep1();
            DialogResult result = s1.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // page 3 button
            // needs condition so that i cant go to other forms if this form / forms before this hasn't filled yet
            SignUpStep3 s3 = new SignUpStep3();
            DialogResult result = s3.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUpStep3 s3 = new SignUpStep3();
            DialogResult result = s3.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            DialogResult result = l1.ShowDialog();
            this.Hide();
        }
    }
}
