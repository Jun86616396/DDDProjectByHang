using System.Collections.Generic;
using DDD.Domain.Bus;
using DDD.Domain.Commands;
using DDD.Domain.Interfaces;
using DDD.Domain.Notifications;

namespace DDD.Domain.CommandHandlers
{

    /// <summary>
    /// 领域命令处理程序
    /// 用来作为全部处理程序的基类，提供公共方法和接口数据
    /// </summary>
    public class CommandHandler
    {
        // 注入工作单元
        private readonly IUnitOfWork _unitOfWork;


        // 注入中介处理接口（在领域事件中用来发布事件）
        private readonly IMediatorHandler _bus;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="bus"></param>
        public CommandHandler(IUnitOfWork unitOfWork, IMediatorHandler bus)
        {
            _unitOfWork = unitOfWork;
            _bus = bus;
        }


        //将领域命令中的验证错误信息收集
        //目前用的是缓存方法（以后通过领域通知替换）
        protected void NotifyValidationErrors(Command message)
        {
            List<string> errorInfo = new List<string>();
            foreach (var error in message.ValidationResult.Errors)
            {

                //将错误信息提交到事件总线，派发出去
                _bus.RaiseEvent(new DomainNotification("", error.ErrorMessage));
            }

        }


        //工作单元提交
        //如果有错误，下一步会在这里添加领域通知
        public bool Commit()
        {
            if (_unitOfWork.SaveChanges()) return true;

            return false;
        }
    }
}