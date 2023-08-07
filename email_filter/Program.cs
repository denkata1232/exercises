namespace email_filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();
            while(name != "stop")
            {
                string email = Console.ReadLine();
                if (email.Substring(email.Length - 2, 2) != ("uk") && email.Substring(email.Length - 2, 2) != ("us"))
                {
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach(var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}