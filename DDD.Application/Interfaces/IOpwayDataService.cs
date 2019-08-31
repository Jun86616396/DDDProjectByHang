using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Interfaces
{
    public interface IOpwayDataService
    {


        int GetFirstTestCount(string snMin, string snMax);

        int GetLastTestCount(string snMin, string snMax);

        List<string> GetFirstTestFinishedSn(string snMin, string snMax);

        List<string> GetLastTestFinishedSn(string snMin, string snMax);
    }
}
