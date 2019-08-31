using System;
using System.Linq;
using DDD.Domain;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;


namespace Infra.EF.Repository
{
    public class CollectionRepository : BaseRepository<Collection, ManageContext>, ICollectionRepository
    {
        public CollectionRepository(ManageContext dbcontext) : base(dbcontext)
        {

        }

        /// <summary>
        /// 领取物料
        /// </summary>
        /// <param name="orderId"> 订单Id</param>
        /// <param name="number"> 领取数量</param>
        public void MaterialCollection(int orderId, int number)
        {
            DbSet.Add(new Collection()
            { OrderID = orderId, Number = number, CollectionCreateTime = DateTime.Now });
        }

        /// <summary>
        /// 当前订单领取物料数量
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public int GetOrderCollectionNumber(int orderId)
        {
            var collectionEntity = DbSet.AsNoTracking().FirstOrDefault(collection => collection.OrderID == orderId);

            if (collectionEntity == null)
                return 0;
            else
                return DbSet.AsNoTracking().Where(collection => collection.OrderID == orderId).Sum(o => o.Number);
        }


        /// <summary>
        /// 得到当前订单 领取物料数量  最后一次时间
        /// </summary>
        /// <returns></returns>
        public Tuple<int, DateTime> GetCurrentOrderCollectionInfo(int orderId)
        {

            var linqResult = from collec in DbSet
                             where collec.OrderID == orderId
                             group collec by collec.OrderID
                             into gp
                             select new
                             {
                                 Ccount = gp.Sum(t => t.Number),
                                 Cdatetime = gp.Max(t => t.CollectionCreateTime)
                             };

            //DbSet.Where(collection => collection.OrderID == orderId).Sum(o => o.Number);

            return new Tuple<int, DateTime>(linqResult.Single().Ccount, linqResult.Single().Cdatetime);

        }

       


        public IQueryable<Collection> GetOrderIdCollectionInfo(int orderId)
        {
            return  DbSet.AsNoTracking().Where(o=>o.OrderID== orderId);
        }
    }
}
