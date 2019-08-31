using System;
using System.ComponentModel;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.DTO.DayFinished;
using DDD.Application.Interfaces;
using DDD.Domain;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.Utility.Result;

namespace DDD.Application.Services
{
    public class DayFinishedService : IDayFinishedService
    {
        private readonly IUnitOfWork2 _unitOfWork2;
        private readonly IDayFinishedRepository _dayFinishedRepository;
        private readonly IOpwayDataRepository _opwayDataRepository;
        private readonly IMapper _mapper;

        public DayFinishedService(IUnitOfWork2 unitOfWork2, IDayFinishedRepository dayFinishedRepository, IOpwayDataRepository opwayDataRepository, IMapper mapper)
        {
            _unitOfWork2 = unitOfWork2;
            _dayFinishedRepository = dayFinishedRepository;
            _opwayDataRepository = opwayDataRepository;
            _mapper = mapper;
        }



        public DayFinishedDto GetTodayFinishedInfo(DateTime dateTime)
        {

            var obj = _dayFinishedRepository.GetByDateTime(dateTime);

            if (obj == null)
            {
                InsertDayInfo(new DayFinished() { CreateTime = DateTime.Now.ToShortDateString() });
                return _mapper.Map<DayFinishedDto>(_dayFinishedRepository.GetByDateTime(dateTime));
            }

            return _mapper.Map<DayFinishedDto>(obj);


        }

        public DayFinishedDto GetFinishedInfo(DateTime dateTime, bool month)
        {
            //获取选择日期的数据
            if (!month)
            {
                //数据库没记录在此之前的数据
                if (dateTime < new DateTime(2019, 08, 25))
                {
                    return  new DayFinishedDto();
                }
                return GetTodayFinishedInfo(dateTime);
            }
            else//获取月平均
            {
                return _mapper.Map<DayFinishedDto>(_dayFinishedRepository.GetMonthAverage(dateTime));
            }

        }

        public void InsertDayInfo(DayFinished dayFinished)
        {

            _dayFinishedRepository.Insert(dayFinished);
            _unitOfWork2.SaveChanges();
        }

        public PagedResult<DayFinishedDto> GetDayFinishedList(int pageIndex, int pageSize)
        {
            var bindingList = new BindingList<DayFinishedDto>();


            var query = _dayFinishedRepository.GetAll()
                .ProjectTo<DayFinishedDto>(_mapper.ConfigurationProvider);

            var list = query
                .OrderByDescending(o => o.CreateTime)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize).ToList();

            ////获得记录总数
            var count = query.Count();


            list.ForEach(o => bindingList.Add(o));
            return new PagedResult<DayFinishedDto>(pageIndex, pageSize, count, bindingList);
        }

        public bool SynchronizeTestDataToLocal(DayFinishedDto dayFinishedDto)
        {
            var dateTime = Convert.ToDateTime(dayFinishedDto.CreateTime);
            var firstTestCount = _opwayDataRepository.GetDayFirstTestCount(dateTime);
            var lastTestCount = _opwayDataRepository.GetDayLastTestCount(dateTime);

            if (dayFinishedDto.FistTestCount != firstTestCount || dayFinishedDto.LastTestCount != lastTestCount)
            {
                dayFinishedDto.FistTestCount = firstTestCount;
                dayFinishedDto.LastTestCount = lastTestCount;

                if (dayFinishedDto.CreateTime != DateTime.Now.ToShortDateString())
                {
                    dayFinishedDto.SynchronizationFlag = 1;
                }
                
                _dayFinishedRepository.Update(_mapper.Map<DayFinished>(dayFinishedDto));
            }

            return _unitOfWork2.SaveChanges();
        }
    }
}