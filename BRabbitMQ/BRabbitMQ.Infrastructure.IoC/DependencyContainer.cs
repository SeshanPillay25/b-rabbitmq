using BRabbitMQ.Banking.Application.Interfaces;
using BRabbitMQ.Banking.Application.Services;
using BRabbitMQ.Banking.Data.Context;
using BRabbitMQ.Banking.Data.Repository;
using BRabbitMQ.Banking.Domain.CommandHandlers;
using BRabbitMQ.Banking.Domain.Commands;
using BRabbitMQ.Banking.Domain.Interfaces;
using BRabbitMQ.Domain.Core.Bus;
using BRabbitMQ.Infrastructure.Bus;
using BRabbitMQ.Transfer.Application.Interfaces;
using BRabbitMQ.Transfer.Application.Services;
using BRabbitMQ.Transfer.Data.Context;
using BRabbitMQ.Transfer.Data.Repository;
using BRabbitMQ.Transfer.Domain.EventHandlers;
using BRabbitMQ.Transfer.Domain.Events;
using BRabbitMQ.Transfer.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BRabbitMQ.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });
            
            //Subscriptions
            services.AddTransient<TransferEventHandler>();
            
            //Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
            
            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            
            //Application layer
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();
            
            //Data layer
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}