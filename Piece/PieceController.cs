namespace Tetris
{
    public class PieceController : IBehaviour
    {
        private int currentHorizontalPosition = 0;
        private int currentVerticalPosition = 0;
        private int currentPattenIndex = 0;
        private IPiece? currentPiece;
        private readonly List<Cell> _lastCellsUpdated;
        private readonly Board _board;
         
        public PieceController(Board board)
        {
            _lastCellsUpdated = new List<Cell>();
            _board = board;

            Init();
        }

        public void Init()
        {
            currentHorizontalPosition = _board.Rows / 2 - 1;
            currentVerticalPosition = 0;

            Task.Run(() =>
            {
                while (true)
                {
                    var keyInfo = Console.ReadKey();
                      
                    if (currentPiece == null) return;

                    if (keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.Spacebar)
                    {
                        if (keyInfo.Key == ConsoleKey.LeftArrow)
                            currentHorizontalPosition--;
                        else if (keyInfo.Key == ConsoleKey.RightArrow)
                            currentHorizontalPosition++;
                        else if (keyInfo.Key == ConsoleKey.Spacebar)
                        {
                            currentPattenIndex++;

                            if (currentPattenIndex > 3)
                                currentPattenIndex = 0;

                            currentPiece.SetPatternIndex(currentPattenIndex); 
                        }

                        if (currentHorizontalPosition <= 0)
                            currentHorizontalPosition = 0;
                        else if ((currentHorizontalPosition + currentPiece.Rows) >= _board.Rows)
                            currentHorizontalPosition = _board.Rows - currentPiece.Rows;
                         
                        Reset();
                        Update();
                    }
                }
            });

            Task.Run(() =>
            {
                while (true)
                {
                    Update();
                    Thread.Sleep(300);
                    Reset();
                }
            });
        }

        public void Update()
        { 
            if (currentPiece == null)
            {
                _lastCellsUpdated.Clear();
                currentHorizontalPosition = _board.Rows / 2 - 1;
                currentVerticalPosition = 0;
                currentPattenIndex = new Random().Next(0, 4);
                currentPiece = PeekRandomPiece();
                return;
            }

            bool fits = true;

            if (CanMoveVertically(currentPiece))
            {
                currentPiece.SetPatternIndex(currentPattenIndex);
                DrawPiece(currentHorizontalPosition, currentVerticalPosition, out fits);
            }
            else
            {
                DrawPiece(currentHorizontalPosition, currentVerticalPosition - 1, out _);

                _lastCellsUpdated.Clear();
                currentPiece = null;
            }

            if (fits)
            {
                currentVerticalPosition++;
            }
            else
            {
                _lastCellsUpdated.Clear();
                currentPiece = null;
            }
        }

        public void Reset()
        {
            Clear();
        }

        public bool CanMoveVertically(IPiece piece)
        {
            for (int x = 0; x < piece.Rows; x++)
            {
                for (int y = 0; y < piece.Columns; y++)
                {
                    if (piece.GetShape(x, y) == 1)
                    {
                        if (_board.GetCell(currentHorizontalPosition + x, currentVerticalPosition + y).isOccupied)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void DrawPiece(int row, int column, out bool state)
        {
            state = true;
            for (int x = 0; x < currentPiece?.Rows; x++)
            {
                for (int y = 0; y < currentPiece.Columns; y++)
                {
                    if (currentPiece.GetShape(x, y) == 1)
                    {
                        Cell cell = _board.GetCell(row + x, column + y);

                        cell.isOccupied = true;
                        cell.foregroundColor = currentPiece.Color;

                        if ((column + y) <= _board.Columns - 2)
                            _lastCellsUpdated.Add(_board.GetCell(row + x, column + y));
                        else
                        {
                            state = false;
                        }
                    }
                }
            }
        }

        private IPiece PeekRandomPiece()
        {
            var random = new Random();
            Pattern pattern = Patterns.AllPieces[random.Next(0, Patterns.AllPieces.Count)];

            var piece = new PieceBehaviour(pattern, PeekRandomColor());
            return piece;
        }

        private ConsoleColor PeekRandomColor()
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

        private void Clear()
        {
            foreach (var item in _lastCellsUpdated)
            {
                item.isOccupied = false;
            }

            _lastCellsUpdated.Clear();
        }
    }
}
