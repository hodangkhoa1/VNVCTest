using FluentValidation.Results;
using VNVC_BAL.Enums;
using VNVC_BAL.Models;
using VNVC_BAL.Services.Interfaces;
using VNVC_BAL.Utils;
using VNVC_BAL.Validators;
using VNVC_DAL.Models;
using VNVC_DAL.Repositories.Implements;
using VNVC_DAL.Repositories.Interfaces;

namespace VNVC_BAL.Services.Implements
{
    public class UserLotteryService(IRepository<UserLottery> userLotteryRepository) : IUserLotteryService
    {
        private readonly IRepository<UserLottery> _userLotteryRepository = userLotteryRepository;

        public async Task<ResponseEntityDTO> AddUserLottery(UserLotteryRequest userLotteryRequest)
        {
            string errorMessage;
            bool status = false;
            var validator = new UserLotteryRequestValidator();

            try
            {
                if (userLotteryRequest == null)
                {
                    errorMessage = "Thông tin của Api đã bị lỗi, vui lòng thử lại hoặc liên hệ với nhà phát triển để được hỗ trợ thêm!";
                }
                else
                {
                    UserLottery userLottery = FunctionConvert.ConvertObjectToObject<UserLottery, UserLotteryRequest>(userLotteryRequest);
                    userLottery.InsertedDate = DateTime.Now;

                    ValidationResult results = validator.Validate(userLotteryRequest);
                    errorMessage = FunctionValidation.GetErrorInFluentValidation(results);

                    if (string.IsNullOrEmpty(errorMessage))
                    {
                        if (await _userLotteryRepository.ActionEdit(userLottery, ActionConstants.ACTION_ADD) == true)
                        {
                            status = true;
                            errorMessage = "Đặt cược thành công!";
                        }
                        else
                        {
                            errorMessage = "Đặt cược thất bại!";
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

        public async Task<ResponseEntityDTO> GetUserLottery(IdRequest idRequest)
        {
            string errorMessage;
            bool status = false;
            List<LotteryResultsInformationDTO>? result = null;
            var validator = new IdRequestValidator();

            try
            {
                if (idRequest == null)
                {
                    errorMessage = "Vui lòng liên hệ với admin!";
                }
                else
                {
                    ValidationResult results = validator.Validate(idRequest);
                    errorMessage = FunctionValidation.GetErrorInFluentValidation(results);

                    if (string.IsNullOrEmpty(errorMessage))
                    {
                        var getListUserLotteryByID = await _userLotteryRepository.GetAll(new()
                        {
                            AccountID = idRequest.ID,
                        }, ActionConstants.ACTION_GET_ALL, 0, 0);

                        if (getListUserLotteryByID.Any())
                        {
                            errorMessage = "Danh sách lịch sử đặt cược trống!";
                        }
                        else
                        {
                            result = FunctionConvert.ConvertListToList<LotteryResultsInformationDTO, UserLottery>(getListUserLotteryByID);
                            status = true;
                            errorMessage = "Lấy danh sách lịch sử đặt cược thành công!";
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
