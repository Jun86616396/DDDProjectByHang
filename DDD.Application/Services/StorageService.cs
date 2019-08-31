using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.DTO.Storage;
using DDD.Application.Interfaces;
using DDD.Domain;
using DDD.Domain.DomainServices;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.Utility.Result;

namespace DDD.Application.Services
{
    public class StorageService : IStorageService
    {
        private readonly IUnitOfWork2 _unitOfWork2;
        private readonly IStorageVerifyService _storageVerifyService;
        private readonly IStorageRepository _storageRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IDayFinishedRepository _dayFinishedRepository;

        private readonly IMapper _mapper;

        public StorageService(IUnitOfWork2 unitOfWork2,
            IStorageVerifyService storageVerifyService,
            IStorageRepository storageRepository,
            IOrderRepository orderRepository,
            IDayFinishedRepository dayFinishedRepository,
            IMapper mapper)
        {
            _unitOfWork2 = unitOfWork2;
            _storageVerifyService = storageVerifyService;
            _storageRepository = storageRepository;
            _orderRepository = orderRepository;
            _dayFinishedRepository = dayFinishedRepository;
            _mapper = mapper;
        }

        public bool ChangeOrderStorageState(OrderStorageDto orderStorageDto, bool finished)
        {
            _orderRepository.ChangeOrderStorageState(orderStorageDto.OrderId,finished);
            return _unitOfWork2.SaveChanges();
        }

        public async Task<List<StorageDto>> GetOrderStorageList(int orderId)
        {
            return await _storageRepository.GetAll(o => o.OrderId == orderId).ProjectTo<StorageDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<SubmitResult> OrderStorage(OrderStorageDto orderStorageDto, int storageNumber)
        {
            var verifyResult = await _storageVerifyService.VerifyForCollection(_mapper.Map<OrderPlacing>(orderStorageDto), storageNumber);

            if (!string.IsNullOrEmpty(verifyResult))
            {
                return new SubmitResult() { IsSucceed = false, Message = verifyResult };
            }

            try
            {
                var storage = _mapper.Map<Storage>(orderStorageDto);
                storage.Number = storageNumber;

                _storageRepository.Insert(storage);

                //更新订单
                _orderRepository.OrderStorageNumberAdd(orderStorageDto.OrderId, storageNumber);

                //更新每日记录
                _dayFinishedRepository.UpdateStorageFinished(storageNumber);

                return new SubmitResult
                {
                    IsSucceed = _unitOfWork2.SaveChanges()
                };
            }
            catch (Exception ex)
            {
                return new SubmitResult() { IsSucceed = false, Message = ex.Message };
            }


        }


    }
}