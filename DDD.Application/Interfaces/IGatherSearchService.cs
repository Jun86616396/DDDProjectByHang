using DDD.Application.DTO.Order;
using Infra.Utility.Result;

namespace DDD.Application.Interfaces
{
    public interface IGatherSearchService
    {

        PagedResult<OrderGatherSearchDto> GetOrderList(int pageIndex, int pageSize);

        int GetFirstTestCount(OrderGatherSearchDto orderGatherSearchDto);
        int GetLastTestCount(OrderGatherSearchDto orderGatherSearchDto);


        bool UpdateTestCount(OrderGatherSearchDto orderGatherSearchDto);

    }
}