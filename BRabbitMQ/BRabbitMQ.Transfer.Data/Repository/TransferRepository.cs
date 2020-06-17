using System.Collections.Generic;
using BRabbitMQ.Transfer.Data.Context;
using BRabbitMQ.Transfer.Domain.Interfaces;
using BRabbitMQ.Transfer.Domain.Models;

namespace BRabbitMQ.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        //Injecting BankingDbContext
        private TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }
        
        public void Add(AccountTransferLog transferLog)
        {
            _context.AccountTransferLogs.Add(transferLog);
            _context.SaveChanges();
        }
        
        public IEnumerable<AccountTransferLog> GetTransferLogs()
        {
            return _context.AccountTransferLogs;
        }

    }
}