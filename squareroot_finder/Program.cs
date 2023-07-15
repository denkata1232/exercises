namespace squareroot_finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            list = squareRootFinder(list);
            list.Sort();
            list.Reverse();
            Console.WriteLine(String.Join(" ", list));
        }
        static List<int> squareRootFinder(List<int> list)
        {
            for(int i  = 0; i < list.Count; i++)
            {
                if (list[i] % Math.Sqrt(list[i]) != 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;
        }
    }
}