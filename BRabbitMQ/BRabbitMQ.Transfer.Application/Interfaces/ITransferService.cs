using System.Collections.Generic;
using BRabbitMQ.Transfer.Domain.Models;

namespace BRabbitMQ.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<AccountTransferLog> GetTransferLogs();
    }
}