using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface IAccountSettingsService
    {
        Task<bool> AddAccountSettingAsync(AccountSettings accountSetting);
        Task<SpecialAccountVm> GetAccountSettingAsync(int id);
        Task<List<SpecialAccountVm>> GetAccountSettingsAsync(Expression<Func<AccountSettings, bool>> filter = null,
            Func<IQueryable<AccountSettings>, IOrderedQueryable<AccountSettings>> orderBy = null);
        Task<bool> IsMultipleAccount(string accountNumber);
        Task<bool> RemoveAccountSettingsAsync(int accountId);
    }
}