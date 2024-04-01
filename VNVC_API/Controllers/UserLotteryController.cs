using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VNVC_BAL.Enums;
using VNVC_BAL.Models;
using VNVC_BAL.Services.Implements;
using VNVC_BAL.Services.Interfaces;

namespace VNVC_API.Controllers
{
    [ApiController]
    public class UserLotteryController(IUserLotteryService userLotteryService) : ControllerBase
    {
        private readonly IUserLotteryService _userLotteryService = userLotteryService;

        #region Get All User Lottery
        /// <summary>
        /// UC0-001
        /// Get All User Lottery
        /// </summary>
        /// <returns>Specific HTTP Status code</returns>
        /// <response code="200">Return information user lottery if user lottery is exist</response>
        /// <response code="404">If user lottery is not found</response>
        [HttpGet]
        [Route(ApiConstants.API_GET_ALL_USER_LOTTERY)]
        [ProducesResponseType(typeof(List<UserLotteryInformationDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserLottery([FromQuery] IdRequest idRequest)
        {
            try
            {
                return Ok(await _userLotteryService.GetUserLottery(idRequest));
            }
            catch (Exception e)
            {
                return Ok(new ResponseEntityDTO(null, false, e.Message));
            }
        }
        #endregion

        #region Add User Lottery
        /// <summary>
        /// UC0-002
        /// Add User Lottery
        /// </summary>
        /// <returns>Specific HTTP Status code</returns>
        /// <response code="200">Return if add user lottery is successful</response>
        /// <response code="400">If the user lottery went wrong</response>
        [HttpPost]
        [Route(ApiConstants.API_ADD_USER_LOTTERY)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddUserLottery([FromBody] UserLotteryRequest userLotteryRequest)
        {
            try
            {
                return Ok(await _userLotteryService.AddUserLottery(userLotteryRequest));
            }
            catch (Exception e)
            {
                return Ok(new ResponseEntityDTO(null, false, e.Message));
            }
        }
        #endregion
    }
}
