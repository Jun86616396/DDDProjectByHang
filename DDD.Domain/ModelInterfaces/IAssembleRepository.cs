using System.Collections.Generic;

namespace DDD.Domain.ModelInterfaces
{
    public interface IAssembleRepository
    {
        void AssembleOneBox(int orderID, string boxNumber, byte count = 50);
        List<string> GetAssembleFinishedBoxNo(int orderId);
    }
}