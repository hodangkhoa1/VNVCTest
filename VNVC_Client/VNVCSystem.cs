using Newtonsoft.Json;
using System.Diagnostics;
using VNVC_Client.Forms;
using VNVC_Client.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace VNVC_Client
{
    public partial class VNVCSystem : Form
    {
        private Button currentButton;
        private string text;
        private int lengthTitle = 0;
        private int indexOption = 0;
        private readonly List<LotteryResultsModelAPI> lotteryResultsModelAPIList = [];

        public VNVCSystem()
        {
            InitializeComponent();
            btnAdd.Hide();
            panel2.Hide();
            panelRamCPU.Hide();
        }

        private static void Alert(string message, Forms.Notification.enmType type, int width)
        {
            Forms.Notification notification = new();
            notification.ShowAlert(message, type, width);
        }

        private async void btnLotteryResults_Click(object sender, EventArgs e)
        {
            indexOption = 0;
            await LoadData();
            btnAdd.Show();
            panel2.Hide();
            panelRamCPU.Hide();
            dataGridView1.Show();
            ActiveButton(sender);
        }

        private async void btnHistory_Click(object sender, EventArgs e)
        {
            indexOption = 1;
            await LoadData();
            btnAdd.Hide();
            dataGridView1.Show();
            panel2.Hide();
            panelRamCPU.Hide();
            ActiveButton(sender);
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            indexOption = 2;
            dataGridView1.DataSource = null;
            btnAdd.Hide();
            dataGridView1.Hide();
            panel2.Hide();
            panelRamCPU.Show();
            ActiveButton(sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            indexOption = 3;
            dataGridView1.DataSource = null;
            btnAdd.Hide();
            dataGridView1.Hide();
            panel2.Show();
            panelRamCPU.Hide();
            ActiveButton(sender);
        }

        private void DisableButtonBottom()
        {
            btnAdd.Enabled = false;
        }

        private void EnabledButtonBottom()
        {
            btnAdd.Enabled = true;
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 192, 0);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = Color.FromArgb(0, 192, 0);
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void timerRunTitle_Tick(object sender, EventArgs e)
        {
            if (lengthTitle < text.Length)
            {
                lblTitle.Text += text.ElementAt(lengthTitle);
                lengthTitle++;
            }
            else
            {
                timerRunTitle.Stop();
            }
        }

        private void VNVCSystem_Load(object sender, EventArgs e)
        {
            text = lblTitle.Text;
            lblTitle.Text = "";
            timerRunTitle.Start();
        }

        private async Task LoadData()
        {
            dataGridView1.DataSource = null;
            string urlAPI, jsonString;
            HttpClient client = new();

            try
            {
                switch (indexOption)
                {
                    case 0:
                        urlAPI = "https://dienmaysaigonxanh.com:442/get-all-lottery-results";
                        jsonString = await client.GetStringAsync(urlAPI);
                        ResponseLotteryResultsData responseLotteryResultsData = JsonConvert.DeserializeObject<ResponseLotteryResultsData>(jsonString);
                        dataGridView1.DataSource = responseLotteryResultsData.Data;
                        dataGridView1.AutoResizeColumns();
                        Alert(responseLotteryResultsData.Message, Forms.Notification.enmType.Success, 543);
                        break;
                    case 1:
                        var getAccountID = Properties.Settings.Default.AccountID;

                        if (!string.IsNullOrEmpty(getAccountID))
                        {
                            urlAPI = "https://dienmaysaigonxanh.com:442/get-all-user-lottery?ID=" + getAccountID;
                            jsonString = await client.GetStringAsync(urlAPI);
                            ResponseUserLotteryData responseUserLotteryData = JsonConvert.DeserializeObject<ResponseUserLotteryData>(jsonString);
                            dataGridView1.DataSource = responseUserLotteryData.Data;
                            dataGridView1.AutoResizeColumns();
                            Alert(responseUserLotteryData.Message, Forms.Notification.enmType.Success, 543);
                        }
                        else
                        {
                            Alert("Tài khoản chưa có thực hiện đặt cược!", Notification.enmType.Error, 543);
                        }
                        break;
                }
            }
            catch (Exception)
            {
                Alert("Xảy ra lỗi! Vui lòng thử lại", Forms.Notification.enmType.Error, 500);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var getAccountID = Properties.Settings.Default.AccountID;

                if (!string.IsNullOrEmpty(getAccountID))
                {
                    btnAdd.Show();
                    AddLottery addLottery = new();
                    addLottery.ShowDialog();
                    await LoadData();
                }
                else
                {
                    CheckAccount checkAccount = new();
                    checkAccount.Show();
                }
            }
            catch (Exception)
            {
                Alert("Xảy ra lỗi! Vui lòng thử lại", Forms.Notification.enmType.Error, 500);
            }
        }

        private void VNVCSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkAuthor.LinkVisited = true;
            Process.Start(new ProcessStartInfo { FileName = @"https://github.com/hodangkhoa1", UseShellExecute = true });
        }
    }
}
