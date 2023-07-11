using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class ProductsUpdateForm : Form
    {
        public MainFormAdmin mainform;
        public Point mouseLocation;
        public ProductsUpdateForm()
        {
            InitializeComponent();
        }

        private void ProductsUpdateForm_Shown(object sender, EventArgs e)
        {
            nametextbox.Text = mainform.producttname;
        }

        private void submitchangesbtn_Click(object sender, EventArgs e)
        {
            if (sellpricetextbox.Text.Length < 1 || buypricetextbox.Text.Length < 1 || quantitystocktextbox.Text.Length < 1)
            {
                MessageBox.Show("لطفا تمامی فیلد ها را پر کنید");
                return;
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string name = nametextbox.Text;
                string productnewsellprice = sellpricetextbox.Text;
                string productnewbuyprice = buypricetextbox.Text;
                string productnewquantity = quantitystocktextbox.Text;
                string query = "UPDATE Products SET productbuyprice=N'" + productnewbuyprice + "' , productsellprice=N'" + productnewsellprice + "' , quantityinstock=N'" + productnewquantity + "' WHERE productname=N'" + name + "'";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تغییرات با موفقیت ثبت شد");
                sellpricetextbox.Text = buypricetextbox.Text = quantitystocktextbox.Text = nametextbox.Text = "";
                mainform.ProductsUPDinfoPNL.Visible = false;
                mainform.ProductsUpdateComboboxLoader();
                this.Hide();
                sc.Close();
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

        private void backicon_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void backicon_MouseEnter(object sender, EventArgs e)
        {
            backicon.BackgroundImage = Properties.Resources.icons8_back_arrow_48;

        }

        private void backicon_MouseLeave(object sender, EventArgs e)
        {
            backicon.BackgroundImage = Properties.Resources.back_arrow_white1;

        }

        private void ProductsUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void sellpricetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buypricetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void quantitystocktextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
