using System.Linq;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;

namespace DDD.Domain.Repository
{
    public interface ICollectionRepository : IRepository<Collection>
    {
        int GetOrderCollectionNumber(int orderId);

        void MaterialCollection(int orderId, int number);

        IQueryable<Collection> GetOrderIdCollectionInfo(int orderId);
    }
}
