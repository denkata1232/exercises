namespace word_sorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test input -> Learn programming at CodeCamp: Java, PHP, JS, HTML, 5, CSS, Web, C#, SQl, databases, AJAX, ect.
            string text = Console.ReadLine();
            char[] symbols = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            string word = null;
            List<string> lower = new List<string>();
            List<string> mixed = new List<string>();
            List<string> upper = new List<string>();
            for (int i = 0; i < text.Length;i++)
            {
                bool statement = symbols.Contains(text[i]);
                if (!statement)
                {
                    word += text[i];
                }
                else
                {
                    if (word == null) goto end;
                    bool hasUpper = word.Any(char.IsUpper);
                    bool hasLower = word.Any(char.IsLower);
                    if (hasUpper && !hasLower)
                    {
                        upper.Add(word);
                    }
                    else if(hasLower && !hasUpper)
                    {
                        lower.Add(word);
                    }
                    else
                    {
                        mixed.Add(word);
                    }
                    word = null;
                }
            end:
                int so = 0;
            }
            Console.WriteLine($"Lower-case: {String.Join(", ", lower)}");
            Console.WriteLine($"Mixed-case: {String.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", upper)}");
        }
    }
}