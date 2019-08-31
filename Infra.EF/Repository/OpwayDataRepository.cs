using System;
using System.Collections.Generic;
using System.Linq;
using DDD.Domain.Models.OPWAY;
using DDD.Domain.Repository;
using Infra.EF.Contexts;

namespace Infra.EF.Repository
{
	public class OpwayDataRepository:BaseRepository<OPWAYDATA, ManageContext>, IOpwayDataRepository
    {
        public OpwayDataRepository(ManageContext dbcontext) : base(dbcontext)
        {

        }

        public int GetDayFirstTestCount(DateTime dateTime)
        {
            
            var dtMin = dateTime.ToString("u");
            var dtMax = dateTime.AddDays(1).ToString("u");

            var sql = $"SELECT COUNT( Distinct [SN]) FROM [ATSDATABASE].[dbo].[OPWAYDATA]  WHERE [DATATIME] BETWEEN '{dtMin}' AND '{dtMax}' AND [PoDAC] !='' AND [PF] = 'PASS' ";

            return DbContext.Database.SqlQuery<int>(sql).First();
        }

        public int GetDayLastTestCount(DateTime dateTime)
        {
            var dtMin = dateTime.ToString("u");
            var dtMax = dateTime.AddDays(1).ToString("u");

            var sql=   $"SELECT COUNT( Distinct [SN]) FROM [ATSDATABASE].[dbo].[OPWAYDATA]  WHERE [DATATIME] BETWEEN '{dtMin}' AND '{dtMax}' AND [EMM] != '' AND [PF] = 'PASS' ";

         return DbContext.Database.SqlQuery<int>(sql).First();
        }

        public  int  GetFirstTestCount(string snMin,string snMax)
		{

			var sql = $"SELECT COUNT( Distinct [SN]) FROM [ATSDATABASE].[dbo].[OPWAYDATA]  WHERE[SN] BETWEEN '{snMin}' AND '{snMax}' AND [PoDAC] !='' AND [PF] = 'PASS' ";

			return	 DbContext.Database.SqlQuery<int>(sql).First();
		}


		public  List<string> GetFirstTestFinishedSn(string snMin, string snMax)
		{
            //留在这里将来可能查询多列   不仅仅是SN  这时不能用distinc去重 要保留最后一次成功的记录  
            //var sql = $"SELECT [SN] FROM [ATSDATABASE].[dbo].[OPWAYDATA] as  [A] WHERE [A].[DataId] =(SELECT MAX([DataId]) FROM[ATSDATABASE].[dbo].[OPWAYDATA] as [B] WHERE[SN] BETWEEN '{snMin}' AND '{snMax}' AND[EMM] = '' AND[PF] = 'PASS'  AND[B].[SN] = [A].[SN])";

            //SELECT* FROM[ATSDATABASE].[dbo].[OPWAYDATA] as  [A] WHERE[A].[SN] BETWEEN  'OP19030502001'  AND  'OP19030504000' AND[A].[PoDAC] !=''  AND[A].[PF] = 'PASS' AND[A].[DataId]= (SELECT MAX([DataId]) FROM[ATSDATABASE].[dbo].[OPWAYDATA]  as [B] WHERE[B].[PoDAC] !='' AND[B].[SN] = [A].[SN])

			//因为只是想知道数量 和已完成的SN 所以不用关联查询
			var sql2 = $"SELECT Distinct [SN] FROM[ATSDATABASE].[dbo].[OPWAYDATA]  WHERE[SN] BETWEEN '{snMin}' AND '{snMax}' AND [PoDAC] !='' AND[PF] = 'PASS' ";

			return DbContext.Database.SqlQuery<string>(sql2).ToList();
		}


		public int GetLastTestCount(string snMin, string snMax)
		{

            //SELECT* FROM[ATSDATABASE].[dbo].[OPWAYDATA] as  [A] WHERE[A].[SN] BETWEEN  'OP19030502001'  AND  'OP19030504000' AND[A].[EMM] !=''  AND[A].[PF] = 'PASS' AND[A].[DataId]= (SELECT MAX([DataId]) FROM[ATSDATABASE].[dbo].[OPWAYDATA]  as [B] WHERE[B].[SN] = [A].[SN])

			var sql = $"SELECT COUNT( Distinct [SN]) FROM [ATSDATABASE].[dbo].[OPWAYDATA]  WHERE [SN] BETWEEN '{snMin}' AND '{snMax}' AND[EMM] != '' AND [PF] = 'PASS' ";

			return DbContext.Database.SqlQuery<int>(sql).First();
		}


		public List<string> GetLastTestFinishedSn(string snMin, string snMax)
		{
			//留在这里将来可能查询多列   不仅仅是SN  这时不能用distinc去重 要保留最后一次成功的记录  
			//var sql = $"SELECT [SN] FROM [ATSDATABASE].[dbo].[OPWAYDATA] as  [A] WHERE [A].[DataId] =(SELECT MAX([DataId]) FROM[ATSDATABASE].[dbo].[OPWAYDATA] as [B] WHERE[SN] BETWEEN '{snMin}' AND '{snMax}' AND[EMM] != '' AND [PF] = 'PASS'  AND[B].[SN] = [A].[SN])";

			//因为只是想知道数量 和已完成的SN 所以不用关联查询
			var sql2 = $"SELECT Distinct [SN] FROM[ATSDATABASE].[dbo].[OPWAYDATA]  WHERE[SN] BETWEEN '{snMin}' AND '{snMax}' AND[EMM] != '' AND[PF] = 'PASS' ";

			return DbContext.Database.SqlQuery<string>(sql2).ToList();
		}

	}
}
