using System.Threading;
using System.Threading.Tasks;
using DDD.Domain.Evens.User;
using MediatR;

namespace DDD.Domain.EventHandlers
{
    public class UserEventHandler : INotificationHandler<UerRegisteredEvent>
    {
        public  Task Handle(UerRegisteredEvent notification, CancellationToken cancellationToken)
        {
            Task.Delay(5000);
            return Task.CompletedTask;
        }
    }
}