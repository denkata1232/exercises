namespace names_list
{
    internal class Program
    {
        //input
        //Ivan Dimitrov, Maria Ivanova, Dimitar Petrov
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();
            list = reverseNames(list);
            Console.WriteLine(String.Join(", ", list));
        }
        static string reverseName(string name, int count)
        {
            string reverseName = name.Substring((count + 1), (name.Length - (count + 1))) + " " + name.Substring(0, count);
            return reverseName;
        }
        static List<string> reverseNames(List<string> list) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < list[i].Length; j++)
                {
                    if (list[i][j] == ' ')
                    {
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                list[i] = reverseName(list[i], count);
            }
            return list;
        }
    }
}