﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using BRabbitMQ.Domain.Core.Commands;
using BRabbitMQ.Domain.Core.Events;

namespace BRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>() 
            where T : Event
            where TH : IEventHandler<T>;

    }
}
