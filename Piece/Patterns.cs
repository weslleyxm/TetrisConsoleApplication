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

    public static class Patterns
    {
        public static List<Pattern> AllPieces = new List<Pattern>()
        { 
            //L 
            new Pattern
            {
                Shape = new List<int[,]>
                {
                    new int[2, 3]
                    {
                        { 1, 0 ,0},
                        { 1, 1, 1},
                    },
                    new int[3, 2]
                    {
                         { 0, 1},
                         { 0, 1},
                         { 1, 1}
                    },
                    new int[2, 3]
                    {
                        { 1, 1 ,1},
                        { 0, 0, 1},
                    },
                    new int[3, 2]
                    {
                        { 1, 1 },
                        { 1, 0 },
                        { 1, 0 }
                    }
                }
            },
            //L
            new Pattern
            {
                Shape = new List<int[,]>
                {
                    new int[2, 3]
                    {
                        { 0, 0 ,1},
                        { 1, 1, 1},
                    },
                    new int[3, 2]
                    {
                         { 1, 1},
                         { 0, 1},
                         { 0, 1}
                    },
                    new int[2, 3]
                    {
                        { 1, 1 ,1},
                        { 1, 0, 0},
                    },
                    new int[3, 2]
                    {
                        { 1, 0 },
                        { 1, 0 },
                        { 1, 1 }
                    }
                }
            },
            //Z
            new Pattern
            {
                Shape = new List<int[,]>
                {
                    new int[2, 3]
                    {
                        { 0, 1, 1 },
                        { 1, 1, 0 },
                    },
                    new int[3, 2]
                    {
                        { 1, 0 },
                        { 1, 1 },
                        { 0, 1 }
                    },
                    new int[2, 3]
                    {
                        { 0, 1, 1 },
                        { 1, 1, 0 }
                    },
                    new int[3, 2]
                    {
                        { 1, 0 },
                        { 1, 1 },
                        { 0, 1 }
                    },
                }
            },
            //Z
            new Pattern
            {
                Shape = new List<int[,]>
                {
                    new int[2, 3]
                    {
                        { 1, 1, 0 },
                        { 0, 1, 1 },
                    },
                    new int[3, 2]
                    {
                        { 0, 1 },
                        { 1, 1 },
                        { 1, 0 }
                    },
                    new int[2, 3]
                    {
                        { 1, 1, 0 },
                        { 0, 1, 1 }
                    },
                    new int[3, 2]
                    {
                        { 0, 1 },
                        { 1, 1 },
                        { 1, 0 }
                    }
                }
            },
            //T
            new Pattern
            {
                Shape = new List<int[,]>
                {
                    new int[2, 3]
                    {
                        { 0, 1, 0 },
                        { 1, 1, 1 }
                    },
                   new int[3, 2]
                    {
                        { 0, 1 },
                        { 1, 1 },
                        { 0, 1 }
                    },
                    new int[2, 3]
                    {
                        { 1, 1, 1 },
                        { 0, 1, 0 }
                    },
                     new int[3, 2]
                    {
                        { 1, 0 },
                        { 1, 1 },
                        { 1, 0 }
                    },
                }
            },
            //Square
            new Pattern
            {
                RotateAllowed = false,
                Shape = new List<int[,]>()
                {
                    new int[2, 2]
                    {
                        { 1, 1 },
                        { 1, 1 }
                    }
                }
            },
            //Straight
            new Pattern
            {
                 Shape = new List<int[,]>()
                 {
                      new int[1, 4]
                      { 
                           { 1, 1, 1, 1 }
                      },
                      new int[4, 1]
                      {
                           { 1 },
                           { 1 },
                           { 1 },
                           { 1 },
                      },
                      new int[1, 4]
                      {
                           { 1, 1, 1, 1 }
                      },
                      new int[4, 1]
                      {
                          { 1 },
                          { 1 },
                          { 1 },
                          { 1 }
                      }
                 }
            }
        };
    }
}
