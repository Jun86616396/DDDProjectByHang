namespace DDD.Application.DTO.Assemble
{
    public class AssembleDto
    {
        public int OrderId { get; set; }
        public string BoxNumber { get; set; }
        public byte FinishedNumber { get; set; }
        public System.DateTime AssembleCreateTime { get; set; }
    }
}