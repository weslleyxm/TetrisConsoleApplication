
using System.Data.Common;
using System.Runtime.InteropServices;

namespace Tetris
{
    public class Board : IBehaviour
    {
        public readonly int Rows = 10;
        public readonly int Columns = 20;

        private Cell[,] board = new Cell[0, 0];

        private string bottonMap = string.Empty;
        private string topMap = string.Empty;

        public Board()
        {
            board = new Cell[Rows, Columns];

            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    board[x, y] = new Cell(x, y, ConsoleColor.White);
                }
            }

            Init();
        }

        public void Init()
        {
            bottonMap = $"└{new string('─', Rows * 2)}┘";
            topMap = $"┌{new string('─', Rows * 2)}┐"; 
        }

        public void Update()
        {
            Console.WriteLine(topMap);
            for (int y = 0; y < Columns; y++)
            {
                Console.Write("│");
                for (int x = 0; x < Rows; x++)
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

        public void Reset()
        {

        }

        public Cell GetCell(int x, int y)
        {
            return board[x, y];
        }
    }
}