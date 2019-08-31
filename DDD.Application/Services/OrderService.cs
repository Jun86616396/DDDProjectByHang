using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.DTO.Order;
using DDD.Application.DTO.Storage;
using DDD.Application.Interfaces;
using DDD.Domain;
using DDD.Domain.Enum;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.Utility;
using Infra.Utility.Result;

namespace DDD.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderBoxRepository _orderBoxRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork, IOrderRepository orderRepository,IOrderBoxRepository orderBoxRepository, IMapper mapper)
        {
            this._orderRepository = orderRepository;
            _orderBoxRepository = orderBoxRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        //用计划单号获取订单
        public OrderPlacing GetOrderByPlanNo(string planNo)
        {
            return _orderRepository.GetOrderByPlanNo(planNo);
        }


        //判断计划单号是否存在
        public bool PlanNoExist(string planNo)
        {
            var obj = _orderRepository.GetOrderByPlanNo(planNo);
            if (obj != null)
            {
                return true;
            }
            return false;
        }

        //订单分页数据
        //public PagedResult<OrderCollectionDto> LoadPageData(int pageIndex, int pageSize, bool storageFinished = false)
        //{
        //    //获得记录总数
        //    var count = _orderRepository.GetOrderCollectionStateCount(OrderCollectionState.NoneCare, storageFinished);


        //    var bindingList = new BindingList<OrderCollectionDto>();

        //    var list = _orderRepository.GetOrders(pageIndex, pageSize, storageFinished)
        //        .ProjectTo<OrderCollectionDto>(_mapper.ConfigurationProvider).ToList();
        //    list.ForEach(o => bindingList.Add(o));

        //    return new PagedResult<OrderCollectionDto>(pageIndex, pageSize, count, bindingList);

        //}


        /// <summary>
        /// 获取组装界面 展示订单数据
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderCollectionState"></param>
        /// <param name="storageFinished"></param>
        /// <returns></returns>
        public PagedResult<OrderCollectionDto> GetOrders(int pageIndex, int pageSize, OrderCollectionState orderCollectionState,
              bool storageFinished = false)
        {
           

            var bindingList = new BindingList<OrderCollectionDto>();

            var list = _orderRepository.GetOrders(pageIndex, pageSize, orderCollectionState, storageFinished)
                .ProjectTo<OrderCollectionDto>(_mapper.ConfigurationProvider).ToList();

            //获得记录总数
            var count = _orderRepository.GetOrderCollectionStateCount(orderCollectionState, storageFinished);

            list.ForEach(o => bindingList.Add(o));

            return new PagedResult<OrderCollectionDto>(pageIndex, pageSize, count, bindingList);

        }

        public PagedResult<OrderAssembleDto> GetOrders(int pageIndex, int pageSize, OrderAssembleState orderAssembleState,
            bool storageFinished = false)
        {
           

            var bindingList = new BindingList<OrderAssembleDto>();

            var list = _orderRepository.GetOrders(pageIndex, pageSize, orderAssembleState, storageFinished)
                .ProjectTo<OrderAssembleDto>(_mapper.ConfigurationProvider).ToList();

            //获得记录总数
            var count = _orderRepository.GetOrderAssembleStateCount(orderAssembleState, storageFinished);

            list.ForEach(o => bindingList.Add(o));

            return new PagedResult<OrderAssembleDto>(pageIndex, pageSize, count, bindingList);

        }


        public PagedResult<OrderEditDto> GetOrders(int pageIndex, int pageSize, OrderState orderState)
        {

            var bindingList = new BindingList<OrderEditDto>();

            var list = _orderRepository.GetOrders(pageIndex, pageSize, orderState)
                .ProjectTo<OrderEditDto>(_mapper.ConfigurationProvider).ToList();

            ////获得记录总数
            var count = _orderRepository.GetOrderStateCount(orderState);

            list.ForEach(o => bindingList.Add(o));

            return new PagedResult<OrderEditDto>(pageIndex, pageSize, count, bindingList);
           
        }

        public PagedResult<OrderStorageDto> GetOrders(int pageIndex, int pageSize, OrderStorageState orderStorageState)
        {

            var bindingList = new BindingList<OrderStorageDto>();

            var list = _orderRepository.GetOrders(pageIndex, pageSize, orderStorageState)
                .ProjectTo<OrderStorageDto>(_mapper.ConfigurationProvider).ToList();

            ////获得记录总数
            var count = _orderRepository.GetOrderStateCount(orderStorageState);

            list.ForEach(o => bindingList.Add(o));

            return new PagedResult<OrderStorageDto>(pageIndex, pageSize, count, bindingList);

        }




        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="orderId"></param>
        public void DelOrder(int orderId)
        {
            _orderRepository.Delete(orderId);
            _unitOfWork.SaveChanges();
        }


        /// <summary>
        /// 更新订单领取物料数
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="collectionCount">该订单领取的总数</param>
        public void UpdateOrderCollectionNumber(int orderId, int collectionCount)
        {
            _orderRepository.UpdateOrderCollectionNumber(orderId, collectionCount);

            _unitOfWork.SaveChanges();
        }
        /// <summary>
        /// 更新订单领取物料数
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="addCount">该订单物料本次领取的数量</param>
        public void OrderCollectionNumberAdd(int orderId, int addCount)
        {
            _orderRepository.OrderCollectionNumberAdd(orderId, addCount);

            _unitOfWork.SaveChanges();
        }


        /// <summary>
        /// 获取订单某状态下的数量
        /// </summary>
        /// <param name="orderCollectionState"></param>
        /// <param name="storageFinished"></param>
        /// <returns></returns>
        public int GetOrderStateCount(OrderCollectionState orderCollectionState, bool storageFinished = false)
        {
            return _orderRepository.GetOrderCollectionStateCount(orderCollectionState, storageFinished);
        }

        public int GetOrderStateCount(OrderAssembleState orderAssembleState, bool storageFinished = false)
        {
            return _orderRepository.GetOrderAssembleStateCount(orderAssembleState, storageFinished);
        }

        public OrderEditDto GetEditOrderById(int orderId)
        {
            return _mapper.Map<OrderEditDto>(_orderRepository.GetOrderByOrderId(orderId));
        }

        public void EditOrder(OrderEditDto orderEditDto, bool changeOneToMany=false)
        {

            if (changeOneToMany)
            {
                List<OrderBox> orderBoxes = SnHelper.GetListboxNumber(orderEditDto.SnMin, orderEditDto.OnLineQuantity).Select(item => new OrderBox()
                {
                    //设置外键Id
                    OrderId = orderEditDto.OrderId,
                    //盒号
                    BoxNumber = item,
                    //新建时间
                    OrderBoxCreateTime = DateTime.Now

                }).ToList();


                var editEntity = _mapper.Map<OrderPlacing>(orderEditDto);
                //editEntity.OrderBoxes = orderBoxes;

                _orderBoxRepository.DelOrderBox(editEntity.OrderId);
                _orderBoxRepository.AddOrderAllBoxes(orderBoxes);
                _orderRepository.Update(editEntity);

                _unitOfWork.SaveChanges();
            }
            else
            {
                var editEntity = _mapper.Map<OrderPlacing>(orderEditDto);

                _orderRepository.Update(editEntity);
                _unitOfWork.SaveChanges();
            }
        }


        public void AddOrder(OrderAddDto orderAddDto )
        {

            List<OrderBox> orderBoxes = SnHelper.GetListboxNumber(orderAddDto.SnMin, orderAddDto.OnLineQuantity).Select(item => new OrderBox()
            {
                
                //设置外键Id
                OrderId = orderAddDto.OrderId,
                //盒号
                BoxNumber = item,
                //新建时间
                OrderBoxCreateTime = DateTime.Now

            }).ToList();

            var newEntity = _mapper.Map<OrderPlacing>(orderAddDto);
            newEntity.OrderBoxes = orderBoxes;
            _orderRepository.Insert(newEntity);
            _unitOfWork.SaveChanges();
;        }




        public OrderAssembleDto GetOrderById(int orderId)
        {
            return _mapper.Map<OrderAssembleDto>(_orderRepository.GetById(orderId));
        }

       
    }
}
