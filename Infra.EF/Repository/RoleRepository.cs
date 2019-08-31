using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DDD.Domain;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;
   

namespace Infra.EF.Repository
{
	public class RoleRepository : BaseRepository<Role, ManageContext>, IRoleRepository
    {
		public RoleRepository(ManageContext dbContext) : base(dbContext)
		{

		}

	}
}
