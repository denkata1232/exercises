namespace longest_repeated_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            list = longestRepeatedNumber(list);
            Console.WriteLine(String.Join(" ", list));
        }
        static List<int> longestRepeatedNumber(List<int> list)
        {
            int bestRep = 0;
            int bestNum = list.First();
            foreach (var item in list)
            {
                int tempRep = 0;
                int tempNum = item;
                foreach (var item2 in list)
                {
                    if (tempNum == item2)
                    {
                        tempRep++;
                    }
                    else if(tempRep > 0)
                    {
                        break;
                    }
                }
                if(tempRep > bestRep) 
                {
                    bestNum = tempNum;
                    bestRep = tempRep;
                }
            }
            list.RemoveAll(x => x != bestNum);
            return list;
        }
    }
}