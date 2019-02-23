using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    /// <summary>
    /// public class Coordinate create field with Decard coordinate system
    /// </summary>
    public class Coordinate
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinate(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }
    }
}
