using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Mar_CS_Project_Snake
{
    enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }
    class Snake
    {
        private Coord anchorPoint;
        private List<Square> body;
        private int size;

        public Snake(Coord anchorPoint, float qtyOfSquare, int size, int a, int r, int g, int b)
        {
            this.anchorPoint = anchorPoint;
            this.size = size;
            body = new List<Square>();
            int tempColor = (int)(255 / qtyOfSquare);
            for (int i = 0; i < qtyOfSquare; i++)
            {
                r = 255 - tempColor * i;
                body.Add(new Square(anchorPoint.X - (this.size * i), anchorPoint.Y, a, r, g, b));
            }
        }

        public void DrawSnake(Graphics graphics)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.Red);
            foreach (var item in body)
            {
                brush.Color = Color.FromArgb(item.A, item.R, item.G, item.B);
                graphics.FillRectangle(brush, new Rectangle(item.X + this.size/4, item.Y + this.size / 4, this.size / 2, this.size / 2));
                graphics.DrawRectangle(pen, new Rectangle(item.X + this.size / 4, item.Y + this.size / 4, this.size / 2, this.size / 2));
            }
            brush.Color = Color.FromArgb(255, 0, 0);
            graphics.FillEllipse(brush, body[0].X, body[0].Y, this.size, this.size);
        }
        
        public bool Move(Direction direction)
        {
            
            
            switch (direction)
            {
                case Direction.UP:
                    anchorPoint.Y -= this.size;
                    for (int i = 1, j = body.Count - 1; i < body.Count; i++, j--)
                    {
                        MoveBodyPiece(j);
                    }
                    body[0].LastMove = Direction.UP;
                    body[0].Y -= this.size;
                    break;
                case Direction.DOWN:
                    anchorPoint.Y += this.size;

                    for (int i = 1, j = body.Count - 1; i < body.Count; i++, j--)
                    {
                        MoveBodyPiece(j);
                    }
                    body[0].LastMove = Direction.DOWN;
                    body[0].Y += this.size;
                    break;
                case Direction.LEFT:
                    anchorPoint.X -= this.size;
                    for (int i = 1, j = body.Count - 1; i < body.Count; i++,j--)
                    {
                        MoveBodyPiece(j);
                    }
                    body[0].LastMove = Direction.LEFT;
                    body[0].X -= this.size;
                    break;
                case Direction.RIGHT:
                    anchorPoint.X += this.size;
                    for (int i = 1, j = body.Count - 1; i < body.Count; i++, j--)
                    {
                        MoveBodyPiece(j);
                    }
                    body[0].LastMove = Direction.RIGHT;
                    body[0].X += this.size;
                    break;
                default:
                    break;
            }

            // Check colision with rest of body.
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].Equals(body[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private void MoveBodyPiece(int i)
        {
            switch (body[i - 1].LastMove)
            {
                case Direction.UP:
                    body[i].LastMove = Direction.UP;
                    body[i].Y -= this.size;
                    break;
                case Direction.DOWN:
                    body[i].LastMove = Direction.DOWN;
                    body[i].Y += this.size;
                    break;
                case Direction.LEFT:
                    body[i].LastMove = Direction.LEFT;
                    body[i].X -= this.size;
                    break;
                case Direction.RIGHT:
                    body[i].LastMove = Direction.RIGHT;
                    body[i].X += this.size;
                    break;
                default:
                    break;
            }
        }

        public void AddBody(Color color)
        {
            
            switch (body[body.Count - 1].LastMove)
            {
                case Direction.UP:
                    body.Add(new Square(
                        body[body.Count - 1].X,
                        body[body.Count - 1].Y + this.size,
                        color.A,
                        color.R,
                        color.G,
                        color.B,
                        Direction.UP));
                    break;
                case Direction.DOWN:
                    body.Add(new Square(
                        body[body.Count - 1].X,
                        body[body.Count - 1].Y - this.size,
                        color.A,
                        color.R,
                        color.G,
                        color.B,
                        Direction.DOWN));
                    break;
                case Direction.LEFT:
                    body.Add(new Square(
                        body[body.Count - 1].X + this.size,
                        body[body.Count - 1].Y,
                        color.A,
                        color.R,
                        color.G,
                        color.B,
                        Direction.LEFT));
                    break;
                case Direction.RIGHT:
                    body.Add(new Square(
                        body[body.Count - 1].X - this.size,
                        body[body.Count - 1].Y,
                        color.A,
                        color.R,
                        color.G,
                        color.B,
                        Direction.RIGHT));
                    break;
                default:
                    break;
            }
            //int tempColor = (255 / (body.Count));
            //for (int i = 0; i < body.Count; i++)
            //{
            //    body[i].R = 255 - tempColor * i;
            //}
        }

        public void EatFruit(List<Square> fruits)
        {
            foreach (var item in fruits)
            {
                if (Body[0].Equals(item))
                {
                    AddBody(Color.FromArgb(item.A, item.R, item.G, item.B));
                    fruits.Remove(item);
                    break;
                }
            }
        }
        public Coord AnchorPoint { get => anchorPoint; set => anchorPoint = value; }
        public List<Square> Body { get => body; set => body = value; }
        public int Size { get => size; set => size = value; }
    }
}
