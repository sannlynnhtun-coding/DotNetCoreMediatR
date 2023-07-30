using DotNetCoreMediatR.MultipleNotification.Features.Notification;
using MediatR;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DotNetCoreMediatR.MultipleNotification.Features.Blog
{
    public class NotificationHandler : INotificationHandler<NotificationMessage>
    {
        public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"NotificationHandler => {JsonConvert.SerializeObject(notification)}");
            return Task.CompletedTask;
        }
    }

    public class EmailNotificationHandler : INotificationHandler<NotificationMessage>
    {
        public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"EmailNotificationHandler => {JsonConvert.SerializeObject(notification)}");
            return Task.CompletedTask;
        }
    }
}
