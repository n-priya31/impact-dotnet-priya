using System;

// Custom EventArgs
class AlarmEventArgs : EventArgs
{
    public DateTime AlarmTime { get; set; }

    public AlarmEventArgs(DateTime alarmTime)
    {
        AlarmTime = alarmTime;
    }
}

// Publisher
class AlarmClock
{
    // Event Declaration
    public event EventHandler<AlarmEventArgs> OnAlarmRing;

    public void RingAlarm()
    {
        Console.WriteLine("Alarm is ringing...\n");

        OnAlarmRing?.Invoke(this, new AlarmEventArgs(DateTime.Now));
    }
}

// Subscriber 1
class Person
{
    public void WakeUp(object sender, AlarmEventArgs e)
    {
        Console.WriteLine($"Person: Woke up at {e.AlarmTime}");
    }
}

// Subscriber 2
class CoffeeMachine
{
    public void StartCoffee(object sender, AlarmEventArgs e)
    {
        Console.WriteLine($"Coffee Machine: Started brewing coffee at {e.AlarmTime}");
    }
}

class Program
{
    static void Main()
    {
        AlarmClock alarmClock = new AlarmClock();

        Person person = new Person();
        CoffeeMachine coffeeMachine = new CoffeeMachine();

        // Subscribe to the event
        alarmClock.OnAlarmRing += person.WakeUp;
        alarmClock.OnAlarmRing += coffeeMachine.StartCoffee;

        // Trigger the event
        alarmClock.RingAlarm();
    }
}