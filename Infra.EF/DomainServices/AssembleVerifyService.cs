using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain;
using DDD.Domain.DomainServices;
using DDD.Domain.Repository;
using Infra.EF.Repository;

namespace Infra.EF.DomainServices
{
    public class AssembleVerifyService : IAssembleVerifyService
    {
        private readonly IOrderBoxRepository _orderBoxRepository;
        private readonly IAssembleRepository _assembleRepository;
        private readonly IOrderRepository _orderRepository;

        public AssembleVerifyService(IOrderBoxRepository orderBoxRepository ,IAssembleRepository assembleRepository,IOrderRepository orderRepository)
        {
            _orderBoxRepository = orderBoxRepository;
            _assembleRepository = assembleRepository;
            _orderRepository = orderRepository;
        }

        public async Task<string> VerifyForAssemble(string boxNumber, int assembleNumber)
        {
             //根据盒号检查是否存在关联订单
            var orderBox = _orderBoxRepository.GetOrderBox(boxNumber);

            if (orderBox == null)
            {
                return await Task.FromResult("不存在的盒号，检查盒号是否正确");
            }

            var orderId = orderBox.OrderId;

            //在组装完成前 判断是否重复扫
            List<string> hasFinishedBoxes = _assembleRepository.GetAssembleFinishedBoxes(orderId);
            if (hasFinishedBoxes.Contains(boxNumber))
            {
                return await Task.FromResult("此盒已完成，勿重复扫!");
            }

            var hasDoCount = _assembleRepository.GetAssembleCount(orderId);

            var orderCount = _orderRepository.GetOrderByOrderId(orderId);

            //此时完成的数量 加上数据库已经完成的 不能超过总数量
            if ((hasDoCount + assembleNumber) > orderCount.OnLineQuantity)
            {
             
                return await Task.FromResult("完成后的总数量 超过下订单数量，请核实该盒完成数量");
            }

            return string.Empty;
        }
    }
}