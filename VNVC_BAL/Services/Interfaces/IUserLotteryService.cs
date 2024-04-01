using VNVC_BAL.Models;

namespace VNVC_BAL.Services.Interfaces
{
    public interface IUserLotteryService
    {
        Task<ResponseEntityDTO> GetUserLottery(IdRequest idRequest);

        Task<ResponseEntityDTO> AddUserLottery(UserLotteryRequest userLotteryRequest);
    }
}
