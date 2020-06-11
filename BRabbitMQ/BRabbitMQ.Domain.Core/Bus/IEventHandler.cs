using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BRabbitMQ.Domain.Core.Events;

namespace BRabbitMQ.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
    where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
