namespace remove_last_all
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            list.RemoveAll(x => x == list.Last());
            Console.WriteLine(String.Join(" ", list));
        }
    }
}