namespace Tetris
{
    public class Pattern
    {
        public bool RotateAllowed = true;
        public List<int[,]> Shape = new List<int[,]>(); 

        public int GetLength(int dimension, int index = 0)
        {
            return Shape[CorrectIndex(index)].GetLength(dimension);
        }

        public int[,] GetShape(int index = 0)
        {
            return Shape[CorrectIndex(index)];
        }

        private int CorrectIndex(int index)
        {
            if (!RotateAllowed) return 0;
            return index;
        } 
    }
}
