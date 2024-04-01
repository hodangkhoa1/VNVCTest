using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using VNVC_Client.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VNVC_Client.Forms
{
    public partial class CheckAccount : Form
    {

        public CheckAccount()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

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

        private void CheckAccount_Load(object sender, EventArgs e)
        {
            lblErrorPhoneNumber.Text = "";
        }

        private static void Alert(string message, Forms.Notification.enmType type, int width)
        {
            Forms.Notification notification = new();
            notification.ShowAlert(message, type, width);
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                lblErrorPhoneNumber.Text = "Vui lòng nhập số điện thoại!";
            }
            else
            {
                try
                {
                    var checkAccountPhoneNumber = new CheckAccountRequest()
                    {
                        PhoneNumber = txtName.Text,
                    };
                    HttpClient client = new();
                    var urlAPI = "https://dienmaysaigonxanh.com:442/get-account";
                    StringContent stringContent = new(JsonConvert.SerializeObject(checkAccountPhoneNumber), Encoding.UTF8, "application/json");
                    var jsonString = await client.PostAsync(urlAPI, stringContent);

                    if (jsonString.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        AccountInformationResultsData accountInformationResultsData = JsonConvert.DeserializeObject<AccountInformationResultsData>(await jsonString.Content.ReadAsStringAsync());

                        if (accountInformationResultsData.Data != null)
                        {
                            Properties.Settings.Default.AccountID = accountInformationResultsData.Data.AccountID.ToString();
                            this.Hide();
                            AddAccount addAccount = new()
                            {
                                ViewOrAdd = true,
                                AccountInformation = new()
                                {
                                    AccountID = accountInformationResultsData.Data.AccountID,
                                    Email = accountInformationResultsData.Data.Email,
                                    FirstName = accountInformationResultsData.Data.FirstName,
                                    LastName = accountInformationResultsData.Data.LastName,
                                    FullName = accountInformationResultsData.Data.FullName,
                                    Birthday = accountInformationResultsData.Data.Birthday,
                                    PhoneNumber = accountInformationResultsData.Data.PhoneNumber,
                                    Address = accountInformationResultsData.Data.Address,
                                    InsertedDate = accountInformationResultsData.Data.InsertedDate
                                }
                            };
                            addAccount.Show();
                        }
                        else
                        {
                            this.Hide();
                            AddAccount addAccount = new()
                            {
                                ViewOrAdd = false,
                            };
                            addAccount.Show();
                        }
                    }
                    else
                    {
                        Alert("Xảy ra lỗi! Vui lòng thử lại", Notification.enmType.Error, 500);
                    }
                }
                catch (Exception)
                {
                    Alert("Xảy ra lỗi! Vui lòng thử lại", Notification.enmType.Error, 500);
                }
            }
        }

        private void CheckValidationName()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblErrorPhoneNumber.Text = "Vui lòng nhập số điện thoại!";
            }
            else
            {
                lblErrorPhoneNumber.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            CheckValidationName();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CheckValidationName();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
