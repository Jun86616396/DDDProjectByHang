using System;
using DDD.Application.DTO.DayFinished;
using DDD.Domain;
using Infra.Utility.Result;

namespace DDD.Application.Interfaces
{
    public interface IDayFinishedService
    {
        DayFinishedDto GetTodayFinishedInfo(DateTime dateTime);


        PagedResult<DayFinishedDto> GetDayFinishedList(int pageIndex, int pageSize);

        DayFinishedDto GetFinishedInfo(DateTime dateTime,bool month);

       bool  SynchronizeTestDataToLocal(DayFinishedDto dayFinishedDto);

    }
}