using System;
using System.Collections.Generic;

class Program
{
    static void ProcessList(
        List<int> numbers,
        Predicate<int> filter,
        Func<int, int> transform,
        Action<string> output)
    {
        foreach (int number in numbers)
        {
            if (filter(number))
            {
                int result = transform(number);
                output(result.ToString());
            }
        }
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Predicate - Check Even
        Predicate<int> isEven = n => n % 2 == 0;

        // Func - Square Number
        Func<int, int> square = n => n * n;

        // Action - Print in Uppercase
        Action<string> print = text =>
        {
            Console.WriteLine(text.ToUpper());
        };

        ProcessList(numbers, isEven, square, print);
    }
}