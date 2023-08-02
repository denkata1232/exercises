namespace max_under_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = MatrixRead();
            int[,] result = MaxUnderMatrix(matrix);
            PrintMatrix(result);
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
        static int[,] MaxUnderMatrix(int[,] matrix)
        {
            int[,] result = new int[2,2];
            int max = int.MinValue;
            int lenght = matrix.GetLength(0) - 1;

            for(int i = 0; i < lenght; i++)
            {
                for(int j = 0;j < lenght; j++)
                {
                    int sum = matrix[i, j] + matrix[i+1,j] + matrix[i+1,j+1] + matrix[i,j+1];
                    if(sum > max)
                    {
                        result[0, 0] = matrix[i, j];
                        result[0, 1] = matrix[i, j + 1];
                        result[1, 0] = matrix[i + 1, j];
                        result[1, 1] = matrix[i + 1, j + 1];
                        max = sum;
                    }
                    sum = 0;
                }
            }
            return result;
        }
    }
}