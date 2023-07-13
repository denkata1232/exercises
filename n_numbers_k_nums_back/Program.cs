namespace n_numbers_k_nums_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int down = 1;
                if (i < k)
                {
                    for(int j = 0; j < i; j++)
                    {
                        arr[i] += arr[i - down];
                        down++;
                    }
                }
                else
                {
                    for (int j = 0; j < k; j++)
                    {
                        arr[i] += arr[i - down];
                        down++;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}