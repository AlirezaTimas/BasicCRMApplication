namespace CRM
{
    partial class exitconfirmform
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(238, 195, 152);
            label1.Location = new Point(62, 70);
            label1.Name = "label1";
            label1.Size = new Size(315, 23);
            label1.TabIndex = 0;
            label1.Text = "آیا میخواهید از برنامه خارج شوید ؟";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LawnGreen;
            button1.Location = new Point(234, 133);
            button1.Name = "button1";
            button1.Size = new Size(143, 80);
            button1.TabIndex = 1;
            button1.Text = "بله";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(62, 133);
            button2.Name = "button2";
            button2.Size = new Size(143, 80);
            button2.TabIndex = 2;
            button2.Text = "خیر";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // exitconfirmform
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.wpasset;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(447, 264);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "exitconfirmform";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "exitconfirmform";
            FormClosing += exitconfirmform_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}