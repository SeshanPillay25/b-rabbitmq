using System;
using System.Collections.Generic;
using System.Text;
using BRabbitMQ.Domain.Core.Events;

namespace BRabbitMQ.Domain.Core.Commands
{
   public abstract class Command : Message
    {
        public DateTime TimeStamp { get; set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
