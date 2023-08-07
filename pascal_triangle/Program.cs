namespace dictionary_odd_repeated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string,int> dictionary = new SortedDictionary<string, int>();
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(var item in words)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else dictionary[item] = 1;
            }
            List<string> result = new List<string>();
            foreach(var item in dictionary)
            {
                if(item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}