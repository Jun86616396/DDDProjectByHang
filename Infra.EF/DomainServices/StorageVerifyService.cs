using System.Threading.Tasks;
using DDD.Domain;
using DDD.Domain.DomainServices;
using DDD.Domain.Models;
using DDD.Domain.Repository;

namespace Infra.EF.DomainServices
{
    public class StorageVerifyService : IStorageVerifyService
    {
        private readonly IOpwayDataRepository _opwayDataRepository;

        public StorageVerifyService(IOpwayDataRepository opwayDataRepository)
        {
            _opwayDataRepository = opwayDataRepository;
        }

        public async Task<string> VerifyForCollection(OrderPlacing order, int storageNumber)
        {

            //数据库记录的已经入库的数量
            var dbCount = order.OrderStorageCount;

            //订单要做的数量
            var count = order.OnLineQuantity;

            //理想情况下  入库完后的数量
            var planCount = storageNumber + dbCount;

            //入库数量不能大于订单要求做的数量
            if (planCount > count)
            {
               return await Task.FromResult("当前订单数量: " + count + $"  已入库数量：{dbCount}  本次入库数量：" + storageNumber + "请核实!") ;
                
            }


            var snMin = order.SnMin;
            var snMax = order.SnMax;

          
            if (_opwayDataRepository.GetLastTestCount(snMin, snMax) < planCount)
            {
                
              return  await Task.FromResult("本次入库数量不能大于终测通过的数量！！！");
            }

            return string.Empty;
        }
    }
}