using RewardsPlus.WebApi.Shared.Notifications;

namespace RewardsPlus.BlazorWebAssembly.Client.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}