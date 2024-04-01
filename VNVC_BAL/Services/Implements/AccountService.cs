using FluentValidation.Results;
using VNVC_BAL.Enums;
using VNVC_BAL.Models;
using VNVC_BAL.Services.Interfaces;
using VNVC_BAL.Utils;
using VNVC_BAL.Validators;
using VNVC_DAL.Models;
using VNVC_DAL.Repositories.Interfaces;

namespace VNVC_BAL.Services.Implements
{
    public class AccountService(IRepository<Account> accountRepository) : IAccountService
    {
        private readonly IRepository<Account> _accountRepository = accountRepository;

        public async Task<ResponseEntityDTO> AddAccount(AccountRequest accountRequest)
        {
            string errorMessage;
            bool status = false;
            var validator = new AccountRequestValidator();

            try
            {
                if (accountRequest == null)
                {
                    errorMessage = "Thông tin của Api đã bị lỗi, vui lòng thử lại hoặc liên hệ với nhà phát triển để được hỗ trợ thêm!";
                }
                else
                {
                    Account account = FunctionConvert.ConvertObjectToObject<Account, AccountRequest>(accountRequest);
                    account.InsertedDate = DateTime.Now;
                    account.ColorAvatar = FunctionRandom.ColorAvatar();
                    account.DefaultAvatar = account.FullName?.FirstOrDefault().ToString();

                    ValidationResult results = validator.Validate(accountRequest);
                    errorMessage = FunctionValidation.GetErrorInFluentValidation(results);

                    if (string.IsNullOrEmpty(errorMessage))
                    {
                        if (await _accountRepository.Get(account, ActionConstants.ACTION_GET_BY_PHONE_NUMBER) == null)
                        {
                            if (await _accountRepository.ActionEdit(account, ActionConstants.ACTION_ADD) == true)
                            {
                                status = true;
                                errorMessage = "Thêm mới tài khoản thành công!";
                            }
                            else
                            {
                                errorMessage = "Thêm mới tài khoản thất bại!";
                            }
                        }
                        else
                        {
                            errorMessage = "Tài khoản đã tồn tại!";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }

            return new ResponseEntityDTO(null, status, errorMessage);
        }

        public async Task<ResponseEntityDTO> GetAccountByPhoneNumber(GetAccountRequest getAccountRequest)
        {
            string errorMessage;
            bool status = false;
            AccountInformationDTO? result = null;
            var validator = new GetAccountRequestValidator();

            try
            {
                if (getAccountRequest == null)
                {
                    errorMessage = "Thông tin của Api đã bị lỗi, vui lòng thử lại hoặc liên hệ với nhà phát triển để được hỗ trợ thêm!";
                }
                else
                {
                    ValidationResult results = validator.Validate(getAccountRequest);
                    errorMessage = FunctionValidation.GetErrorInFluentValidation(results);

                    if (string.IsNullOrEmpty(errorMessage))
                    {
                        var getAccountByPhoneNumber = await _accountRepository.Get(new()
                        {
                            PhoneNumber = getAccountRequest.PhoneNumber,
                        }, ActionConstants.ACTION_GET_BY_PHONE_NUMBER);

                        if (getAccountByPhoneNumber == null)
                        {
                            errorMessage = "Thông tin tài khoản không tồn tại!";
                        }
                        else
                        {
                            result = FunctionConvert.ConvertObjectToObject<AccountInformationDTO, Account>(getAccountByPhoneNumber);
                            status = true;
                            errorMessage = "Lấy thông tin tài khoản thành công!";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }

            return new ResponseEntityDTO(result, status, errorMessage);
        }
    }
}
