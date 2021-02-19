using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancassuranceApi.Security;
using BancassuranceApi.Services;
using BancassuranceApi.Utils;
using BancassuranceApi.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BancassuranceApi.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        private readonly ITokenGenerator _tokenGenerator;
        private readonly IJsonResultFacade _jsonResultFacade;
        private readonly ISessionBridgeService _sessionBridgeService;

        public HomeController(ITokenGenerator tokenGenerator,
            IJsonResultFacade jsonResultFacade,
            ISessionBridgeService sessionBridgeService)
        {
            _tokenGenerator = tokenGenerator;
            _jsonResultFacade = jsonResultFacade;            
            _sessionBridgeService = sessionBridgeService;
        }

        [HttpPost]
        [Route("sign_in")]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn([FromBody] string guid)
        {
            var sessionBridge = await _sessionBridgeService.GetSessionBridgeAsync(guid, true);

            if (sessionBridge != null)
            {
                var token = _tokenGenerator.Generate(sessionBridge);

                var result = new SignInResultVm
                {
                    Token = token,
                    SessionBridge = sessionBridge
                };

                return Ok(_jsonResultFacade.SingleResult(result));
            }

            return Ok(_jsonResultFacade.SingleResult(1, new SignInResultVm()));
        }
    }
}
