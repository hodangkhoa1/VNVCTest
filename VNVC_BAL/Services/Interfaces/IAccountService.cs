using VNVC_BAL.Models;

namespace VNVC_BAL.Services.Interfaces
{
    public interface IAccountService
    {
        Task<ResponseEntityDTO> AddAccount(AccountRequest accountRequest);

        Task<ResponseEntityDTO> GetAccountByPhoneNumber(GetAccountRequest getAccountRequest);
    }
}
