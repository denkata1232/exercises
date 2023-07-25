using System.Text;

namespace letters_only
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            input = noNumbers(input);
            Console.WriteLine(input);
        }
        static StringBuilder noNumbers(StringBuilder input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    input.Remove(i, 1);
                    i--;
                    if (char.IsLetter(input[i + 1]))
                    {
                        input.Insert(i+1, input[i + 1]);
                    }
                }
            }
            return input;
        }
    }
}