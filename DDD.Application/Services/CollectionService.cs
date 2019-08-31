using System;
using System.Collections.Generic;
using DDD.Application.Interfaces;
using DDD.Domain.Interfaces;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.DTO.Collection;
using DDD.Application.DTO.Order;
using DDD.Domain;
using DDD.Domain.DomainServices;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.Utility.Result;

namespace DDD.Application.Services
{
    /// <summary>
    /// 物料领取服务
    /// </summary>
    public class CollectionService : ICollectionService
    {
        private readonly ICollectionRepository _collectionRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _orderRepository;
        private readonly IDayFinishedRepository _dayFinishedRepository;
        private readonly ICollectionVerifyService _collectionVerifyService;

        private readonly IMapper _mapper;

        public CollectionService(IUnitOfWork unitOfWork,
            ICollectionRepository collectionRepository,
            IOrderRepository orderRepository,
            IDayFinishedRepository dayFinishedRepository,
            ICollectionVerifyService collectionVerifyService,
            IMapper mapper)
        {
            _collectionRepository = collectionRepository;
            _unitOfWork = unitOfWork;
            _orderRepository = orderRepository;
            _dayFinishedRepository = dayFinishedRepository;
            _collectionVerifyService = collectionVerifyService;

            _mapper = mapper;
        }

        /// <summary>
        /// 获取订单 物料已领数量
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public int GetOrderCollectionNumber(int orderId)
        {
            return _collectionRepository.GetOrderCollectionNumber(orderId);
        }

        //获取领料详细
        public async Task<List<CollectionDto>> GetOrderIdCollectionList(int orderId)
        {
            return await _collectionRepository.GetOrderIdCollectionInfo(orderId).ProjectTo<CollectionDto>(_mapper.ConfigurationProvider).ToListAsync();

        }

        /// <summary>
        /// 订单   领取物料
        /// </summary>
        /// <param name="orderCollectionDto"></param>
        /// <param name="collectionNumber">本次领取数量</param>
        public async Task<SubmitResult> MaterialCollection(OrderCollectionDto orderCollectionDto, int collectionNumber)
        {

            var verifyResult = await _collectionVerifyService.VerifyForCollection(_mapper.Map<OrderPlacing>(orderCollectionDto),
                  collectionNumber);

            if (!string.IsNullOrEmpty(verifyResult))
            {
                return new SubmitResult() { IsSucceed = false, Message = verifyResult };
            }

            try
            {
                //领取物料表新增一条记录
                _collectionRepository.MaterialCollection(orderCollectionDto.OrderId, collectionNumber);

                //修改订单表
                _orderRepository.OrderCollectionNumberAdd(orderCollectionDto.OrderId, collectionNumber);

                //更新今日完成数量
                _dayFinishedRepository.UpdateCollectionFinished(collectionNumber);


                return new SubmitResult
                {
                    IsSucceed = _unitOfWork.SaveChanges()
                };
            }
            catch (Exception ex)
            {
                return new SubmitResult { IsSucceed = false, Message = ex.Message };
            }


        }
    }
}
