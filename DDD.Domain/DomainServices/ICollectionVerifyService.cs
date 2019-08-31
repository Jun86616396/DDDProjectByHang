using System.Threading.Tasks;
using DDD.Domain.Models;

namespace DDD.Domain.DomainServices
{
    public interface ICollectionVerifyService
    {
       

        Task<string> VerifyForCollection(OrderPlacing order,int collectionNumber);
    }

    
}