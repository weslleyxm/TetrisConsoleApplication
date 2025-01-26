namespace Tetris
{
    internal class PieceBehaviour : IPiece
    {
        private readonly ConsoleColor _color = ConsoleColor.White;
        private readonly Pattern _pattern;
        private int pattenIndex; 

        public ConsoleColor Color { get { return _color; } }
         
        public int Rows => _pattern.GetLength(0, pattenIndex);

        public int Columns => _pattern.GetLength(1, pattenIndex); 

        public PieceBehaviour(Pattern pattern, ConsoleColor color) 
        {
            _color = color;
            _pattern = pattern; 
        }
         
        public void Init()
        {

        } 
        public void Update()
        {

        } 
        public void Reset()
        {

        }

        public int GetShape(int x, int y)
        {
            return _pattern.GetShape(pattenIndex)[x, y]; 
        }

      
        public void SetPatternIndex(int index)
        {
            pattenIndex = index;
        }  
    }
}
