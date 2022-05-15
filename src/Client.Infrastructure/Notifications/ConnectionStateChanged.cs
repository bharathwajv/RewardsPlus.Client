using RewardsPlus.WebApi.Shared.Notifications;

namespace RewardsPlus.BlazorWebAssembly.Client.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;