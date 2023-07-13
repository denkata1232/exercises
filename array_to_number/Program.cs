using System.Diagnostics;

namespace array_to_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] number = new int[num.Length-1];
            while(num.Length > 1)
            {
                int[] condesed = new int[num.Length-1];
                for(int i = 0; i < condesed.Length; i++)
                {
                    condesed[i] = num[i] + num[i+1];
                }
                num = condesed;
            }
            Console.WriteLine(num[0]);
            Console.WriteLine(timer.Elapsed);
        }
    }
}