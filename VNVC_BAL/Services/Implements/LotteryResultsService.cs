using VNVC_BAL.Enums;
using VNVC_BAL.Models;
using VNVC_BAL.Services.Interfaces;
using VNVC_BAL.Utils;
using VNVC_DAL.Models;
using VNVC_DAL.Repositories.Interfaces;

namespace VNVC_BAL.Services.Implements
{
    public class LotteryResultsService(IRepository<LotteryResults> lotteryResultsRepository) : ILotteryResultsService
    {
        private readonly IRepository<LotteryResults> _lotteryResultsRepository = lotteryResultsRepository;

        public async Task<ResponseEntityDTO> GetLotteryResults()
        {
            string errorMessage;
            bool status = false;
            List<LotteryResultsInformationDTO>? result = null;

            try
            {
                var getAllLotteryResults = await _lotteryResultsRepository.GetAll(null, ActionConstants.ACTION_GET_ALL, 0, 0);

                if (getAllLotteryResults == null)
                {
                    errorMessage = "Kết quả xổ số không tồn tại!";
                }
                else
                {
                    result = FunctionConvert.ConvertListToList<LotteryResultsInformationDTO, LotteryResults>(getAllLotteryResults);
                    status = true;
                    errorMessage = "Lấy danh sách kết quả xổ số thành công!";
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
