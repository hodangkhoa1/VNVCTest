namespace VNVC_Client.Forms
{
    partial class CheckAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAccount));
            label2 = new Label();
            btnCheck = new CustomButton();
            txtName = new TextBox();
            lblErrorPhoneNumber = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(75, 58);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCheck.BackColor = Color.MediumSlateBlue;
            btnCheck.BackgroundColor = Color.MediumSlateBlue;
            btnCheck.BorderColor = Color.PaleVioletRed;
            btnCheck.BorderRadius = 20;
            btnCheck.BorderSize = 0;
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Segoe UI", 12F);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(225, 160);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(188, 50);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Kiểm tra";
            btnCheck.TextColor = Color.White;
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(225, 60);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nhập số điện thoại";
            txtName.Size = new Size(305, 27);
            txtName.TabIndex = 8;
            txtName.TextChanged += txtName_TextChanged;
            txtName.Leave += txtName_Leave;
            // 
            // lblErrorPhoneNumber
            // 
            lblErrorPhoneNumber.AutoSize = true;
            lblErrorPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblErrorPhoneNumber.ForeColor = Color.Red;
            lblErrorPhoneNumber.Location = new Point(225, 98);
            lblErrorPhoneNumber.Name = "lblErrorPhoneNumber";
            lblErrorPhoneNumber.Size = new Size(236, 23);
            lblErrorPhoneNumber.TabIndex = 10;
            lblErrorPhoneNumber.Text = "Vui lòng nhập số điện thoại!";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Red;
            btnClose.Image = Properties.Resources.cancel;
            btnClose.Location = new Point(627, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 36);
            btnClose.TabIndex = 11;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CheckAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 247);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(lblErrorPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(btnCheck);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckAccount";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += CheckAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private CustomButton btnCheck;
        private TextBox txtName;
        private Label lblErrorPhoneNumber;
        private Button btnClose;
    }
}