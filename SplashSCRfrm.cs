using System.Runtime.CompilerServices;

namespace CRM
{
    public partial class SplashSCRfrm : Form
    {
        int move = 2;
        int x = 0;
        public StartingForm strtfrm = new StartingForm();
        public LoginForm loginform = new LoginForm();
        public MainFormAdmin mainformadmin = new MainFormAdmin();
        public Passrecoveryform passrecoveryform = new Passrecoveryform();
        public CustomerUpdateForm customerupdateform = new CustomerUpdateForm();
        public EmployeesUpdateForm employeeupdateform = new EmployeesUpdateForm();
        public ProductsUpdateForm productsupdateform = new ProductsUpdateForm();
        public FullExitConfirmMainForm fullexitformmain = new FullExitConfirmMainForm();
        public SplashSCRfrm()
        {
            InitializeComponent(); //this section is used to connect multiple forms to each other , in order to save all connections inside a single form and create every instance at the start of the application to avoid potential upcoming errors
            strtfrm.splashscrfrm = this;
            strtfrm.loginform = loginform;
            loginform.startingform = strtfrm;
            loginform.passrecoveryform = passrecoveryform;
            passrecoveryform.loginform = loginform;
            loginform.Mainformadmin = mainformadmin;
            mainformadmin.loginform = loginform;
            mainformadmin.customerupdateform = customerupdateform;
            customerupdateform.mainform = mainformadmin;
            mainformadmin.employeeupdateform = employeeupdateform;
            employeeupdateform.mainform = mainformadmin;
            productsupdateform.mainform = mainformadmin;
            mainformadmin.productsupdateform = productsupdateform;
            fullexitformmain.mainformadmin = mainformadmin;
            mainformadmin.fullexitform = fullexitformmain;


        }

        private void timer1_Tick(object sender, EventArgs e)
        { //custom progress bar made with timer
            panel2.Left += 2;

            if (panel2.Left > 610)
            {
                panel2.Left = 0;
            }
            if (panel2.Left < 0)
            {
                move = 2;

            }
            x++;
            if (x > 300)
            {
                timer1.Stop();
                this.Hide();
                strtfrm.Show();
            }
        }

        private void SplashSCRfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Application.ExitThread();
        }
    }
}