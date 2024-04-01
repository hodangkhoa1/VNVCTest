using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VNVC_BAL.Enums;
using VNVC_BAL.Models;
using VNVC_BAL.Services.Interfaces;

namespace VNVC_API.Controllers
{
    [ApiController]
    public class AccountController(IAccountService accountService) : ControllerBase
    {
        private readonly IAccountService _accountService = accountService;

        #region Add Account
        /// <summary>
        /// UC0-001
        /// Add Account
        /// </summary>
        /// <returns>Specific HTTP Status code</returns>
        /// <response code="200">Return if add account is successful</response>
        /// <response code="400">If the account is exist</response>
        [HttpPost]
        [Route(ApiConstants.API_ADD_ACCOUNT)]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddAccount([FromBody] AccountRequest accountRequest)
        {
            try
            {
                return Ok(await _accountService.AddAccount(accountRequest));
            }
            catch (Exception e)
            {
                return Ok(new ResponseEntityDTO(null, false, e.Message));
            }
        }
        #endregion

        #region Get Account By Phone Number
        /// <summary>
        /// UC0-002
        /// Get Account By Phone Number
        /// </summary>
        /// <returns>Specific HTTP Status code</returns>
        /// <response code="200">Return information account if phone number is exist</response>
        /// <response code="404">If phone number is not found</response>
        [HttpPost]
        [Route(ApiConstants.API_GET_ACCOUNT)]
        [ProducesResponseType(typeof(AccountInformationDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAccountByPhoneNumber([FromBody] GetAccountRequest getAccountRequest)
        {
            try
            {
                return Ok(await _accountService.GetAccountByPhoneNumber(getAccountRequest));
            }
            catch (Exception e)
            {
                return Ok(new ResponseEntityDTO(null, false, e.Message));
            }
        }
        #endregion
    }
}
