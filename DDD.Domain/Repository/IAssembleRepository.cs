using System.Collections.Generic;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;

namespace DDD.Domain.Repository
{
    public interface IAssembleRepository: IRepository<Assemble>
    {
        int GetAssembleCount(int orderId);

        void AssembleOneBox(int orderId, string boxNumber, byte count = 50);

        List<string> GetAssembleFinishedBoxes(int orderId);

        
    }
}