using System.Threading;
using System.Threading.Tasks;
using BRabbitMQ.Banking.Domain.Commands;
using BRabbitMQ.Banking.Domain.Events;
using BRabbitMQ.Domain.Core.Bus;
using MediatR;

namespace BRabbitMQ.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //Publish event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult(true);
        }
    }
}