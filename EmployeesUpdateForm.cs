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
    public partial class EmployeesUpdateForm : Form
    {
        public MainFormAdmin mainform;
        public Point mouseLocation;
        public EmployeesUpdateForm()
        {
            InitializeComponent();
        }

        private void EmployeesUpdateForm_Shown(object sender, EventArgs e)
        {
            nametextbox.Text = mainform.employeename;
        }

        private void submitchangesbtn_Click(object sender, EventArgs e)
        {
            if (mobilenumbertxtbox.Text.Length < 1 || roletxtbox.Text.Length < 1 || degreetxtbox.Text.Length < 1)
            {
                MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");
                return;
            }
            else
            {
                string mobilenumber = mobilenumbertxtbox.Text;
                string role = roletxtbox.Text;
                string degree = degreetxtbox.Text;

                string name = mainform.employeename;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string query = "UPDATE Employees SET mobilenumber='" + mobilenumber + "' , role=N'" + role + "' , degreeofeducation=N'" + degree + "' WHERE name=N'" + name + "'";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("تغییرات با موفقیت ثبت شد");
                mobilenumbertxtbox.Text = roletxtbox.Text = degreetxtbox.Text = nametextbox.Text = "";
                this.Hide();

            }
        }

        private void toppanelmove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void toppanelmove_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void backicon_MouseEnter(object sender, EventArgs e)
        {
            backicon.BackgroundImage = Properties.Resources.icons8_back_arrow_48;

        }

        private void backicon_MouseLeave(object sender, EventArgs e)
        {
            backicon.BackgroundImage = Properties.Resources.back_arrow_white1;

        }

        private void backicon_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void EmployeesUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            mainform.Show();
        }

        private void mobilenumbertxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
