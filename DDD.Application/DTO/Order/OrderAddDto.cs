using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Application.DTO.Order
{
    public class OrderAddDto
    {
        //public int OrderId { get; set; }
        //public System.DateTime OrderDate { get; set; }
        //public string Type { get; set; }
        //public string PlanNo { get; set; }
        //public string FinishedProductNo { get; set; }
        //public string ProductTypeNo { get; set; }
        //public int OnLineQuantity { get; set; }
        //public string SnMin { get; set; }
        //public string SnMax { get; set; }
        //public string LabelingRequirements { get; set; }
        //public string TestReport { get; set; }
        //public string CodingRequirements { get; set; }
        //public string PackingRequirement { get; set; }
        //public string SpecialRequirement { get; set; }
        //public string TestSoftConfigFile { get; set; }
        //public string Remark { get; set; }
        //public System.DateTime CustomDemandDate { get; set; }
        //public System.DateTime PlannedLaunchDate { get; set; }
        //public System.DateTime PlanStorageDate { get; set; }
        //public byte DaysOfProduction { get; set; }
        //public System.DateTime OrderCreateTime { get; set; }
        //public string StorageFinishedFlag { get; set; }
        //public int OrderStorageCount { get; set; }

        [Key]
        public int OrderId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        [Required]
        [StringLength(20)]
        public string PlanNo { get; set; }

        [Required]
        [StringLength(15)]
        public string FinishedProductNo { get; set; }

        [Required]
        [StringLength(15)]
        public string ProductTypeNo { get; set; }

        public int OnLineQuantity { get; set; }

        [Required]
        [StringLength(15)]
        public string SnMin { get; set; }

        [Required]
        [StringLength(15)]
        public string SnMax { get; set; }

        [StringLength(100)]
        public string LabelingRequirements { get; set; }

        [StringLength(20)]
        public string TestReport { get; set; }

        [StringLength(100)]
        public string CodingRequirements { get; set; }

        [StringLength(20)]
        public string PackingRequirement { get; set; }

        [StringLength(100)]
        public string SpecialRequirement { get; set; }

        [StringLength(20)]
        public string TestSoftConfigFile { get; set; }

        [StringLength(20)]
        public string Remark { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CustomDemandDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PlannedLaunchDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PlanStorageDate { get; set; }

        public byte DaysOfProduction { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime OrderCreateTime { get; set; }

        [Required]
        [StringLength(1)]
        public string StorageFinishedFlag { get; set; }


    }
}