using System.Collections;
using System.Collections.Generic;
using BRabbitMQ.Banking.Domain.Models;

namespace BRabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}