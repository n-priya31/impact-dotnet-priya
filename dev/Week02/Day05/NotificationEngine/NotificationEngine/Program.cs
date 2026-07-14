using NotificationEngine;
using System;

namespace NotificationEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService service = new NotificationService();

            NotificationLogger logger = new NotificationLogger();

            // Subscribe to event
            service.OnNotificationSent += logger.Log;

            Notification notification = new Notification
            {
                Recipient = "Priya",
                Message = "Welcome to the Notification Engine!"
            };

            Console.WriteLine("EMAIL");
            service.Send(notification, Senders.SendEmail);

            Console.WriteLine();

            Console.WriteLine("SMS");
            service.Send(notification, Senders.SendSms);

            Console.WriteLine();

            Console.WriteLine("PUSH");
            service.Send(notification, Senders.SendPush);

            Console.ReadKey();
        }
    }
}