namespace VNVC_Client.Forms
{
    partial class Notification
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
            lblMessage = new Label();
            timerClose = new System.Windows.Forms.Timer(components);
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(73, 23);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(98, 23);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Message";
            // 
            // timerClose
            // 
            timerClose.Enabled = true;
            timerClose.Interval = 1000;
            timerClose.Tick += timerClose_Tick;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.AutoSize = true;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClose.ForeColor = Color.Red;
            btnClose.Image = Properties.Resources.cancel;
            btnClose.Location = new Point(398, 12);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 41);
            btnClose.TabIndex = 1;
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.success;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Notification
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(453, 69);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(lblMessage);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notification";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Notification";
            Load += Notification_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private System.Windows.Forms.Timer timerClose;
        private Button btnClose;
        private PictureBox pictureBox1;
    }
}