using System.Diagnostics;

namespace number_letter_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            string[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            sw.Start();
            double result = GAME(arr);
            Console.WriteLine($"{result:f2}");
            Console.WriteLine(sw.Elapsed);
        }
        static double GAME(string[] arr)
        {
            double result = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                char firstLetter = arr[i][0];
                char lastLetter = arr[i][arr[i].Length-1];
                double number = NumExtract(arr[i]);
                int upperCase = 'A' - 1;
                int lowerCase = 'a' - 1;
                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - upperCase;
                }
                else if (char.IsLower(firstLetter))
                {
                    number *= firstLetter - lowerCase;
                }
                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - upperCase;
                }
                else if(char.IsLower(lastLetter))
                {
                    number += lastLetter - lowerCase;
                }
                result += number;
            }
            return result;
        }
        static int NumExtract(string command)
        {
            string num = null;
            int number = 0;
            for (int i = 0; i < command.Length; i++)
            {
                if (Char.IsDigit(command[i]))
                {
                    num += command[i];
                }
            }
            if (num.Length > 0)
            {
                number = int.Parse(num);
            }
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == '-')
                {
                    number = number * (-1);
                }
            }
            return number;
        }
    }
}