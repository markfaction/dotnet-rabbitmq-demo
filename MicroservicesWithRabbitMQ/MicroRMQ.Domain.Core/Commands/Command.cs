using MicroRMQ.Domain.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRMQ.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; }

        protected Command()
        {
            Timestamp = DateTime.UtcNow;
        }
    }
}
