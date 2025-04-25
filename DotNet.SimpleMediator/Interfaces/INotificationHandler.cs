using System.Threading;
using System.Threading.Tasks;

namespace DotNet.SimpleMediator.Interfaces
{
    public interface INotificationHandler<TNotification> where TNotification : INotification
    {
        Task Handle(INotification notification, CancellationToken cancellationToken);
    }
}
