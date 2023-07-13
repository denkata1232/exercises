namespace even_numbers_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            list = oddRemove(list);
            Console.WriteLine(String.Join(", ", list));
        }
        static List<int> oddRemove(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;
        }
    }
}