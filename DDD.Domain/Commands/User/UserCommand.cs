using System.Security.Claims;

namespace DDD.Domain.Commands.User
{
    public abstract class UserCommand:Command
    {
        public string UserName { get;protected set; }//注意：set 都是 protected 的

        public string UserPwd { get; protected set; }//注意：set 都是 protected 的

       
    }
}