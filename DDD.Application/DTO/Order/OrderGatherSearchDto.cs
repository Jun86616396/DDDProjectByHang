using System;

namespace DDD.Application.DTO.Order
{
    public class OrderGatherSearchDto
    {
        public int OrderId { get; set; }
        public string PlanNo { get; set; }

        public string ProductTypeNo { get; set; }
        public int OnLineQuantity { get; set; }
        public string SnMin { get; set; }
        public string SnMax { get; set; }
        public System.DateTime PlanStorageDate { get; set; }
        public byte DaysOfProduction { get; set; }

        public Nullable<int> OrderStorageCount { get; set; }

        public int OrderCollectionCount { get; set; }
        public int OrderAssembleCount { get; set; }
        public int FisrtTestCount { get; set; }
        public int LastTestCount { get; set; }

        public int StorageAdvanceDays { get; set; }
    }
}