namespace big_numbers_mult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int128 a = Int128.Parse(Console.ReadLine());
            Int16 b = Int16.Parse(Console.ReadLine());
            Int128 c = a * b;
            Console.WriteLine(c);
        }
    }
}