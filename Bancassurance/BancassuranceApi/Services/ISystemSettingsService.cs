using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface ISystemSettingsService
    {
        Task<bool> AddSystemSettingAsync(SystemSettings accountSetting);
        Task<SystemSettingsVm> GetSystemSettingAsync(int id);
        Task<SystemSettingsVm> GetSystemSettingByCodeAsync(Expression<Func<SystemSettings, bool>> filter);
        Task<List<SystemSettingsVm>> GetSystemSettingsAsync(Expression<Func<SystemSettings, bool>> filter = null, Func<IQueryable<SystemSettings>, IOrderedQueryable<SystemSettings>> orderBy = null);
        Task<bool> UpdateSystemSettingAsync(SystemSettings systemSetting);
    }
}