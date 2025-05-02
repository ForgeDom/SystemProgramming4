namespace SystemProgramming4;
using System.Threading.Tasks;

class Program
{
    static int[] numbers = new int[10000];
    static int max, min;
    static double avg;
    static async Task Main(string[] args)
    {
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-10000, 10000);
        }
        
        Task maxTask = Task.Run(() => max = numbers.Max());
        Task minTask = Task.Run(() => min = numbers.Min());
        Task avgTask = Task.Run(() => avg = numbers.Average());
        
        await Task.WhenAll(maxTask, minTask, avgTask);
        
        Console.WriteLine($"Max : {max}");
        Console.WriteLine($"Min : {min}");
        Console.WriteLine($"Avg : {avg}");
        Console.ReadKey();
    }
}