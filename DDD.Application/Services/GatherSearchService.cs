using System.ComponentModel;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.DTO.Order;
using DDD.Application.Interfaces;
using DDD.Domain.Interfaces;
using DDD.Domain.Repository;
using Infra.Utility.Result;

namespace DDD.Application.Services
{
    public class GatherSearchService : IGatherSearchService
    {
        private readonly IUnitOfWork2 _unitOfWork2;
        private readonly IOrderRepository _orderRepository;
        private readonly IOpwayDataRepository _opwayDataRepository;
        private readonly IMapper _mapper;

        public GatherSearchService(IUnitOfWork2 unitOfWork2, IOrderRepository orderRepository, IOpwayDataRepository opwayDataRepository,
            IMapper mapper)
        {
            _unitOfWork2 = unitOfWork2;
            _orderRepository = orderRepository;
            _opwayDataRepository = opwayDataRepository;
            _mapper = mapper;
        }

        public int GetFirstTestCount(OrderGatherSearchDto orderGatherSearchDto)
        {

            return _opwayDataRepository.GetFirstTestCount(orderGatherSearchDto.SnMin, orderGatherSearchDto.SnMax);
        }

        public int GetLastTestCount(OrderGatherSearchDto orderGatherSearchDto)
        {

            return _opwayDataRepository.GetLastTestCount(orderGatherSearchDto.SnMin, orderGatherSearchDto.SnMax);
        }

        public PagedResult<OrderGatherSearchDto> GetOrderList(int pageIndex, int pageSize)
        {


            var bindingList = new BindingList<OrderGatherSearchDto>();


            var query = _orderRepository.GetAll().Where(o => o.StorageFinishedFlag == "0").OrderBy(o => o.OrderDate)
                .ProjectTo<OrderGatherSearchDto>(_mapper.ConfigurationProvider);

            var list = query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();

            ////获得记录总数
            var count = query.Count();


            list.ForEach(o => bindingList.Add(o));
            return new PagedResult<OrderGatherSearchDto>(pageIndex, pageSize, count, bindingList);
        }

        public bool UpdateTestCount(OrderGatherSearchDto orderGatherSearchDto)
        {

            int firstTestCount = _opwayDataRepository.GetFirstTestCount(orderGatherSearchDto.SnMin, orderGatherSearchDto.SnMax);

            int lastTestCount = _opwayDataRepository.GetLastTestCount(orderGatherSearchDto.SnMin, orderGatherSearchDto.SnMax);

            var order = _orderRepository.GetOrderByOrderId(orderGatherSearchDto.OrderId);


            if (order.FisrtTestCount != firstTestCount || order.LastTestCount != lastTestCount)
            {
                order.FisrtTestCount = firstTestCount;
                order.LastTestCount = lastTestCount;

                _orderRepository.Update(order);
            }

            return _unitOfWork2.SaveChanges();
        }
    }
}