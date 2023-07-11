using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Security.Cryptography;
using System.IO;

namespace CRM
{
    public partial class SignInForm : Form
    {
        public StartingForm startform;
        public Point mouseLocation;
        bool checkifeyeison = false;
        public SignInForm()
        {
            InitializeComponent();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkifeyeison == false)
            {
                if (Passtextbox.UseSystemPasswordChar == true)
                {
                    Passtextbox.UseSystemPasswordChar = false;
                    Passrepeattextbox.UseSystemPasswordChar = false;
                    checkifeyeison = true;
                    eyepicturebox.BorderStyle = BorderStyle.Fixed3D;
                    return;

                }
            }
            if (checkifeyeison == true)
            {
                if (Passrepeattextbox.UseSystemPasswordChar == false)
                {
                    Passtextbox.UseSystemPasswordChar = true;
                    Passrepeattextbox.UseSystemPasswordChar = true;
                    checkifeyeison = false;
                    eyepicturebox.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void usernametextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1) //avoiding persian chars
            {
                e.Handled = true;
            }
        }

        private void Passtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void Passrepeattextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            mouseLocation = new Point(-e.X, -e.Y); //pointer set for movepannel(moving the form)
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            startform.Show();
        }

        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //avoiding dispose
            this.Hide();
            startform.Show();
        }

        private void emailadtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.icons8_back_arrow_48;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.back_arrow_white1;
        }

        private void submitbutton_MouseEnter(object sender, EventArgs e)
        {
            submitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            submitbutton.Font = new Font("Tahoma", 14, FontStyle.Bold);
            submitbutton.ForeColor = System.Drawing.Color.LightCyan;
        }

        private void submitbutton_MouseLeave(object sender, EventArgs e)
        {

            submitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            submitbutton.Font = new Font("Tahoma", 14, FontStyle.Bold);
            submitbutton.ForeColor = System.Drawing.Color.FromArgb(238, 195, 152);
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (nametxtbox.Text.Length == 0 || lastnametxtbox.Text.Length == 0 || usernametextbox.Text.Length == 0 || Passtextbox.Text.Length == 0 || Passrepeattextbox.Text.Length == 0 || emailtxtbox.Text.Length == 0)
            {
                MessageBox.Show("لطفا فیلد ها را خالی نگذارید", "خطا"); //avoiding empty fields
                return;
            }
            if (Passrepeattextbox.Text != Passtextbox.Text) //password match check
            {
                MessageBox.Show("رمزعبور تکرار شده با رمزعبور وارد شده تطابق ندارد ، لطفا آن را اصلاح کنید", "عدم تطابق رمزعبور");
                return;
            }
            else //code to insert field values into CRMDatabase.mdf
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string name = nametxtbox.Text;
                string lastname = lastnametxtbox.Text;
                string username = usernametextbox.Text;
                string password = Passtextbox.Text;
                string email = emailtxtbox.Text;
                string firstteachername = securityqtxtbox.Text;
                string query = "INSERT INTO Users(firstname , lastname , username , password , email , status , firstteachername) VALUES(N'" + name + "',N'" + lastname + "',N'" + username + "',N'" + password + "',N'" + email + "',N'active',N'" + firstteachername + "')";
                SqlCommand cmd = new SqlCommand(query, sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("حساب کاربری شما با موفقیت ساخته شد");
                nametxtbox.Text = "";
                lastnametxtbox.Text = "";
                Passtextbox.Text = "";
                Passrepeattextbox.Text = "";
                emailtxtbox.Text = "";
                securityqtxtbox.Text = "";
                this.Hide();
                startform.loginform.Show();
                return;

            }

        }
    }
}
