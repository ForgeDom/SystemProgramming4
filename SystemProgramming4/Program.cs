namespace SystemProgramming4;

class Program
{
    static async Task Main(string[] args)
    {
        Task task = Task.Run(() => PrintNumbers());
        Console.WriteLine("Main thread is doing other work...");
        await task; 
        Console.WriteLine("Task completed.");
    }
    static void PrintNumbers()
    {
        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(100);
        }
    }
}
