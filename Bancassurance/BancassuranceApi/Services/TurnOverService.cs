using AutoMapper;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class TurnOverService : ITurnOverService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkRepo _unitOfWork;

        public TurnOverService(IMapper mapper, IUnitOfWorkRepo unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<TurnOverTypeVm>> GetTurnOverTypesAsync()
        {
            var types = (await _unitOfWork.TurnOverTypesRepository.GetAllAsync())
                .Select(t => _mapper.Map<TurnOverTypeVm>(t))
                .ToList();

            return types;
        }
    }
}
