namespace mirror_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string answer = MirrorWordTRUE_FALSE(input);
            Console.WriteLine(answer);
        }
        static string MirrorWordTRUE_FALSE(string input)
        {
            string answer = null;
            string output = null;
            if(input.Length == 1)
            {
                output = input;
            }
            else
            {
                for(int i = 1; i <= input.Length; i++)
                {
                    output += input[input.Length-i];
                }
            }
            if (input == output)
            {
                answer = "True";
            }
            else
            {
                answer = "False";
            }
            return answer;
        }
    }
}