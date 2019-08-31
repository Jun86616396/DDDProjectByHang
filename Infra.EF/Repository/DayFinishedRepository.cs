using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using DDD.Domain;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;
   
using Infra.Utility;


namespace Infra.EF.Repository
{
    public class DayFinishedRepository : BaseRepository<DayFinished, ManageContext>, IDayFinishedRepository
    {
        public DayFinishedRepository(ManageContext dbContext) : base(dbContext)
        {
        }

        //时间以字符串形式存储 方便处理  因为需要的是每天
        public DayFinished GetByDateTime(DateTime dateTime)
        {
            var dtStr = dateTime.ToShortDateString();

            return DbSet.FirstOrDefault(o => o.CreateTime == dtStr);

        }

        public DayFinished GetMonthAverage(DateTime dateTime)
        {
            var dtMin = dateTime.AddDays(1 - dateTime.Day).ToShortDateString();
            var dtMax = dateTime.AddDays(1 - dateTime.Day).AddMonths(1).AddDays(-1).ToShortDateString();

            var sql =
                $"SELECT  avg([Id]) as [Id],avg([CollectionCount]) as [CollectionCount],avg([AssembleCount]) as [AssembleCount],avg([FistTestCount]) as [FistTestCount],avg([LastTestCount]) as [LastTestCount],avg([StorageCount]) as [StorageCount]FROM[FlowManageSystem].[dbo].[DayFinished]Where[CreateTime] between '{dtMin}' And '{dtMax}'";

            //var sqlCollection =
            //    $"SELECT  avg([CollectionCount]) as [CollectionCount] FROM [FlowManageSystem].[dbo].[DayFinished]Where[CreateTime] between '{dtMin}' And '{dtMax}'";
            //var sqlAssemble =
            //    $"SELECT  avg([AssembleCount]) as [AssembleCount] FROM [FlowManageSystem].[dbo].[DayFinished]Where[CreateTime] between '@dtMin' And '@dtMax'";

            //var sqlFirst =
            //    $"SELECT  avg([FistTestCount]) as [FistTestCount] FROM [FlowManageSystem].[dbo].[DayFinished]Where[CreateTime] between '@dtMin' And '@dtMax'";
            //var sqlLast =
            //    $"SELECT  avg([LastTestCount]) as [LastTestCount] FROM [FlowManageSystem].[dbo].[DayFinished]Where[CreateTime] between '@dtMin' And '@dtMax'";
            //var sqlStorage =
            //    $"SELECT  avg([StorageCount]) as [StorageCount] FROM [FlowManageSystem].[dbo].[DayFinished]Where[CreateTime] between '@dtMin' And '@dtMax'";

            //SqlParameter[] paras =
            //{
            //    new SqlParameter("@dtMin", dtMin),
            //    new SqlParameter("@dtMax", dtMax)
            //};

            //dynamic a = new {CollectionCount = 0, AssembleCount = 0, FistTestCount = 0, LastTestCount = 0};


            var result = new SearchResult();
            try
            {
                result = DbContext.Database.SqlQuery<SearchResult>(sql).FirstOrDefault();
            }
            catch (Exception e)
            {
                LogHelper.WriteLog("查询数据出现错误，查询了不存在的月份"+e.Message);
            }

            return new DayFinished()
            {
                CollectionCount = result.CollectionCount,
                AssembleCount = result.AssembleCount,
                FistTestCount = result.FistTestCount,
                LastTestCount = result.LastTestCount,
                StorageCount = result.StorageCount
            };
        }

        public DayFinished UpdateAssembleFinished(int finishedCount)
        {
            var entity = GetByDateTime(DateTime.Now);
            entity.AssembleCount = entity.AssembleCount + finishedCount;
            return base.Update(entity);
        }

        public DayFinished UpdateCollectionFinished(int finishedCount)
        {
            var entity = GetByDateTime(DateTime.Now);
            entity.CollectionCount = entity.CollectionCount + finishedCount;
            return base.Update(entity);
        }

        public DayFinished UpdateFirstTestFinished(int finishedCount)
        {
            var entity = GetByDateTime(DateTime.Now);
            entity.FistTestCount = entity.FistTestCount + finishedCount;
            return base.Update(entity);
        }

        public DayFinished UpdateLastTestFinished(int finishedCount)
        {
            var entity = GetByDateTime(DateTime.Now);
            entity.LastTestCount = entity.LastTestCount + finishedCount;
            return base.Update(entity);
        }

        public DayFinished UpdateStorageFinished(int finishedCount)
        {
            var entity = GetByDateTime(DateTime.Now);
            entity.StorageCount = entity.StorageCount + finishedCount;
            return base.Update(entity);
        }
    }

    class SearchResult
    {
        public int CollectionCount { get; set; }
        public int AssembleCount { get; set; }
        public int FistTestCount { get; set; }
        public int LastTestCount { get; set; }
        public int StorageCount { get; set; }
    }
}