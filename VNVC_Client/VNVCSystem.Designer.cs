namespace VNVC_Client
{
    partial class VNVCSystem
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VNVCSystem));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelMenu = new GradientBackground();
            btnAbout = new Button();
            btnMonitoring = new Button();
            btnHistory = new Button();
            btnOrderManagement = new Button();
            panelLogo = new Panel();
            panelTitle = new Panel();
            btnClose = new Button();
            lblTitle = new Label();
            panelDesktop = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            linkAuthor = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            productBindingSource = new BindingSource(components);
            timerRunTitle = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            btnAdd = new CustomButton();
            panelRamCPU = new Panel();
            panelMenu.SuspendLayout();
            panelTitle.SuspendLayout();
            panelDesktop.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Angle = 0F;
            panelMenu.ColorBottom = Color.WhiteSmoke;
            panelMenu.ColorTop = Color.WhiteSmoke;
            panelMenu.Controls.Add(btnAbout);
            panelMenu.Controls.Add(btnMonitoring);
            panelMenu.Controls.Add(btnHistory);
            panelMenu.Controls.Add(btnOrderManagement);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(289, 641);
            panelMenu.TabIndex = 0;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.Transparent;
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.Dock = DockStyle.Top;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 12F);
            btnAbout.ForeColor = Color.FromArgb(0, 192, 0);
            btnAbout.Image = Properties.Resources.information;
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 424);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(10, 0, 0, 0);
            btnAbout.Size = new Size(289, 90);
            btnAbout.TabIndex = 6;
            btnAbout.Text = "Về chúng tôi";
            btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnMonitoring
            // 
            btnMonitoring.BackColor = Color.Transparent;
            btnMonitoring.Cursor = Cursors.Hand;
            btnMonitoring.Dock = DockStyle.Top;
            btnMonitoring.FlatAppearance.BorderSize = 0;
            btnMonitoring.FlatStyle = FlatStyle.Flat;
            btnMonitoring.Font = new Font("Segoe UI", 12F);
            btnMonitoring.ForeColor = Color.FromArgb(0, 192, 0);
            btnMonitoring.Image = Properties.Resources.category;
            btnMonitoring.ImageAlign = ContentAlignment.MiddleLeft;
            btnMonitoring.Location = new Point(0, 334);
            btnMonitoring.Name = "btnMonitoring";
            btnMonitoring.Padding = new Padding(10, 0, 0, 0);
            btnMonitoring.Size = new Size(289, 90);
            btnMonitoring.TabIndex = 5;
            btnMonitoring.Text = "Monitoring";
            btnMonitoring.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMonitoring.UseVisualStyleBackColor = false;
            btnMonitoring.Click += btnMonitoring_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.Transparent;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 12F);
            btnHistory.ForeColor = Color.FromArgb(0, 192, 0);
            btnHistory.Image = Properties.Resources.debit_card;
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 244);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(10, 0, 0, 0);
            btnHistory.Size = new Size(289, 90);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "Lịch sử đặt cược";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.BackColor = Color.Transparent;
            btnOrderManagement.Cursor = Cursors.Hand;
            btnOrderManagement.Dock = DockStyle.Top;
            btnOrderManagement.FlatAppearance.BorderSize = 0;
            btnOrderManagement.FlatStyle = FlatStyle.Flat;
            btnOrderManagement.Font = new Font("Segoe UI", 12F);
            btnOrderManagement.ForeColor = Color.FromArgb(0, 192, 0);
            btnOrderManagement.Image = Properties.Resources.box;
            btnOrderManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrderManagement.Location = new Point(0, 154);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Padding = new Padding(10, 0, 0, 0);
            btnOrderManagement.Size = new Size(289, 90);
            btnOrderManagement.TabIndex = 1;
            btnOrderManagement.Text = "Kết quả sổ xố";
            btnOrderManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrderManagement.UseVisualStyleBackColor = false;
            btnOrderManagement.Click += btnLotteryResults_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.WhiteSmoke;
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(289, 154);
            panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.WhiteSmoke;
            panelTitle.Controls.Add(btnClose);
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(289, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(965, 154);
            panelTitle.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Red;
            btnClose.Image = Properties.Resources.cancel;
            btnClose.Location = new Point(908, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 36);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 192, 0);
            lblTitle.Location = new Point(6, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(959, 133);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CHÀO MỪNG ĐẾN VỚI XỔ SỐ KIẾN THIẾT CON GÀ TRỐNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(panel2);
            panelDesktop.Controls.Add(dataGridView1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(289, 154);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(965, 487);
            panelDesktop.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 487);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(linkAuthor, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1853848F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.67045F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.14417F));
            tableLayoutPanel1.Size = new Size(965, 487);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // linkAuthor
            // 
            linkAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkAuthor.AutoSize = true;
            linkAuthor.Location = new Point(3, 315);
            linkAuthor.Name = "linkAuthor";
            linkAuthor.Size = new Size(959, 172);
            linkAuthor.TabIndex = 1;
            linkAuthor.TabStop = true;
            linkAuthor.Text = "© Existing Xo So Kien Thiet Con Ga Trong App. All Rights Reserved | Design by Khoa Ho";
            linkAuthor.TextAlign = ContentAlignment.MiddleCenter;
            linkAuthor.LinkClicked += linkAuthor_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(959, 49);
            label1.TabIndex = 0;
            label1.Text = "Hệ Thống Xổ Số Kiến Thiến Con Gà Trống";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 49);
            label2.Name = "label2";
            label2.Size = new Size(959, 266);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(965, 487);
            dataGridView1.TabIndex = 0;
            // 
            // timerRunTitle
            // 
            timerRunTitle.Enabled = true;
            timerRunTitle.Tick += timerRunTitle_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panelRamCPU);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(289, 522);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 119);
            panel1.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.BackgroundColor = Color.CornflowerBlue;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(765, 57);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Đặt cược";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelRamCPU
            // 
            panelRamCPU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRamCPU.Location = new Point(0, -368);
            panelRamCPU.Name = "panelRamCPU";
            panelRamCPU.Size = new Size(965, 487);
            panelRamCPU.TabIndex = 1;
            // 
            // VNVCSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1254, 641);
            Controls.Add(panel1);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VNVCSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VNVC System";
            WindowState = FormWindowState.Maximized;
            FormClosed += VNVCSystem_FormClosed;
            Load += VNVCSystem_Load;
            panelMenu.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GradientBackground panelMenu;
        private Button btnOrderManagement;
        private Panel panelLogo;
        private Button btnHistory;
        private Button btnMonitoring;
        private Panel panelTitle;
        private Label lblTitle;
        private Panel panelDesktop;
        private System.Windows.Forms.Timer timerRunTitle;
        private Panel panel1;
        private DataGridView dataGridView1;
        private CustomButton btnAdd;
        private BindingSource productBindingSource;
        private Button btnClose;
        private Button btnAbout;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private LinkLabel linkAuthor;
        private Panel panelRamCPU;
    }
}