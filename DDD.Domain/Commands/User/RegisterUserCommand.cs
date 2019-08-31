using DDD.Domain.Validations.User;

namespace DDD.Domain.Commands.User
{
    public class RegisterUserCommand:UserCommand
    {
        public string UserConfirmPwd { get; protected set; }//注意：set 都是 protected 的

        // set 受保护，只能通过构造函数方法赋值
        public RegisterUserCommand(string name, string pwd, string pwdConfirm)
        {
            UserName = name;
            UserPwd = pwd;
            UserConfirmPwd = pwdConfirm;

        }


        
        public override bool IsValid()
        {
            ValidationResult = new RegisterUserValidation().Validate(this);//注意：这个就是命令验证，我们会在下边实现它
            return ValidationResult.IsValid;
        }
    }
}