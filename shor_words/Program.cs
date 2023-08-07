namespace short_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '\\', '!', '?', ' ' };
            string text = Console.ReadLine().ToLower();
            string[] words = text.Split(symbols);
            List<string> result = words
                .Where(x => x != "")
                .Distinct()
                .OrderBy(x => x)
                .ToList();
            for(int i = 0; i < result.Count; i++)
            {
                if (result[i].Length > 4)
                {
                    result.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}