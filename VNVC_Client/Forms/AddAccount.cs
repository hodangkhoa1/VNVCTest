using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using VNVC_Client.Models;

namespace VNVC_Client.Forms
{
    public partial class AddAccount : Form
    {
        [GeneratedRegex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        private static partial Regex RegexEmail();

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

        public bool ViewOrAdd { get; set; }

        public AccountInformationModelAPI AccountInformation { get; set; }

        public AddAccount()
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

        private void AddAccount_Load(object sender, EventArgs e)
        {
            lblErrorEmail.Text = "";
            lblErrorFirstName.Text = "";
            lblErrorLastName.Text = "";
            lblErrorFullName.Text = "";
            lblErrorPhoneNumber.Text = "";
            lblErrorAddress.Text = "";

            if (ViewOrAdd == true)
            {
                txtEmail.ReadOnly = true;
                txtFirstName.ReadOnly = true;
                txtLastName.ReadOnly = true;
                txtFullName.ReadOnly = true;
                txtPhoneNumber.ReadOnly = true;
                txtAddress.ReadOnly = true;
                dtpBirthday.Enabled = false;
                btnAdd.Hide();

                txtEmail.Text = AccountInformation.Email;
                txtFirstName.Text = AccountInformation.FirstName;
                txtLastName.Text = AccountInformation.LastName;
                txtFullName.Text = AccountInformation.FullName;
                txtPhoneNumber.Text = AccountInformation.PhoneNumber;
                txtAddress.Text = AccountInformation.Address;
                dtpBirthday.Value = (DateTime)AccountInformation.Birthday;
            }
        }

        private static void Alert(string message, Notification.enmType type, int width)
        {
            Notification notification = new();
            notification.ShowAlert(message, type, width);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && txtFullName.Text == "" && txtPhoneNumber.Text == "" && txtAddress.Text == "")
            {
                lblErrorEmail.Text = "Vui lòng nhập email!";
                lblErrorFirstName.Text = "Vui lòng nhập tên riêng!";
                lblErrorLastName.Text = "Vui lòng nhập tên họ!";
                lblErrorFullName.Text = "Vui lòng nhập họ và tên!";
                lblErrorPhoneNumber.Text = "Vui lòng nhập số điện thoại!";
                lblErrorAddress.Text = "Vui lòng nhập địa chỉ!";
            }
            else if (txtEmail.Text == "")
            {
                lblErrorEmail.Text = "Vui lòng nhập email!";
            }
            else if (txtFirstName.Text == "")
            {
                lblErrorFirstName.Text = "Vui lòng nhập tên riêng!";
            }
            else if (txtLastName.Text == "")
            {
                lblErrorLastName.Text = "Vui lòng nhập tên họ!";
            }
            else if (txtFullName.Text == "")
            {
                lblErrorFullName.Text = "Vui lòng nhập họ và tên!";
            }
            else if (txtPhoneNumber.Text == "")
            {
                lblErrorPhoneNumber.Text = "Vui lòng nhập số điện thoại!";
            }
            else if (txtAddress.Text == "")
            {
                lblErrorAddress.Text = "Vui lòng nhập địa chỉ!";
            }
            else
            {
                try
                {
                    var accountRequest = new AccountRequest()
                    {
                        Email = txtEmail.Text,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        FullName = txtFullName.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Birthday = dtpBirthday.Value,
                        Address = txtAddress.Text,
                    };
                    HttpClient client = new();
                    var urlAPI = "https://dienmaysaigonxanh.com:442/add-account";
                    StringContent stringContent = new(JsonConvert.SerializeObject(accountRequest), Encoding.UTF8, "application/json");
                    var jsonString = await client.PostAsync(urlAPI, stringContent);

                    if (jsonString.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        AddAccountResultsData addAccountResultsData = JsonConvert.DeserializeObject<AddAccountResultsData>(await jsonString.Content.ReadAsStringAsync());
                        Alert(addAccountResultsData.Message, Notification.enmType.Success, 543);
                        var checkAccountPhoneNumber = new CheckAccountRequest()
                        {
                            PhoneNumber = txtPhoneNumber.Text,
                        };
                        urlAPI = "https://dienmaysaigonxanh.com:442/get-account";
                        stringContent = new(JsonConvert.SerializeObject(checkAccountPhoneNumber), Encoding.UTF8, "application/json");
                        jsonString = await client.PostAsync(urlAPI, stringContent);
                        AccountInformationResultsData accountInformationResultsData = JsonConvert.DeserializeObject<AccountInformationResultsData>(await jsonString.Content.ReadAsStringAsync());
                        Properties.Settings.Default.AccountID = accountInformationResultsData.Data.AccountID.ToString();
                        this.Hide();
                    }
                    else
                    {
                        Alert("Xảy ra lỗi! Vui lòng thử lại", Notification.enmType.Success, 543);
                    }
                }
                catch (Exception)
                {
                    Alert("Xảy ra lỗi! Vui lòng thử lại", Notification.enmType.Error, 500);
                }
            }
        }

        private void CheckValidationEmail()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblErrorEmail.Text = "Vui lòng nhập email!";
            }
            else if (!RegexEmail().IsMatch(txtEmail.Text))
            {
                lblErrorEmail.Text = "Địa chỉ email không hợp lệ!";
            }
            else
            {
                lblErrorEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            CheckValidationEmail();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CheckValidationEmail();
        }

        private void CheckValidationFirstName()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                lblErrorFirstName.Text = "Vui lòng nhập tên riêng!";
            }
            else
            {
                lblErrorFirstName.Text = "";
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            CheckValidationFirstName();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            CheckValidationFirstName();
        }

        private void CheckValidationLastName()
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                lblErrorLastName.Text = "Vui lòng nhập tên họ!";
            }
            else
            {
                lblErrorLastName.Text = "";
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            CheckValidationLastName();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            CheckValidationLastName();
        }

        private void CheckValidationFullName()
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                lblErrorFullName.Text = "Vui lòng nhập họ và tên!";
            }
            else
            {
                lblErrorFullName.Text = "";
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            CheckValidationFullName();
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            CheckValidationFullName();
        }

        private void CheckValidationPhoneNumber()
        {
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                lblErrorPhoneNumber.Text = "Vui lòng nhập số điện thoại!";
            }
            else
            {
                lblErrorPhoneNumber.Text = "";
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            CheckValidationPhoneNumber();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            CheckValidationPhoneNumber();
        }

        private void CheckValidationAddress()
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                lblErrorAddress.Text = "Vui lòng nhập địa chỉ!";
            }
            else
            {
                lblErrorAddress.Text = "";
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            CheckValidationAddress();
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            CheckValidationAddress();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
