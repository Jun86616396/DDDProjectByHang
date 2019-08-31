using System.Collections.Generic;
using DDD.Domain.Interfaces;

namespace DDD.Domain.ModelInterfaces
{
 

    public interface IOpwayDataRepository : IRepository<OPWAYDATA>
    {
        int GetFirstTestCount(string snMin, string snMax);

        int GetLastTestCount(string snMin, string snMax);

        List<string> GetFirstTestFinishedSn(string snMin, string snMax);

        List<string> GetLastTestFinishedSn(string snMin, string snMax);

    }
}
