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
    public partial class exitconfirmform : Form
    {
        public StartingForm startingform;
        public exitconfirmform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            startingform.Show();
        }

        private void exitconfirmform_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            startingform.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button1.Font = new Font("Tahoma", 22, FontStyle.Bold);

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button2.Font = new Font("Tahoma", 22, FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font("Tahoma", 20, FontStyle.Regular);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Font = new Font("Tahoma", 20, FontStyle.Regular);

        }
    }
}
