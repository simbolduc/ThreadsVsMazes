using System;
using System.Collections;

namespace ThreadsVsMazes
{
    public class Position
    {

        public readonly int X;
        public readonly int Y;
        public int[] Neighbours {get;}
        
        public Position(int row, int col, int last = -1)
        {
            Neighbours = new[] {0, 0, 0, 0};
            X = row;
            Y = col;
            AddNeighbour(last);
        }

        private void AddNeighbour(int last)
        {
            if (last == 0)
                Neighbours[2] = 1;
            if (last == 1)
                Neighbours[3] = 1;
            if (last == 2)
                Neighbours[0] = 1;
            if (last == 3)
                Neighbours[1] = 1;
        }

        // For debugging
        public override string ToString()
        {
            var res = X + ", " + Y + " --- Neighbours : ";
            for (var i = 0; i < 4; i++)
                res += Neighbours[i];
            return res;
        }

    }
}