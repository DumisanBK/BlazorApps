using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancassuranceApi.Services;
using BancassuranceApi.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancassuranceApi.Controllers
{
    [ApiController]
    [Route("t24")]
    [Authorize]
    public class T24Controller : ControllerBase
    {
        private readonly IT24AccountService _t24AccountService;
        private readonly IJsonResultFacade _jsonResultFacade;

        public T24Controller(IT24AccountService t24AccountService, IJsonResultFacade jsonResultFacade)
        {
            _t24AccountService = t24AccountService;
            _jsonResultFacade = jsonResultFacade;
        }

        [HttpGet]
        [Route("{accountNumber}")]
        public async Task<IActionResult> GetCustomerDetailsAsync(string accountNumber)
        {
            var result = await _t24AccountService.GetCustomerDetailsAsync(accountNumber);

            return Ok(result);
        }

        [HttpGet]
        [Route("can_fetch_account")]
        public async Task<IActionResult> CanFetchAccountAsync()
        {
            var result = await Task.Run(() => _t24AccountService.CanFetchAccount());

            return Ok(result);
        }
    }
}