using ConsultationManagementUI;
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
    public partial class SignupStep2 : Form
    {
        public SignupStep2()
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
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
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



        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            DialogResult result = l1.ShowDialog();
            this.Hide();
        }



        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Underline);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "First Name*")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Last Name*")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = "First Name*";
                    textBox1.ForeColor = Color.Gray;
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    textBox2.Text = "Last Name*";
                    textBox2.ForeColor = Color.Gray;
                }
            }
        }


        private void tableLayoutPanel4_Leave(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ResetButtonStyles();
            button1.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetButtonStyles();
            button2.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonStyles();
            button1.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonStyles();
            button2.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void ResetButtonStyles()
        {
            // function to reset styles when faculty or staff is clicked
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignupStep3 s3 = new SignupStep3();
            DialogResult result = s3.ShowDialog();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // page 1 button
            // needs condition so that i cant go to other forms if this form hasn't filled yet
            SignupStep1 s1 = new SignupStep1();
            DialogResult result = s1.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // page 3 button
            // needs condition so that i cant go to other forms if this form / forms before this hasn't filled yet
            SignupStep3 s3 = new SignupStep3();
            DialogResult result = s3.ShowDialog();
            this.Hide();
        }
    }
}





