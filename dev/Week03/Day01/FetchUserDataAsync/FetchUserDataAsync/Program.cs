using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Sequential Execution");

        Stopwatch stopwatch = Stopwatch.StartNew();

        await FetchUserDataAsync(1);
        await FetchUserDataAsync(2);
        await FetchUserDataAsync(3);

        stopwatch.Stop();

        Console.WriteLine($"Sequential Time: {stopwatch.Elapsed.TotalSeconds} seconds");

        Console.WriteLine();

        Console.WriteLine("Concurrent Execution");

        stopwatch.Restart();

        Task task1 = FetchUserDataAsync(1);
        Task task2 = FetchUserDataAsync(2);
        Task task3 = FetchUserDataAsync(3);

        await Task.WhenAll(task1, task2, task3);

        stopwatch.Stop();

        Console.WriteLine($"Concurrent Time: {stopwatch.Elapsed.TotalSeconds} seconds");
    }

    static async Task FetchUserDataAsync(int userId)
    {
        Console.WriteLine($"Fetching User {userId}...");

        Console.WriteLine($"Before await - User {userId}");

        await Task.Delay(3000);

        Console.WriteLine($"After await - User {userId}");

        Console.WriteLine($"User {userId} data fetched.");
    }
}