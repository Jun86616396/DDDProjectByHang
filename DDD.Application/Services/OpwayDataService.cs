using System.Collections.Generic;
using DDD.Application.Interfaces;
using DDD.Domain.Repository;

namespace DDD.Application.Services
{
    public class OpwayDataService: IOpwayDataService
    {
        private readonly IOpwayDataRepository _opwayDataRepository;

        public OpwayDataService(IOpwayDataRepository opwayDataRepository)
        {
            _opwayDataRepository = opwayDataRepository;
        }

        public int GetFirstTestCount(string snMin, string snMax)
        {
            return _opwayDataRepository.GetFirstTestCount(snMin, snMax);
        }

        public List<string> GetFirstTestFinishedSn(string snMin, string snMax)
        {
          return  _opwayDataRepository.GetFirstTestFinishedSn(snMin, snMax);
        }

        
        public int GetLastTestCount(string snMin, string snMax)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetLastTestFinishedSn(string snMin, string snMax)
        {
            throw new System.NotImplementedException();
        }
    }
}
