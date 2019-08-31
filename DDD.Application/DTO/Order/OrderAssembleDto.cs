using System;

namespace DDD.Application.DTO.Order
{
    public class OrderAssembleDto
    {
        public int OrderId { get; set; }

        //计划单号  --订单号
        public string PlanNo { get; set; }

        //产品型号
        public string ProductTypeNo { get; set; }

        public string SnMin { get; set; }

        public int OnLineQuantity { get; set; }

        public int OrderAssembleCount { get; set; }
        public System.DateTime CustomDemandDate { get; set; }
        public System.DateTime PlannedLaunchDate { get; set; }

        public byte DaysOfProduction { get; set; }
    }
}