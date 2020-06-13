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
        }
    }
}