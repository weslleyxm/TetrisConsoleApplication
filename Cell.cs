namespace Tetris
{
    public class Cell
    {
        public int x;
        public int y;
        public ConsoleColor foregroundColor;
        public bool isOccupied;
        public Cell(int x, int y, ConsoleColor foregroundColor)
        {
            this.x = x;
            this.y = y;
        }
    }
}
