using System.Threading.Tasks;
using BRabbitMQ.Domain.Core.Bus;
using BRabbitMQ.Transfer.Domain.Events;
using BRabbitMQ.Transfer.Domain.Interfaces;
using BRabbitMQ.Transfer.Domain.Models;

namespace BRabbitMQ.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new AccountTransferLog()
            {
                SourceAccount = @event.From,
                TargetAccount = @event.To,
                TransferAmount = @event.Amount
            });
            return Task.CompletedTask;
        }
    }
}