namespace ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = MatrixRead();
            LottaryTicket(matrix);
        }
        static int[,] MatrixRead()
        {
            int[] size = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine();
                var spl = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (spl.Length != cols) throw new Exception();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(spl[j]);
                }
            }
            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void LottaryTicket(int[,] ticket)
        {
            int diagonal = 0;
            int secondaryDiagonal = 0;
            for(int i = 0;i < ticket.GetLength(0);i++)
            {
                diagonal += ticket[i, i];
                secondaryDiagonal += ticket[i, ticket.GetLength(0)-(i+1)];
            }
            int upperSum = 0;
            int lowerSum = 0;
            for(int i = 0;i < ticket.GetLength(0); i++)
            {
                for(int j = 0; j < ticket.GetLength(1); j++)
                {
                    if(i > j)
                    {
                        upperSum += ticket[j, i];
                    }
                    if(i < j)
                    {
                        lowerSum += ticket[j, i];
                    }
                }
            }
            bool winning = diagonal == secondaryDiagonal && upperSum % 2 == 0 && lowerSum % 2 != 0;
            if(winning)
            {
                double prize = lowerSum;
                for(int i = 0;i < ticket.GetLength(0); i++)
                {
                    if (ticket[i, i] % 2 == 0)
                    {
                        prize += ticket[i, i];
                    }
                }
                for(int i = 0; i < ticket.GetLength(0); i++)
                {
                    if (ticket[0, i] % 2 == 0)
                    {
                        prize += ticket[0, i];
                    }
                    if (ticket[i, 0] % 2 != 0)
                    {
                        prize += ticket[i, 0];
                    }
                }
                for (int i = 0; i < ticket.GetLength(0); i++)
                {
                    if (ticket[(ticket.GetLength(0) - 1), i] % 2 == 0)
                    {
                        prize += ticket[(ticket.GetLength(0) - 1), i];
                    }
                    if (ticket[i, (ticket.GetLength(0) - 1)] % 2 != 0)
                    {
                        prize += ticket[i, (ticket.GetLength(0) - 1)];
                    }
                }
                prize /= 4;
                Console.WriteLine("YES");
                Console.WriteLine($"{prize:f2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}