using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Common.application.bus.bus
{
    public interface ICommandQueryBus
    {
        Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : INotification;
        Task Send<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest;
    }
}
