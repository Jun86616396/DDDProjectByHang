using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.DTO.Assemble;
using DDD.Application.Interfaces;
using DDD.Domain;
using DDD.Domain.DomainServices;
using DDD.Domain.Interfaces;
using DDD.Domain.Repository;
using Infra.Utility.Result;

namespace DDD.Application.Services
{
    public class AssembleService : IAssembleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAssembleRepository _assembleRepository;
        private readonly IAssembleVerifyService _assembleVerifyService;
        private readonly IOrderBoxRepository _orderBoxRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IDayFinishedRepository _dayFinishedRepository;
        private readonly IMapper _mapper;


        public AssembleService(IUnitOfWork unitOfWork,
            IAssembleRepository assembleRepository,
            IAssembleVerifyService assembleVerifyService,
            IOrderBoxRepository orderBoxRepository,
            IOrderRepository orderRepository,
            IDayFinishedRepository dayFinishedRepository,
            IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _assembleRepository = assembleRepository;
            _assembleVerifyService = assembleVerifyService;
            _orderBoxRepository = orderBoxRepository;
            _orderRepository = orderRepository;
            _dayFinishedRepository = dayFinishedRepository;
            _mapper = mapper;
        }

        public List<string> GetAssembleFinishedBoxes(int orderId)
        {
            return _assembleRepository.GetAssembleFinishedBoxes(orderId);
        }

        public int GetOrderAssembleFinishedCount(int orderId)
        {
          return  _assembleRepository.GetAssembleCount(orderId);
        }


        public async Task<List<AssembleDto>>  GetOrderAssembleList(int orderId)
        {
            return await _assembleRepository.GetAll(o => o.OrderId == orderId).ProjectTo<AssembleDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<SubmitResult> OrderAssemble(string boxNumber, byte assembleNumber)
        {
            var verifyResult = await _assembleVerifyService.VerifyForAssemble(boxNumber, assembleNumber);

            if (!string.IsNullOrEmpty(verifyResult))
            {
                return new SubmitResult() { IsSucceed = false, Message = verifyResult };
            }

            try
            {

                //添加组装记录
                var orderId = _orderBoxRepository.GetOrderBox(boxNumber).OrderId;

                _assembleRepository.AssembleOneBox(orderId, boxNumber, assembleNumber);

                //更改订单完成组装数量

                _orderRepository.OrderAssembleNumberAdd(orderId, assembleNumber);


                //更新今日完成数量
                _dayFinishedRepository.UpdateAssembleFinished(assembleNumber);


                return new SubmitResult
                {
                    IsSucceed = _unitOfWork.SaveChanges()
                };
            }
            catch (Exception ex)
            {
                return new SubmitResult() { IsSucceed = false, Message = ex.Message };
            }
        }

        public int GetOrderId(string boxNumber)
        {
             return _orderBoxRepository.GetOrderBox(boxNumber).OrderId;
        }

        public List<string> GetOrderAllAssembleBoxes(int orderId)
        {
            return _orderBoxRepository.GetOrderIdBoxes(orderId);
        }
    }
}
