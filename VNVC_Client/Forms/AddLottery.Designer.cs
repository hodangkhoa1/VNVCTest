namespace VNVC_Client.Forms
{
    partial class AddLottery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLottery));
            label2 = new Label();
            label3 = new Label();
            btnAdd = new CustomButton();
            txtResult = new TextBox();
            lblErrorResult = new Label();
            dtpSlot = new DateTimePicker();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(88, 54);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 1;
            label2.Text = "Slot";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(88, 130);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 2;
            label3.Text = "Result";
            // 
            // btnAdd
            // 
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
            btnAdd.Location = new Point(225, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 50);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Đặt Cược";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(225, 134);
            txtResult.Name = "txtResult";
            txtResult.PlaceholderText = "Enter Result";
            txtResult.Size = new Size(305, 27);
            txtResult.TabIndex = 9;
            txtResult.TextChanged += txtResult_TextChanged;
            txtResult.Leave += txtResult_Leave;
            // 
            // lblErrorResult
            // 
            lblErrorResult.AutoSize = true;
            lblErrorResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblErrorResult.ForeColor = Color.Red;
            lblErrorResult.Location = new Point(225, 176);
            lblErrorResult.Name = "lblErrorResult";
            lblErrorResult.Size = new Size(162, 23);
            lblErrorResult.TabIndex = 11;
            lblErrorResult.Text = "Please enter result!";
            // 
            // dtpSlot
            // 
            dtpSlot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpSlot.Location = new Point(225, 56);
            dtpSlot.Name = "dtpSlot";
            dtpSlot.Size = new Size(305, 27);
            dtpSlot.TabIndex = 29;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Red;
            btnClose.Image = Properties.Resources.cancel;
            btnClose.Location = new Point(627, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 36);
            btnClose.TabIndex = 48;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // AddLottery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 323);
            Controls.Add(btnClose);
            Controls.Add(dtpSlot);
            Controls.Add(lblErrorResult);
            Controls.Add(txtResult);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddLottery";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Load += AddLottery_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private CustomButton btnAdd;
        private TextBox txtResult;
        private Label lblErrorResult;
        private DateTimePicker dtpSlot;
        private Button btnClose;
    }
}