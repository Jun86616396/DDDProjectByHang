using System.ComponentModel;
using DDD.Domain.Enum;
using DDD.Domain.Interfaces;

namespace DDD.Domain.ModelInterfaces
{
    public interface IOrderRepository : IRepository<OrderPlacing>
    {
        /// <summary>
        /// 获取分页订单信息
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="storageFinished"></param>
        /// <returns></returns>
        BindingList<OrderPlacing> GetOrders(int pageIndex, int pageSize, bool storageFinished = false);

        BindingList<OrderPlacing> GetOrders(int pageIndex, int pageSize, OrderCollectionState state,
            bool storageFinished = false);


        int GetOrderCollectionStateCount(OrderCollectionState orderCollectionState, bool storageFinished = false);
        /// <summary>
        /// 根据计划单号获取订单
        /// </summary>
        /// <param name="planNo"></param>
        /// <returns></returns>
        OrderPlacing GetOrderByPlanNo(string planNo);

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
    }
}
