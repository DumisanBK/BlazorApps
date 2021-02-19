using AutoMapper;
using BancassuranceApi.Expressions;
using BancassuranceApi.Mappers;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using BancassuranceLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class AccountSettingsService : IAccountSettingsService
    {
        private readonly IMapper _mapper;        
        private readonly IUnitOfWorkRepo _unitOfWork;

        public AccountSettingsService(IMapper mapper, IUnitOfWorkRepo unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddAccountSettingAsync(AccountSettings accountSetting)
        {
            await _unitOfWork.AccountSettingsRepository.AddAsync(accountSetting);
                        
            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<SpecialAccountVm> GetAccountSettingAsync(int id)
        {
            var account = await _unitOfWork.AccountSettingsRepository.GetByIdAsync(id);

            if (account == null) return null;

            return _mapper.Map<SpecialAccountVm>(account);
        }

        public async Task<List<SpecialAccountVm>> GetAccountSettingsAsync(Expression<Func<AccountSettings, bool>> filter = null,
            Func<IQueryable<AccountSettings>, IOrderedQueryable<AccountSettings>> orderBy = null)
        {
            if (orderBy == null)
                orderBy = MultipleAccountExpressions.OrderByIdAsc();

            var accounts = (await _unitOfWork.AccountSettingsRepository.GetAllAsync(filter, orderBy))
                .Select(setting => _mapper.Map<SpecialAccountVm>(setting))
                .ToList();

            return accounts;
        }

        public async Task<bool> RemoveAccountSettingsAsync(int accountId)
        {
            await _unitOfWork.AccountSettingsRepository.DeleteAsync(accountId);

            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<bool> IsMultipleAccount(string accountNumber)
        {
            long count = (await _unitOfWork.AccountSettingsRepository.GetAllAsync(
                    MultipleAccountExpressions.DefaultFilter(accountNumber)))
                .LongCount();

            return count > 0L;
        }
    }
}
