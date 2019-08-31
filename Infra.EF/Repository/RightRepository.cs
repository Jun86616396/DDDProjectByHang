using System.Collections.Generic;
using System.Linq;
using DDD.Domain;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;
   

namespace Infra.EF.Repository
{
	public class RightRepository : BaseRepository<Right, ManageContext>, IRightRepository
    {
		public RightRepository(ManageContext dbContext) : base(dbContext)
		{

		}

	}
}
