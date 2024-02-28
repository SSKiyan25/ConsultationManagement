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
            System.Reflection.PropertyInfo? aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Underline);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SignupStep1 s1 = new SignupStep1();
            DialogResult result = s1.ShowDialog();
            this.Hide();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonStyles();
            button2.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonStyles();
            button3.BackColor = Color.FromArgb(192, 255, 192);
        }


        private void ResetButtonStyles()
        {
            // function to reset styles when faculty or staff is clicked
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Password")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.ControlText; // Set the color back to normal text color
            }


        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Email")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.ControlText; // Set the color back to normal text color
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter Password";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Enter Email";
                textBox2.ForeColor = Color.DarkGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignupStep1 s1 = new SignupStep1();
            DialogResult result = s1.ShowDialog();
            this.Hide();
        }
    }
}
