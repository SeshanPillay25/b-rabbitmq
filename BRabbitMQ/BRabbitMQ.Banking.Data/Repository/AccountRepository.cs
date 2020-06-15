using System.Collections.Generic;
using BRabbitMQ.Banking.Data.Context;
using BRabbitMQ.Banking.Domain.Interfaces;
using BRabbitMQ.Banking.Domain.Models;

namespace BRabbitMQ.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        //Injecting BankingDbContext
        private BankingDbContext _context;

        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}