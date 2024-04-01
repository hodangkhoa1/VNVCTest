namespace VNVC_Client
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            progressBar = new CircularProgressBar.CircularProgressBar();
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            TimerProgress = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            progressBar.AnimationSpeed = 500;
            progressBar.BackColor = Color.FromArgb(42, 40, 60);
            progressBar.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold);
            progressBar.ForeColor = Color.FromArgb(85, 213, 219);
            progressBar.InnerColor = Color.FromArgb(42, 40, 60);
            progressBar.InnerMargin = 2;
            progressBar.InnerWidth = -1;
            progressBar.Location = new Point(48, 101);
            progressBar.MarqueeAnimationSpeed = 2000;
            progressBar.Name = "progressBar";
            progressBar.OuterColor = Color.FromArgb(26, 28, 43);
            progressBar.OuterMargin = -25;
            progressBar.OuterWidth = 26;
            progressBar.ProgressColor = Color.FromArgb(85, 213, 219);
            progressBar.ProgressWidth = 6;
            progressBar.SecondaryFont = new Font("Segoe UI", 36F);
            progressBar.Size = new Size(250, 252);
            progressBar.StartAngle = 270;
            progressBar.Step = 15;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.SubscriptColor = Color.FromArgb(166, 166, 166);
            progressBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            progressBar.SubscriptText = "";
            progressBar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            progressBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            progressBar.SuperscriptText = "";
            progressBar.TabIndex = 0;
            progressBar.TextMargin = new Padding(8, 8, 0, 0);
            progressBar.Value = 68;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(85, 213, 219);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(326, 83);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Xổ số kiến thiết\r\nCon Gà Trống";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(85, 213, 219);
            label1.Location = new Point(107, 371);
            label1.Name = "label1";
            label1.Size = new Size(129, 35);
            label1.TabIndex = 2;
            label1.Text = "Loading...";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = Color.FromArgb(85, 213, 219);
            label2.Location = new Point(12, 407);
            label2.Name = "label2";
            label2.Size = new Size(326, 57);
            label2.TabIndex = 3;
            label2.Text = "Copyright © KhoaHo";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimerProgress
            // 
            TimerProgress.Enabled = true;
            TimerProgress.Tick += TimerProgress_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 40, 60);
            ClientSize = new Size(350, 473);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(progressBar);
            Cursor = Cursors.WaitCursor;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CircularProgressBar.CircularProgressBar progressBar;
        private Label lblTitle;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer TimerProgress;
    }
}