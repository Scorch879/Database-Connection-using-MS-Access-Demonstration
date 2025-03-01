namespace Week8Activity
{
    partial class Form2
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
            label8 = new Label();
            label10 = new Label();
            fg1Tbx = new TextBox();
            fg2Tbx = new TextBox();
            panel4 = new Panel();
            label1 = new Label();
            yesBtn = new Button();
            pictureBox1 = new PictureBox();
            noBtn = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(199, 395);
            label8.Name = "label8";
            label8.Size = new Size(142, 23);
            label8.TabIndex = 44;
            label8.Text = "FINAL GRADE 1 : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(199, 451);
            label10.Name = "label10";
            label10.Size = new Size(142, 23);
            label10.TabIndex = 47;
            label10.Text = "FINAL GRADE 2 : ";
            // 
            // fg1Tbx
            // 
            fg1Tbx.Location = new Point(343, 393);
            fg1Tbx.Margin = new Padding(3, 4, 3, 4);
            fg1Tbx.Name = "fg1Tbx";
            fg1Tbx.Size = new Size(272, 27);
            fg1Tbx.TabIndex = 43;
            // 
            // fg2Tbx
            // 
            fg2Tbx.Location = new Point(343, 449);
            fg2Tbx.Margin = new Padding(3, 4, 3, 4);
            fg2Tbx.Name = "fg2Tbx";
            fg2Tbx.Size = new Size(272, 27);
            fg2Tbx.TabIndex = 45;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(noBtn);
            panel4.Controls.Add(yesBtn);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(fg2Tbx);
            panel4.Controls.Add(fg1Tbx);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(12, 13);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(669, 387);
            panel4.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 103);
            label1.Name = "label1";
            label1.Size = new Size(553, 46);
            label1.TabIndex = 48;
            label1.Text = "Are you sure you want to delete ?";
            // 
            // yesBtn
            // 
            yesBtn.BackColor = Color.FromArgb(192, 255, 192);
            yesBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yesBtn.Location = new Point(89, 247);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(166, 53);
            yesBtn.TabIndex = 49;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = false;
            yesBtn.Click += yesBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._384547568_3686299594923254_1959228372170578470_n;
            pictureBox1.Location = new Point(20, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(624, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // noBtn
            // 
            noBtn.BackColor = Color.FromArgb(255, 192, 192);
            noBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noBtn.Location = new Point(405, 247);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(168, 53);
            noBtn.TabIndex = 51;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = false;
            noBtn.Click += noBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 410);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private Label label10;
        private TextBox fg1Tbx;
        private TextBox fg2Tbx;
        private Panel panel4;
        private Button yesBtn;
        private Label label1;
        private Button noBtn;
        private PictureBox pictureBox1;
    }
}