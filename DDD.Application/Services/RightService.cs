using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.DTO.Right;
using DDD.Application.DTO.Role;
using DDD.Application.Interfaces;
using DDD.Domain;
using DDD.Domain.Interfaces;
using DDD.Domain.Repository;

namespace DDD.Application.Services
{
    public class RightService : IRightService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRightRepository _rightRepository;
        private readonly IMapper _mapper;

        public RightService(IUnitOfWork unitOfWork,IRightRepository rightRepository,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _rightRepository = rightRepository;
            _mapper = mapper;
        }


        public async Task<List<RightDto>> GetRightList()
        {
            
           return await _rightRepository.GetAll().ProjectTo<RightDto>(_mapper.ConfigurationProvider).ToListAsync();

        }

    }
}