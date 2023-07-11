using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class StartingForm : Form
    {
        public Point mouseLocation;
        public SplashSCRfrm splashscrfrm;
        public SignInForm signInForm = new SignInForm();
        exitconfirmform exitform = new exitconfirmform();
        public LoginForm loginform;

        public StartingForm()
        {
            InitializeComponent();
            signInForm.startform = this;
            exitform.startingform = this;

        }

        private void move_pannel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void move_pannel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            exitform.Show();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.x_mark_red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.x_white;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button2.ForeColor = Color.Green;
            button2.Font = new Font("Tahoma", 16, FontStyle.Bold);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(238, 195, 152);
            button2.Font = new Font("Tahoma", 14, FontStyle.Bold);
        }

        private void StartingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            exitform.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
