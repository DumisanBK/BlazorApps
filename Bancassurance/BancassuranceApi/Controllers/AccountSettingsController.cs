using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BancassuranceApi.Services;
using BancassuranceApi.Utils;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancassuranceApi.Controllers
{
    [ApiController]
    [Route("account_settings")]
    public class AccountSettingsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IJsonResultFacade _jsonResultFacade;
        private readonly IAccountSettingsService _accountSettingsService;

        public AccountSettingsController(IMapper mapper, IJsonResultFacade jsonResultFacade,
            IAccountSettingsService accountSettingsService)
        {
            _mapper = mapper;
            _jsonResultFacade = jsonResultFacade;
            _accountSettingsService = accountSettingsService;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddAccountAsync([FromBody] SpecialAccountVm specialAccount)
        {
            if (ModelState.IsValid)
            {
                var account = _mapper.Map<AccountSettings>(specialAccount);

                var result = await _accountSettingsService.AddAccountSettingAsync(account);

                return Ok(_jsonResultFacade.BooleanResult(result));
            }

            return Ok(_jsonResultFacade.FormNotValidResult());
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAccountsAsync()
        {
            var accounts = await _accountSettingsService.GetAccountSettingsAsync();

            return Ok(_jsonResultFacade.ListResult(accounts));
        }

        [HttpGet]
        [Route("is_multiple_account/{account}")]
        public async Task<IActionResult> IsMultipleAccountAsync(string account)
        {
            var result = await _accountSettingsService.IsMultipleAccount(account);

            return Ok(_jsonResultFacade.BooleanResult(result));
        }

        [HttpPost]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _accountSettingsService.RemoveAccountSettingsAsync(id);

            return Ok(_jsonResultFacade.BooleanResult(result));
        }
    }
}
