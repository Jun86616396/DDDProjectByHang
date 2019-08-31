using DDD.Application.DTO.Order;
using DDD.Domain;
using DDD.Domain.Enum;
using Infra.Utility.Result;
using System.Collections.Generic;
using DDD.Application.DTO.Storage;
using DDD.Domain.Models;

namespace DDD.Application.Interfaces
{
    public interface IOrderService
    {
        /// <summary>
        /// 判断订单是否存在
        /// </summary>
        /// <param name="planNo"></param>
        /// <returns></returns>
        bool PlanNoExist(string planNo);

        /// <summary>
        /// 根据计划单号获取订单信息
        /// </summary>
        /// <param name="planNo"></param>
        /// <returns></returns>
        OrderPlacing GetOrderByPlanNo(string planNo);


        OrderEditDto GetEditOrderById(int id);


        PagedResult<OrderCollectionDto> GetOrders(int pageIndex, int pageSize, OrderCollectionState orderCollectionState,
            bool storageFinished = false);
        PagedResult<OrderAssembleDto> GetOrders(int pageIndex, int pageSize, OrderAssembleState orderAssembleState,
            bool storageFinished = false);



        PagedResult<OrderEditDto> GetOrders(int pageIndex, int pageSize, OrderState orderState);

        PagedResult<OrderStorageDto> GetOrders(int pageIndex, int pageSize, OrderStorageState orderStorageState);


        int GetOrderStateCount(OrderCollectionState orderCollectionState, bool storageFinished = false);

        int GetOrderStateCount(OrderAssembleState orderAssembleState, bool storageFinished = false);

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="orderId"></param>
        void DelOrder(int orderId);

        void EditOrder(OrderEditDto orderEditDto, bool changeOneToMany = false);


        void AddOrder(OrderAddDto orderAddDto);


        /// <summary>
        /// 更新订单领取物料数量
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="collectionCount"></param>
        void UpdateOrderCollectionNumber(int orderId, int collectionCount);


        /// <summary>
        /// 更新订单  物料数量增加
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="addCount"> </param>
        void OrderCollectionNumberAdd(int orderId, int addCount);




        OrderAssembleDto GetOrderById(int orderId);
    }
}
