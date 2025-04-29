namespace SystemProgramming4;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter thread count:");
        int threadCount = int.Parse(Console.ReadLine());
        
        int rangeSize = (end - start + 1) / threadCount;
        var tasks = new Task[threadCount];
        for (int i = 0; i < threadCount; i++)
        {
            int rangeStart = start + i * rangeSize;
            int rangeEnd = (i == threadCount - 1) ? end : rangeStart + rangeSize - 1;
            tasks[i] = Task.Run(() => PrintNumbers(rangeStart, rangeEnd));
        }

        await Task.WhenAll(tasks);
        Console.WriteLine("Tasks completed.");
        Console.ReadKey();
    }
    static async Task PrintNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine($"Потік {Thread.CurrentThread.ManagedThreadId}: {i}");
            Task.Delay(100).Wait(); 
        }
    }
}