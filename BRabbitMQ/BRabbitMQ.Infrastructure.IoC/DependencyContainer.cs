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
using ITransferService = BRabbitMQ.Banking.Application.Interfaces.ITransferService;
using TransferService = BRabbitMQ.Banking.Application.Services.TransferService;

namespace BRabbitMQ.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
            
            //Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
            
            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            
            //Application layer
            services.AddTransient<ITransferService, TransferService>();
            services.AddTransient<Transfer.Application.Interfaces.ITransferService, Transfer.Application.Services.TransferService>();
            
            //Data layer
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}