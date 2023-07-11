namespace CRM
{
    partial class StartingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingForm));
            label1 = new Label();
            label2 = new Label();
            move_pannel = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel2 = new Panel();
            move_pannel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(238, 195, 152);
            label1.Location = new Point(166, 122);
            label1.Name = "label1";
            label1.Size = new Size(97, 42);
            label1.TabIndex = 0;
            label1.Text = "CRM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(12, 202);
            label2.MaximumSize = new Size(400, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(396, 217);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // move_pannel
            // 
            move_pannel.BackColor = Color.Transparent;
            move_pannel.Controls.Add(panel1);
            move_pannel.Dock = DockStyle.Top;
            move_pannel.Location = new Point(0, 0);
            move_pannel.Name = "move_pannel";
            move_pannel.Size = new Size(1159, 57);
            move_pannel.TabIndex = 3;
            move_pannel.MouseDown += move_pannel_MouseDown;
            move_pannel.MouseMove += move_pannel_MouseMove;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(1097, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 57);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.x_white;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.x_white;
            pictureBox2.Location = new Point(0, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 42);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(238, 195, 152);
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(114, 448);
            button2.Name = "button2";
            button2.Size = new Size(194, 58);
            button2.TabIndex = 4;
            button2.TabStop = false;
            button2.Text = "شروع کنید";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.metaverse_businessman_wearing_vr_virtual_reality_headset_hand_touching_virtual_screen_global_link_connecting_diagram_dark_background_networking_security_digital_inte;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(move_pannel);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 656);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // StartingForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Ivory;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1159, 656);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartingForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += StartingForm_FormClosing;
            move_pannel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel move_pannel;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
    }
}