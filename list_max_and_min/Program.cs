namespace list_max_and_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            list = min_max(list);
            Console.WriteLine(string.Join(", ", list));
        }
        static List<int> min_max(List<int> list)
        {
            int max = list.Max();
            int min = list.Min();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != min && list[i] != max)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            list.Sort();
            return list;
        }
    }
}