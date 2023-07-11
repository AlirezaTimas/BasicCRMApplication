namespace CRM
{
    partial class SignInForm
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
            nametxtbox = new TextBox();
            label1 = new Label();
            lastnametxtbox = new TextBox();
            usernametextbox = new TextBox();
            Passtextbox = new TextBox();
            Passrepeattextbox = new TextBox();
            emailtxtbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            submitbutton = new Button();
            panel1 = new Panel();
            eyepicturebox = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            securityqtxtbox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyepicturebox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // nametxtbox
            // 
            nametxtbox.BackColor = Color.FromArgb(57, 63, 68);
            nametxtbox.BorderStyle = BorderStyle.None;
            nametxtbox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nametxtbox.ForeColor = Color.White;
            nametxtbox.Location = new Point(329, 161);
            nametxtbox.Margin = new Padding(2, 3, 2, 3);
            nametxtbox.Name = "nametxtbox";
            nametxtbox.Size = new Size(219, 25);
            nametxtbox.TabIndex = 0;
            nametxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(238, 195, 152);
            label1.Location = new Point(175, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 36);
            label1.TabIndex = 1;
            label1.Text = "ثبت نام کاربر جدید";
            // 
            // lastnametxtbox
            // 
            lastnametxtbox.BackColor = Color.FromArgb(57, 63, 68);
            lastnametxtbox.BorderStyle = BorderStyle.None;
            lastnametxtbox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastnametxtbox.ForeColor = Color.White;
            lastnametxtbox.Location = new Point(48, 161);
            lastnametxtbox.Margin = new Padding(2, 3, 2, 3);
            lastnametxtbox.Name = "lastnametxtbox";
            lastnametxtbox.Size = new Size(220, 25);
            lastnametxtbox.TabIndex = 3;
            lastnametxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // usernametextbox
            // 
            usernametextbox.BackColor = Color.FromArgb(57, 63, 68);
            usernametextbox.BorderStyle = BorderStyle.None;
            usernametextbox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernametextbox.ForeColor = Color.White;
            usernametextbox.Location = new Point(46, 254);
            usernametextbox.Margin = new Padding(2, 3, 2, 3);
            usernametextbox.Name = "usernametextbox";
            usernametextbox.PlaceholderText = "نام کاربری باید بصورت انگلیسی وارد شود";
            usernametextbox.ShortcutsEnabled = false;
            usernametextbox.Size = new Size(502, 25);
            usernametextbox.TabIndex = 4;
            usernametextbox.TextAlign = HorizontalAlignment.Center;
            usernametextbox.KeyPress += usernametextbox_KeyPress;
            // 
            // Passtextbox
            // 
            Passtextbox.BackColor = Color.FromArgb(57, 63, 68);
            Passtextbox.BorderStyle = BorderStyle.None;
            Passtextbox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Passtextbox.ForeColor = Color.White;
            Passtextbox.Location = new Point(48, 340);
            Passtextbox.Margin = new Padding(2, 3, 2, 3);
            Passtextbox.Name = "Passtextbox";
            Passtextbox.ShortcutsEnabled = false;
            Passtextbox.Size = new Size(502, 25);
            Passtextbox.TabIndex = 5;
            Passtextbox.TextAlign = HorizontalAlignment.Center;
            Passtextbox.UseSystemPasswordChar = true;
            Passtextbox.KeyPress += Passtextbox_KeyPress;
            // 
            // Passrepeattextbox
            // 
            Passrepeattextbox.BackColor = Color.FromArgb(57, 63, 68);
            Passrepeattextbox.BorderStyle = BorderStyle.None;
            Passrepeattextbox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Passrepeattextbox.ForeColor = Color.White;
            Passrepeattextbox.Location = new Point(48, 432);
            Passrepeattextbox.Margin = new Padding(2, 3, 2, 3);
            Passrepeattextbox.Name = "Passrepeattextbox";
            Passrepeattextbox.ShortcutsEnabled = false;
            Passrepeattextbox.Size = new Size(502, 25);
            Passrepeattextbox.TabIndex = 6;
            Passrepeattextbox.TextAlign = HorizontalAlignment.Center;
            Passrepeattextbox.UseSystemPasswordChar = true;
            Passrepeattextbox.KeyPress += Passrepeattextbox_KeyPress;
            // 
            // emailtxtbox
            // 
            emailtxtbox.BackColor = Color.FromArgb(57, 63, 68);
            emailtxtbox.BorderStyle = BorderStyle.None;
            emailtxtbox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxtbox.ForeColor = Color.White;
            emailtxtbox.Location = new Point(48, 521);
            emailtxtbox.Margin = new Padding(2, 3, 2, 3);
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.ShortcutsEnabled = false;
            emailtxtbox.Size = new Size(502, 25);
            emailtxtbox.TabIndex = 8;
            emailtxtbox.TextAlign = HorizontalAlignment.Center;
            emailtxtbox.KeyPress += emailadtxtbox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(238, 195, 152);
            label2.Location = new Point(516, 123);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 24);
            label2.TabIndex = 9;
            label2.Text = "نام";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(238, 195, 152);
            label3.Location = new Point(150, 123);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 10;
            label3.Text = "نام خانوادگی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 195, 152);
            label4.Location = new Point(456, 210);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 11;
            label4.Text = "نام کاربری";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(238, 195, 152);
            label5.Location = new Point(480, 303);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 24);
            label5.TabIndex = 12;
            label5.Text = "رمزعبور";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(238, 195, 152);
            label6.Location = new Point(437, 390);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 24);
            label6.TabIndex = 13;
            label6.Text = "تکرار رمزعبور";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(238, 195, 152);
            label7.Location = new Point(445, 479);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 24);
            label7.TabIndex = 14;
            label7.Text = "آدرس ایمیل";
            // 
            // submitbutton
            // 
            submitbutton.BackColor = Color.Transparent;
            submitbutton.BackgroundImageLayout = ImageLayout.None;
            submitbutton.FlatAppearance.BorderColor = Color.White;
            submitbutton.FlatAppearance.BorderSize = 0;
            submitbutton.FlatStyle = FlatStyle.Flat;
            submitbutton.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            submitbutton.ForeColor = Color.FromArgb(238, 195, 152);
            submitbutton.Location = new Point(223, 653);
            submitbutton.Margin = new Padding(2, 3, 2, 3);
            submitbutton.Name = "submitbutton";
            submitbutton.RightToLeft = RightToLeft.Yes;
            submitbutton.Size = new Size(174, 62);
            submitbutton.TabIndex = 15;
            submitbutton.Text = "ثبت نام";
            submitbutton.UseVisualStyleBackColor = false;
            submitbutton.Click += submitbutton_Click;
            submitbutton.MouseEnter += submitbutton_MouseEnter;
            submitbutton.MouseLeave += submitbutton_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(eyepicturebox);
            panel1.Location = new Point(568, 378);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(48, 46);
            panel1.TabIndex = 16;
            // 
            // eyepicturebox
            // 
            eyepicturebox.BackgroundImage = Properties.Resources.eye_white;
            eyepicturebox.BackgroundImageLayout = ImageLayout.Stretch;
            eyepicturebox.Cursor = Cursors.Hand;
            eyepicturebox.Dock = DockStyle.Fill;
            eyepicturebox.Location = new Point(0, 0);
            eyepicturebox.Margin = new Padding(2, 3, 2, 3);
            eyepicturebox.Name = "eyepicturebox";
            eyepicturebox.Size = new Size(48, 46);
            eyepicturebox.TabIndex = 0;
            eyepicturebox.TabStop = false;
            eyepicturebox.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 109);
            panel2.TabIndex = 17;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.back_arrow_white1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(22, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 54);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(238, 195, 152);
            label8.Location = new Point(175, 574);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(375, 24);
            label8.TabIndex = 18;
            label8.Text = "سوال امنیتی : نام اولین معلم شما چیست؟";
            // 
            // securityqtxtbox
            // 
            securityqtxtbox.BackColor = Color.FromArgb(57, 63, 68);
            securityqtxtbox.BorderStyle = BorderStyle.None;
            securityqtxtbox.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            securityqtxtbox.ForeColor = Color.White;
            securityqtxtbox.Location = new Point(48, 612);
            securityqtxtbox.Margin = new Padding(2, 3, 2, 3);
            securityqtxtbox.Name = "securityqtxtbox";
            securityqtxtbox.ShortcutsEnabled = false;
            securityqtxtbox.Size = new Size(502, 25);
            securityqtxtbox.TabIndex = 19;
            securityqtxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // SignInForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.wpasset2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(628, 731);
            Controls.Add(securityqtxtbox);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(submitbutton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(emailtxtbox);
            Controls.Add(Passrepeattextbox);
            Controls.Add(Passtextbox);
            Controls.Add(usernametextbox);
            Controls.Add(lastnametxtbox);
            Controls.Add(nametxtbox);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignInForm";
            FormClosing += SignInForm_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eyepicturebox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nametxtbox;
        private Label label1;
        private TextBox lastnametxtbox;
        private TextBox usernametextbox;
        private TextBox Passtextbox;
        private TextBox Passrepeattextbox;
        private TextBox emailtxtbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button submitbutton;
        private Panel panel1;
        private PictureBox eyepicturebox;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label8;
        private TextBox securityqtxtbox;
    }
}