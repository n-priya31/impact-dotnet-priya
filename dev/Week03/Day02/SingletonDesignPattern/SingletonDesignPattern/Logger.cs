using System;

namespace SingletonDemo
{
    public class Logger
    {
        // Lazy<T> creates the object only when it is first needed.
        private static readonly Lazy<Logger> instance =
            new Lazy<Logger>(() => new Logger());

        // Private constructor prevents creating objects using 'new'.
        private Logger()
        {
        }

        // Public property to access the single instance.
        public static Logger Instance
        {
            get { return instance.Value; }
        }

        public void Log(string message)
        {
            Console.WriteLine($"{message} | Hash Code: {GetHashCode()}");
        }
    }
}