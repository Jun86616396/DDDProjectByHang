using System;
using System.Collections.Generic;
using System.Linq;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;

namespace Infra.EF.Repository
{
	public class AssembleRepository : BaseRepository<Assemble,ManageContext>, IAssembleRepository
    {
		public AssembleRepository(ManageContext dbContext):base(dbContext)
		{

		}

        /// <summary>
        /// 当前一盒组装完成---新完成一盒
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="boxNumber"></param>
        /// <param name="count"> 当前盒完成的数量</param>
        public void AssembleOneBox(int orderId, string boxNumber,byte count=50)
		{

			DbSet.Add(new Assemble() { OrderId = orderId, BoxNumber = boxNumber,AssembleCreateTime=DateTime.Now,FinishedNumber=count });
        }

		/// <summary>
		/// 得到当前订单已组装完成的盒号
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns></returns>
		public List<string> GetAssembleFinishedBoxes( int orderId)
		{
			return DbSet.AsNoTracking().Where(assemble => assemble.OrderId == orderId).Select(o => o.BoxNumber).ToList();
		}

		//得到组装的数量
		public int  GetAssembleCount( int orderId)
		{

			var list = DbSet.AsNoTracking().Where(assembel => assembel.OrderId == orderId).ToList();
			if (list.Count == 0)
			{
				return 0;
			}
			return list.Sum(o => o.FinishedNumber);
		}

		public Tuple<int, DateTime> GetCurrentOrderAssembleInfo(int orderId)
		{

			var linqResult = from asse in DbSet
							 where asse.OrderId == orderId
							 group asse by asse.OrderId
							 into gp
							 select new
							 {
								 Ccount = gp.Sum(t => t.FinishedNumber),
								 Cdatetime = gp.Max(t => t.AssembleCreateTime)
							 };

		

			return new Tuple<int, DateTime>(linqResult.Single().Ccount, linqResult.Single().Cdatetime);

		}

       
    }
}
