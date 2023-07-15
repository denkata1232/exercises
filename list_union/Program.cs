namespace list_union
{
    internal class Program
    {
        //incompleted
        public static int j = 0;
        public static int k = j;
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string numbers = Console.ReadLine();
            j = numbers.Length-1;
            for(int i = 0; i < numbers.Length; i++)
            {
                list.Add(NumExtract(numbers));
            }
            Console.WriteLine(String.Join(" ", list));
        }
        static int NumExtract(string command)
        {
            string num = null;
            int number = 0;
            while (true)
            {
                if (command[k] == '|')
                {
                    break;
                }
                else
                {
                    k--;
                }
            }
            int index = k;
            for (; index < command.Length; index++)
            {
                if ((command[index] == '|' || command[index] == ' ') && num != null)
                {
                    goto done;
                }
                if (Char.IsDigit(command[index]))
                {
                    num += command[index];
                }
            }
        done:
            k--;
            if (num.Length > 0)
            {
                number = int.Parse(num);
            }
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == '|' || command[i] == ' ')
                {
                    goto finish;
                }

                if (command[i] == '-')
                {
                    number = number * (-1);
                }
            }
            finish:
            return number;
        }
    }
}