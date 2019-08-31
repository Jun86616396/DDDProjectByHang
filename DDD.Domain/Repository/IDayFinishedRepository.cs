using System;
using System.Linq;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;

namespace DDD.Domain.Repository
{
    public interface IDayFinishedRepository : IRepository<DayFinished>
    {
        DayFinished GetByDateTime(DateTime dateTime);

        DayFinished UpdateCollectionFinished(int finishedCount);

        DayFinished UpdateAssembleFinished(int finishedCount);

        DayFinished UpdateFirstTestFinished(int finishedCount);

        DayFinished UpdateLastTestFinished(int finishedCount);

        DayFinished UpdateStorageFinished(int finishedCount);

        DayFinished GetMonthAverage(DateTime dateTime);

    }
}