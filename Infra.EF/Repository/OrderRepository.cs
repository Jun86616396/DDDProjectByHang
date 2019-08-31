using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DDD.Domain;
using DDD.Domain.Enum;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;
   

namespace Infra.EF.Repository
{
    public class OrderRepository : BaseRepository<OrderPlacing, ManageContext>, IOrderRepository

    {
        public OrderRepository(ManageContext dbContext) :
           base(dbContext)
        {

        }


        public IQueryable<OrderPlacing> GetOrders(int pageIndex, int pageSize, OrderCollectionState orderCollectionState, bool storageFinished = false)
        {
            var query = GetOrderCollectionStateQuery(orderCollectionState, storageFinished);

            query = query.OrderByDescending(order => order.OrderCreateTime);

            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

        }


        public IQueryable<OrderPlacing> GetOrders(int pageIndex, int pageSize, OrderAssembleState orderAssembleState, bool storageFinished = false)
        {


            var query = GetOrderAssembleStateQuery(orderAssembleState, storageFinished);

            query = query.OrderByDescending(order => order.OrderCreateTime);

            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
        public IQueryable<OrderPlacing> GetOrders(int pageIndex, int pageSize, OrderStorageState orderStorageState)
        {
            var query = GetOrderStorageStateQuery(orderStorageState);
            query = query.OrderByDescending(order => order.OrderCreateTime);

            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }

        public IQueryable<OrderPlacing> GetOrders(int pageIndex, int pageSize, OrderState orderState)
        {
            var query = GetOrderStateQuery(orderState);

            query = query.OrderByDescending(order => order.OrderCreateTime);

            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

        }

        public int GetOrderCollectionStateCount(OrderCollectionState orderCollectionState, bool storageFinished = false)
        {

            var query = GetOrderCollectionStateQuery(orderCollectionState, storageFinished);
            return query.Count();
        }

        public int GetOrderAssembleStateCount(OrderAssembleState orderAssembleState, bool storageFinished = false)
        {
            var query = GetOrderAssembleStateQuery(orderAssembleState, storageFinished);

            return query.Count();
        }


        public int GetOrderStateCount(OrderState orderState)
        {
            var query = GetOrderStateQuery(orderState);
            return query.Count();
        }

   

        public int GetOrderStateCount(OrderStorageState orderStorageState)
        {
            var query = GetOrderStorageStateQuery(orderStorageState);
            return query.Count();
        }


        private IQueryable<OrderPlacing> GetOrderStorageStateQuery(OrderStorageState orderStorageState)
        {
            IQueryable<OrderPlacing> query;

            query = DbSet.AsNoTracking();

            switch (orderStorageState)
            {
                case OrderStorageState.StorageFinished:
                    query = query.Where(o => o.StorageFinishedFlag == "1");
                    break;
                case OrderStorageState.NoneStorage:
                    query = query.Where(o => o.StorageFinishedFlag == "0");
                    break;
            }

            return query;
        }
        private IQueryable<OrderPlacing> GetOrderStateQuery(OrderState orderState)
        {
            IQueryable<OrderPlacing> query;

            query = DbSet.AsNoTracking();

            switch (orderState)
            {
                case OrderState.StorageFinished:
                    query = query.Where(o => o.StorageFinishedFlag == "1");
                    break;
                case OrderState.NoneStorage:
                    query = query.Where(o => o.StorageFinishedFlag == "0");
                    break;
            }

            return query;
        }

        private IQueryable<OrderPlacing> GetOrderAssembleStateQuery(OrderAssembleState orderAssembleState, bool storageFinished)
        {
            IQueryable<OrderPlacing> query;
            if (storageFinished)
            {
                query = DbSet.AsNoTracking().Where(o => o.StorageFinishedFlag == "1");
            }
            else
            {
                query = DbSet.AsNoTracking().Where(o => o.StorageFinishedFlag == "0");
            }
            switch (orderAssembleState)
            {
                case OrderAssembleState.NoneCare:
                    break;
                case OrderAssembleState.NoneStartAssemble:
                    query = query.Where(o => o.OrderAssembleCount == 0);
                    break;
                case OrderAssembleState.PartialAssemble:
                    query = query.Where(o => o.OrderAssembleCount != o.OnLineQuantity && o.OrderAssembleCount > 0);
                    break;
                case OrderAssembleState.FinishedAssemble:
                    query = query.Where(o => o.OrderAssembleCount == o.OnLineQuantity);
                    break;
            }

            return query;
        }

        private IQueryable<OrderPlacing> GetOrderCollectionStateQuery(OrderCollectionState orderCollectionState, bool storageFinished)
        {
            IQueryable<OrderPlacing> query;
            if (storageFinished)
            {
                query = DbSet.AsNoTracking().Where(o => o.StorageFinishedFlag == "1");
            }
            else
            {
                query = DbSet.AsNoTracking().Where(o => o.StorageFinishedFlag == "0");
            }


            switch (orderCollectionState)
            {
                case OrderCollectionState.NoneCare:
                    break;
                case OrderCollectionState.NoneStartCollection:
                    query = query.Where(o => o.OrderCollectionCount == 0);
                    break;
                case OrderCollectionState.PartialCollection:
                    query = query.Where(o => o.OrderCollectionCount != o.OnLineQuantity && o.OrderCollectionCount > 0);
                    break;
                case OrderCollectionState.FinishedCollection:
                    query = query.Where(o => o.OrderCollectionCount == o.OnLineQuantity);
                    break;
            }

            return query;
        }

        /// <summary>
        /// 获取订单  以计划单号
        /// </summary>
        /// <param name="planNo"></param>
        /// <returns></returns>
        public OrderPlacing GetOrderByPlanNo(string planNo)
        {

            return DbSet.AsNoTracking().SingleOrDefault(o => o.PlanNo == planNo);

        }
   
        /// <summary>
        /// 获取订单  以订单Id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public OrderPlacing GetOrderByOrderId(int orderId)
        {
            return DbSet.AsNoTracking().SingleOrDefault(o => o.OrderId == orderId);

        }

        public void UpdateOrderCollectionNumber(int orderId, int collectionCount)
        {
            var obj = DbSet.SingleOrDefault(o => o.OrderId == orderId);
            if (obj != null)
            {
                obj.OrderCollectionCount = collectionCount;
            }
        }



        public void OrderCollectionNumberAdd(int orderId, int addCount)
        {
            var obj = DbSet.SingleOrDefault(o => o.OrderId == orderId);
            if (obj != null)
            {
                obj.OrderCollectionCount = obj.OrderCollectionCount + addCount;
            }
        }

        public void OrderAssembleNumberAdd(int orderId, int addCount)
        {
            var obj = DbSet.SingleOrDefault(o => o.OrderId == orderId);
            if (obj != null)
            {
                obj.OrderAssembleCount = obj.OrderAssembleCount + addCount;
            }
        }

        public void OrderStorageNumberAdd(int orderId, int addCount)
        {
            var obj = DbSet.SingleOrDefault(o => o.OrderId == orderId);
            if (obj != null)
            {
                obj.OrderStorageCount = obj.OrderStorageCount + addCount;

                //修改入库时间记录
                obj.StorageAdvanceDays = (obj.PlanStorageDate - Convert.ToDateTime(DateTime.Now.ToShortDateString())).Days;
            }
        }

        public void ChangeOrderStorageState(int orderId, bool finished)
        {
            var obj = DbSet.SingleOrDefault(o => o.OrderId == orderId);
            if (obj != null)
            {
                obj.StorageFinishedFlag = finished==true?"1":"0";
            }
        }
    }
}
