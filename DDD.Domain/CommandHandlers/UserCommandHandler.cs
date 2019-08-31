using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DDD.Domain.Bus;
using DDD.Domain.Commands.User;
using DDD.Domain.Evens.User;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;
using DDD.Domain.Notifications;
using DDD.Domain.Repository;
using MediatR;

namespace DDD.Domain.CommandHandlers
{
    public class UserCommandHandler :  CommandHandler,IRequestHandler<RegisterUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediatorHandler _bus;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="userRepository"></param>
        /// <param name="unitOfWork"></param>
        /// <param name="bus"></param>
        public UserCommandHandler(IUserRepository userRepository,
            IUnitOfWork unitOfWork,
            IMediatorHandler bus
        ) : base(unitOfWork, bus)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _bus = bus;
        }


        // 整个命令处理程序的核心都在这里
        // 不仅包括命令验证的收集，持久化，还有领域事件和通知的添加

        public Task<Unit> Handle(RegisterUserCommand requestCommand, CancellationToken cancellationToken)
        {
            // 命令验证
            if (!requestCommand.IsValid())
            {
                //命令处理者        错误信息收集
                NotifyValidationErrors(requestCommand);

                return Task.FromResult(new Unit());
            }

            // 实例化领域模型，这里才真正的用到了领域模型
            // 注意这里是通过构造函数方法实现
            var user = new User(){UserName = requestCommand .UserName,UserPwd = requestCommand.UserPwd,CreateTime = DateTime.Now,StatusId = 1};

            //判断用户名是否存在
            // 这些业务逻辑，当然要在领域层中（领域命令处理程序中）进行处理
            if (_userRepository.GetAll(o=>o.UserName== requestCommand.UserName).FirstOrDefault() != null)
            {

                //引发错误事件
                _bus.RaiseEvent(new DomainNotification("", "该用户名已经被使用！"));
                return Task.FromResult(new Unit());
            }


            // 持久化
            _userRepository.Insert(user);

            // 统一提交
            if (Commit())
            {
                // 提交成功后，这里需要发布领域事件
                // 比如欢迎用户注册邮件呀，短信呀等
                _bus.RaiseEvent(new DomainNotification("success", "恭喜您，注册成功，已为您分配默认权限"));
                // waiting....
            }

            return Task.FromResult(new Unit());
        }


    }
}