using System.Linq;
using DDD.Domain.Enum;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;

namespace DDD.Domain.Repository
{
    public interface IOrderRepository : IRepository<OrderPlacing>
    {
        /// <summary>
        /// 获取分页订单信息
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderState"></param>
        /// <returns></returns>
        IQueryable<OrderPlacing> GetOrders(int pageIndex, int pageSize, OrderState orderState);

        IQueryable<OrderPlacing> GetOrders(int pageIndex, int pageSize, OrderStorageState orderStorageState);

        IQueryable<OrderPlacing> GetOrders(int pageIndex, int pageSize, OrderCollectionState state,
            bool storageFinished = false);

        IQueryable<OrderPlacing> GetOrders(int pageIndex, int pageSize, OrderAssembleState state,
            bool storageFinished = false);


        int GetOrderCollectionStateCount(OrderCollectionState orderCollectionState, bool storageFinished = false);

        int GetOrderAssembleStateCount(OrderAssembleState orderAssembleState, bool storageFinished = false);

        int GetOrderStateCount(OrderState orderAssembleState);

        int GetOrderStateCount(OrderStorageState orderStorageState);
        /// <summary>
        /// 根据计划单号获取订单
        /// </summary>
        /// <param name="planNo"></param>
        /// <returns></returns>
        OrderPlacing GetOrderByPlanNo(string planNo);

        OrderPlacing GetOrderByOrderId(int orderId);

        /// <summary>
        /// 更新订单 物料领取数量
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="collectionCount">订单已领取的值 </param>
        void UpdateOrderCollectionNumber(int orderId,int collectionCount);


        /// <summary>
        /// 更新订单  物料数量增加
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="addCount"> </param>
        void OrderCollectionNumberAdd(int orderId, int addCount);

        void OrderAssembleNumberAdd(int orderId, int addCount);

        void OrderStorageNumberAdd(int orderId, int addCount);

        void ChangeOrderStorageState(int orderId, bool finished);
    }
}
