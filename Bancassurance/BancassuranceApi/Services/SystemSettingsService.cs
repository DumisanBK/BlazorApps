using AutoMapper;
using BancassuranceApi.Expressions;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using BancassuranceLib.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class SystemSettingsService : ISystemSettingsService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkRepo _unitOfWork;
        private readonly BancassuranceContext _bancassuranceContext;

        public SystemSettingsService(IMapper mapper, IUnitOfWorkRepo unitOfWork,
            BancassuranceContext bancassuranceContext)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _bancassuranceContext = bancassuranceContext;
        }

        public async Task<bool> AddSystemSettingAsync(SystemSettings systemSetting)
        {
            await _unitOfWork.SystemSettingsRepository.AddAsync(systemSetting);

            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<SystemSettingsVm> GetSystemSettingAsync(int id)
        {
            var systemSetting = await _unitOfWork.SystemSettingsRepository.GetByIdAsync(id);

            if (systemSetting == null) return null;

            return _mapper.Map<SystemSettingsVm>(systemSetting);
        }

        public async Task<SystemSettingsVm> GetSystemSettingByCodeAsync(Expression<Func<SystemSettings, bool>> filter)
        {
            var systemSetting = await _unitOfWork.SystemSettingsRepository.GetSingleOrDefaultAsync(filter);

            if (systemSetting == null) return null;

            return _mapper.Map<SystemSettingsVm>(systemSetting);
        }

        public async Task<List<SystemSettingsVm>> GetSystemSettingsAsync(Expression<Func<SystemSettings, bool>> filter = null,
            Func<IQueryable<SystemSettings>, IOrderedQueryable<SystemSettings>> orderBy = null)
        {
            if (orderBy == null)
                orderBy = SystemSettingsExpression.OrderByIdAsc();

            var settings = (await _unitOfWork.SystemSettingsRepository.GetAllAsync(filter, orderBy))
                .Select(setting => _mapper.Map<SystemSettingsVm>(setting))
                .ToList();

            return settings;
        }

        public async Task<bool> UpdateSystemSettingAsync(SystemSettings systemSetting)
        {      
            var dbSetting = await _bancassuranceContext
                .SystemSettings
                .FindAsync(systemSetting.Id);

            dbSetting.Value = systemSetting.Value;
            dbSetting.LastDateModified = DateTime.Now;

            await _bancassuranceContext.SaveChangesAsync();

            return true;
        }
    }
}
