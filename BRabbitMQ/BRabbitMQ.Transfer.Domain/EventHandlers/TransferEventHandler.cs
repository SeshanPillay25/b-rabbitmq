using System.Threading.Tasks;
using BRabbitMQ.Domain.Core.Bus;
using BRabbitMQ.Transfer.Domain.Events;

namespace BRabbitMQ.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
            
        }
        
        public Task Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}