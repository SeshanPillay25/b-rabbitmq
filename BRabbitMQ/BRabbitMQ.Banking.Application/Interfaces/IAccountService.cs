﻿using System.Collections;
using System.Collections.Generic;
using BRabbitMQ.Banking.Application.Models;
using BRabbitMQ.Banking.Domain.Models;

namespace BRabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void TransferFunds(AccountTransfer accountTransfer);
    }
}