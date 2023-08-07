using System.Globalization;

namespace time_input_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => DateTime.ParseExact(x,"H:mm", CultureInfo.InvariantCulture))
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine(String.Join(", ", list));
        }
    }
}