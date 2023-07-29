using System.Diagnostics;
using System.Text;

namespace karate_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            StringBuilder karate = new StringBuilder(Console.ReadLine());
            sw.Start();
            karate = Karate(karate);
            Console.WriteLine(karate);
            Console.WriteLine(sw.Elapsed);
        }
        static StringBuilder Karate(StringBuilder karate)
        {
            int power = 0;
            for (int i = 0; i < karate.Length; i++)
            {
                if (karate[i] == '>')
                {
                    power += karate[i + 1] - '0';
                    while (power > 0 && karate[i + 1] != '>')
                    {
                        karate.Remove(i + 1, 1);
                        power--;
                    }
                }
            }
            return karate;
        }
    }
}