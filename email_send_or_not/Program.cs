namespace email_send_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Mail(input);
        }
        static void Mail(string email)
        {
            int before = 0;
            int after = 0;
            int index = 0;
            while (email[index] != '@')
            {
                index++;
            }
            for (int i = 1; i <= email.Length; i++)
            {
                if (index - i < 0)
                {
                    break;
                }
                before += email[index - i];
            }
            for (int i = 1; i <= email.Length; i++)
            {
                if (index + i >= email.Length)
                {
                    break;
                }
                after += email[index + i];
            }
            if (after - before <= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}