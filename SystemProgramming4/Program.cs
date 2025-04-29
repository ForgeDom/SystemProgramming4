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

        await PrintNumbers(start, end); 
        Console.WriteLine("Task completed.");
    }
    static async Task PrintNumbers(int start, int end)
    {
        await Task.Run(() =>
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
                Task.Delay(100).Wait(); 
            }
        });
    }
}