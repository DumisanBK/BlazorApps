using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancassuranceApi.Services;
using BancassuranceApi.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancassuranceApi.Controllers
{
    [ApiController]
    [Route("relationships")]
    [Authorize]
    public class RelationshipsController : ControllerBase
    {
        private readonly IJsonResultFacade _jsonResultFacade;
        private readonly IRelationshipsService _relationshipsService;

        public RelationshipsController(IJsonResultFacade jsonResultFacade, IRelationshipsService relationshipsService)
        {
            _jsonResultFacade = jsonResultFacade; ;
            _relationshipsService = relationshipsService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetRelationshipsAsync()
        {
            var relationships = await _relationshipsService.GetRelationshipsAsync();

            return Ok(_jsonResultFacade.ListResult(relationships));
        }
    }
}
