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
    [Route("titles")]
    [Authorize]
    public class TitlesController : ControllerBase
    {
        private readonly ITitlesService _titlesService;
        private readonly IJsonResultFacade _jsonResultFacade;        

        public TitlesController(ITitlesService titlesService, IJsonResultFacade jsonResultFacade)
        {
            _titlesService = titlesService;
            _jsonResultFacade = jsonResultFacade;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetTitlesAsync()
        {
            var titles = await _titlesService.GetTitlesAsync();

            return Ok(_jsonResultFacade.ListResult(titles));
        }
    }
}