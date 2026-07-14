using NotificationEngine;
using System;

namespace NotificationEngine
{
    // Delegate
    public delegate void NotificationSender(Notification notification);

    public static class Senders
    {
        public static void SendEmail(Notification notification)
        {
            Console.WriteLine($"Email sent to {notification.Recipient}");
            Console.WriteLine($"Message : {notification.Message}");
        }

        public static void SendSms(Notification notification)
        {
            Console.WriteLine($"SMS sent to {notification.Recipient}");
            Console.WriteLine($"Message : {notification.Message}");
        }

        public static void SendPush(Notification notification)
        {
            Console.WriteLine($"Push Notification sent to {notification.Recipient}");
            Console.WriteLine($"Message : {notification.Message}");
        }
    }
}