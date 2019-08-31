using System.Collections.Generic;

namespace DDD.Domain.ModelInterfaces
{
    public interface IOrderBoxRepository
    {
        void AddOrderBoxAfterDel(int orderId, IEnumerable<OrderBox> orderBoxes);

        void AddOrderAllBoxes(IEnumerable<OrderBox> orderBoxes);

        int GetOrderId(string boxNumber);

        List<string> GetOrderIdBoxes(int orderId);
    }
}