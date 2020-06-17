using System.Collections.Generic;
using BRabbitMQ.Banking.Application.Interfaces;
using BRabbitMQ.Banking.Application.Models;
using BRabbitMQ.Banking.Domain.Commands;
using BRabbitMQ.Banking.Domain.Interfaces;
using BRabbitMQ.Banking.Domain.Models;
using BRabbitMQ.Domain.Core.Bus;

namespace BRabbitMQ.Banking.Application.Services
{
    public class TransferService : ITransferService
    {
        //Injecting repository
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus; 
            

        public TransferService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void TransferFunds(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.AccountSource,
                accountTransfer.AccountTarget,
                accountTransfer.TransferAmount
                );

            //So beautiful
            _bus.SendCommand(createTransferCommand);
        }
    }
}