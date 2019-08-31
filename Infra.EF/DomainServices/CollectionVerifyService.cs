using System.Threading.Tasks;
using DDD.Domain;
using DDD.Domain.DomainServices;
using DDD.Domain.Models;

namespace Infra.EF.DomainServices
{

    public class CollectionVerifyService : ICollectionVerifyService
    {

        public async Task<string> VerifyForCollection(OrderPlacing order, int collectionNumber)
        {
            var onlineCount = order.OnLineQuantity;

            //当前已经领取数量
            var hasCount = order.OrderCollectionCount;

            //现在领取后的数量大于 订单计划做的数量 不允许
            if (onlineCount < (hasCount + collectionNumber))
            {

                return await Task.FromResult("领取物料后的数量 怎么能大于下单数量呢？请核对") ;
            }

            return string.Empty;
        }
    }
}

