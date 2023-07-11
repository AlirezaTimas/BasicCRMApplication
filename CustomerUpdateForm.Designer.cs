namespace CRM
{
    partial class CustomerUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toppanelmove = new Panel();
            backicon = new PictureBox();
            panel1 = new Panel();
            nametextbox = new TextBox();
            label6 = new Label();
            submitchangesbtn = new Button();
            label1 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            addresstxtbox = new ReaLTaiizor.Controls.DreamTextBox();
            panel3 = new Panel();
            label4 = new Label();
            companynametxtbox = new ReaLTaiizor.Controls.DreamTextBox();
            panel2 = new Panel();
            label3 = new Label();
            emailtxtbox = new ReaLTaiizor.Controls.DreamTextBox();
            panel11 = new Panel();
            label2 = new Label();
            mobilenumbertxtbox = new ReaLTaiizor.Controls.DreamTextBox();
            toppanelmove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backicon).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // toppanelmove
            // 
            toppanelmove.BackColor = Color.FromArgb(23, 24, 29);
            toppanelmove.Controls.Add(backicon);
            toppanelmove.Dock = DockStyle.Top;
            toppanelmove.Location = new Point(0, 0);
            toppanelmove.Name = "toppanelmove";
            toppanelmove.Size = new Size(820, 45);
            toppanelmove.TabIndex = 0;
            toppanelmove.MouseDown += toppanelmove_MouseDown;
            toppanelmove.MouseMove += toppanelmove_MouseMove;
            // 
            // backicon
            // 
            backicon.BackgroundImage = Properties.Resources.back_arrow_white1;
            backicon.BackgroundImageLayout = ImageLayout.Stretch;
            backicon.Location = new Point(12, 12);
            backicon.Name = "backicon";
            backicon.Size = new Size(28, 25);
            backicon.TabIndex = 0;
            backicon.TabStop = false;
            backicon.Click += backicon_Click;
            backicon.MouseEnter += backicon_MouseEnter;
            backicon.MouseLeave += backicon_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nametextbox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(submitchangesbtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel11);
            panel1.Location = new Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 467);
            panel1.TabIndex = 1;
            // 
            // nametextbox
            // 
            nametextbox.BackColor = Color.FromArgb(32, 33, 36);
            nametextbox.BorderStyle = BorderStyle.FixedSingle;
            nametextbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nametextbox.ForeColor = Color.White;
            nametextbox.Location = new Point(275, 59);
            nametextbox.Name = "nametextbox";
            nametextbox.PlaceholderText = "Name";
            nametextbox.Size = new Size(233, 23);
            nametextbox.TabIndex = 14;
            nametextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(508, 60);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(100, 18);
            label6.TabIndex = 13;
            label6.Text = "نام مشتری : ";
            // 
            // submitchangesbtn
            // 
            submitchangesbtn.BackColor = Color.FromArgb(23, 24, 29);
            submitchangesbtn.FlatStyle = FlatStyle.Flat;
            submitchangesbtn.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            submitchangesbtn.ForeColor = Color.White;
            submitchangesbtn.Location = new Point(285, 389);
            submitchangesbtn.Name = "submitchangesbtn";
            submitchangesbtn.Size = new Size(208, 58);
            submitchangesbtn.TabIndex = 12;
            submitchangesbtn.Text = "ثبت تغییرات";
            submitchangesbtn.UseVisualStyleBackColor = false;
            submitchangesbtn.Click += submitchangesbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(166, 5);
            label1.Name = "label1";
            label1.Size = new Size(461, 33);
            label1.TabIndex = 0;
            label1.Text = "مشخصات جدید مشتری را وارد کنید";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(32, 33, 36);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(addresstxtbox);
            panel4.Location = new Point(404, 252);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 124);
            panel4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(73, 23);
            label5.Name = "label5";
            label5.Size = new Size(184, 23);
            label5.TabIndex = 1;
            label5.Text = "آدرس جدید مشتری";
            // 
            // addresstxtbox
            // 
            addresstxtbox.BackColor = Color.FromArgb(23, 24, 29);
            addresstxtbox.BorderStyle = BorderStyle.FixedSingle;
            addresstxtbox.ColorA = Color.FromArgb(31, 31, 31);
            addresstxtbox.ColorB = Color.FromArgb(41, 41, 41);
            addresstxtbox.ColorC = Color.FromArgb(51, 51, 51);
            addresstxtbox.ColorD = Color.FromArgb(0, 0, 0, 0);
            addresstxtbox.ColorE = Color.FromArgb(25, 255, 255, 255);
            addresstxtbox.ColorF = Color.Black;
            addresstxtbox.ForeColor = Color.White;
            addresstxtbox.Location = new Point(45, 74);
            addresstxtbox.Name = "addresstxtbox";
            addresstxtbox.PlaceholderText = "Address";
            addresstxtbox.Size = new Size(247, 23);
            addresstxtbox.TabIndex = 6;
            addresstxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 33, 36);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(companynametxtbox);
            panel3.Location = new Point(53, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 124);
            panel3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(57, 23);
            label4.Name = "label4";
            label4.Size = new Size(225, 23);
            label4.TabIndex = 1;
            label4.Text = "نام جدید شرکت مشتری";
            // 
            // companynametxtbox
            // 
            companynametxtbox.BackColor = Color.FromArgb(23, 24, 29);
            companynametxtbox.BorderStyle = BorderStyle.FixedSingle;
            companynametxtbox.ColorA = Color.FromArgb(31, 31, 31);
            companynametxtbox.ColorB = Color.FromArgb(41, 41, 41);
            companynametxtbox.ColorC = Color.FromArgb(51, 51, 51);
            companynametxtbox.ColorD = Color.FromArgb(0, 0, 0, 0);
            companynametxtbox.ColorE = Color.FromArgb(25, 255, 255, 255);
            companynametxtbox.ColorF = Color.Black;
            companynametxtbox.ForeColor = Color.White;
            companynametxtbox.Location = new Point(44, 74);
            companynametxtbox.Name = "companynametxtbox";
            companynametxtbox.PlaceholderText = "Companyname";
            companynametxtbox.Size = new Size(247, 23);
            companynametxtbox.TabIndex = 6;
            companynametxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 33, 36);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(emailtxtbox);
            panel2.Location = new Point(53, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 124);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(78, 23);
            label3.Name = "label3";
            label3.Size = new Size(180, 23);
            label3.TabIndex = 1;
            label3.Text = "ایمیل جدید مشتری";
            // 
            // emailtxtbox
            // 
            emailtxtbox.BackColor = Color.FromArgb(23, 24, 29);
            emailtxtbox.BorderStyle = BorderStyle.FixedSingle;
            emailtxtbox.ColorA = Color.FromArgb(31, 31, 31);
            emailtxtbox.ColorB = Color.FromArgb(41, 41, 41);
            emailtxtbox.ColorC = Color.FromArgb(51, 51, 51);
            emailtxtbox.ColorD = Color.FromArgb(0, 0, 0, 0);
            emailtxtbox.ColorE = Color.FromArgb(25, 255, 255, 255);
            emailtxtbox.ColorF = Color.Black;
            emailtxtbox.ForeColor = Color.White;
            emailtxtbox.Location = new Point(45, 74);
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.PlaceholderText = "Email";
            emailtxtbox.Size = new Size(247, 23);
            emailtxtbox.TabIndex = 6;
            emailtxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(32, 33, 36);
            panel11.Controls.Add(label2);
            panel11.Controls.Add(mobilenumbertxtbox);
            panel11.Location = new Point(404, 111);
            panel11.Name = "panel11";
            panel11.Size = new Size(329, 124);
            panel11.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 23);
            label2.Name = "label2";
            label2.Size = new Size(249, 23);
            label2.TabIndex = 1;
            label2.Text = "شماره تماس جدید مشتری";
            // 
            // mobilenumbertxtbox
            // 
            mobilenumbertxtbox.BackColor = Color.FromArgb(23, 24, 29);
            mobilenumbertxtbox.BorderStyle = BorderStyle.FixedSingle;
            mobilenumbertxtbox.ColorA = Color.FromArgb(31, 31, 31);
            mobilenumbertxtbox.ColorB = Color.FromArgb(41, 41, 41);
            mobilenumbertxtbox.ColorC = Color.FromArgb(51, 51, 51);
            mobilenumbertxtbox.ColorD = Color.FromArgb(0, 0, 0, 0);
            mobilenumbertxtbox.ColorE = Color.FromArgb(25, 255, 255, 255);
            mobilenumbertxtbox.ColorF = Color.Black;
            mobilenumbertxtbox.ForeColor = Color.White;
            mobilenumbertxtbox.Location = new Point(48, 74);
            mobilenumbertxtbox.Name = "mobilenumbertxtbox";
            mobilenumbertxtbox.PlaceholderText = "Mobilenumber";
            mobilenumbertxtbox.ShortcutsEnabled = false;
            mobilenumbertxtbox.Size = new Size(247, 23);
            mobilenumbertxtbox.TabIndex = 6;
            mobilenumbertxtbox.TextAlign = HorizontalAlignment.Center;
            mobilenumbertxtbox.KeyPress += mobilenumbertxtbox_KeyPress;
            // 
            // CustomerUpdateForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(820, 522);
            Controls.Add(panel1);
            Controls.Add(toppanelmove);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerUpdateForm";
            FormClosing += CustomerUpdateForm_FormClosing;
            Load += CustomerUpdateForm_Load;
            Shown += CustomerUpdateForm_Shown;
            toppanelmove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backicon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel toppanelmove;
        private Panel panel1;
        private Label label1;
        private Panel panel11;
        private Label label2;
        private ReaLTaiizor.Controls.DreamTextBox mobilenumbertxtbox;
        private Panel toppanelmove2;
        private Panel panel4;
        private Label label5;
        private ReaLTaiizor.Controls.DreamTextBox addresstxtbox;
        private Panel panel3;
        private Label label4;
        private ReaLTaiizor.Controls.DreamTextBox companynametxtbox;
        private Panel panel2;
        private Label label3;
        private ReaLTaiizor.Controls.DreamTextBox emailtxtbox;
        private Button submitchangesbtn;
        private PictureBox backicon;
        public TextBox nametextbox;
        private Label label6;
    }
}