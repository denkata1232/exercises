namespace IP_loggins_processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IP_loggins();
        }
        static void IP_loggins()
        {
            SortedDictionary<string, int> timeSpend = new SortedDictionary<string, int>();
            SortedDictionary<string, string> ipAdresses = new SortedDictionary<string, string>();
            int inputCounts = int.Parse(Console.ReadLine());
            for(int i = 0; i < inputCounts; i++)
            {
                string input = Console.ReadLine();
                string ip = null;
                string name = null;
                int time = 0;
                string num = null;
                int j = 0;
                for(; j < input.Length; j++)
                {
                    if (input[j] == ' ')
                    {
                        j++;
                        break;
                    }
                    ip += input[j];
                }
                for(; j < input.Length; j++)
                {
                    if (input[j] == ' ')
                    {
                        j++;
                        break;
                    }
                    name += input[j];
                }
                for(; j < input.Length; j++)
                {
                    num += input[j];
                }
                time = int.Parse(num);
                if (timeSpend.ContainsKey(name))
                {
                    timeSpend[name]+=time;
                    if(!ipAdresses.ContainsKey(ip))
                    ipAdresses.Add(ip, name);
                }
                else
                {
                    timeSpend.Add(name, time);
                    ipAdresses.Add(ip, name);
                }
            }
            foreach(var item in timeSpend)
            {
                List<string> output = new List<string>();
                foreach(var item2 in ipAdresses)
                {
                    if(item2.Value == item.Key)
                    output.Add(item2.Key);
                }
                Console.WriteLine($"{item.Key}: {item.Value} [{String.Join(", ", output)}]");
            }
        }
    }
}