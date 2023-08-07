namespace miner_info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> info = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                info.Add(resource, quantity);
                resource = Console.ReadLine();
            }
            foreach(var item in info)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}