namespace Tetris
{
    //Straight - Tetromino.
    //Square - Tetromino.
    //L - Tetromino.
    //Z - Tetromino.
    //T - Tetromino.

    //██
    //██
    //████

    //████
    //████

    //██
    //████
    //  ██

    //████████

    //██████
    //  ██

    public static class Pieces
    {
        public static List<Piece> AllPieces = new List<Piece>()
        {
            // lPiece
            new Piece
            {
                Location = new int[3, 2]
                { 
                    { 0, 1 },
                    { 0, 1 },
                    { 1, 1 }
                }
            },
            // zPiece
            new Piece
            {
                Location = new int[3, 2]
                {
                    { 1, 0 },
                    { 1, 1 },
                    { 0, 1 }
                }
            },
            // tPiece
            new Piece
            {
                Location = new int[2, 3]
                {
                    { 1, 1, 1 },
                    { 0, 1, 0 }
                }
            },
            // squarePiece
            new Piece
            {
                Location = new int[2, 2]
                {
                    { 1, 1 },
                    { 1, 1 }
                }
            },
            // straightPiece
            new Piece
            {
                Location = new int[1, 4]
                {
                    { 1, 1, 1, 1 }
                }
            }
        };
    }
}
