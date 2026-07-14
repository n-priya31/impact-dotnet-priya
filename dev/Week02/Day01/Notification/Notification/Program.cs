using System;

class Notification
{
    // Virtual method
    public virtual void Send()
    {
        Console.WriteLine("Sending Notification...");
    }
}

class EmailNotification : Notification
{
    // Sealed Override
    public sealed override void Send()
    {
        Console.WriteLine("Sending Email Notification...");
    }
}

class SmsNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Notification...");
    }
}

class PushNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending Push Notification...");
    }
}

// compile-time error

/*
class OfficeEmailNotification : EmailNotification
{
    public override void Send()
    {
        Console.WriteLine("Sending Office Email Notification...");
    }
}
*/

class Program
{
    static void Main()
    {
        Notification email = new EmailNotification();
        Notification sms = new SmsNotification();
        Notification push = new PushNotification();

        email.Send();
        sms.Send();
        push.Send();
    }
}