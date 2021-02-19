using AutoMapper;
using BancassuranceApi.Utils;
using BancassuranceApi.Expressions;
using BancassuranceLib.Models;
using BancassuranceLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class UnsubscriptionService : IUnsubscriptionService
    {
        private readonly IMapper _mapper;
        private readonly IConfigReader _configReader;
        private readonly IUnitOfWorkRepo _unitOfWorkRepo;

        public UnsubscriptionService(IMapper mapper, IConfigReader configReader, IUnitOfWorkRepo unitOfWorkRepo)
        {
            _mapper = mapper;
            _configReader = configReader;
            _unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<bool> AuthorizeRequestAsync(long memberId, string voider)
        {
            var member = await _unitOfWorkRepo.MemberRepository.GetByIdAsync(memberId);

            if (member == null) return false;

            member.VoidAuthorization = _configReader.Read("UnsubAcceptCode");
            member.DateVoided = DateTime.Now;
            member.Void = 1;
            member.VoidedBy = voider;

            await _unitOfWorkRepo.MemberRepository.UpdateAsync(member);

            await _unitOfWorkRepo.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DenyRequestAsync(long memberId, string voider)
        {
            var member = await _unitOfWorkRepo.MemberRepository.GetByIdAsync(memberId);

            if (member == null) return false;

            member.VoidAuthorization = _configReader.Read("UnsubRejectCode");
            member.DateVoided = DateTime.Now;
            member.Void = 2;
            member.VoidedBy = voider;

            await _unitOfWorkRepo.MemberRepository.UpdateAsync(member);

            await _unitOfWorkRepo.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RequestUnSubscriptionAsync(long memberId, string requester, string reason)
        {
            var member = await _unitOfWorkRepo.MemberRepository.GetByIdAsync(memberId);

            if (member == null) return false;

            member.VoidAuthorization = _configReader.Read("UnsubRequestCode");
            member.DateVoidRequested = DateTime.Now;
            member.VoidReason = reason;
            member.VoidRequestedBy = requester;
            member.Void = null;

            await _unitOfWorkRepo.MemberRepository.UpdateAsync(member);

            await _unitOfWorkRepo.SaveChangesAsync();

            return true;
        }

        public async Task<List<UnSubscriptionRequest>> GetPendingUnsubscriptionsAsync()
        {
            var requests = (await _unitOfWorkRepo.MemberRepository
                .GetAllAsync(MemberExpressions.FilterByVoidAuthorization(_configReader.Read("UnsubRequestCode")),
                    MemberExpressions.OrderByIdAsc(), "Dependents,TurnOver"
                ))
                .Select(m => _mapper.Map<UnSubscriptionRequest>(m))
                .ToList();

            if (requests.Count < 1) return null;

            return requests;
        }
    }
}
