namespace CRM
{
    partial class LoginForm
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
            emailtxtbox = new TextBox();
            passtxtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            EnterButton = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // emailtxtbox
            // 
            emailtxtbox.BackColor = Color.FromArgb(57, 63, 68);
            emailtxtbox.BorderStyle = BorderStyle.FixedSingle;
            emailtxtbox.ForeColor = Color.White;
            emailtxtbox.Location = new Point(107, 99);
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.PlaceholderText = "Email";
            emailtxtbox.Size = new Size(279, 26);
            emailtxtbox.TabIndex = 1;
            emailtxtbox.TextAlign = HorizontalAlignment.Center;
            emailtxtbox.KeyPress += emailtxtbox_KeyPress;
            // 
            // passtxtbox
            // 
            passtxtbox.BackColor = Color.FromArgb(57, 63, 68);
            passtxtbox.BorderStyle = BorderStyle.FixedSingle;
            passtxtbox.ForeColor = Color.White;
            passtxtbox.Location = new Point(107, 167);
            passtxtbox.Name = "passtxtbox";
            passtxtbox.PlaceholderText = "Password";
            passtxtbox.Size = new Size(279, 26);
            passtxtbox.TabIndex = 2;
            passtxtbox.TextAlign = HorizontalAlignment.Center;
            passtxtbox.UseSystemPasswordChar = true;
            passtxtbox.KeyPress += passtxtbox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(238, 195, 152);
            label1.Location = new Point(415, 101);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 2;
            label1.Text = "ایمیل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(238, 195, 152);
            label2.Location = new Point(408, 169);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 3;
            label2.Text = "رمزعبور";
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Transparent;
            EnterButton.BackgroundImageLayout = ImageLayout.None;
            EnterButton.FlatAppearance.BorderSize = 0;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            EnterButton.ForeColor = Color.FromArgb(238, 195, 152);
            EnterButton.Location = new Point(174, 224);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(157, 58);
            EnterButton.TabIndex = 4;
            EnterButton.Text = "ورود";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += button1_Click;
            EnterButton.MouseEnter += button1_MouseEnter;
            EnterButton.MouseLeave += button1_MouseLeave;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.PaleTurquoise;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Transparent;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(144, 307);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(207, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ایمیلم / رمزم را فراموش کرده ام";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(238, 195, 152);
            label3.Location = new Point(177, 30);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(146, 27);
            label3.TabIndex = 0;
            label3.Text = "خوش آمدید !";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 195, 152);
            label4.Location = new Point(229, 361);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(185, 23);
            label4.TabIndex = 7;
            label4.Text = "حساب کاربری ندارید ؟";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.ForeColor = Color.Transparent;
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel2.LinkColor = Color.PaleTurquoise;
            linkLabel2.Location = new Point(87, 359);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.RightToLeft = RightToLeft.Yes;
            linkLabel2.Size = new Size(136, 25);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "اینجا کلیک کنید !";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 84);
            panel1.TabIndex = 9;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.back_arrow_white1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 41);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.eye_white;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(38, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 41);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.wpasset2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(506, 439);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(EnterButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passtxtbox);
            Controls.Add(emailtxtbox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox emailtxtbox;
        public TextBox passtxtbox;
        private Label label1;
        private Label label2;
        private Button EnterButton;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}