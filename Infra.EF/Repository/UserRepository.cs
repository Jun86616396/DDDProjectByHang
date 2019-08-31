using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DDD.Domain;
using DDD.Domain.Models;
using DDD.Domain.Repository;
using Infra.EF.Contexts;
   

namespace Infra.EF.Repository
{
	public class UserRepository : BaseRepository<User, ManageContext>, IUserRepository
    {
		public UserRepository(ManageContext dbContext) : base(dbContext)
		{

		}

		//用户登录
		public User UserLogin(User loginUser)
		{
			return DbSet.AsNoTracking().SingleOrDefault(o => o.UserName == loginUser.UserName && o.UserPwd == loginUser.UserPwd);
		}

	}
}
