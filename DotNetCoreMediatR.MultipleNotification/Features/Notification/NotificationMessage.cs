using MediatR;

namespace DotNetCoreMediatR.MultipleNotification.Features.Notification
{
    public class NotificationMessage : INotification
    {
        public string Message { get; set; }
    }
}
