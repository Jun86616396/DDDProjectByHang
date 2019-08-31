using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDD.Domain;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;
   

namespace Infra.EF.Repository
{
	public class RoleRightRepository : BaseRepository<RoleRightRelation, ManageContext>, IRoleRightRepository
    {
		public RoleRightRepository(ManageContext dbContext) : base(dbContext)
		{

		}

	}
}
