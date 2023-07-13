namespace bestNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bestNum = 0;
            int bestCount = 0;
            foreach(var item in arr)
            {
                int count = 0;
                foreach(var item2 in arr) 
                {
                    if(item == item2)
                    {
                        count++;
                    }
                }
                if(count > bestCount) 
                {
                    bestNum = item;
                    bestCount = count;
                }
            }
            Console.WriteLine($"the best number is {bestNum} repeated {bestCount}");
        }
    }
}