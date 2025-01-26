namespace Tetris
{
    internal static class Board
    {
        private static int rows = 10;
        private static int columns = 20;
        private static Cell[,] board = new Cell[0, 0];
        private static int currentHorizontalPosition = 0;
        private static int currentVerticalPosition = 0;
        private static Piece? currentPiece;
        private static List<Cell> lastCellsUpdated = new List<Cell>();
        private static ConsoleColor currentColor = ConsoleColor.White;

        private static string bottonMap = string.Empty;
        private static string topMap = string.Empty;

        private static int currentRotate;
        public static void Initialize()
        {
            board = new Cell[rows, columns];

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    board[x, y] = new Cell(x, y, ConsoleColor.White);
                }
            }

            currentHorizontalPosition = rows / 2 - 1;
            currentVerticalPosition = 0;
             
            bottonMap = $"└{new string('─', rows * 2)}┘";
            topMap = $"┌{new string('─', rows * 2)}┐";
        }

        public static void Update()
        {
            if (currentPiece == null)
            {
                lastCellsUpdated.Clear();
                currentVerticalPosition = 0;
                currentRotate = new Random().Next(0, 4);
                currentPiece = PeekRandomPiece();
                return;
            }

            bool fits = true;

            if (CanMoveVertically(currentPiece))
            {
                DrawPiece(currentHorizontalPosition, currentVerticalPosition, out fits);
            }
            else
            {
                DrawPiece(currentHorizontalPosition, currentVerticalPosition - 1, out _);

                lastCellsUpdated.Clear();
                currentPiece = null;
            }

            if (fits)
            {
                currentVerticalPosition++;
            }
            else
            {
                lastCellsUpdated.Clear();
                currentPiece = null;
            }
        }

        private static void DrawPiece(int row, int column, out bool state)
        {
            state = true;
            for (int x = 0; x < currentPiece?.GetLength(0); x++)
            {
                for (int y = 0; y < currentPiece.GetLength(1); y++)
                {
                    if (currentPiece.GetLocation(currentRotate)[x, y] == 1)
                    {
                        board[row + x, column + y].isOccupied = true;
                        board[row + x, column + y].foregroundColor = currentColor;

                        if ((column + y) <= columns - 2)
                            lastCellsUpdated.Add(board[row + x, column + y]);
                        else
                        {
                            state = false;
                        }
                    }
                }
            }
        }

        public static bool CanMoveVertically(Piece piece)
        {
            for (int x = 0; x < piece.GetLength(0); x++)
            {
                for (int y = 0; y < piece.GetLength(1); y++)
                {
                    if (piece.GetLocation(currentRotate)[x, y] == 1) 
                    {
                        if (board[currentHorizontalPosition + x, currentVerticalPosition + y].isOccupied)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public static void Clear()
        {
            foreach (var item in lastCellsUpdated)
            {
                item.isOccupied = false;
            }

            lastCellsUpdated.Clear();
        }

        public static void DrawBoard()
        {
            Console.WriteLine(topMap);
            for (int y = 0; y < columns; y++)
            {
                Console.Write("│");
                for (int x = 0; x < rows; x++)
                {
                    var node = board[x, y];

                    if (node.isOccupied)
                    {
                        Console.ForegroundColor = node.foregroundColor;
                        Console.Write("██");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("│");
                Console.WriteLine();
            }
            Console.WriteLine(bottonMap);
        }
          
        private static Piece PeekRandomPiece()
        {
            currentColor = PeekRandomColor();
            var random = new Random();
            return Pieces.AllPieces[random.Next(0, Pieces.AllPieces.Count)];
        }

        private static ConsoleColor PeekRandomColor()
        {
            var colors = Enum.GetValues(typeof(ConsoleColor));
            var random = new Random();
            ConsoleColor randomColor = (ConsoleColor)(colors.GetValue(random.Next(colors.Length)) ?? ConsoleColor.White);

            if (randomColor == ConsoleColor.Black)
            {
                randomColor = ConsoleColor.White;
            }

            return randomColor;
        }
    }
}