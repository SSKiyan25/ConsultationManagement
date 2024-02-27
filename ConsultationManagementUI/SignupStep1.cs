using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultationManagementUI
{
    public partial class SignupStep1 : Form
    {
        public SignupStep1()
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Email Address*")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password*")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.ControlText; // Set the color back to normal text color
            }
        }



        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Confirm Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = SystemColors.ControlText; // Set the color back to normal text color
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Email Address*";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    textBox2.Text = "Password*";
                    textBox2.ForeColor = Color.Gray;
                }
            }

        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    textBox3.Text = "Confirm Password";
                    textBox3.ForeColor = Color.Gray;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
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
            label2.Font = new Font(label2.Font, label1.Font.Style | FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, label1.Font.Style & ~FontStyle.Underline);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignupStep2 s2 = new SignupStep2();
            DialogResult result = s2.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // page 2 button
            // needs condition so that i cant go to other forms if this form or forms before this hasn't filled yet
            SignupStep2 s2 = new SignupStep2();
            DialogResult result = s2.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // page 2 button
            // needs condition so that i cant go to other forms if this form or forms before this hasn't filled yet
            SignupStep3 s3 = new SignupStep3();
            DialogResult result = s3.ShowDialog();
            this.Hide();
        }
    }
}

