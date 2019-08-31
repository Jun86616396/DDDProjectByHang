using System.Threading.Tasks;
using DDD.Domain.Models;

namespace DDD.Domain.DomainServices
{
    public interface IStorageVerifyService
    {


        Task<string> VerifyForCollection(OrderPlacing order, int storageNumber);
    }
}