using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Application.DTO.Assemble;
using DDD.Application.DTO.Order;
using DDD.Domain;
using Infra.Utility.Result;

namespace DDD.Application.Interfaces
{
    public interface IAssembleService
    {
        /// <summary>
        /// 从详细表统计完成数量--过渡使用  因为现在在订单表中增加了组装完成数量 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        int GetOrderAssembleFinishedCount(int orderId);


        List<string> GetAssembleFinishedBoxes(int orderId);

        List<string> GetOrderAllAssembleBoxes(int orderId);


        Task<List<AssembleDto>> GetOrderAssembleList(int orderId);


       Task<SubmitResult> OrderAssemble(string boxNumber, byte assembleNumber);

       int GetOrderId(string boxNumber);

    }
}