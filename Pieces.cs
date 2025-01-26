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
            //L 
            new Piece
            {
                Location = new List<int[,]> 
                { 
                    new int[3, 3]
                    {  
                        { 1, 0 ,0},
                        { 1, 1, 1},
                        { 0, 0 ,0},
                    }, 
                    new int[3, 3]
                    {
                         { 0, 1, 0},
                         { 0, 1, 0},
                         { 1, 1, 0}
                    }, 
                    new int[3, 3]
                    { 
                        { 1, 1 ,1},
                        { 0, 0, 1},
                        { 0, 0, 0}
                    }, 
                    new int[3, 3]
                    {
                        { 1, 1, 0 },
                        { 1, 0, 0 },
                        { 1, 0, 0 }
                    } 
                }
            },
            //L
            new Piece
            {
                Location = new List<int[,]>
                { 
                    new int[3, 3]
                    {
                        { 0, 0 ,1},
                        { 1, 1, 1},
                        { 0, 0 ,0},
                    },
                    new int[3, 3]
                    {
                         { 1, 1, 0},
                         { 0, 1, 0},
                         { 0, 1, 0}
                    },
                    new int[3, 3]
                    {
                        { 1, 1 ,1},
                        { 1, 0, 0},
                        { 0, 0, 0}
                    },
                    new int[3, 3]
                    {
                        { 1, 0, 0 },
                        { 1, 0, 0 },
                        { 1, 1, 0 }
                    }
                }
            },
            //Z
            new Piece
            {
                Location = new List<int[,]>
                { 
                    new int[3, 3]
                    {
                        { 0, 1, 1 },
                        { 1, 1, 0 },
                        { 0, 0, 0 }
                    }, 
                    new int[3, 3]
                    {
                        { 1, 0, 0 },
                        { 1, 1, 0 },
                        { 0, 1, 0 }
                    }, 
                    new int[3, 3]
                    {
                        { 0, 0, 0 },
                        { 0, 1, 1 },
                        { 1, 1, 0 }
                    }, 
                    new int[3, 3]
                    {
                        { 1, 0, 0 },
                        { 1, 1, 0 },
                        { 0, 1, 0 }
                    },
                }
            },
            //Z
            new Piece
            {
                Location = new List<int[,]>
                { 
                    new int[3, 3]
                    {
                        { 1, 1, 0 },
                        { 0, 1, 1 },
                        { 0, 0, 0 }
                    }, 
                    new int[3, 3]
                    {
                        { 0, 1, 0 },
                        { 1, 1, 0 },
                        { 1, 0, 0 }
                    }, 
                    new int[3, 3]
                    {
                        { 0, 0, 0 },
                        { 1, 1, 0 },
                        { 0, 1, 1 }
                    }, 
                    new int[3, 3]
                    {
                        { 0, 1, 0 },
                        { 1, 1, 0 },
                        { 1, 0, 0 }
                    }
                }
            },
            //T
            new Piece
            {
                Location = new List<int[,]>
                {
                    new int[3, 3]
                    {
                        { 0, 1, 0 },
                        { 1, 1, 1 },
                        { 0, 0, 0 }
                    },
                   new int[3, 3]
                    {
                        { 0, 1, 0 },
                        { 1, 1, 0 },
                        { 0, 1, 0 }
                    },
                    new int[3, 3]
                    {
                        { 0, 0, 0 },
                        { 1, 1, 1 },
                        { 0, 1, 0 }
                    },
                     new int[3, 3]
                    {
                        { 0, 1, 0 },
                        { 0, 1, 1 },
                        { 0, 1, 0 }
                    },
                }
            },
            //Square
            new Piece
            {
                RotateAllowed = false,
                Location = new List<int[,]>()
                {
                    new int[3, 3]
                    {
                        { 1, 1, 0 },
                        { 1, 1, 0 },
                        { 0, 0, 0 } 
                    }
                }
            },
            //Straight
            new Piece
            {
                 Location = new List<int[,]>()
                 {
                      new int[4, 4]
                      {
                           { 0, 0, 0, 0 },
                           { 1, 1, 1, 1 },
                           { 0, 0, 0, 0 },
                           { 0, 0, 0, 0 },
                      },
                      new int[4, 4]
                      {
                           {  0, 1, 0, 0 },
                           {  0, 1, 0, 0 },
                           {  0, 1, 0, 0 },
                           {  0, 1, 0, 0 },
                      },
                      new int[4, 4]
                      {
                           { 0, 0, 0, 0 },
                           { 1, 1, 1, 1 },
                           { 0, 0, 0, 0 },
                           { 0, 0, 0, 0 },
                      },
                      new int[4, 4]
                      {
                           {  0, 1, 0, 0 },
                           {  0, 1, 0, 0 },
                           {  0, 1, 0, 0 },
                           {  0, 1, 0, 0 },
                      } 
                 }
            } 
        };
    }
}
