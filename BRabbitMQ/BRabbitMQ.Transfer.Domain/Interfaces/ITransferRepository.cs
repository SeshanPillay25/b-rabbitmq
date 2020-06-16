using System.Collections.Generic;
using BRabbitMQ.Transfer.Domain.Models;

namespace BRabbitMQ.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<AccountTransferLog> GetTransferLogs();
        void Add(AccountTransferLog transferLog);
    }
}