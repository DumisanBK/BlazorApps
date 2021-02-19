using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using BancassuranceApi.Utils;
using BancassuranceApi.Expressions;
using BancassuranceApi.Services;
using BancassuranceApi.Utils;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using BancassuranceLib.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancassuranceApi.Controllers
{
    [ApiController]
    [Route("members")]
    [Authorize]
    public class MembersController : ControllerBase
    {
        private readonly IConfigReader _configReader;
        private readonly IMemberService _memberService;
        private readonly IJsonResultFacade _jsonResultFacade;
        private readonly IUnsubscriptionService _unsubscriptionService;

        public MembersController(IConfigReader configReader,
        IMemberService memberService,
            IJsonResultFacade jsonResultFacade,
            IUnsubscriptionService unsubscriptionService)
        {
            _configReader = configReader;
            _memberService = memberService;
            _jsonResultFacade = jsonResultFacade;
            _unsubscriptionService = unsubscriptionService;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddMemberAsync([FromBody] PolicyForm policyForm)
        {
            if (ModelState.IsValid)
            {
                bool result = await _memberService.AddMemberAsync(policyForm);

                return Ok(_jsonResultFacade.BooleanResult(result));
            }

            return Ok(_jsonResultFacade.FormNotValidResult());
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetMembersAsync()
        {
            var members = await _memberService.GetMembersAsync();

            return Ok(_jsonResultFacade.ListResult(members));
        }

        [HttpGet]
        [Route("unvoided")]
        public async Task<IActionResult> GetUnVoidedMembersAsync()
        {
            var members = await _memberService.GetMembersAsync(
                    MemberExpressions.DefaultFilter(_configReader.Read("UnsubRejectCode")));

            return Ok(_jsonResultFacade.ListResult(members));
        }

        [HttpGet]
        [Route("rejected")]
        public async Task<IActionResult> GetUnRejectedMembersAsync()
        {
            var members = await _memberService.GetMembersAsync(
                MemberExpressions.FilterByVoidAuthorization(_configReader.Read("UnsubRejectCode")));

            return Ok(_jsonResultFacade.ListResult(members));
        }

        [HttpGet]
        [Route("voided")]
        public async Task<IActionResult> GetVoidedMembersAsync()
        {
            var members = await _memberService.GetMembersAsync(
                MemberExpressions.FilterByVoidAuthorization(_configReader.Read("UnsubAcceptCode")));

            return Ok(_jsonResultFacade.ListResult(members));
        }

        [HttpGet]
        [Route("pending_unsubscriptions")]
        public async Task<IActionResult> GetPendingUnsubscriptionsAsync()
        {
            var unsubscriptions = await _unsubscriptionService.GetPendingUnsubscriptionsAsync();

            return Ok(_jsonResultFacade.ListResult(unsubscriptions));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetMemberAsync(long id)
        {
            var member = await _memberService.GetMemberAsync(id);

            return Ok(_jsonResultFacade.SingleResult(member));
        }

        [HttpGet]
        [Route("exists/{accountNumber}")]
        public async Task<IActionResult> MemberExistAsync(string accountNumber)
        {
            var member = await _memberService.GetMemberAsync(MemberExpressions.FilterByAccount(accountNumber));

            return Ok(_jsonResultFacade.SingleResult(member));
        }

        [HttpPost]
        [Route("accept_unsubscription")]
        public async Task<IActionResult> AcceptMemberUnsubscriptionAsync([FromBody] AccessUnsubscriptionRequest request)
        {
            if (ModelState.IsValid)
            {
                bool result = await _unsubscriptionService.AuthorizeRequestAsync(request.MemberId, request.Voider);

                return Ok(_jsonResultFacade.BooleanResult(result));
            }

            return Ok(_jsonResultFacade.FormNotValidResult());
        }

        [HttpPost]
        [Route("reject_unsubscription")]
        public async Task<IActionResult> RejectMemberUnsubscriptionAsync([FromBody] RejectUnsubscriptionRequest request)
        {
            if (ModelState.IsValid)
            {
                bool result = await _unsubscriptionService.DenyRequestAsync(request.MemberId, request.Voider);

                return Ok(_jsonResultFacade.BooleanResult(result));
            }

            return Ok(_jsonResultFacade.FormNotValidResult());
        }

        [HttpPost]
        [Route("request_unsubscription")]
        public async Task<IActionResult> RequestMemberUnSubscriptionAsync([FromBody] UnsubscriptionRequestResource request)
        {
            if (ModelState.IsValid)
            {
                bool result = await _unsubscriptionService.RequestUnSubscriptionAsync(request.MemberId, request.Requester, request.Reason);

                return Ok(_jsonResultFacade.BooleanResult(result));
            }

            return Ok(_jsonResultFacade.FormNotValidResult());
        }
    }
}