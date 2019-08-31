using DDD.Domain.Interfaces;
using DDD.Domain.Models;

namespace DDD.Domain.Repository
{
    public interface IStorageRepository : IRepository<Storage>
    {

        //void BeginStorage( int orderId,int storageNumber);
        
    }
}