namespace DDD.Domain.Services
{
    public interface IOrderAssembleService
    {
        void AssembleOneBox(int orderId, string boxNumber, byte finishedCount);
    }
}