using System.Collections.Generic;
using System.Linq;
using DDD.Domain;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;
   

namespace Infra.EF.Repository
{
    public class OrderBoxRepository : BaseRepository<OrderBox, ManageContext>, IOrderBoxRepository
    {
        //外界注入的形式
        public OrderBoxRepository(ManageContext dbContext) : base(dbContext)
        {

        }

        /// <summary>
        /// 根据扫描的盒号找到所属的订单号
        /// </summary>
        /// <param name="boxNumber"></param>
        /// <returns></returns>
        public OrderBox GetOrderBox (string boxNumber)
        {
            return  DbSet.AsNoTracking().SingleOrDefault(o => o.BoxNumber == boxNumber);
        }

        /// <summary>
        /// 获取订单关联的盒号
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public List<string> GetOrderIdBoxes(int orderId)
        {
            return DbSet.AsNoTracking().Where(orderboxes => orderboxes.OrderId == orderId).Select(o => o.BoxNumber).ToList();
        }

        //删除订单所有的盒号
        public void DelOrderBox(int orderId)
        {
            var entity = DbSet.Where(o => o.OrderId == orderId);
            DbSet.RemoveRange(entity);
        }
        //添加改变后的盒号
        public void AddOrderAllBoxes(IEnumerable<OrderBox> orderBoxes)
        {
            DbSet.AddRange(orderBoxes);
        }

    }
}
