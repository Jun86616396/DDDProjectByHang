using DDD.Application.DTO.Storage;
using Infra.Utility.Result;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDD.Application.Interfaces
{
    public interface IStorageService
    {

        //提交入库申请
        Task<SubmitResult> OrderStorage(OrderStorageDto storageDto, int storageNumber);

        bool ChangeOrderStorageState(OrderStorageDto orderStorageDto, bool finished);

        Task<List<StorageDto>> GetOrderStorageList(int orderId);
    }
}