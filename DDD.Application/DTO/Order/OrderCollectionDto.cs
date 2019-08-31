using System;

namespace DDD.Application.DTO.Order
{
    public class OrderCollectionDto
    {
        public int OrderId { get; set; }

        //计划单号  --订单号
        public string PlanNo { get; set; }

        //产品型号
        public string ProductTypeNo { get; set; }

        public string SnMin { get; set; }

        public int OnLineQuantity { get; set; }

        public int OrderCollectionCount { get; set; }
        public System.DateTime CustomDemandDate { get; set; }
        public System.DateTime PlannedLaunchDate { get; set; }

        public byte DaysOfProduction { get; set; }

      



        //public string FinishedProductNo { get; set; }
        //public string SnMax { get; set; }
        //public string LabelingRequirements { get; set; }
        //public string TestReport { get; set; }
        //public string CodingRequirements { get; set; }
        //public string PackingRequirement { get; set; }
        //public string SpecialRequirement { get; set; }
        //public string TestSoftConfigFile { get; set; }
        //public string Remark { get; set; }
        //public System.DateTime PlanStorageDate { get; set; }
        //public System.DateTime OrderCreateTime { get; set; }
        //public Nullable<int> OrderStorageCount { get; set; }
        //public string StorageFinishedFlag { get; set; }
        //public int OrderAssembleCount { get; set; }
        //public int FisrtTestCount { get; set; }
        //public int LastTestCount { get; set; }
        //public System.DateTime OrderDate { get; set; }
        //public string Type { get; set; }
    }
}