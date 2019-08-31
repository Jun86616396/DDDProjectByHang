using System.Collections.Generic;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;

namespace DDD.Domain.Repository
{
    public interface IOrderBoxRepository : IRepository<OrderBox>
    {
        //void AddOrderBoxAfterDel(int orderId, IEnumerable<OrderBox> orderBoxes);

        void AddOrderAllBoxes(IEnumerable<OrderBox> orderBoxes);

        OrderBox GetOrderBox(string boxNumber);

        List<string> GetOrderIdBoxes(int orderId);

        void DelOrderBox(int orderId);
    }
}