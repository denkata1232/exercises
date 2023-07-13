namespace number_mid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            if(arr.Length == 1) 
            {
                Console.WriteLine("{ " + arr[0] + " }");
            }
            else if(arr.Length % 2 == 0) 
            {
                int firstIndex = arr.Length/2 - 1;
                int secondIndex = arr.Length/2;
                Console.WriteLine("{ " + arr[firstIndex] + ", " + arr[secondIndex] + " }");
            }
            else
            {
                int firstIndex = ((arr.Length-1) / 2) - 1;
                int secondIndex = (arr.Length-1) / 2;
                int thirdIndex = ((arr.Length-1) / 2) + 1;
                Console.WriteLine("{ " + arr[firstIndex] + ", " + arr[secondIndex] + ", " + arr[thirdIndex] + " }");
            }
        }
    }
}