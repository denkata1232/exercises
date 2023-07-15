namespace fold_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] firstHalf = new int[arr.Length/4];
            int[] secondHalf = new int[arr.Length/4];
            int[] result = new int[arr.Length/2];
            int i = 1;
            int firstIndex = 0;
            for (int j = 0; j < firstHalf.Length; j++)
            {
                firstHalf[j] = arr[firstIndex] + arr[(arr.Length/2)-i];
                i++;
                firstIndex++;
            }
            i = arr.Length/2;
            int lastIndex = 1;
            for(int j = 0; j < secondHalf.Length; j++)
            {
                secondHalf[j] = arr[i]+arr[arr.Length-lastIndex];
                i++;
                lastIndex++;
            }
            result = firstHalf
                .Concat(secondHalf)
                .ToArray();
            Console.WriteLine(String.Join(" ", result));
        }
    }
}