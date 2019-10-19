using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRMQ.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; }

        public Event()
        {
            Timestamp = DateTime.UtcNow;
        }
    }
}
