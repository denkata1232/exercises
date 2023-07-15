namespace count_of_repeated_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Dictionary<int, int> repeat = Repetion(list);
            foreach(var item in repeat)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
        static Dictionary<int, int> Repetion(List<int> list)
        {
            Dictionary<int, int> repeat = new Dictionary<int, int>();
            list.Sort();
            int rep = list.Last();
            foreach (var item in list) 
            {
                int count = 0;
                foreach (var item2 in list)
                {
                    if (rep == item) break;
                    if (item == item2) count++;
                }
                if(count != 0)
                {
                    repeat.Add(item, count);
                }
                rep = item;
            }
            return repeat;
        }
    }
}