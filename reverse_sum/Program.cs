namespace reverse_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int rSum = reverseSum(list);
            Console.WriteLine(rSum);
        }
        static int reverseSum(List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += reverseNumber(item);
            }
            return sum;
        }
        static int reverseNumber(int num)
        {
            int reverse = num.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
            return reverse;
        }
    }
}