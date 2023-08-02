namespace tic_tac_toe
{
    internal class Program
    {
        public static int playerTurn = 1;
        static void Main(string[] args)
        {
            char[,] board =
            {
                { '-', '-', '-'},
                { '-', '-', '-'},
                { '-', '-', '-'},
            };
            PrintMatrix(board);
            bool win = false;
            bool draw = false;
            while (true)
            {
                board = PlaceTurn(board);
                Console.Clear();
                PrintMatrix(board);
                win = WinVerHorDiag(board);
                if (win) { goto Finish; }
                else playerTurn++;
                draw = DrawPossition(board);
                if(draw) { goto Finish; }
            }
            Finish:
            if (win)
            {
                if(playerTurn % 2 == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("X Wins");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("O Wins");
                }
            }
            else { Console.WriteLine(); Console.WriteLine("Draw"); }
        }
        static void PrintMatrix(char[,] matrix)
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
        static char[,] PlaceTurn(char[,] board)
        {
            string play = Console.ReadLine();
            char symbol = play[0];
            if((playerTurn % 2 == 1 && symbol == 'O') || (playerTurn % 2 == 0 && symbol == 'X'))
            {
                Console.WriteLine("Wrong Player Turn");
                Console.ReadKey();
                goto END;
            }
            if(symbol != 'X' && symbol != 'O')
            {
                Console.WriteLine("invalid symbol");
                Console.ReadKey();
                goto END;
            }
            int possitionX = play[2] - '1';
            int possitionY = play[4] - '1';
            if (board[possitionX, possitionY] != '-')
            {
                Console.WriteLine("invalid possition");
                Console.ReadKey();
                goto END;
            }
            board[possitionX, possitionY] = symbol;
            END:
            return board;
        }
        static bool WinVerHorDiag(char[,] board)
        {
            bool win = false;
            win = Vertical(board);
            if(win) { goto ending; }
            win = Horizontal(board);
            if(win) { goto ending; }
            win = Diagonal(board);
            if(win) { goto ending; }
            ending:
            return win;
        }
        static bool Vertical(char[,] board)
        {
            bool win = false;
            int j = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[j, i] == 'X' && board[j + 1, i] == 'X' && board[j + 2, i] == 'X') { win = true; break; }
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[j, i] == 'O' && board[j + 1, i] == 'O' && board[j + 2, i] == 'O') { win = true; break; }
            }
            return win;
        }
        static bool Horizontal(char[,] board)
        {
            bool win = false;
            int j = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, j] == 'X' && board[i, j + 1] == 'X' && board[i, j + 2] == 'X') { win = true; break; }
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, j] == 'O' && board[i, j + 1] == 'O' && board[i, j + 2] == 'O') { win = true; break; }
            }
            return win;
        }
        static bool Diagonal(char[,] board)
        {
            bool win = false;
            if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X') { win = true; }
            if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O') { win = true; }
            if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X') { win = true; }
            if (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O') { win = true; }
            return win;
        }
        static bool DrawPossition(char[,] board)
        {
            bool draw = true;
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == '-') { draw = false; break; }
                }
                if (!draw) break;
            }
            return draw;
        }
    }
}