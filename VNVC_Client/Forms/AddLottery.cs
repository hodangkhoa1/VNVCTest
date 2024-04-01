using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Text;
using VNVC_Client.Models;

namespace VNVC_Client.Forms
{
    public partial class AddLottery : Form
    {
        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static partial IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public AddLottery()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void AddLottery_Load(object sender, EventArgs e)
        {
            lblErrorResult.Text = "";
        }

        private static void Alert(string message, Notification.enmType type, int width)
        {
            Notification notification = new();
            notification.ShowAlert(message, type, width);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                lblErrorResult.Text = "Vui lòng nhập kết quả!";
            }
            else
            {
                try
                {
                    var userLotteryRequest = new UserLotteryRequest()
                    {
                        AccountID = Guid.Parse(Properties.Settings.Default.AccountID),
                        Result = int.Parse(txtResult.Text),
                        Slot = dtpSlot.Value
                    };
                    HttpClient client = new();
                    var urlAPI = "https://dienmaysaigonxanh.com:442/add-user-lottery";
                    StringContent stringContent = new(JsonConvert.SerializeObject(userLotteryRequest), Encoding.UTF8, "application/json");
                    var jsonString = await client.PostAsync(urlAPI, stringContent);

                    if (jsonString.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        this.Hide();
                    }
                    else
                    {
                        Alert("Xảy ra lỗi! Vui lòng thử lại", Notification.enmType.Success, 543);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void CheckValidationResult()
        {
            if (string.IsNullOrEmpty(txtResult.Text))
            {
                lblErrorResult.Text = "Please input category status!";
            }
            else
            {
                lblErrorResult.Text = "";
            }
        }

        private void txtResult_Leave(object sender, EventArgs e)
        {
            CheckValidationResult();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            CheckValidationResult();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
