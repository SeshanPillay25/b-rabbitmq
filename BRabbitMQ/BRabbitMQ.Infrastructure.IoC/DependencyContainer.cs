using BRabbitMQ.Banking.Application.Interfaces;
using BRabbitMQ.Banking.Application.Services;
using BRabbitMQ.Banking.Data.Context;
using BRabbitMQ.Banking.Data.Repository;
using BRabbitMQ.Banking.Domain.Interfaces;
using BRabbitMQ.Domain.Core.Bus;
using BRabbitMQ.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace BRabbitMQ.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
            
            //Application layer
            services.AddTransient<IAccountService, AccountService>();
            
            //Data layer
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}