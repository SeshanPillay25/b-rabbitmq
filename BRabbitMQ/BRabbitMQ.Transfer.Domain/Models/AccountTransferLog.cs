namespace BRabbitMQ.Transfer.Domain.Models
{
    public class AccountTransferLog
    {
        public int Id { get; set; }
        public string SourceAccount { get; set; }
        public decimal TargetAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}