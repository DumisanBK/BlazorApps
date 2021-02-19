using BancassuranceApi.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface ITitlesService
    {
        Task<List<TitlesVm>> GetTitlesAsync();
    }
}