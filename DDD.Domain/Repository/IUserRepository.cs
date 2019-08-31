using DDD.Domain.Interfaces;
using DDD.Domain.Models;

namespace DDD.Domain.Repository
{
    public interface IUserRepository: IRepository<User>
    {
        User UserLogin(User loginUser);
    }
}