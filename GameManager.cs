using System.Runtime.InteropServices;

namespace Tetris
{
    public static class GameManager
    {
        public static void Initialize()
        {
            IBehaviour board = new Board();
            PieceController sadasd = new PieceController(board as Board ?? throw new ArgumentNullException(nameof(board)));

            while (true)
            { 
                Console.SetCursorPosition(0, 1);
                Console.CursorVisible = false;

                board.Update();

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.BufferHeight = 200;
                    Console.BufferWidth = 200;
                }
            }
        }
    }
}
