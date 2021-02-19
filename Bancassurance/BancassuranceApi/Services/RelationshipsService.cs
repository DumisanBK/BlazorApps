using AutoMapper;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class RelationshipsService : IRelationshipsService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkRepo _unitOfWork;

        public RelationshipsService(IMapper mapper, IUnitOfWorkRepo unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<RelationshipsVm>> GetRelationshipsAsync()
        {
            var relationships = (await _unitOfWork.RelationshipsRepository.GetAllAsync())
                .Select(r => _mapper.Map<RelationshipsVm>(r))
                .ToList();

            return relationships;
        }
    }
}
