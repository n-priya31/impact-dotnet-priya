using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 100).ToList();

        // Sequential foreach
        Stopwatch sw = Stopwatch.StartNew();

        foreach (var item in numbers)
        {
            DoWork(item);
        }

        sw.Stop();
        Console.WriteLine($"Sequential foreach : {sw.ElapsedMilliseconds} ms");


        // Task.Run
        sw.Restart();

        Task[] tasks = numbers
            .Select(n => Task.Run(() => DoWork(n)))
            .ToArray();

        Task.WaitAll(tasks);

        sw.Stop();
        Console.WriteLine($"Task.Run            : {sw.ElapsedMilliseconds} ms");


        // Parallel.ForEach
        sw.Restart();

        Parallel.ForEach(numbers, item =>
        {
            DoWork(item);
        });

        sw.Stop();
        Console.WriteLine($"Parallel.ForEach    : {sw.ElapsedMilliseconds} ms");

        Console.ReadKey();
    }

    static void DoWork(int number)
    {
        Thread.Sleep(100);   // Simulate 100 ms work
    }
}