namespace CRM
{
    partial class FullExitConfirmMainForm
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
            panel2 = new Panel();
            NoButton = new Button();
            YesButton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 317);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(NoButton);
            panel2.Controls.Add(YesButton);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(14, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 289);
            panel2.TabIndex = 0;
            // 
            // NoButton
            // 
            NoButton.BackColor = Color.Transparent;
            NoButton.FlatAppearance.BorderSize = 0;
            NoButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            NoButton.FlatStyle = FlatStyle.Flat;
            NoButton.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            NoButton.ForeColor = Color.Black;
            NoButton.Location = new Point(105, 129);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(255, 87);
            NoButton.TabIndex = 2;
            NoButton.Text = "خیر";
            NoButton.UseVisualStyleBackColor = false;
            NoButton.Click += NoButton_Click;
            NoButton.MouseEnter += NoButton_MouseEnter;
            NoButton.MouseLeave += NoButton_MouseLeave;
            // 
            // YesButton
            // 
            YesButton.BackColor = Color.Transparent;
            YesButton.FlatAppearance.BorderSize = 0;
            YesButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            YesButton.FlatStyle = FlatStyle.Flat;
            YesButton.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            YesButton.ForeColor = Color.Black;
            YesButton.Location = new Point(401, 129);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(255, 87);
            YesButton.TabIndex = 1;
            YesButton.Text = "بله";
            YesButton.UseVisualStyleBackColor = false;
            YesButton.Click += YesButton_Click;
            YesButton.MouseEnter += YesButton_MouseEnter;
            YesButton.MouseLeave += YesButton_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 53);
            label1.Name = "label1";
            label1.Size = new Size(619, 39);
            label1.TabIndex = 0;
            label1.Text = "آیا واقعا قصد دارید از برنامه خارج شوید ؟";
            // 
            // FullExitConfirmMainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(804, 338);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FullExitConfirmMainForm";
            Text = "FullExitConfirmMainForm";
            FormClosing += FullExitConfirmMainForm_FormClosing;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button NoButton;
        private Button YesButton;
    }
}