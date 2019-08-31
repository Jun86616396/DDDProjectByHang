using System;
using MediatR;

namespace DDD.Domain.Evens
{
    /// 事件模型 抽象基类，继承 INotification
    /// 也就是说，拥有中介者模式中的 发布/订阅模式
    public abstract class DomainEvent:INotification
    {
        // 时间戳
        public DateTime Timestamp { get; private set; }

        //用来获取我们事件执行过程中的类名
        public string MessageType { get; protected set; }

        public Guid AggregateId { get; protected set; }


        // 每一个事件都是有状态的
        protected DomainEvent()
        {
            Timestamp = DateTime.Now;

            MessageType = GetType().Name;
        }
    }
}