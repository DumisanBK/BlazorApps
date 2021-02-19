using AutoMapper;
using BancassuranceApi.Utils;
using BancassuranceApi.Expressions;
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
    public class DependantsService : IDependantsService
    {
        private readonly IMapper _mapper;
        private readonly IConfigReader _configReader;
        private readonly IUnitOfWorkRepo _unitOfWorkRepo;

        public DependantsService(IMapper mapper, IConfigReader configReader, IUnitOfWorkRepo unitOfWorkRepo)
        {
            _mapper = mapper;
            _configReader = configReader;
            _unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<bool> AddNormalAsync(Dependents dependant)
        {
            int normalCode = Convert.ToInt32(_configReader.Read("NormalCode"));

            long max = Convert.ToInt64(_configReader.Read("MaxNormalDependants"));

            long premiumCount = (await _unitOfWorkRepo.DependantsRepository
                .GetAllAsync(DependantsExpressions.TypeFilter(dependant.MemberId, normalCode)))
                .LongCount();

            if (premiumCount >= max) return false;

            await _unitOfWorkRepo.DependantsRepository.AddAsync(dependant);

            await _unitOfWorkRepo.SaveChangesAsync();

            return true;
        }

        public async Task<bool> AddSpouseAsync(Dependents dependant)
        {
            int spouseCode = Convert.ToInt32(_configReader.Read("SpouseCode"));

            long max = Convert.ToInt64(_configReader.Read("MaxSpouseDependants"));

            long spouseCount = (await _unitOfWorkRepo.DependantsRepository
                .GetAllAsync(DependantsExpressions.TypeFilter(dependant.MemberId, spouseCode)))
                .LongCount();

            if (spouseCount >= max) return false;

            await _unitOfWorkRepo.DependantsRepository.AddAsync(dependant);

            await _unitOfWorkRepo.SaveChangesAsync();

            return true;
        }

        public async Task<bool> AddPremiumAsync(Dependents dependant)
        {
            int premiumCode = Convert.ToInt32(_configReader.Read("PremiumCode"));

            long max = Convert.ToInt64(_configReader.Read("MaxPremiumDependants"));

            long premiumCount = (await _unitOfWorkRepo.DependantsRepository
                .GetAllAsync(DependantsExpressions.TypeFilter(dependant.MemberId, premiumCode)))
                .LongCount();

            if (premiumCount >= max) return false;

            await _unitOfWorkRepo.DependantsRepository.AddAsync(dependant);

            await _unitOfWorkRepo.SaveChangesAsync();

            return true;
        }

        public async Task<DependantVm> GetDependantAsync(long dependantId)
        {
            var dependant = await _unitOfWorkRepo.DependantsRepository.GetByIdAsync(dependantId);

            if (dependant == null) return null;

            return _mapper.Map<DependantVm>(dependant);
        }

        public async Task<List<DependantVm>> GetDependantsAsync(Expression<Func<Dependents, bool>> filter = null,
            Func<IQueryable<Dependents>, IOrderedQueryable<Dependents>> orderBy = null)
        {
            if (orderBy == null)
                orderBy = DependantsExpressions.OrderByIdAsc();

            var dependants = (await _unitOfWorkRepo.DependantsRepository.GetAllAsync(filter, orderBy))
                .Select(d => _mapper.Map<DependantVm>(d))
                .ToList();

            if (dependants.Count < 1) return null;

            return dependants;
        }

        public async Task<bool> RemoveDependantAsync(long dependantId)
        {
            await _unitOfWorkRepo.DependantsRepository.DeleteAsync(dependantId);

            await _unitOfWorkRepo.SaveChangesAsync();

            return true;
        }


    }
}
