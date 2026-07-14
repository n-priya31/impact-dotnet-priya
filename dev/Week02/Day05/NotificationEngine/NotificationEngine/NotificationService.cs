using NotificationEngine;
using System;

namespace NotificationEngine
{
    public class NotificationService
    {
        // Event
        public event Action<string> OnNotificationSent;

        public void Send(Notification notification, NotificationSender sender)
        {
            sender(notification);

            OnNotificationSent?.Invoke(
                $"Notification delivered to {notification.Recipient}");
        }
    }
}