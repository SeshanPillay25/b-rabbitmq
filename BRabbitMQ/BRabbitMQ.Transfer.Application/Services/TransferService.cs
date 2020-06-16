using System.Collections.Generic;
using BRabbitMQ.Domain.Core.Bus;
using BRabbitMQ.Transfer.Application.Interfaces;
using BRabbitMQ.Transfer.Domain.Interfaces;
using BRabbitMQ.Transfer.Domain.Models;

namespace BRabbitMQ.Transfer.Application.Services
{
    public class TransferService : ITransferService 
    {
        //Injecting repository
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus; 
            

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }
        public IEnumerable<AccountTransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}