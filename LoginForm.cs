using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class LoginForm : Form
    {
        public StartingForm startingform;
        public Passrecoveryform passrecoveryform;
        public MainFormAdmin Mainformadmin;
        bool checkifeyeison = false;
        public Point mouseLocation;


        public LoginForm()
        {
            InitializeComponent();
            label1.Select();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (emailtxtbox.Text.Length < 1 || passtxtbox.Text.Length < 1)
            {
                MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "خطا");
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string query = "SELECT email , password , status FROM Users";
                SqlCommand cmd = new SqlCommand(query, sc);
                sc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string email = reader["email"].ToString();
                    if (email == emailtxtbox.Text)
                    {
                        string password = reader["password"].ToString();
                        if (password == passtxtbox.Text)
                        {
                            string status = reader["status"].ToString();
                            if (status == "active")
                            {
                                MessageBox.Show("ورود موفقیت آمیز بود ، خوش آمدید", "");
                                this.Hide();
                                Mainformadmin.Show();
                                return;
                            }
                            else
                                MessageBox.Show("حساب کاربری شما غیرفعال است");
                            return;
                        }
                        else
                            MessageBox.Show("رمزعبور اشتباه است");
                        return;
                    }
                    else
                        continue;
                }
                MessageBox.Show("ایمیل وارد شده اشتباه است یا حساب کاربری با این ایمیل وجود ندارد");
                sc.Close();
            }

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.icons8_back_arrow_48;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.back_arrow_white1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            startingform.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            EnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            EnterButton.Font = new Font("Tahoma", 14, FontStyle.Bold);
            EnterButton.ForeColor = System.Drawing.Color.LightCyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            EnterButton.Font = new Font("Tahoma", 14, FontStyle.Bold);
            EnterButton.ForeColor = System.Drawing.Color.FromArgb(238, 195, 152);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkifeyeison == false)
            {
                if (passtxtbox.UseSystemPasswordChar == true)

                    passtxtbox.UseSystemPasswordChar = false;
                checkifeyeison = true;
                pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                return;

            }

            if (checkifeyeison == true)
            {
                if (passtxtbox.UseSystemPasswordChar == false)
                {
                    passtxtbox.UseSystemPasswordChar = true;
                    checkifeyeison = false;
                    pictureBox2.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void emailtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void passtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            startingform.signInForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            startingform.Show();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            passrecoveryform.Show();
        }
    }

}
