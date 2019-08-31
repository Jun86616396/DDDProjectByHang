using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models.OPWAY
{
    [Table("OPWAYDATA")]
    public partial class OPWAYDATA
    {
        [Key]
        public int DataId { get; set; }

        [StringLength(50)]
        public string Station { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string DATATIME { get; set; }

        [StringLength(50)]
        public string SN { get; set; }

        [StringLength(50)]
        public string PN { get; set; }

        [StringLength(50)]
        public string TEM { get; set; }

        [StringLength(50)]
        public string PoDAC { get; set; }

        [StringLength(50)]
        public string ERDAC { get; set; }

        [StringLength(50)]
        public string EMM { get; set; }

        [StringLength(50)]
        public string Po { get; set; }

        [StringLength(50)]
        public string ER { get; set; }

        [StringLength(50)]
        public string SEN { get; set; }

        [StringLength(50)]
        public string LOSA { get; set; }

        [StringLength(50)]
        public string LOSD { get; set; }

        [StringLength(50)]
        public string CurrentmA { get; set; }

        [StringLength(50)]
        public string TXdiabeldBm { get; set; }

        [StringLength(50)]
        public string DOMVcc { get; set; }

        [StringLength(50)]
        public string DOMTemp { get; set; }

        [StringLength(50)]
        public string DOMIbiasmA { get; set; }

        [StringLength(50)]
        public string DOMPtxdBm { get; set; }

        [StringLength(50)]
        public string DOMTXErrdB { get; set; }

        [StringLength(50)]
        public string DOMRXPwrdBm { get; set; }

        [StringLength(50)]
        public string DOMMaxRXErrdB { get; set; }

        [StringLength(50)]
        public string PF { get; set; }

        [StringLength(50)]
        public string Failedmode { get; set; }

        [StringLength(50)]
        public string APDDAC { get; set; }

        [StringLength(50)]
        public string LosDAC { get; set; }

        [StringLength(50)]
        public string TECDAC { get; set; }

        [StringLength(50)]
        public string CrossDAC { get; set; }

        [StringLength(50)]
        public string EQDAC { get; set; }

        [StringLength(10)]
        public string EADAC { get; set; }

        [StringLength(50)]
        public string Wavelength { get; set; }

        [StringLength(50)]
        public string LaserTemp { get; set; }

        [StringLength(50)]
        public string JitterRMS { get; set; }

        [StringLength(50)]
        public string JitterPP { get; set; }

        [StringLength(50)]
        public string CrossValue { get; set; }

        [StringLength(50)]
        public string WorkVoltage { get; set; }

        [StringLength(50)]
        public string TranCostSen { get; set; }
    }
}
