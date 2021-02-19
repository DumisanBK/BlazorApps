using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface IDependantsService
    {
        Task<bool> AddNormalAsync(Dependents dependant);
        Task<bool> AddPremiumAsync(Dependents dependant);
        Task<bool> AddSpouseAsync(Dependents dependant);
        Task<DependantVm> GetDependantAsync(long dependantId);
        Task<List<DependantVm>> GetDependantsAsync(Expression<Func<Dependents, bool>> filter = null,
            Func<IQueryable<Dependents>, IOrderedQueryable<Dependents>> orderBy = null);
        Task<bool> RemoveDependantAsync(long dependantId);
    }
}