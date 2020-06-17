using BRabbitMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BRabbitMQ.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<AccountTransferLog> AccountTransferLogs { get; set; }
    }
}