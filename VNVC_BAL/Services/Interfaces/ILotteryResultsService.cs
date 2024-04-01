using VNVC_BAL.Models;

namespace VNVC_BAL.Services.Interfaces
{
    public interface ILotteryResultsService
    {
        Task<ResponseEntityDTO> GetLotteryResults();
    }
}
