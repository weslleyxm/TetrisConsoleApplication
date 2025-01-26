namespace Tetris
{
    public class Piece
    {
        public bool RotateAllowed = true;
        public List<int[,]> Location = new List<int[,]>();

        public int GetLength(int dimension, int index = 0)
        {
            return Location[CorrectIndex(index)].GetLength(dimension);
        }

        public int[,] GetLocation(int index = 0)
        {
            return Location[CorrectIndex(index)];
        }

        private int CorrectIndex(int index)
        {
            if (!RotateAllowed) return 0;
            return index;
        } 
    }
}
