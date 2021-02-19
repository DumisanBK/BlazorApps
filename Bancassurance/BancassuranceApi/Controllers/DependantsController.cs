using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BancassuranceApi.Utils;
using BancassuranceApi.Services;
using BancassuranceApi.Utils;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancassuranceApi.Controllers
{
    [ApiController]
    [Route("dependants")]
    [Authorize]
    public class DependantsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IConfigReader _configReader;
        private readonly IJsonResultFacade _jsonResultFacade;
        private readonly IDependantsService _dependantsService;

        public DependantsController(IMapper mapper,
            IConfigReader configReader,
            IJsonResultFacade jsonResultFacade, 
            IDependantsService dependantsService)
        {
            _mapper = mapper;
            _configReader = configReader;
            _jsonResultFacade = jsonResultFacade;
            _dependantsService = dependantsService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetDependantsAsync()
        {
            var dependants = await _dependantsService.GetDependantsAsync();

           return Ok(_jsonResultFacade.ListResult(dependants));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetDependantAsync(long dependantId)
        {
            var dependant = await _dependantsService.GetDependantAsync(dependantId);

            return Ok(_jsonResultFacade.SingleResult(dependant));
        }

        [HttpPost]
        [Route("add_spouse")]
        public async Task<IActionResult> AddSpouseAsync([FromBody] DependantForm dependantForm)
        {
            if (ModelState.IsValid)
            {
                var dependant = _mapper.Map<Dependents>(dependantForm);
                dependant.DateAdded = DateTime.Now;
                dependant.Normal = Convert.ToInt32(_configReader.Read("SpouseCode"));

                bool result = await _dependantsService.AddSpouseAsync(dependant);

                return Ok(_jsonResultFacade.BooleanResult(result));
            }

            return Ok(_jsonResultFacade.FormNotValidResult());
        }

        [HttpPost]
        [Route("add_normal")]
        public async Task<IActionResult> AddNormalAsync([FromBody] DependantForm dependantForm)
        {
            if (ModelState.IsValid)
            {
                var dependant = _mapper.Map<Dependents>(dependantForm);
                dependant.DateAdded = DateTime.Now;
                dependant.Normal = Convert.ToInt32(_configReader.Read("NormalCode"));

                bool result = await _dependantsService.AddNormalAsync(dependant);

                return Ok(_jsonResultFacade.BooleanResult(result));
            }

            return Ok(_jsonResultFacade.FormNotValidResult());
        }

        [HttpPost]
        [Route("add_premium")]
        public async Task<IActionResult> AddPremiumAsync([FromBody] DependantForm dependantForm)
        {
            if (ModelState.IsValid)
            {
                var dependant = _mapper.Map<Dependents>(dependantForm);
                dependant.DateAdded = DateTime.Now;
                dependant.Normal = Convert.ToInt32(_configReader.Read("PremiumCode"));

                bool result = await _dependantsService.AddPremiumAsync(dependant);

                return Ok(_jsonResultFacade.BooleanResult(result));
            }

            return Ok(_jsonResultFacade.FormNotValidResult());
        }
    }
}
