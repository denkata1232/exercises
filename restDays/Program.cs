using System.Globalization;

namespace restDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy",CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for(var date = startDate;date <= endDate;date = date.AddDays(1))
            {
                if(date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    holidaysCount++;
                }
            }
            Console.WriteLine(holidaysCount);
        }
    }
}