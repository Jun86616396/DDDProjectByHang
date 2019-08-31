using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using DDD.Application.DTO.Collection;
using DDD.Application.DTO.Order;
using DDD.Domain;
using Infra.Utility.Result;

namespace DDD.Application.Interfaces
{
    public interface ICollectionService
    {
        //物料领取
        Task<SubmitResult> MaterialCollection(OrderCollectionDto orderCollectionDto, int collectionNumber);

        int GetOrderCollectionNumber(int orderId);

        Task<List<CollectionDto>> GetOrderIdCollectionList(int orderId);
    }
}
