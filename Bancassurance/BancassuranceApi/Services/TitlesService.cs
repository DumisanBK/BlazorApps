using AutoMapper;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class TitlesService : ITitlesService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkRepo _unitOfWork;

        public TitlesService(IMapper mapper, IUnitOfWorkRepo unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<TitlesVm>> GetTitlesAsync()
        {
            var titles = (await _unitOfWork.TitlesRepository.GetAllAsync())
                .Select(t => _mapper.Map<TitlesVm>(t))
                .ToList();

            return titles;
        }
    }
}
