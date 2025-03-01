namespace Week8Activity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            dgvTable = new DataGridView();
            menuStrip1 = new MenuStrip();
            testConnection = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            loadDatabtn = new Button();
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            panel4 = new Panel();
            courseTbx = new TextBox();
            label9 = new Label();
            yrTbx = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            fg2Tbx = new TextBox();
            courseNum2Tbx = new TextBox();
            fg1Tbx = new TextBox();
            courseNum1Tbx = new TextBox();
            lastNametbx = new TextBox();
            studentIDtbx = new TextBox();
            firstNametbx = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dgvTable);
            panel2.Location = new Point(719, 51);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(939, 512);
            panel2.TabIndex = 1;
            // 
            // dgvTable
            // 
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Dock = DockStyle.Fill;
            dgvTable.Location = new Point(0, 0);
            dgvTable.Margin = new Padding(3, 4, 3, 4);
            dgvTable.Name = "dgvTable";
            dgvTable.ReadOnly = true;
            dgvTable.RowHeadersWidth = 51;
            dgvTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTable.Size = new Size(939, 512);
            dgvTable.TabIndex = 0;
            dgvTable.CellClick += dataGrid_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { testConnection, loadFileToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1685, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // testConnection
            // 
            testConnection.Name = "testConnection";
            testConnection.Size = new Size(128, 24);
            testConnection.Text = "Test Connection";
            testConnection.Click += testConnection_Click;
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(92, 24);
            loadFileToolStripMenuItem.Text = "Load Data";
            loadFileToolStripMenuItem.Click += loadDatabtn_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 678);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1685, 36);
            panel3.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 255, 128);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(loadDatabtn, 3, 0);
            tableLayoutPanel1.Controls.Add(insertBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(updateBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(deleteBtn, 1, 0);
            tableLayoutPanel1.Location = new Point(243, 594);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1206, 76);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // loadDatabtn
            // 
            loadDatabtn.Dock = DockStyle.Fill;
            loadDatabtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadDatabtn.Location = new Point(906, 7);
            loadDatabtn.Margin = new Padding(3, 4, 3, 4);
            loadDatabtn.Name = "loadDatabtn";
            loadDatabtn.Size = new Size(294, 62);
            loadDatabtn.TabIndex = 11;
            loadDatabtn.Text = "Load Data";
            loadDatabtn.UseVisualStyleBackColor = true;
            loadDatabtn.Click += loadDatabtn_Click;
            // 
            // insertBtn
            // 
            insertBtn.Dock = DockStyle.Fill;
            insertBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertBtn.Location = new Point(606, 7);
            insertBtn.Margin = new Padding(3, 4, 3, 4);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(291, 62);
            insertBtn.TabIndex = 10;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Dock = DockStyle.Fill;
            updateBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(6, 7);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(291, 62);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Dock = DockStyle.Fill;
            deleteBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(306, 7);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(291, 62);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(courseTbx);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(yrTbx);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(fg2Tbx);
            panel4.Controls.Add(courseNum2Tbx);
            panel4.Controls.Add(fg1Tbx);
            panel4.Controls.Add(courseNum1Tbx);
            panel4.Controls.Add(lastNametbx);
            panel4.Controls.Add(studentIDtbx);
            panel4.Controls.Add(firstNametbx);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(12, 51);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(675, 514);
            panel4.TabIndex = 11;
            // 
            // courseTbx
            // 
            courseTbx.Location = new Point(343, 185);
            courseTbx.Margin = new Padding(3, 4, 3, 4);
            courseTbx.Name = "courseTbx";
            courseTbx.Size = new Size(272, 27);
            courseTbx.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(254, 186);
            label9.Name = "label9";
            label9.Size = new Size(83, 23);
            label9.TabIndex = 53;
            label9.Text = "COURSE :";
            // 
            // yrTbx
            // 
            yrTbx.Location = new Point(343, 234);
            yrTbx.Margin = new Padding(3, 4, 3, 4);
            yrTbx.Name = "yrTbx";
            yrTbx.Size = new Size(272, 27);
            yrTbx.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(280, 238);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 51;
            label5.Text = "YEAR :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 509);
            panel1.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 192);
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 163);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 24;
            label4.Text = "Student Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4042171;
            pictureBox1.Location = new Point(5, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // fg2Tbx
            // 
            fg2Tbx.Location = new Point(343, 449);
            fg2Tbx.Margin = new Padding(3, 4, 3, 4);
            fg2Tbx.Name = "fg2Tbx";
            fg2Tbx.Size = new Size(272, 27);
            fg2Tbx.TabIndex = 45;
            // 
            // courseNum2Tbx
            // 
            courseNum2Tbx.Location = new Point(343, 339);
            courseNum2Tbx.Margin = new Padding(3, 4, 3, 4);
            courseNum2Tbx.Name = "courseNum2Tbx";
            courseNum2Tbx.Size = new Size(272, 27);
            courseNum2Tbx.TabIndex = 41;
            // 
            // fg1Tbx
            // 
            fg1Tbx.Location = new Point(343, 393);
            fg1Tbx.Margin = new Padding(3, 4, 3, 4);
            fg1Tbx.Name = "fg1Tbx";
            fg1Tbx.Size = new Size(272, 27);
            fg1Tbx.TabIndex = 43;
            // 
            // courseNum1Tbx
            // 
            courseNum1Tbx.Location = new Point(343, 284);
            courseNum1Tbx.Margin = new Padding(3, 4, 3, 4);
            courseNum1Tbx.Name = "courseNum1Tbx";
            courseNum1Tbx.Size = new Size(272, 27);
            courseNum1Tbx.TabIndex = 39;
            // 
            // lastNametbx
            // 
            lastNametbx.Location = new Point(343, 78);
            lastNametbx.Margin = new Padding(3, 4, 3, 4);
            lastNametbx.Name = "lastNametbx";
            lastNametbx.Size = new Size(272, 27);
            lastNametbx.TabIndex = 31;
            // 
            // studentIDtbx
            // 
            studentIDtbx.Location = new Point(343, 22);
            studentIDtbx.Margin = new Padding(3, 4, 3, 4);
            studentIDtbx.Name = "studentIDtbx";
            studentIDtbx.Size = new Size(272, 27);
            studentIDtbx.TabIndex = 34;
            // 
            // firstNametbx
            // 
            firstNametbx.Location = new Point(343, 134);
            firstNametbx.Margin = new Padding(3, 4, 3, 4);
            firstNametbx.Name = "firstNametbx";
            firstNametbx.Size = new Size(272, 27);
            firstNametbx.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(229, 22);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 32;
            label2.Text = "STUDENT ID : ";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(196, 284);
            label6.Name = "label6";
            label6.Size = new Size(147, 23);
            label6.TabIndex = 40;
            label6.Text = "COURSE NUM 1 : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(195, 341);
            label7.Name = "label7";
            label7.Size = new Size(147, 23);
            label7.TabIndex = 42;
            label7.Text = "COURSE NUM 2 : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(229, 136);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 35;
            label1.Text = "FIRST NAME : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(233, 78);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 36;
            label3.Text = "LAST NAME : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1685, 714);
            Controls.Add(panel4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information Table";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private MenuStrip menuStrip1;
        private Panel panel3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem testConnection;
        private DataGridView dgvTable;
        private TableLayoutPanel tableLayoutPanel1;
        private Button updateBtn;
        private Button deleteBtn;
        private Button loadDatabtn;
        private Button insertBtn;
        private Panel panel4;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox fg2Tbx;
        private TextBox courseNum2Tbx;
        private TextBox fg1Tbx;
        private TextBox courseNum1Tbx;
        private TextBox lastNametbx;
        private TextBox studentIDtbx;
        private TextBox firstNametbx;
        private Label label2;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label1;
        private Label label3;
        private TextBox yrTbx;
        private Label label5;
        private TextBox courseTbx;
        private Label label9;
    }
}
