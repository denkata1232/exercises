using System.Diagnostics;
using System.Text;

namespace letter_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            StringBuilder stringBuilder = new StringBuilder();
            string word = Console.ReadLine();
            stringBuilder.Insert(0, word);
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                int index = stringBuilder[i] - 'a';
                Console.WriteLine($"{stringBuilder[i]} -> {index}");
            }
            Console.WriteLine(stop.Elapsed);
        }
    }
}
