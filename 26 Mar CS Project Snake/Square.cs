using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Mar_CS_Project_Snake
{
    class Square : Coord
    {
        private int a;
        private int r;
        private int g;
        private int b;
        private Direction lastMove;

        public Square(int x, int y, int a, int r, int g, int b, Direction direction = Direction.RIGHT) : base(x, y)
        {
            this.a = a;
            this.r = r;
            this.g = g;
            this.b = b;
            this.lastMove = direction;
        }
        
        
      
        public int A { get => a; set => a = value; }
        public int R { get => r; set => r = value; }
        public int G { get => g; set => g = value; }
        public int B { get => b; set => b = value; }
        public Direction LastMove { get => lastMove; set => lastMove = value; }

        public override bool Equals(object obj)
        {
            return obj is Square square &&
                   this.X == square.X &&
                   this.Y == square.Y;
        }
    }
}
