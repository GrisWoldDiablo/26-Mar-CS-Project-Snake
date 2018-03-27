using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Mar_CS_Project_Snake
{
    class Coord : IEquatable<Coord>
    {
        private int x;
        private int y;

        
        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override bool Equals(object obj)
        {
            var coord = obj as Coord;
            return coord != null &&
                   x == coord.x &&
                   y == coord.y;
        }

        public bool Equals(Coord other)
        {
            return other != null &&
                   this.x == other.x &&
                   this.y == other.y;
        }

    }
}
