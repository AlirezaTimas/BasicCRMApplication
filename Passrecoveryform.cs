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
    public partial class Passrecoveryform : Form
    {
        public Point mouseLocation;
        public LoginForm loginform;
        public Passrecoveryform()
        {
            InitializeComponent();
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

        private void returnpicturebox_MouseEnter(object sender, EventArgs e)
        {
            returnpicturebox.BackgroundImage = Properties.Resources.icons8_back_arrow_48;
        }

        private void returnpicturebox_MouseLeave(object sender, EventArgs e)
        {
            returnpicturebox.BackgroundImage = Properties.Resources.back_arrow_white1;
        }

        private void returnpicturebox_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform.Show();
        }

        private void Passrecoveryform_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            loginform.Show();
        }

        private void Passrecoveryform_Load(object sender, EventArgs e)
        {
            forgotcombobox.Items.Add("ایمیل");
            forgotcombobox.Items.Add("رمزعبور");
            label1.Select();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (forgotcombobox.Text == "ایمیل")
            {
                tobelabel.Text = "رمزعبوری که به یاد دارید را وارد کنید";
                securitylabel.Text = "نام اولین معلم شما چیست؟";
                tobelabel.Visible = true;
                textbox.Visible = true;
                Searchbutton.Visible = true;
                securitylabel.Visible = true;
                securityqtxtbox.Visible = true;
                textbox.Text = "";
                securityqtxtbox.Text = "";
                return;
            }
            if (forgotcombobox.Text == "رمزعبور")
            {
                tobelabel.Text = "ایمیلی که به یاد دارید را وارد کنید";
                securitylabel.Text = "نام اولین معلم شما چیست؟";
                tobelabel.Visible = true;
                textbox.Visible = true;
                Searchbutton.Visible = true;
                securitylabel.Visible = true;
                securityqtxtbox.Visible = true;
                textbox.Text = "";
                securityqtxtbox.Text = "";
                return;
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT email , password , username , status ,firstteachername FROM Users";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            if (textbox.Text.Length < 1 || securityqtxtbox.Text.Length < 1)
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را کامل کنید");
                return;
            }
            if (forgotcombobox.Text == "ایمیل")
            {
                while (reader.Read())
                {
                    string password = reader["password"].ToString();
                    if (password == textbox.Text)
                    {
                        string firstteachername = reader["firstteachername"].ToString();
                        string email = reader["email"].ToString();
                        string status = reader["status"].ToString();
                        string username = reader["username"].ToString();
                        if (firstteachername == securityqtxtbox.Text)
                        {
                            if (status == "active")
                            {
                                MessageBox.Show("جزییات حساب شما \n" + "Username: " + username + "\nPassword: " + password + "\nEmail: " + email + "");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("حساب شما غیرفعال است ، جهت فعالسازی با پشتیبانی تماس بگیرید");
                                return;
                            }
                        }
                        else
                            continue;
                    }
                    else
                        continue;

                }
                MessageBox.Show("حساب کاربری با این مشخصات موجود نمیباشد ، اگر از صحت اطلاعات وارد شده اطمینان دارید با پشتیبانی تماس بگیرید");
                return;
            }
            if (forgotcombobox.Text == "رمزعبور")
            {
                while (reader.Read())
                {
                    string email = reader["email"].ToString();
                    if (email == textbox.Text)
                    {
                        string firstteachername = reader["firstteachername"].ToString();
                        string password = reader["password"].ToString();
                        string username = reader["username"].ToString();
                        string status = reader["status"].ToString();
                        if (firstteachername == securityqtxtbox.Text)
                        {
                            if (status == "active")
                            {
                                MessageBox.Show("جزییات حساب شما \n" + "Username: " + username + "\nPassword:" + password + "\nEmail:" + email + "");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("حساب شما غیرفعال است ، جهت فعالسازی با پشتیبانی تماس بگیرید");
                                return;
                            }
                        }
                        else
                            continue;
                    }
                    else
                        continue;
                }
                MessageBox.Show("حساب کاربری با این مشخصات موجود نمیباشد ، اگر از صحت اطلاعات وارد شده اطمینان دارید با پشتیبانی تماس بگیرید");
                return;
            }

            sc.Close();
        }

        private void Searchbutton_MouseEnter(object sender, EventArgs e)
        {

            Searchbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            Searchbutton.Font = new Font("Tahoma", 14, FontStyle.Bold);
            Searchbutton.ForeColor = System.Drawing.Color.LightCyan;
        }

        private void Searchbutton_MouseLeave(object sender, EventArgs e)
        {

            Searchbutton.Font = new Font("Tahoma", 14, FontStyle.Bold);
            Searchbutton.ForeColor = System.Drawing.Color.FromArgb(238, 195, 152);
        }
    }
}
