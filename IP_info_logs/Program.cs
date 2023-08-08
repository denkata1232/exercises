namespace IP_info_logs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IP_info();
        }
        static void IP_info()
        {
            SortedDictionary<string, string> IPLoggins = new SortedDictionary<string, string>();
            SortedDictionary<string, int> IP_messageCount = new SortedDictionary<string, int>();
            string loggin = Console.ReadLine();
            while (loggin != "end")
            {
                int i = 3;
                string ip = null;
                string userName = null;
                for (; i < loggin.Length; i++)
                {
                    if (loggin[i] == ' ')
                    {
                        i += 9;
                        break;
                    }
                    else
                    {
                        ip += loggin[i];
                    }
                }
                for(; i < loggin.Length; i++)
                {
                    if (loggin[i] == '=')
                    {
                        i++;
                        break;
                    }
                }
                for(; i < loggin.Length; i++)
                {
                    userName += loggin[i];
                }
                if(IPLoggins.ContainsKey(ip))
                {
                    IP_messageCount[ip]++;
                }
                else
                {
                    IPLoggins.Add(ip, userName);
                    IP_messageCount.Add(ip, 1);
                }
                loggin = Console.ReadLine();
            }
            foreach(var item in IPLoggins)
            {
                TriplePair triplePair = new TriplePair();
                triplePair.Name = item.Value;
                triplePair.Value = item.Key;
                triplePair.Count = IP_messageCount[item.Key];
                Console.WriteLine($"{triplePair.Name}: {triplePair.Value} => {triplePair.Count}");
            }
        }
    }
    public struct TriplePair
    {
        public string Name;
        public string Value;
        public int Count;
    }
}