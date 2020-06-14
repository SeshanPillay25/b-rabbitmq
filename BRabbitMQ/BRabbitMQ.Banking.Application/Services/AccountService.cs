using System.Collections.Generic;
using BRabbitMQ.Banking.Application.Interfaces;
using BRabbitMQ.Banking.Domain.Interfaces;
using BRabbitMQ.Banking.Domain.Models;

namespace BRabbitMQ.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        //Injecting repository
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}