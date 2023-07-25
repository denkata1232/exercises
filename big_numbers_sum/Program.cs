namespace big_numbers_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int128 a = Int128.Parse(Console.ReadLine());
            Int128 b = Int128.Parse(Console.ReadLine());
            Int128 result = a + b;
            Console.WriteLine(result);
        }
    }
}