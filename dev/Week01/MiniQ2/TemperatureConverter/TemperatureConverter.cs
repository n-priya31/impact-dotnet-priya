using System;

namespace TemperatureConverter
{
    public class Converter
    {
        // Celsius Input
        public void Convert(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"Celsius    : {celsius}");
            Console.WriteLine($"Fahrenheit : {fahrenheit:F2}");
            Console.WriteLine($"Kelvin     : {kelvin:F2}");
        }

        // Fahrenheit Input
        public void Convert(double fahrenheit, bool isFahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"Fahrenheit : {fahrenheit}");
            Console.WriteLine($"Celsius    : {celsius:F2}");
            Console.WriteLine($"Kelvin     : {kelvin:F2}");
        }

        // Kelvin Input
        public void Convert(double kelvin, bool isKelvin, bool dummy)
        {
            double celsius = kelvin - 273.15;
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Kelvin     : {kelvin}");
            Console.WriteLine($"Celsius    : {celsius:F2}");
            Console.WriteLine($"Fahrenheit : {fahrenheit:F2}");
        }
    }
}