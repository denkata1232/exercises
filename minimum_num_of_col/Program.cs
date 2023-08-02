namespace minimum_num_of_col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = MatrixRead();
            matrix = NewRowMatrix(matrix);
            PrintMatrix(matrix);
        }
        static int[,] MatrixRead()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
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
        static int[,] NewRowMatrix(int[,] matrix)
        {
            int resultRows = matrix.GetLength(0) + 1;
            int resultCols = matrix.GetLength(1);
            int[,] result = new int[resultRows, resultCols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }
            for(int i = 0;i < resultCols; i++)
            {
                int min = int.MaxValue;
                for (int j = 0;j < resultRows-1; j++)
                {
                    if (result[j, i] < min) { min = result[j, i]; }
                }
                result[resultRows-1, i] = min;
            }
            return result;
        }
    }
}