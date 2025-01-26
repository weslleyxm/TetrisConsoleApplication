using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Piece
    {
        public int[,] Location = new int[0, 0];

        public int GetLength(int dimension)
        {
            return Location.GetLength(dimension);
        }
    }
}
