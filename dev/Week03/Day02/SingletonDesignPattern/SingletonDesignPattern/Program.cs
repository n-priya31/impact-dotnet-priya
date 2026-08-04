using SingletonDemo;
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Using Threads ");

        Thread[] threads = new Thread[5];

        for (int i = 0; i < 5; i++)
        {
            int threadNumber = i + 1;

            threads[i] = new Thread(() =>
            {
                Logger.Instance.Log($"Thread {threadNumber}");
            });

            threads[i].Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine();

        Console.WriteLine(" Using Tasks ");

        Task[] tasks = new Task[5];

        for (int i = 0; i < 5; i++)
        {
            int taskNumber = i + 1;

            tasks[i] = Task.Run(() =>
            {
                Logger.Instance.Log($"Task {taskNumber}");
            });
        }

        Task.WaitAll(tasks);

        Console.WriteLine();

        Console.WriteLine("Program Finished");
    }
}