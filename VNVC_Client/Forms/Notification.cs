using VNVC_Client.Properties;

namespace VNVC_Client.Forms
{
    public partial class Notification : Form
    {
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        public Notification()
        {
            InitializeComponent();
        }

        private Notification.enmAction notificationAction;

        private int x, y;

        public void ShowAlert(string message, enmType type, int width)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Notification notification = (Notification)Application.OpenForms[fname];

                if (notification == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = 30;
                    this.Location = new Point(this.x, this.y);
                    this.Size = new Size(width, 69);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }

            this.lblMessage.Text = message;
            this.Show();
            this.notificationAction = enmAction.start;
            this.timerClose.Interval = 1;
            timerClose.Start();
        }

        public Notification(string message, Color background)
        {
            BackColor = background;
            lblMessage.Text = message;
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            timerClose.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timerClose.Interval = 1;
            notificationAction = enmAction.close;
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            switch (this.notificationAction)
            {
                case enmAction.wait:
                    timerClose.Interval = 5000;
                    notificationAction = enmAction.close;
                    break;
                case enmAction.start:
                    timerClose.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            notificationAction = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timerClose.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}
