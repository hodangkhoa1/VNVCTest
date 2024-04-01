namespace VNVC_Client.Forms
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            dtpBirthday = new DateTimePicker();
            lblOrderDate = new Label();
            lblPrice = new Label();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            lblStatus = new Label();
            lblName = new Label();
            lblOrderAddress = new Label();
            txtFirstName = new TextBox();
            btnAdd = new CustomButton();
            lblErrorEmail = new Label();
            lblErrorFirstName = new Label();
            lblErrorPhoneNumber = new Label();
            lblErrorLastName = new Label();
            txtLastName = new TextBox();
            lblErrorFullName = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            lblErrorAddress = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // dtpBirthday
            // 
            dtpBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpBirthday.Location = new Point(322, 332);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(305, 27);
            dtpBirthday.TabIndex = 28;
            // 
            // lblOrderDate
            // 
            lblOrderDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 12F);
            lblOrderDate.Location = new Point(146, 330);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(85, 28);
            lblOrderDate.TabIndex = 26;
            lblOrderDate.Text = "Birthday";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.Location = new Point(146, 173);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(103, 28);
            lblPrice.TabIndex = 25;
            lblPrice.Text = "Last Name";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(322, 397);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Enter Phone Number";
            txtPhoneNumber.Size = new Size(305, 27);
            txtPhoneNumber.TabIndex = 24;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            txtPhoneNumber.Leave += txtPhoneNumber_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(322, 23);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.Size = new Size(305, 27);
            txtEmail.TabIndex = 23;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(146, 393);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(144, 28);
            lblStatus.TabIndex = 22;
            lblStatus.Text = "Phone Number";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(146, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 28);
            lblName.TabIndex = 21;
            lblName.Text = "Email";
            // 
            // lblOrderAddress
            // 
            lblOrderAddress.AutoSize = true;
            lblOrderAddress.Font = new Font("Segoe UI", 12F);
            lblOrderAddress.Location = new Point(146, 93);
            lblOrderAddress.Name = "lblOrderAddress";
            lblOrderAddress.Size = new Size(106, 28);
            lblOrderAddress.TabIndex = 31;
            lblOrderAddress.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(322, 97);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Enter First Name";
            txtFirstName.Size = new Size(305, 27);
            txtFirstName.TabIndex = 32;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            txtFirstName.Leave += txtFirstName_Leave;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.BackColor = Color.MediumSlateBlue;
            btnAdd.BackgroundColor = Color.MediumSlateBlue;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(322, 573);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 50);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Add";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(323, 60);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(161, 23);
            lblErrorEmail.TabIndex = 36;
            lblErrorEmail.Text = "Please enter email!";
            // 
            // lblErrorFirstName
            // 
            lblErrorFirstName.AutoSize = true;
            lblErrorFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblErrorFirstName.ForeColor = Color.Red;
            lblErrorFirstName.Location = new Point(323, 136);
            lblErrorFirstName.Name = "lblErrorFirstName";
            lblErrorFirstName.Size = new Size(199, 23);
            lblErrorFirstName.TabIndex = 37;
            lblErrorFirstName.Text = "Please enter first name!";
            // 
            // lblErrorPhoneNumber
            // 
            lblErrorPhoneNumber.AutoSize = true;
            lblErrorPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblErrorPhoneNumber.ForeColor = Color.Red;
            lblErrorPhoneNumber.Location = new Point(323, 437);
            lblErrorPhoneNumber.Name = "lblErrorPhoneNumber";
            lblErrorPhoneNumber.Size = new Size(235, 23);
            lblErrorPhoneNumber.TabIndex = 38;
            lblErrorPhoneNumber.Text = "Please enter phone number!";
            // 
            // lblErrorLastName
            // 
            lblErrorLastName.AutoSize = true;
            lblErrorLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblErrorLastName.ForeColor = Color.Red;
            lblErrorLastName.Location = new Point(323, 213);
            lblErrorLastName.Name = "lblErrorLastName";
            lblErrorLastName.Size = new Size(194, 23);
            lblErrorLastName.TabIndex = 40;
            lblErrorLastName.Text = "Please enter last name!";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(322, 174);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Enter Last Name";
            txtLastName.Size = new Size(305, 27);
            txtLastName.TabIndex = 39;
            txtLastName.TextChanged += txtLastName_TextChanged;
            txtLastName.Leave += txtLastName_Leave;
            // 
            // lblErrorFullName
            // 
            lblErrorFullName.AutoSize = true;
            lblErrorFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblErrorFullName.ForeColor = Color.Red;
            lblErrorFullName.Location = new Point(323, 293);
            lblErrorFullName.Name = "lblErrorFullName";
            lblErrorFullName.Size = new Size(193, 23);
            lblErrorFullName.TabIndex = 43;
            lblErrorFullName.Text = "Please enter full name!";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(322, 254);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter Full Name";
            txtFullName.Size = new Size(305, 27);
            txtFullName.TabIndex = 42;
            txtFullName.TextChanged += txtFullName_TextChanged;
            txtFullName.Leave += txtFullName_Leave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(146, 253);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 41;
            label3.Text = "Full Name";
            // 
            // lblErrorAddress
            // 
            lblErrorAddress.AutoSize = true;
            lblErrorAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblErrorAddress.ForeColor = Color.Red;
            lblErrorAddress.Location = new Point(323, 517);
            lblErrorAddress.Name = "lblErrorAddress";
            lblErrorAddress.Size = new Size(178, 23);
            lblErrorAddress.TabIndex = 46;
            lblErrorAddress.Text = "Please enter address!";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(322, 477);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Enter Address";
            txtAddress.Size = new Size(305, 27);
            txtAddress.TabIndex = 45;
            txtAddress.TextChanged += txtAddress_TextChanged;
            txtAddress.Leave += txtAddress_Leave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(146, 473);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 44;
            label5.Text = "Address";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Red;
            btnClose.Image = Properties.Resources.cancel;
            btnClose.Location = new Point(743, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 36);
            btnClose.TabIndex = 47;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(btnClose);
            Controls.Add(lblErrorAddress);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(lblErrorFullName);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(lblErrorLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblErrorPhoneNumber);
            Controls.Add(lblErrorFirstName);
            Controls.Add(lblErrorEmail);
            Controls.Add(btnAdd);
            Controls.Add(txtFirstName);
            Controls.Add(lblOrderAddress);
            Controls.Add(dtpBirthday);
            Controls.Add(lblOrderDate);
            Controls.Add(lblPrice);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(lblStatus);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAccount";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Load += AddAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpBirthday;
        private Label lblOrderDate;
        private Label lblPrice;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Label lblStatus;
        private Label lblName;
        private Label lblOrderAddress;
        private TextBox txtFirstName;
        private CustomButton btnAdd;
        private Label lblErrorEmail;
        private Label lblErrorFirstName;
        private Label lblErrorPhoneNumber;
        private Label lblErrorLastName;
        private TextBox txtLastName;
        private Label lblErrorFullName;
        private TextBox txtFullName;
        private Label label3;
        private Label lblErrorAddress;
        private TextBox txtAddress;
        private Label label5;
        private Button btnClose;
    }
}