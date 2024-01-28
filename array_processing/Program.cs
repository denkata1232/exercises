namespace array_processing
{
    internal class Program
    {
        public static void Main(string[] args)
    {
        string[] arr = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0] != "END")
            {
                if (command[0] == "Distinct")
                {
                    int leng = arr.Length;
                    arr = arr.Distinct().ToArray();
                    if(leng == arr.Length)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else if (command[0] == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (command[0] == "Replace" && int.Parse(command[1])>=0 && int.Parse(command[1]) < arr.Length)
                {
                    int ind = int.Parse(command[1]);
                    arr[ind] = command[2];
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(String.Join(" ",arr));
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
                if (command[i]=='-')
                {
                    number = number * (-1);
                }
            }
            return number;
        }
        static void NO()
        {
            string[] arr = Console.ReadLine()
                .Split()
                .ToArray();
            string command = Console.ReadLine();
            string[] result = arr;
            while (command != "END") 
            {
                if (command == "Reverse")
                {
                    string[] temp = new string[arr.Length];
                    for(int i = 0; i < arr.Length; i++)
                    {
                        temp[i] = arr[arr.Length - (i+1)];
                    }
                    result = temp;
                }
                else if(command == "Distinct")
                {
                    string[] temp = new string[arr.Length];
                    int tempIndex = 0;
                    int index = 0;
                    foreach (var item in arr)
                    {
                        bool flag = true;
                        foreach(var copy in temp)
                        {
                            if (item == copy)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if(flag)
                        {
                            temp[tempIndex] = arr[index];
                            tempIndex++;
                        }
                        index++;
                    }
                    string[] result2 = new string[tempIndex];
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (temp[i] == null)
                        {
                            break;
                        }
                        result2[i] = temp[i];
                    }
                    result = result2;
                }
                else if (command.Substring(0,7) == "Replace")
                {
                    int index = NumExtract(command);
                    int wordStart = 9+index.ToString().Length;
                    int wordEnd = command.Length - wordStart;
                    string wordReplace = command.Substring(wordStart,wordEnd);
                    if(result.Length <= index || index < 0) { Console.WriteLine("Invalid input!"); }
                    else
                    {
                        result[index] = wordReplace;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Command!");
                }
                arr = result;
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
