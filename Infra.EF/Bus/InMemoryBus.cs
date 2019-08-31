using System.Threading.Tasks;
using DDD.Domain.Bus;
using DDD.Domain.Commands;
using DDD.Domain.Evens;
using MediatR;

namespace Infra.EF.Bus
{
    public sealed class InMemoryBus:IMediatorHandler
    {
        //构造函数注入
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task RaiseEvent<T>(T @event) where T : DomainEvent
        {
            // MediatR中介者模式中的第二种方法，发布/订阅模式

            return _mediator.Publish(@event);

        }

        /// <summary>
        /// 实现我们在IMediatorHandler中定义的接口
        /// 没有返回值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);//这里要注意下 command 对象
        }
    }
}