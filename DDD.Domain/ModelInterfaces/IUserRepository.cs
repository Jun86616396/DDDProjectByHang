namespace DDD.Domain.ModelInterfaces
{
    public interface IUserRepository
    {
        User UserLogin(User loginUser);
    }
}