namespace Tetris
{
    public interface IPiece : IBehaviour
    {
        int Rows { get; }
        int Columns { get; } 
        ConsoleColor Color { get; }
        int GetShape(int x, int y); 
        void SetPatternIndex(int rotation); 
    }
}
