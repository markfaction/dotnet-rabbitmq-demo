using MediatR;

namespace MicroRMQ.Domain.Core.Common
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get;}

        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
