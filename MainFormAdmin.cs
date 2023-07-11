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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CRM
{
    public partial class MainFormAdmin : Form
    {
        //note : these forms are linked in SplashScreen Form
        public CustomerUpdateForm customerupdateform;
        public EmployeesUpdateForm employeeupdateform;
        public ProductsUpdateForm productsupdateform;
        public FullExitConfirmMainForm fullexitform;
        public LoginForm loginform;
        public MainFormAdmin()
        {
            InitializeComponent();

        }
        //booleans to control panels visibility
        //------------------------------------- Dashboard
        bool dashbordvisible = true;
        //------------------------------------- customers
        bool customeraddvisible = false;
        bool customerdelvisible = false;
        bool customerlistvisible = false;
        bool customerupdatevisible = false;
        //------------------------------------- employees
        bool employeeaddvisible = false;
        bool employeedelvisible = false;
        bool employeelistvisible = false;
        bool employeeupdatevisible = false;
        //------------------------------------- products
        bool productaddvisible = false;
        bool productdelvisible = false;
        bool productlistvisible = false;
        bool productsupdatevisible = false;
        //------------------------------------- deals
        bool dealsaddvisible = false;
        bool dealsdelvisible = false;
        bool dealslistvisible = false;
        //------------------------------------- booleans to control different panel groups (menu opening & closing) / used by timers
        bool customerPanelopened = false;
        bool productPanelopened = false;
        bool employeePanelopened = false;
        bool dealsPanelopened = false;
        bool exitPanelopened = false;
        bool menuopened = false;

        public string customername = ""; //used to save customer name in order to pass it between this form and customerupdate form
        public string employeename = ""; //used to save employee name in order to pass it between this form and employeeupdate form
        public string producttname = ""; //used to save products name in order to pass it between this form and productsupdate form



        public Point mouseLocation;
        private void menuOpener_Tick(object sender, EventArgs e)
        {
            if (customerPanelopened == false)
            {
                customersgroupPNL.Height += 10;
                if (customersgroupPNL.Height >= 260)
                {
                    customermenuOpener.Stop();
                    customerPanelopened = true;
                }
            }
            else
            {
                customersgroupPNL.Height -= 10;
                if (customersgroupPNL.Height <= 47)
                {
                    customermenuOpener.Stop();
                    customerPanelopened = false;
                }
            }
        }

        private void customerbtnmain_Click(object sender, EventArgs e)
        {
            if (exitPanelopened)
            {
                exitmenuOpener.Start();
            }
            if (productPanelopened)
            {
                productmenuOpener.Start();
            }
            if (employeePanelopened)
            {
                employeesmenuOpener.Start();
            }
            if (dealsPanelopened)
            {
                dealsmenuOpener.Start();
            }
            customermenuOpener.Start();
        }

        private void productsmainbtn_Click(object sender, EventArgs e) //productsmainbutton 
        {
            if (exitPanelopened)
            {
                exitmenuOpener.Start();
            }
            if (customerPanelopened)
            {
                customermenuOpener.Start();
            }
            if (employeePanelopened)
            {
                employeesmenuOpener.Start();
            }
            if (dealsPanelopened)
            {
                dealsmenuOpener.Start();
            }
            productmenuOpener.Start();
        }

        private void productmenoOpener_Tick(object sender, EventArgs e)
        {

            if (productPanelopened == false)
            {
                productsgroupPNL.Height += 10;
                if (productsgroupPNL.Height >= 260)
                {
                    productmenuOpener.Stop();
                    productPanelopened = true;
                }
            }
            else
            {
                productsgroupPNL.Height -= 10;
                if (productsgroupPNL.Height <= 47)
                {
                    productmenuOpener.Stop();
                    productPanelopened = false;
                }
            }
        }

        private void menupic_Click(object sender, EventArgs e)
        {
            menuexpand.Start();
            if (menuopened == false)
            {
                menupic.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                menupic.BorderStyle = BorderStyle.None;
            }
        }

        private void menuexpand_Tick(object sender, EventArgs e)
        {
            if (menuopened == false)
            {
                sidepanel.Width += 10;
                if (sidepanel.Width >= 202)
                {
                    menuexpand.Stop();
                    menuopened = true;
                    menupic.BorderStyle = BorderStyle.Fixed3D;
                }
            }
            else
            {
                sidepanel.Width -= 10;
                if (sidepanel.Width <= 0)
                {
                    menuexpand.Stop();
                    menuopened = false;
                    menupic.BorderStyle = BorderStyle.None;
                }
            }
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customeraddbtn_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = true;
            customerdelvisible = false;
            CustomerAddPNL.Visible = true;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();

        }

        private void CustomerAddPNL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametextbox.Text.Length < 1 || mobilenumbertxtbox.Text.Length < 1 || emailtxtbox.Text.Length < 1 || companytxtbox.Text.Length < 1 || addresstxtbox.Text.Length < 1 || dobtextbox.Text.Length < 1)
            {
                MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "فیلد ها را خالی نگذارید");
                return;
            }
            else
            {
                string name = nametextbox.Text;
                string mobile = mobilenumbertxtbox.Text;
                string email = emailtxtbox.Text;
                string company = companytxtbox.Text;
                string address = addresstxtbox.Text;
                string dob = dobtextbox.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string query = "SELECT name FROM Customers";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string selectorname = reader["name"].ToString();
                    if (selectorname == name)
                    {
                        MessageBox.Show("مشتری با این نام قبلا اضافه شده است");
                        return;
                    }
                    else
                        continue;
                }
                sc.Close();

                string active = "active";
                SqlConnection sc2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string query2 = "INSERT INTO Customers(name,mobilenumber,email,companyname,address,dateofbirth,status) VALUES(N'" + name + "', N'" + mobile + "', N'" + email + "', N'" + company + "', N'" + address + "' , N'" + dob + "' , N'" + active + "')";
                sc2.Open();
                SqlCommand cmd2 = new SqlCommand(query2, sc2);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("مشتری با موفقیت اضافه شد");
                nametextbox.Text = emailtxtbox.Text = companytxtbox.Text = mobilenumbertxtbox.Text = addresstxtbox.Text = dobtextbox.Text = "";
                sc2.Close();

                return;
            }

        }

        private void customerdelbtn_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = true;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = true;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            menuexpand.Start();
            CustomerDeleteComboboxLoader(); //function to add names into Combobox


        }

        public void CustomerDeleteComboboxLoader()
        {
            SqlConnection conntoDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string selectorquery = "SELECT name,status FROM Customers";
            conntoDB.Open();
            SqlCommand cmd = new SqlCommand(selectorquery, conntoDB);
            SqlDataReader selectorreader = cmd.ExecuteReader();
            customerdeletecombobox.Items.Clear();
            while (selectorreader.Read())
            {
                string name = selectorreader["name"].ToString();
                string status = selectorreader["status"].ToString();
                if (status == "active")
                {
                    customerdeletecombobox.Items.Add(name);
                }
                else
                    continue;
            }
            conntoDB.Close();
        }

        private void customerdeletecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerInfoPNL.Visible = true;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Customers";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                if (name == customerdeletecombobox.Text)
                {
                    string mobile = reader["mobilenumber"].ToString();
                    string email = reader["email"].ToString();
                    string companyname = reader["companyname"].ToString();
                    string address = reader["address"].ToString();

                    namelbl.Text = name;
                    mobilelbl.Text = mobile;
                    companylbl.Text = companyname;
                    addresslbl.Text = address;
                    emaillbl.Text = email;

                }
                else
                {
                    continue;
                }
            }
        }

        private void customerlistbtn_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = true;
            customerlistvisible = true;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            menuexpand.Start();
            CustomerListRefresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            CustomerListRefresh();
        }
        private void CustomerListRefresh()
        {
            CustomersListBox.Items.Clear();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Customers";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string mobilenumber = reader["mobilenumber"].ToString();
                string email = reader["email"].ToString();
                string companyname = reader["companyname"].ToString();
                string address = reader["address"].ToString();
                string dateofbirth = reader["dateofbirth"].ToString();
                string status = reader["status"].ToString();
                CustomersListBox.Items.Add("نام و نام خانوادگی : " + name + " | " + " شماره تماس : " + mobilenumber + " | " + " ایمیل : " + email + " | " + " نام شرکت : " + companyname + " | " + " آدرس : " + address + " | " + " تاریخ تولد : " + dateofbirth + " | " + " وضعیت مشتری : " + status + "");
            }
            sc.Close();
        }

        private void ProductsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void employeesmenuOpener_Tick(object sender, EventArgs e)
        {
            if (employeePanelopened == false)
            {
                employeesgroupPNL.Height += 10;
                if (employeesgroupPNL.Height >= 260)
                {
                    employeesmenuOpener.Stop();
                    employeePanelopened = true;
                }
            }
            else
            {
                employeesgroupPNL.Height -= 10;
                if (employeesgroupPNL.Height <= 48)
                {
                    employeesmenuOpener.Stop();
                    employeePanelopened = false;
                }
            }
        }

        private void EmployeesBTNMain_Click(object sender, EventArgs e)
        {
            if (customerPanelopened)
            {
                customermenuOpener.Start();
            }
            if (productPanelopened)
            {
                productmenuOpener.Start();
            }
            if (exitPanelopened)
            {
                exitmenuOpener.Start();
            }
            if (dealsPanelopened)
            {
                dealsmenuOpener.Start();
            }
            employeesmenuOpener.Start();
        }

        private void dealsmenuOpener_Tick(object sender, EventArgs e)
        {
            if (dealsPanelopened == false)
            {
                dealsgroupPNL.Height += 10;
                if (dealsgroupPNL.Height >= 215)
                {
                    dealsmenuOpener.Stop();
                    dealsPanelopened = true;
                }
            }
            else
            {
                dealsgroupPNL.Height -= 10;
                if (dealsgroupPNL.Height <= 47)
                {
                    dealsmenuOpener.Stop();
                    dealsPanelopened = false;
                }
            }
        }

        private void dealsBTNMain_Click(object sender, EventArgs e)
        {
            if (customerPanelopened)
            {
                customermenuOpener.Start();
            }
            if (productPanelopened)
            {
                productmenuOpener.Start();
            }
            if (employeePanelopened)
            {
                employeesmenuOpener.Start();
            }
            if (exitPanelopened)
            {
                exitmenuOpener.Start();
            }
            dealsmenuOpener.Start();
        }

        private void exitmenuOpener_Tick(object sender, EventArgs e)
        {

            if (exitPanelopened == false)
            {
                exitgroupPNL.Height += 10;
                if (exitgroupPNL.Height >= 260)
                {
                    exitmenuOpener.Stop();
                    exitPanelopened = true;
                }
            }
            else
            {
                exitgroupPNL.Height -= 10;
                if (exitgroupPNL.Height <= 47)
                {
                    exitmenuOpener.Stop();
                    exitPanelopened = false;
                }
            }
        }

        private void ExitMain_Click(object sender, EventArgs e)
        {
            if (customerPanelopened)
            {
                customermenuOpener.Start();
            }
            if (productPanelopened)
            {
                productmenuOpener.Start();
            }
            if (employeePanelopened)
            {
                employeesmenuOpener.Start();
            }
            if (dealsPanelopened)
            {
                dealsmenuOpener.Start();
            }
            exitmenuOpener.Start();
        }

        private void DELconfirmBTN_Click(object sender, EventArgs e)
        {
            if (customerdeletecombobox.Text.Length < 1)
            {
                MessageBox.Show("برای حذف باید ابتدا نام مشتری مورد نظر را انتخاب کنید");
                return;
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string name = customerdeletecombobox.Text;
                string query = "UPDATE Customers SET status='disabled' WHERE name='" + name + "'";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("حذف مشتری مورد نظر با موفقیت انجام شد");
                CustomerDeleteComboboxLoader();
                CustomerInfoPNL.Visible = false;
                return;
            }
        }

        private void GotoUPFORM_Click(object sender, EventArgs e)
        {
            if (CustomerUPDCombobox.Text.Length < 1)
            {
                MessageBox.Show("جهت تغییر مشخصات مشتری ابتدا باید نام مشتری را انتخاب کنید");
                return;
            }
            else
            {
                customername = CustomerUPDCombobox.Text;
                customerupdateform.Show();
            }
        }

        private void customerupdtebtn_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = true;
            customerupdatevisible = true;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            customerupdatecomboboxloader();

        }
        public void customerupdatecomboboxloader()
        {
            SqlConnection conntoDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string selectorquery = "SELECT name,status FROM Customers";
            conntoDB.Open();
            SqlCommand cmd = new SqlCommand(selectorquery, conntoDB);
            SqlDataReader selectorreader = cmd.ExecuteReader();
            CustomerUPDCombobox.Items.Clear();
            while (selectorreader.Read())
            {
                string name = selectorreader["name"].ToString();
                string status = selectorreader["status"].ToString();
                if (status == "active")
                {
                    CustomerUPDCombobox.Items.Add(name);
                }
                else
                    continue;
            }
            conntoDB.Close();
        }

        private void CustomerUPDCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            updateforminfopanel.Visible = true;

            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Customers";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                if (name == CustomerUPDCombobox.Text)
                {
                    string mobile = reader["mobilenumber"].ToString();
                    string email = reader["email"].ToString();
                    string companyname = reader["companyname"].ToString();
                    string address = reader["address"].ToString();

                    namelabel.Text = name;
                    mobilelabel.Text = mobile;
                    companylabel.Text = companyname;
                    addresslabel.Text = address;
                    emaillabel.Text = email;

                }
                else
                {
                    continue;
                }
            }
        }

        private void EmpAddBtn_Click(object sender, EventArgs e)
        {

            if (empaddnametxtbx.Text.Length < 1 || empaddmelicodetxtbx.Text.Length < 1 || empaddlicensetxtbx.Text.Length < 1 || empaddmobiletxtbx.Text.Length < 1 || empaddroletxtbx.Text.Length < 1 || empadddobtxtbx.Text.Length < 1)
            {
                MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "فیلد ها را خالی نگذارید");
                return;
            }
            else
            {
                string name = empaddnametxtbx.Text;
                string mobile = empaddmobiletxtbx.Text;
                string degree = empaddlicensetxtbx.Text;
                string nationalcode = empaddmelicodetxtbx.Text;
                string role = empaddroletxtbx.Text;
                string dob = empadddobtxtbx.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string query = "SELECT name FROM Employees";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string selectorname = reader["name"].ToString();
                    if (selectorname == name)
                    {
                        MessageBox.Show("کارمند با این نام قبلا اضافه شده است");
                        return;
                    }
                    else
                        continue;
                }
                sc.Close();

                string active = "active";
                SqlConnection sc2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string query2 = "INSERT INTO Employees(name,mobilenumber,nationalcode,role,degreeofeducation,dateofbirth,status) VALUES(N'" + name + "', N'" + mobile + "', N'" + nationalcode + "', N'" + role + "', N'" + degree + "' , N'" + dob + "' , N'" + active + "')";
                sc2.Open();
                SqlCommand cmd2 = new SqlCommand(query2, sc2);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("کارمند با موفقیت اضافه شد");
                empaddnametxtbx.Text = empaddmobiletxtbx.Text = empaddmelicodetxtbx.Text = empaddlicensetxtbx.Text = empadddobtxtbx.Text = empaddroletxtbx.Text = "";
                sc2.Close();

                return;
            }

        }

        private void EmpDelBTNSubmit_Click(object sender, EventArgs e)
        {

            if (EmpDELComboBX.Text.Length < 1)
            {
                MessageBox.Show("برای حذف باید ابتدا نام کارمند مورد نظر را انتخاب کنید");
                return;
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string name = EmpDELComboBX.Text;
                string disabled = "disabled";
                string query = "UPDATE Employees SET status=N'disabled' WHERE name=N'" + name + "'";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("حذف کارمند مورد نظر با موفقیت انجام شد");
                Empdelinfopanel.Visible = false;
                EmployeeDeleteComboboxLoader();

                return;
            }
        }

        private void EmpDELComboBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empdelinfopanel.Visible = true;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Employees";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                if (name == EmpDELComboBX.Text)
                {
                    string mobile = reader["mobilenumber"].ToString();
                    string role = reader["role"].ToString();
                    string degree = reader["degreeofeducation"].ToString();
                    string nationalcode = reader["nationalcode"].ToString();
                    string dateofbirth = reader["dateofbirth"].ToString();

                    empdelnamelbl.Text = name;
                    empdelrolelbl.Text = role;
                    empdelmelicodelbl.Text = nationalcode;
                    empdeletedegreelbl.Text = degree;
                    empdeldoblbl.Text = dateofbirth;
                    empdelmobinumlbl.Text = mobile;


                }
                else
                {
                    continue;
                }
            }

        }

        private void DelEmployee_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = true;
            EmployeeDelPNL.Visible = true;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            EmployeeDeleteComboboxLoader();
        }
        public void EmployeeDeleteComboboxLoader()
        {

            SqlConnection conntoDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string selectorquery = "SELECT name,status FROM Employees";
            conntoDB.Open();
            SqlCommand cmd = new SqlCommand(selectorquery, conntoDB);
            SqlDataReader selectorreader = cmd.ExecuteReader();
            EmpDELComboBX.Items.Clear();
            while (selectorreader.Read())
            {
                string name = selectorreader["name"].ToString();
                string status = selectorreader["status"].ToString();
                if (status == "active")
                {
                    EmpDELComboBX.Items.Add(name);
                }
                else
                    continue;
            }
            conntoDB.Close();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {

            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = true;
            EmployeeAddPNL.Visible = true;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();

        }

        private void ListEmployee_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = true;
            EmployeeListPNL.Visible = true;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            employeelistRefresh();

        }
        public void employeelistRefresh()
        {
            employeelistbox.Items.Clear();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Employees";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string mobilenumber = reader["mobilenumber"].ToString();
                string nationalcode = reader["nationalcode"].ToString();
                string role = reader["role"].ToString();
                string degreeofeducation = reader["degreeofeducation"].ToString();
                string dateofbirth = reader["dateofbirth"].ToString();
                string status = reader["status"].ToString();
                employeelistbox.Items.Add("نام و نام خانوادگی : " + name + " | " + " شماره تماس : " + mobilenumber + " | " + " کد ملی : " + nationalcode + " | " + " مدرک تحصیلی : " + degreeofeducation + " | " + " نفش کارمند : " + role + " | " + " تاریخ تولد : " + dateofbirth + " | " + " وضعیت کارمند : " + status + "");
            }
            sc.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            employeelistRefresh();
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = true;
            EmployeeUPDPNL.Visible = true;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            employeeUPDATEcomboboxLoader();



        }

        private void GotoEMPUPDForm_Click(object sender, EventArgs e)
        {
            employeename = EmpUPDComboBX.Text;
            employeeupdateform.Show();

        }
        public void employeeUPDATEcomboboxLoader()
        {
            SqlConnection conntoDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string selectorquery = "SELECT name,status FROM Employees";
            conntoDB.Open();
            SqlCommand cmd = new SqlCommand(selectorquery, conntoDB);
            SqlDataReader selectorreader = cmd.ExecuteReader();
            EmpUPDComboBX.Items.Clear();
            while (selectorreader.Read())
            {
                string name = selectorreader["name"].ToString();
                string status = selectorreader["status"].ToString();
                if (status == "active")
                {
                    EmpUPDComboBX.Items.Add(name);
                }
                else
                    continue;
            }
            conntoDB.Close();
        }

        private void EmpUPDComboBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeInfoUPDPnL.Visible = true;

            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Employees";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                if (name == EmpUPDComboBX.Text)
                {
                    string mobile = reader["mobilenumber"].ToString();
                    string role = reader["role"].ToString();
                    string nationalcode = reader["nationalcode"].ToString();
                    string degree = reader["degreeofeducation"].ToString();
                    string dateofbirth = reader["dateofbirth"].ToString();

                    empUPDnamelbl.Text = name;
                    empUPDrolelbl.Text = role;
                    empUPDmobinumlbl.Text = mobile;
                    empUPDnationalclbl.Text = nationalcode;
                    empUPDdoblbl.Text = dateofbirth;
                    empUPDdegreelbl.Text = degree;


                }
                else
                {
                    continue;
                }
            }
        }

        private void prdctAddSubmitBTN_Click(object sender, EventArgs e)
        {
            if (prdctAddtypetxtbox.Text.Length < 1 || prdctAddBuyPtxtbox.Text.Length < 1 || prdctAddCodetxtbox.Text.Length < 1 || prdctAddNametxtbox.Text.Length < 1 || prdctAddstockquantitytxtbox.Text.Length < 1 || prdctAddSellPtxtbox.Text.Length < 1)
            {
                MessageBox.Show("لطفا تمامی اطلاعات خواسته شده را کامل کنید");

                return;
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string productname = prdctAddNametxtbox.Text;
                string productcode = prdctAddCodetxtbox.Text;
                string productsellprice = prdctAddSellPtxtbox.Text;
                string productbuyprice = prdctAddBuyPtxtbox.Text;
                string producttype = prdctAddtypetxtbox.Text;
                string quantity = prdctAddstockquantitytxtbox.Text;
                string status = "active";
                string query = "INSERT INTO Products(productname,productcode,productbuyprice,productsellprice,producttype,quantityinstock,status) VALUES( N'" + productname + "' , N'" + productcode + "' , N'" + productbuyprice + "' , N'" + productsellprice + "' , N'" + producttype + "' , N'" + quantity + "' , N'" + status + "')";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("کالا با موفقیت ثبت شد");
                prdctAddNametxtbox.Text = prdctAddCodetxtbox.Text = prdctAddSellPtxtbox.Text = prdctAddBuyPtxtbox.Text = prdctAddtypetxtbox.Text = prdctAddstockquantitytxtbox.Text = "";
                sc.Close();
            }



        }

        private void addprdctbtn_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = true;
            productaddvisible = true;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
        }

        private void deleteprdctbtn_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = true;
            productdelvisible = true;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            ProductDelComboBoxLoader();

        }
        public void ProductDelComboBoxLoader()
        {
            productDeleteCombobox.Items.Clear();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT productname,status FROM Products";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string status = reader["status"].ToString();
                if (status == "active")
                {
                    string productname = reader["productname"].ToString();
                    productDeleteCombobox.Items.Add(productname);
                }
                else
                {
                    continue;
                }
            }
            sc.Close();
        }

        private void productDeleteCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Products";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string productname = reader["productname"].ToString();
                if (productname == productDeleteCombobox.Text)
                {
                    string productcode = reader["productcode"].ToString();
                    string productbuyprice = reader["productbuyprice"].ToString();
                    string productsellprice = reader["productsellprice"].ToString();
                    string producttype = reader["producttype"].ToString();
                    string quantityinstock = reader["quantityinstock"].ToString();

                    prdctDelnamelbl.Text = productname;
                    prdctDelCodelbl.Text = productcode;
                    prdctDelSellPlbl.Text = productsellprice;
                    prdctDelbuyPlbl.Text = productbuyprice;
                    prdctDelTypelbl.Text = producttype;
                    prdctDelStocklbl.Text = quantityinstock;


                }
                else
                    continue;
            }
            sc.Close();
            ProductDelInfoPanel.Visible = true;
        }

        private void ProductDeleteSubmitBTN_Click(object sender, EventArgs e)
        {
            if (productDeleteCombobox.Text.Length < 1)
            {
                MessageBox.Show("برای حذف محصول ابتدا باید نام آن را انتخاب کنید");
                return;
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string status = "disabled";
                string productname = productDeleteCombobox.Text;
                string query = "UPDATE Products SET status=N'" + status + "' WHERE productname=N'" + productname + "'";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("حذف محصول با موفقیت انجام شد");
                sc.Close();
                ProductDelComboBoxLoader();
                ProductDelInfoPanel.Visible = false;
            }
        }

        private void productlistbtn_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = true;
            ProductsListPNL.Visible = true;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            ProductsListRefresh();
        }
        public void ProductsListRefresh()
        {
            productslistbox.Items.Clear();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Products";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string productcode = reader["productcode"].ToString();
                string productbuyprice = reader["productbuyprice"].ToString();
                string productsellprice = reader["productsellprice"].ToString();
                string producttype = reader["producttype"].ToString();
                string quantityinstock = reader["quantityinstock"].ToString();
                string productname = reader["productname"].ToString();
                string status = reader["status"].ToString();

                productslistbox.Items.Add(" نام محصول : " + productname + " | کد محصول : " + productcode + " | نوع محصول : " + producttype + " | قیمت خرید محصول : " + productbuyprice + " | قیمت فروش محصول : " + productsellprice + " | تعداد موجود در انبار : " + quantityinstock + " | وضعیت محصول : " + status + "");

            }
            sc.Close();
        }

        private void productlistrefreshBTN_Click(object sender, EventArgs e)
        {
            ProductsListRefresh();
        }

        private void updateproductbtn_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = true;
            productsupdatevisible = true;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            ProductsUpdateComboboxLoader();
        }
        public void ProductsUpdateComboboxLoader()
        {

            ProductsUPDcombobox.Items.Clear();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT productname,status FROM Products";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string status = reader["status"].ToString();
                if (status == "active")
                {
                    string productname = reader["productname"].ToString();
                    ProductsUPDcombobox.Items.Add(productname);
                }
                else
                {
                    continue;
                }
            }
            sc.Close();
        }

        private void ProductsUPDcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string query = "SELECT * FROM Products";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string productname = reader["productname"].ToString();
                if (productname == ProductsUPDcombobox.Text)
                {
                    string productcode = reader["productcode"].ToString();
                    string productbuyprice = reader["productbuyprice"].ToString();
                    string productsellprice = reader["productsellprice"].ToString();
                    string producttype = reader["producttype"].ToString();
                    string quantityinstock = reader["quantityinstock"].ToString();

                    prdctUPDnamelbl.Text = productname;
                    prdctUPDcodelbl.Text = productcode;
                    prdctUPDSellPlbl.Text = productsellprice;
                    prdctUPDbuyPlbl.Text = productbuyprice;
                    prdctUPDtypelbl.Text = producttype;
                    prdctUPDquantitylbl.Text = quantityinstock;


                }
                else
                    continue;
            }
            sc.Close();
            ProductsUPDinfoPNL.Visible = true;
        }

        private void ProductsgotoUPDbtn_Click(object sender, EventArgs e)
        {
            producttname = ProductsUPDcombobox.Text;
            productsupdateform.Show();
        }

        private void AddDeal_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = true;
            DealsAddPNL.Visible = true;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            DealsAddPannelComboBoxLoader();
        }
        public void DealsAddPannelComboBoxLoader()
        {
            dealtypecombobox.Items.Clear();
            dealtypecombobox.Items.Add("فروش");

            DealsProductCombobox.Items.Clear();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string productsquery = "SELECT productname,status FROM Products";
            sc.Open();
            SqlCommand cmd = new SqlCommand(productsquery, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string status = reader["status"].ToString();
                if (status == "active")
                {
                    string productname = reader["productname"].ToString();
                    DealsProductCombobox.Items.Add(productname);
                }
                else
                {
                    continue;
                }
            }
            sc.Close();

            dealersComboBox.Items.Clear();
            string dealersquery = "SELECT name,status FROM Employees";
            sc.Open();
            SqlCommand dealerscmd = new SqlCommand(dealersquery, sc);
            SqlDataReader dealersreader = dealerscmd.ExecuteReader();
            while (dealersreader.Read())
            {
                string dealername = dealersreader["name"].ToString();
                string dealerstatus = dealersreader["status"].ToString();
                if (dealerstatus == "active")
                {
                    dealersComboBox.Items.Add(dealername);
                }
                else
                    continue;
            }
            sc.Close();

            DealsCustomerComboBox.Items.Clear();
            string buyersquery = "SELECT name,status FROM Customers";
            sc.Open();
            SqlCommand buyerscmd = new SqlCommand(buyersquery, sc);
            SqlDataReader buyersreader = buyerscmd.ExecuteReader();
            while (buyersreader.Read())
            {
                string buyername = buyersreader["name"].ToString();
                string buyerstatus = buyersreader["status"].ToString();
                if (buyerstatus == "active")
                {
                    DealsCustomerComboBox.Items.Add(buyername);
                }
                else
                    continue;
            }
            sc.Close();


        }

        private void DealSubmitBtn_Click(object sender, EventArgs e)
        {
            if (dealersComboBox.Text.Length < 1 || dealtypecombobox.Text.Length < 1 || DealsProductCombobox.Text.Length < 1 || DealsCustomerComboBox.Text.Length < 1 || DealProductQuantityTxtbox.Text.Length < 1 || additionalinfolbl.Text.Length < 1)
            {
                MessageBox.Show("لطفا فیلد ها را خالی نگذارید");
                return;
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string productname = DealsProductCombobox.Text;
                string queryselector = "SELECT quantityinstock FROM Products WHERE productname = N'" + productname + "'";
                sc.Open();
                SqlCommand cmdselector = new SqlCommand(queryselector, sc);
                SqlDataReader selectorreader = cmdselector.ExecuteReader();
                selectorreader.Read();
                string quantityinstock = selectorreader["quantityinstock"].ToString();
                sc.Close();
                string quantityofproduct = DealProductQuantityTxtbox.Text;
                if (int.Parse(quantityofproduct) > int.Parse(quantityinstock))
                {
                    MessageBox.Show("تعداد محصول وارد شده نباید از موجودی انبار بیشتر باشد ، تعداد را کم کرده یا از پنل به روزرسانی محصولات نسبت به افزایش موجودی محصول اقدام نمایید");
                    return;
                }

                else
                {

                    string dealtype = dealtypecombobox.Text;
                    string dealername = dealersComboBox.Text;
                    string buyername = DealsCustomerComboBox.Text;
                    string additionalinfo = additionalinfotextbox.Text;
                    string status = "فعال";
                    string dealstartdate = DateTime.Now.ToString();
                    string query = "INSERT INTO Deals(dealtype,productname,quantityofproduct,dealername,buyername,additionalinfo,status,dealstartdate) VALUES(N'" + dealtype + "' , N'" + productname + "' , N'" + quantityofproduct + "' , N'" + dealername + "' , N'" + buyername + "' , N'" + additionalinfo + "' , N'" + status + "' , N'" + dealstartdate + "')";
                    sc.Open();
                    SqlCommand cmd = new SqlCommand(query, sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("قرارداد با موفقیت اضافه شد");
                    sc.Close();
                    dealtypecombobox.Text = DealsProductCombobox.Text = DealProductQuantityTxtbox.Text = dealersComboBox.Text = DealsCustomerComboBox.Text = additionalinfotextbox.Text = "";
                    int a = int.Parse(quantityinstock);
                    int b = int.Parse(quantityofproduct);
                    int stockresult = a - b;
                    string stockres = stockresult.ToString();

                    string queryinsertor = "UPDATE Products SET quantityinstock=N'" + stockres + "' WHERE productname=N'" + productname + "'";
                    SqlCommand cmdupdator = new SqlCommand(queryinsertor, sc);
                    sc.Open();
                    cmdupdator.ExecuteNonQuery();
                    sc.Close();
                }
            }

        }

        private void DelDeal_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = true;
            dealsdelvisible = true;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            DealDelPanelComboBoxLoader();
        }
        public void DealDelPanelComboBoxLoader()
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            DealsIDcombobox.Items.Clear();
            string query = "SELECT Id,status FROM Deals";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["Id"].ToString();
                string status = reader["status"].ToString();
                if (status == "فعال")
                {
                    DealsIDcombobox.Items.Add(id);
                }
                else
                    continue;
            }
            sc.Close();
        }

        private void DealDeleteSubmitBTN_Click(object sender, EventArgs e)
        {
            if (DealsIDcombobox.Text.Length < 1)
            {
                MessageBox.Show("جهت حذف قرارداد ابتدا باید شماره قرارداد را انتخاب کنید");
                return;
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string deleted = "حذف شده";
                string id = DealsIDcombobox.Text;
                int intid = int.Parse(id);
                string query = "UPDATE Deals SET status=N'" + deleted + "' WHERE Id='" + intid + "'";
                sc.Open();
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("حذف قرارداد با موفقیت انجام شد");
                DealInfoPanel.Visible = false;
                DealDelPanelComboBoxLoader();
                return;
            }
        }

        private void DealsIDcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string id = DealsIDcombobox.Text;
            int intid = int.Parse(id);
            string query = "SELECT Id,dealtype,productname,dealername,buyername,dealstartdate FROM Deals WHERE Id='" + intid + "'";
            sc.Open();
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();
            string dealtype = r["dealtype"].ToString();
            string productname = r["productname"].ToString();
            string dealername = r["dealername"].ToString();
            string buyername = r["buyername"].ToString();
            string dealstartdate = r["dealstartdate"].ToString();

            dealtypelabel.Text = dealtype;
            productnamelabel.Text = productname;
            dealidlabel.Text = id;
            dealernamelabel.Text = dealername;
            buyernamelabel.Text = buyername;
            dealstartdatelabel.Text = dealstartdate;
            DealInfoPanel.Visible = true;
            sc.Close();

        }

        private void DealsList_Click(object sender, EventArgs e)
        {
            dashbordvisible = false;
            Dashboard.Visible = false;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = true;
            DealsListPanel.Visible = true;
            menuexpand.Start();
            DealsListDataGridItemsLoader();
        }
        public void DealsListDataGridItemsLoader()
        {
            DealsDataGrid.Rows.Clear();

            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");

            string dealsquery = "SELECT * FROM Deals";
            SqlCommand dealscmd = new SqlCommand(dealsquery, sc);
            sc.Open();
            SqlDataReader dealsreader = dealscmd.ExecuteReader();
            while (dealsreader.Read())
            {
                string Id = dealsreader["Id"].ToString();
                string dealtype = dealsreader["dealtype"].ToString();
                string dealername = dealsreader["dealername"].ToString();
                string buyername = dealsreader["buyername"].ToString();
                string productname = dealsreader["productname"].ToString();
                string quantityofproduct = dealsreader["quantityofproduct"].ToString();
                string dealstatus = dealsreader["status"].ToString();
                string dealstartdate = dealsreader["dealstartdate"].ToString();
                string dealenddate = dealsreader["dealenddate"].ToString();
                string additionalinfo = dealsreader["additionalinfo"].ToString();

                SqlConnection sc2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                string customersquery = "SELECT * FROM Customers WHERE name=N'" + buyername + "'";
                SqlCommand customercmd = new SqlCommand(customersquery, sc2);
                sc2.Open();
                SqlDataReader customerreader = customercmd.ExecuteReader();
                customerreader.Read();
                string Cmobilenumber = customerreader["mobilenumber"].ToString();
                string Cemail = customerreader["email"].ToString();
                string Caddress = customerreader["address"].ToString();
                sc2.Close();

                string productsquery = "SELECT * FROM Products WHERE productname =N'" + productname + "'";
                SqlCommand productcmd = new SqlCommand(productsquery, sc2);
                sc2.Open();
                SqlDataReader productsreader = productcmd.ExecuteReader();
                productsreader.Read();
                string productsellprice = productsreader["productsellprice"].ToString();
                sc2.Close();
                int a = int.Parse(quantityofproduct);
                int b = int.Parse(productsellprice);
                int res = a * b;

                string dealprice = res.ToString();


                DealsDataGrid.Rows.Add(Id, dealtype, dealername, buyername, productname, quantityofproduct, dealstatus, dealprice, dealstartdate, dealenddate, Cmobilenumber, Cemail, Caddress, additionalinfo);

            }
            sc.Close();
        }

        private void DealsListRefreshBTN_Click(object sender, EventArgs e)
        {
            DealsDataGrid.Rows.Clear();
            DealsListDataGridItemsLoader();
        }

        private void SubmitFinal_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < DealsDataGridViewDashboard.Rows.Count; i++)
            {
                bool select = Convert.ToBoolean(DealsDataGridViewDashboard.Rows[i].Cells["checkbox"].Value);
                if (select)
                {
                    string id = (DealsDataGridViewDashboard.Rows[i].Cells["columnforid"].Value).ToString();
                    int intid = int.Parse(id);
                    SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                    string querychecker = "SELECT status FROM Deals WHERE Id='" + id + "'";
                    sc.Open();
                    SqlCommand cmdchecker = new SqlCommand(querychecker, sc);
                    SqlDataReader reader = cmdchecker.ExecuteReader();
                    reader.Read();
                    string checkstatus = reader["status"].ToString();
                    sc.Close();
                    if (checkstatus == "حذف شده")
                    {
                        MessageBox.Show("قرارداد شماره " + id + " قبلا حذف شده و امکان نهایی سازی آن وجود ندارد");

                    }
                    else if (checkstatus == "نهایی شده")
                    {
                        MessageBox.Show("قرارداد شماره " + id + " قبلا نهایی شده و امکان نهایی سازی مجدد آن وجود ندارد");

                    }
                    else if (checkstatus == "فعال")
                    {
                        string status = "نهایی شده";
                        string date = DateTime.Now.ToString();
                        string query = "UPDATE Deals SET status=N'" + status + "' , dealenddate=N'" + date + "' WHERE Id='" + id + "'";
                        sc.Open();
                        SqlCommand cmd = new SqlCommand(query, sc);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("نهایی سازی قرارداد شماره " + id + " با موفقیت انجام شد");
                        sc.Close();
                    }
                }
                else
                    continue;
            }
            DashboardDataGridLoader(filtercombobox.Text);
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            DashboardDataGridLoader(filtercombobox.Text);
            filtercombobox.Items.Clear();
            filtercombobox.Items.Add("همه قراردادها");
            filtercombobox.Items.Add("قراردادهای فعال");
            filtercombobox.Items.Add("قراردادهای حذف شده");
            filtercombobox.Items.Add("قراردادهای نهایی شده");
            filtercombobox.SelectedItem = "قراردادهای فعال";


        }
        public void DashboardDataGridLoader(string x)
        {
            DealsDataGridViewDashboard.Rows.Clear();

            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
            string dealsquery = "SELECT * FROM Deals";
            SqlCommand dealscmd = new SqlCommand(dealsquery, sc);
            sc.Open();
            SqlDataReader dealsreader = dealscmd.ExecuteReader();
            if (x == "همه قراردادها")
            {
                while (dealsreader.Read())
                {
                    string Id = dealsreader["Id"].ToString();
                    string dealtype = dealsreader["dealtype"].ToString();
                    string dealername = dealsreader["dealername"].ToString();
                    string buyername = dealsreader["buyername"].ToString();
                    string productname = dealsreader["productname"].ToString();
                    string quantityofproduct = dealsreader["quantityofproduct"].ToString();
                    string dealstatus = dealsreader["status"].ToString();
                    string dealstartdate = dealsreader["dealstartdate"].ToString();
                    string dealenddate = dealsreader["dealenddate"].ToString();
                    string additionalinfo = dealsreader["additionalinfo"].ToString();

                    SqlConnection sc2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                    string customersquery = "SELECT * FROM Customers WHERE name=N'" + buyername + "'";
                    SqlCommand customercmd = new SqlCommand(customersquery, sc2);
                    sc2.Open();
                    SqlDataReader customerreader = customercmd.ExecuteReader();
                    customerreader.Read();
                    string Cmobilenumber = customerreader["mobilenumber"].ToString();
                    string Cemail = customerreader["email"].ToString();
                    string Caddress = customerreader["address"].ToString();
                    sc2.Close();

                    string productsquery = "SELECT * FROM Products WHERE productname =N'" + productname + "'";
                    SqlCommand productcmd = new SqlCommand(productsquery, sc2);
                    sc2.Open();
                    SqlDataReader productsreader = productcmd.ExecuteReader();
                    productsreader.Read();
                    string productsellprice = productsreader["productsellprice"].ToString();
                    sc2.Close();
                    int a = int.Parse(quantityofproduct);
                    int b = int.Parse(productsellprice);
                    int res = a * b;

                    string dealprice = res.ToString();


                    DealsDataGridViewDashboard.Rows.Add(false, Id, dealtype, dealername, buyername, productname, quantityofproduct, dealstatus, dealprice, dealstartdate, dealenddate, Cmobilenumber, Cemail, Caddress, additionalinfo);

                }
            }
            else if (x == "قراردادهای فعال")
            {

                while (dealsreader.Read())
                {
                    string dealstatus = dealsreader["status"].ToString();
                    if (dealstatus == "فعال")
                    {
                        string Id = dealsreader["Id"].ToString();
                        string dealtype = dealsreader["dealtype"].ToString();
                        string dealername = dealsreader["dealername"].ToString();
                        string buyername = dealsreader["buyername"].ToString();
                        string productname = dealsreader["productname"].ToString();
                        string quantityofproduct = dealsreader["quantityofproduct"].ToString();
                        string dealstartdate = dealsreader["dealstartdate"].ToString();
                        string dealenddate = dealsreader["dealenddate"].ToString();
                        string additionalinfo = dealsreader["additionalinfo"].ToString();
                        SqlConnection sc2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                        string customersquery = "SELECT * FROM Customers WHERE name=N'" + buyername + "'";
                        SqlCommand customercmd = new SqlCommand(customersquery, sc2);
                        sc2.Open();
                        SqlDataReader customerreader = customercmd.ExecuteReader();
                        customerreader.Read();
                        string Cmobilenumber = customerreader["mobilenumber"].ToString();
                        string Cemail = customerreader["email"].ToString();
                        string Caddress = customerreader["address"].ToString();
                        sc2.Close();

                        string productsquery = "SELECT * FROM Products WHERE productname =N'" + productname + "'";
                        SqlCommand productcmd = new SqlCommand(productsquery, sc2);
                        sc2.Open();
                        SqlDataReader productsreader = productcmd.ExecuteReader();
                        productsreader.Read();
                        string productsellprice = productsreader["productsellprice"].ToString();
                        sc2.Close();
                        int a = int.Parse(quantityofproduct);
                        int b = int.Parse(productsellprice);
                        int res = a * b;

                        string dealprice = res.ToString();


                        DealsDataGridViewDashboard.Rows.Add(false, Id, dealtype, dealername, buyername, productname, quantityofproduct, dealstatus, dealprice, dealstartdate, dealenddate, Cmobilenumber, Cemail, Caddress, additionalinfo);
                    }
                    else
                        continue;
                }

            }
            else if (x == "قراردادهای حذف شده")
            {
                while (dealsreader.Read())
                {
                    string dealstatus = dealsreader["status"].ToString();
                    if (dealstatus == "حذف شده")
                    {
                        string Id = dealsreader["Id"].ToString();
                        string dealtype = dealsreader["dealtype"].ToString();
                        string dealername = dealsreader["dealername"].ToString();
                        string buyername = dealsreader["buyername"].ToString();
                        string productname = dealsreader["productname"].ToString();
                        string quantityofproduct = dealsreader["quantityofproduct"].ToString();
                        string dealstartdate = dealsreader["dealstartdate"].ToString();
                        string dealenddate = dealsreader["dealenddate"].ToString();
                        string additionalinfo = dealsreader["additionalinfo"].ToString();
                        SqlConnection sc2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                        string customersquery = "SELECT * FROM Customers WHERE name=N'" + buyername + "'";
                        SqlCommand customercmd = new SqlCommand(customersquery, sc2);
                        sc2.Open();
                        SqlDataReader customerreader = customercmd.ExecuteReader();
                        customerreader.Read();
                        string Cmobilenumber = customerreader["mobilenumber"].ToString();
                        string Cemail = customerreader["email"].ToString();
                        string Caddress = customerreader["address"].ToString();
                        sc2.Close();

                        string productsquery = "SELECT * FROM Products WHERE productname =N'" + productname + "'";
                        SqlCommand productcmd = new SqlCommand(productsquery, sc2);
                        sc2.Open();
                        SqlDataReader productsreader = productcmd.ExecuteReader();
                        productsreader.Read();
                        string productsellprice = productsreader["productsellprice"].ToString();
                        sc2.Close();
                        int a = int.Parse(quantityofproduct);
                        int b = int.Parse(productsellprice);
                        int res = a * b;

                        string dealprice = res.ToString();


                        DealsDataGridViewDashboard.Rows.Add(false, Id, dealtype, dealername, buyername, productname, quantityofproduct, dealstatus, dealprice, dealstartdate, dealenddate, Cmobilenumber, Cemail, Caddress, additionalinfo);
                    }
                    else
                        continue;
                }
            }
            else if (x == "قراردادهای نهایی شده")
            {
                while (dealsreader.Read())
                {
                    string dealstatus = dealsreader["status"].ToString();
                    if (dealstatus == "نهایی شده")
                    {
                        string Id = dealsreader["Id"].ToString();
                        string dealtype = dealsreader["dealtype"].ToString();
                        string dealername = dealsreader["dealername"].ToString();
                        string buyername = dealsreader["buyername"].ToString();
                        string productname = dealsreader["productname"].ToString();
                        string quantityofproduct = dealsreader["quantityofproduct"].ToString();
                        string dealstartdate = dealsreader["dealstartdate"].ToString();
                        string dealenddate = dealsreader["dealenddate"].ToString();
                        string additionalinfo = dealsreader["additionalinfo"].ToString();
                        SqlConnection sc2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Visual Studio Projects\CRMapplicationProject\CRM\CRMDatabase.mdf"";Integrated Security=True");
                        string customersquery = "SELECT * FROM Customers WHERE name=N'" + buyername + "'";
                        SqlCommand customercmd = new SqlCommand(customersquery, sc2);
                        sc2.Open();
                        SqlDataReader customerreader = customercmd.ExecuteReader();
                        customerreader.Read();
                        string Cmobilenumber = customerreader["mobilenumber"].ToString();
                        string Cemail = customerreader["email"].ToString();
                        string Caddress = customerreader["address"].ToString();
                        sc2.Close();

                        string productsquery = "SELECT * FROM Products WHERE productname =N'" + productname + "'";
                        SqlCommand productcmd = new SqlCommand(productsquery, sc2);
                        sc2.Open();
                        SqlDataReader productsreader = productcmd.ExecuteReader();
                        productsreader.Read();
                        string productsellprice = productsreader["productsellprice"].ToString();
                        sc2.Close();
                        int a = int.Parse(quantityofproduct);
                        int b = int.Parse(productsellprice);
                        int res = a * b;

                        string dealprice = res.ToString();


                        DealsDataGridViewDashboard.Rows.Add(false, Id, dealtype, dealername, buyername, productname, quantityofproduct, dealstatus, dealprice, dealstartdate, dealenddate, Cmobilenumber, Cemail, Caddress, additionalinfo);
                    }
                    else
                        continue;
                }
            }
            sc.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            DashboardDataGridLoader(filtercombobox.Text);
        }

        private void filtercombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DashboardDataGridLoader(filtercombobox.Text);
        }

        // below section is used only to fix bugs , prevent unwanted data inserted into DB , and finalize the app
        // filtering different sections to allow only digits (this doesn't prevent user from using shortcuts in textbox , so using shortcuts is turned off for each textbox manually)
        private void mobilenumbertxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DealProductQuantityTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void empaddmobiletxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void empaddmelicodetxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void prdctAddBuyPtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void prdctAddSellPtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void prdctAddstockquantitytxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void prdctAddCodetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FullExitBTN_Click(object sender, EventArgs e)
        {
            fullexitform.Show();
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform.Show();
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            dashbordvisible = true;
            Dashboard.Visible = true;
            customeraddvisible = false;
            customerdelvisible = false;
            CustomerAddPNL.Visible = false;
            CustomerDelPNL.Visible = false;
            CustomerListPNL.Visible = false;
            customerlistvisible = false;
            CustomerUpdPNL.Visible = false;
            customerupdatevisible = false;
            employeeaddvisible = false;
            EmployeeAddPNL.Visible = false;
            employeedelvisible = false;
            EmployeeDelPNL.Visible = false;
            employeelistvisible = false;
            EmployeeListPNL.Visible = false;
            employeeupdatevisible = false;
            EmployeeUPDPNL.Visible = false;
            ProductAddPNL.Visible = false;
            productaddvisible = false;
            ProductDelPNL.Visible = false;
            productdelvisible = false;
            productlistvisible = false;
            ProductsListPNL.Visible = false;
            ProductsUPDPNL.Visible = false;
            productsupdatevisible = false;
            dealsaddvisible = false;
            DealsAddPNL.Visible = false;
            DealsDelPNL.Visible = false;
            dealsdelvisible = false;
            dealslistvisible = false;
            DealsListPanel.Visible = false;
            menuexpand.Start();
            DashboardDataGridLoader(filtercombobox.Text);
        }

        private void MainFormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            fullexitform.Show();
        }

        //GG EZ
        //AlirezaTimas
        //Barnameh Sazi Pishrafte Section Shanbe 4:30 ta 7
        //BasicCrmApplication
    }
}

