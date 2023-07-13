using System.Diagnostics;

namespace rotate_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[arr.Length];
            for (int i = 0; i < k; i++)
            {
                int[] rotated = new int[arr.Length];
                for(int j = 0; j < rotated.Length-1; j++)
                {
                    rotated[j+1] = arr[j];
                }
                rotated[0] = arr[rotated.Length-1];
                for(int j =0; j < rotated.Length; j++)
                {
                    sum[j] += rotated[j];
                }
                arr = rotated;
            }
            Console.WriteLine(String.Join(" ", sum));
            Console.WriteLine(timer.Elapsed);
        }
    }
}