using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VNVC_BAL.Enums;
using VNVC_BAL.Models;
using VNVC_BAL.Services.Implements;
using VNVC_BAL.Services.Interfaces;

namespace VNVC_API.Controllers
{
    [ApiController]
    public class LotteryResultsController(ILotteryResultsService lotteryResultsService) : ControllerBase
    {
        private readonly ILotteryResultsService _lotteryResultsService = lotteryResultsService;

        #region Get All Lottery Results
        /// <summary>
        /// UC0-001
        /// Get All Lottery Results
        /// </summary>
        /// <returns>Specific HTTP Status code</returns>
        /// <response code="200">Return information lottery results if lottery results is exist</response>
        /// <response code="404">If lottery results is not found</response>
        [HttpGet]
        [Route(ApiConstants.API_GET_ALL_LOTTERY_RESULTS)]
        [ProducesResponseType(typeof(List<LotteryResultsInformationDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetLotteryResults()
        {
            try
            {
                return Ok(await _lotteryResultsService.GetLotteryResults());
            }
            catch (Exception e)
            {
                return Ok(new ResponseEntityDTO(null, false, e.Message));
            }
        }
        #endregion
    }
}
