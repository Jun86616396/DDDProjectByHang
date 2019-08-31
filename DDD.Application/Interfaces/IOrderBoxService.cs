using DDD.Domain;
using System.Collections.Generic;

namespace DDD.Application.Interfaces
{
    public interface IOrderBoxService
    {
        //void AddOrderBoxAfterDel(int orderId, IEnumerable<OrderBox> orderBoxes);

        //void AddOrderAllBoxes(IEnumerable<OrderBox> orderBoxes);

        //void DelOrderBox(int orderId);

        int GetOrderIdByOrderBoxNumber(string boxNumber);

        List<string> GetOrderBoxesByOrderId(int orderId);
    }
}