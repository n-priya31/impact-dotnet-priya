using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main()
        {
            Converter converter = new Converter();

            Console.WriteLine(" Celsius Input ");
            converter.Convert(25);

            Console.WriteLine();

            Console.WriteLine(" Fahrenheit Input ");
            converter.Convert(98.6, true);

            Console.WriteLine();

            Console.WriteLine(" Kelvin Input ");
            converter.Convert(300, true, true);
        }
    }
}