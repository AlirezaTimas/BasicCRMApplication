namespace CRM
{
    partial class Passrecoveryform
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
            panel1 = new Panel();
            label1 = new Label();
            returnpicturebox = new PictureBox();
            forgotlabel = new Label();
            forgotcombobox = new ComboBox();
            tobelabel = new Label();
            textbox = new TextBox();
            Searchbutton = new Button();
            securitylabel = new Label();
            securityqtxtbox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnpicturebox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(returnpicturebox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 66);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(238, 195, 152);
            label1.Location = new Point(199, 25);
            label1.Name = "label1";
            label1.Size = new Size(276, 28);
            label1.TabIndex = 1;
            label1.Text = "بازیابی ایمیل یا رمز عبور";
            // 
            // returnpicturebox
            // 
            returnpicturebox.BackgroundImage = Properties.Resources.back_arrow_white1;
            returnpicturebox.BackgroundImageLayout = ImageLayout.Stretch;
            returnpicturebox.Location = new Point(12, 12);
            returnpicturebox.Name = "returnpicturebox";
            returnpicturebox.Size = new Size(41, 41);
            returnpicturebox.TabIndex = 0;
            returnpicturebox.TabStop = false;
            returnpicturebox.Click += returnpicturebox_Click;
            returnpicturebox.MouseEnter += returnpicturebox_MouseEnter;
            returnpicturebox.MouseLeave += returnpicturebox_MouseLeave;
            // 
            // forgotlabel
            // 
            forgotlabel.AutoSize = true;
            forgotlabel.BackColor = Color.Transparent;
            forgotlabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            forgotlabel.ForeColor = Color.FromArgb(238, 195, 152);
            forgotlabel.Location = new Point(354, 112);
            forgotlabel.Name = "forgotlabel";
            forgotlabel.RightToLeft = RightToLeft.Yes;
            forgotlabel.Size = new Size(298, 24);
            forgotlabel.TabIndex = 3;
            forgotlabel.Text = "چه چیزی را فراموش کرده اید ؟";
            // 
            // forgotcombobox
            // 
            forgotcombobox.BackColor = Color.FromArgb(57, 63, 68);
            forgotcombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            forgotcombobox.FlatStyle = FlatStyle.Flat;
            forgotcombobox.ForeColor = Color.White;
            forgotcombobox.FormattingEnabled = true;
            forgotcombobox.Location = new Point(24, 109);
            forgotcombobox.Name = "forgotcombobox";
            forgotcombobox.Size = new Size(306, 33);
            forgotcombobox.TabIndex = 4;
            forgotcombobox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tobelabel
            // 
            tobelabel.AutoSize = true;
            tobelabel.BackColor = Color.Transparent;
            tobelabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tobelabel.ForeColor = Color.FromArgb(238, 195, 152);
            tobelabel.Location = new Point(336, 226);
            tobelabel.Name = "tobelabel";
            tobelabel.RightToLeft = RightToLeft.Yes;
            tobelabel.Size = new Size(141, 21);
            tobelabel.TabIndex = 5;
            tobelabel.Text = "LabelToBETEXT";
            tobelabel.Visible = false;
            // 
            // textbox
            // 
            textbox.BackColor = Color.FromArgb(57, 63, 68);
            textbox.ForeColor = Color.White;
            textbox.Location = new Point(24, 223);
            textbox.Name = "textbox";
            textbox.Size = new Size(306, 31);
            textbox.TabIndex = 6;
            textbox.Visible = false;
            // 
            // Searchbutton
            // 
            Searchbutton.BackColor = Color.Transparent;
            Searchbutton.BackgroundImageLayout = ImageLayout.None;
            Searchbutton.FlatAppearance.BorderSize = 0;
            Searchbutton.FlatStyle = FlatStyle.Flat;
            Searchbutton.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Searchbutton.ForeColor = Color.FromArgb(238, 195, 152);
            Searchbutton.Location = new Point(262, 343);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(157, 58);
            Searchbutton.TabIndex = 9;
            Searchbutton.Text = "جستجو";
            Searchbutton.UseVisualStyleBackColor = false;
            Searchbutton.Visible = false;
            Searchbutton.Click += Searchbutton_Click;
            Searchbutton.MouseEnter += Searchbutton_MouseEnter;
            Searchbutton.MouseLeave += Searchbutton_MouseLeave;
            // 
            // securitylabel
            // 
            securitylabel.AutoSize = true;
            securitylabel.BackColor = Color.Transparent;
            securitylabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            securitylabel.ForeColor = Color.FromArgb(238, 195, 152);
            securitylabel.Location = new Point(336, 285);
            securitylabel.Name = "securitylabel";
            securitylabel.RightToLeft = RightToLeft.Yes;
            securitylabel.Size = new Size(141, 21);
            securitylabel.TabIndex = 8;
            securitylabel.Text = "LabelToBETEXT";
            securitylabel.Visible = false;
            // 
            // securityqtxtbox
            // 
            securityqtxtbox.BackColor = Color.FromArgb(57, 63, 68);
            securityqtxtbox.ForeColor = Color.White;
            securityqtxtbox.Location = new Point(24, 282);
            securityqtxtbox.Name = "securityqtxtbox";
            securityqtxtbox.Size = new Size(306, 31);
            securityqtxtbox.TabIndex = 7;
            securityqtxtbox.Visible = false;
            // 
            // Passrecoveryform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wpasset;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(679, 428);
            Controls.Add(securityqtxtbox);
            Controls.Add(securitylabel);
            Controls.Add(Searchbutton);
            Controls.Add(textbox);
            Controls.Add(tobelabel);
            Controls.Add(forgotcombobox);
            Controls.Add(forgotlabel);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Passrecoveryform";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += Passrecoveryform_FormClosing;
            Load += Passrecoveryform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnpicturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox returnpicturebox;
        private Label label1;
        private Label forgotlabel;
        private ComboBox forgotcombobox;
        private Label tobelabel;
        private TextBox textbox;
        private Button Searchbutton;
        private Label securitylabel;
        private TextBox securityqtxtbox;
    }
}