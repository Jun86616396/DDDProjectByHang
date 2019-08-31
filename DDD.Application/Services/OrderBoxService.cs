using System.Collections.Generic;
using DDD.Application.Interfaces;
using DDD.Domain;
using DDD.Domain.Interfaces;
using DDD.Domain.Repository;

namespace DDD.Application.Services
{
    public class OrderBoxService : IOrderBoxService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderBoxRepository _orderBoxRepository;


        public OrderBoxService(IUnitOfWork unitOfWork, IOrderBoxRepository orderBoxRepository)
        {
            _unitOfWork = unitOfWork;
            _orderBoxRepository = orderBoxRepository;
        }


    


        public List<string> GetOrderBoxesByOrderId(int orderId)
        {
           return _orderBoxRepository.GetOrderIdBoxes(orderId);
        }

        public int GetOrderIdByOrderBoxNumber(string boxNumber)
        {
           return _orderBoxRepository.GetOrderBox(boxNumber).OrderBoxId;
        }

        //public void AddOrderAllBoxes(IEnumerable<OrderBox> orderBoxes)
        //{
        //    _orderBoxRepository.AddOrderAllBoxes(orderBoxes);
        //}

        //public void AddOrderBoxAfterDel(int orderId, IEnumerable<OrderBox> orderBoxes)
        //{
        //    _orderBoxRepository.AddOrderBoxAfterDel(orderId, orderBoxes);
        //}
    }
}