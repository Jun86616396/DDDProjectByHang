using System;
using System.Collections.Generic;
using DDD.Domain.Interfaces;
using DDD.Domain.Models.OPWAY;

namespace DDD.Domain.Repository
{
 

    public interface IOpwayDataRepository : IRepository<OPWAYDATA>
    {
        int GetFirstTestCount(string snMin, string snMax);

        int GetLastTestCount(string snMin, string snMax);

        List<string> GetFirstTestFinishedSn(string snMin, string snMax);

        List<string> GetLastTestFinishedSn(string snMin, string snMax);

        int GetDayFirstTestCount(DateTime dateTime);

        int GetDayLastTestCount(DateTime dateTime);

    }
}
