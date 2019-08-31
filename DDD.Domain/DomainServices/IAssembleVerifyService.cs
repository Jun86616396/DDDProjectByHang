using System.Threading.Tasks;

namespace DDD.Domain.DomainServices
{
    public interface IAssembleVerifyService
    {
        Task<string> VerifyForAssemble(string boxNumber, int assembleNumber);
    }
}