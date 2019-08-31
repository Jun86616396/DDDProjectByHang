using DDD.Domain.Commands.User;
using FluentValidation;

namespace DDD.Domain.Validations.User
{
 
    public abstract class UserValidation<T> : AbstractValidator<T> where T : UserCommand
    {
        //受保护方法，验证Name
        protected void ValidateName()
        {
            //定义规则，c 就是当前 StudentCommand 类
            RuleFor(c => c.UserName)
                .NotEmpty().WithMessage("姓名不能为空")//判断不能为空，如果为空则显示Message
                .Length(2, 10).WithMessage("姓名在2~10个字符之间");//定义 Name 的长度
        }

        //验证密码
        protected void ValidatePwd()
        {
            RuleFor(c => c.UserPwd)
                .NotEmpty().WithMessage("密码不能为空")
                .MinimumLength(6).WithMessage("密码长度必须大于等于6位");

        }
    }
}