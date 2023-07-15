namespace next_to_next_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            list = SumOfNeigbours(list);
            Console.WriteLine(String.Join(" ", list));
        }
        static List<int> SumOfNeigbours(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (i + 1 >= list.Count) break;
                if (list[i] == list[i + 1])
                {
                    int resultAdd = list[i] + list[i + 1];
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                    list.Insert(i, resultAdd);
                    i = -1;
                }
            }
            return list;
        }
    }
}