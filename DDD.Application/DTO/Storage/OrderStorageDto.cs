using System;

namespace DDD.Application.DTO.Storage
{
    public class OrderStorageDto
    {
        public int OrderId { get; set; }
        
        public string PlanNo { get; set; }

        public string SnMin { get; set; }
        public string SnMax { get; set; }

        public int OnLineQuantity { get; set; }

        public System.DateTime PlanStorageDate { get; set; }

        public System.DateTime OrderCreateTime { get; set; }
        public Nullable<int> OrderStorageCount { get; set; }

        public int StorageAdvanceDays { get; set; }

    }
}