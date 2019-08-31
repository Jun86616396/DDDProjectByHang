using DDD.Domain.Commands.User;

namespace DDD.Domain.Validations.User
{
    public class RegisterUserValidation:UserValidation<RegisterUserCommand>
    {
        public RegisterUserValidation()
        {
            //验证姓名
            ValidateName();

            //验证密码
            ValidatePwd();

            //可以自定义增加新的验证
        }
    }
}