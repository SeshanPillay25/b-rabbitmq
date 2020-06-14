using System.Collections;
using System.Collections.Generic;
using BRabbitMQ.Banking.Domain.Models;

namespace BRabbitMQ.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}