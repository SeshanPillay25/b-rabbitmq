﻿namespace BRabbitMQ.Transfer.Domain.Models
{
    public class AccountTransferLog
    {
        public int Id { get; set; }
        public int SourceAccount { get; set; }
        public int TargetAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}