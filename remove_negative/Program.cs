namespace remove_negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            list.RemoveAll(x => x < 0);
            if (list.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}