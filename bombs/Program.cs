using System.Diagnostics;

namespace bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            list = bombDetonator(list);
            int sum = list.Sum();
            Console.WriteLine(sum);
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
        static List<int> bombDetonator(List<int> list)
        {
            string bombAndPower = Console.ReadLine();
            int bomb = NumExtract(bombAndPower) / 10;
            int power = NumExtract(bombAndPower) % 10;
            int counter = list.Count;
        anotherOne:
            for (int i = 0; i < counter; i++)
            {
                if (i < power)
                {
                    int lower = list.IndexOf(bomb) - 1;
                    if(lower < list.Count && lower >= 0)
                    {
                        list.RemoveAt(lower);
                    }
                    int upper = list.IndexOf(bomb) + 1;
                    if (upper < list.Count && upper >= 0)
                    {
                        list.RemoveAt(upper);
                    }
                }
                else
                {
                    break;
                }

            }
            list.RemoveAt(list.IndexOf(bomb));
            if (list.Contains(bomb))
            {
                goto anotherOne;
            }
            return list;
        }
        static void thoughts()
        {
            /* thoughts down below
             list.RemoveAll(x => x == lower || x == upper);
             x => (list.IndexOf(x) == list.IndexOf(bomb) - 1) && x != bomb
             || list.IndexOf(x) == list.IndexOf(bomb) - i
             || (list.IndexOf(x) == list.IndexOf(bomb)) && x != bomb*/
        }/*useless*/
    }
}
