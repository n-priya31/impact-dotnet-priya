using System;

namespace NotificationEngine
{
    public class NotificationLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}