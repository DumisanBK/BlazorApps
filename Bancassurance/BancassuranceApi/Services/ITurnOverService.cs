using BancassuranceApi.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface ITurnOverService
    {
        Task<List<TurnOverTypeVm>> GetTurnOverTypesAsync();
    }
}