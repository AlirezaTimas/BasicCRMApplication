using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class FullExitConfirmMainForm : Form
    {
        public MainFormAdmin mainformadmin;
        public FullExitConfirmMainForm()
        {
            InitializeComponent();
        }

        private void YesButton_MouseEnter(object sender, EventArgs e)
        {
            YesButton.ForeColor = Color.Green;
            YesButton.Font = new Font("Tahoma", 28, FontStyle.Bold);
        }

        private void YesButton_MouseLeave(object sender, EventArgs e)
        {
            YesButton.ForeColor = Color.Black;
            YesButton.Font = new Font("Tahoma", 24, FontStyle.Bold);
        }

        private void NoButton_MouseEnter(object sender, EventArgs e)
        {
            NoButton.ForeColor = Color.Red;
            NoButton.Font = new Font("Tahoma", 28, FontStyle.Bold);
        }

        private void NoButton_MouseLeave(object sender, EventArgs e)
        {
            NoButton.ForeColor = Color.Black;
            NoButton.Font = new Font("Tahoma", 24, FontStyle.Bold);
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void FullExitConfirmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
