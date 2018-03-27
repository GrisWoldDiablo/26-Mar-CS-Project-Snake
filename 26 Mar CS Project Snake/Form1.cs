using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_Mar_CS_Project_Snake
{
    public partial class Form1 : Form
    {
        CancellationToken cancellationToken;
        Graphics graphics;
        Snake mySnake;
        List<Square> fruits;
        Random rando;
        Queue<Direction> movedDirection;
        const int SQUARESIZE = 100;
        int fruitsCount = 0;
        int x;
        int y;
        int delayTime = 500;
        const int SPEEDINC = 25;

        int level = 0;

        public Form1()
        {
            InitializeComponent();
            Loop();

        }

        private async void Loop()
        {
            while (true)
            {
                try
                {
                    await GameLoop();
                }
                catch (Exception)
                {
                    //throw;
                }
            }            
        }
        private async Task GameLoop()
        {
            bool resetGame = false;
            await Task.Delay(delayTime);
            if (fruits.Count == 0)
            {
                delayTime -= SPEEDINC;
                ResetFruits();
            }
            if (movedDirection.Count > 0)
            {
                if (mySnake.Move(movedDirection.Peek()))
                {
                    resetGame = true;
                    return;
                }
                movedDirection.Clear();
            }
            else if (mySnake.Move(mySnake.Body[0].LastMove))
            {
                resetGame = true;
            }
            if (mySnake.AnchorPoint.X < 0 || mySnake.AnchorPoint.Y < 0 ||
                mySnake.AnchorPoint.X >= this.Width - SQUARESIZE * 2 || mySnake.AnchorPoint.Y >= this.Height - SQUARESIZE * 2)
            {
                if (MessageBox.Show("Looser!\nTry again?", "Message!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }
                resetGame = true;

            }
            if (resetGame)
            {
                ResetGame();
            }
            Redraw();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (mySnake.Body[0].LastMove == Direction.RIGHT || mySnake.Body[0].LastMove == Direction.LEFT)
                    {
                        break;
                    }
                    movedDirection.Enqueue(Direction.LEFT);
                    break;
                case Keys.D:
                    if (mySnake.Body[0].LastMove == Direction.RIGHT || mySnake.Body[0].LastMove == Direction.LEFT)
                    {
                        break;
                    }
                    movedDirection.Enqueue(Direction.RIGHT);
                    break;
                case Keys.W:
                    if (mySnake.Body[0].LastMove == Direction.UP || mySnake.Body[0].LastMove == Direction.DOWN)
                    {
                        break;
                    }
                    movedDirection.Enqueue(Direction.UP);
                    break;
                case Keys.S:
                    if (mySnake.Body[0].LastMove == Direction.UP || mySnake.Body[0].LastMove == Direction.DOWN)
                    {
                        break;
                    }
                    movedDirection.Enqueue(Direction.DOWN);
                    break;
                case Keys.Space:
                    ResetGame();
                    break;
                default:
                    break;
            }
        }

        private void Redraw()
        {
            try
            {
                this.Refresh();
            }
            catch (Exception)
            {

                // throw;
            }
            SolidBrush brush = new SolidBrush(Color.Black);

            Pen pen = new Pen(Color.Black);
            graphics.FillRectangle(brush, new Rectangle(0, 0, x * SQUARESIZE, y * SQUARESIZE));
            int count = 1;
            foreach (var item in fruits)
            {
                brush.Color = Color.FromArgb(item.A, item.R, item.G, item.B);
                graphics.FillRectangle(brush, new Rectangle(item.X, item.Y, SQUARESIZE, SQUARESIZE));
                graphics.DrawRectangle(pen, new Rectangle(item.X, item.Y, SQUARESIZE, SQUARESIZE));
                graphics.DrawString(count++.ToString(), this.Font, new SolidBrush(Color.Black), item.X + SQUARESIZE / 2, item.Y + SQUARESIZE / 2);
            }
            mySnake.EatFruit(fruits);
            mySnake.DrawSnake(graphics);
            graphics.DrawString($"Level: {level}", this.Font, new SolidBrush(Color.Black), x * SQUARESIZE, y * SQUARESIZE);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            rando = new Random();
            
            
            //this.Width = x * SQUARESIZE;
            //this.Height = y * SQUARESIZE;
            ResetGame();
            //this.Width = x * SQUARESIZE;
            //this.Height = y * SQUARESIZE;
        }

        private void ResetGame()
        {
            level = 0;
            delayTime = 500;
            x = this.Width / SQUARESIZE - 1;
            y = this.Height / SQUARESIZE - 1;
            movedDirection = new Queue<Direction>();

            mySnake = new Snake(
                new Coord(0, 0),
                1, SQUARESIZE,0, 255, 0, 0);

            fruitsCount = 0;
            ResetFruits();
        }

        private void ResetFruits()
        {
            level++;
            fruitsCount++;
            Coord randomCoord;
            fruits = new List<Square>();
            for (int i = 0; i < fruitsCount; i++)
            {
                do
                {
                    randomCoord = new Coord(rando.Next(x) * SQUARESIZE, rando.Next(y) * SQUARESIZE);
                } while (fruits.Contains(randomCoord) || mySnake.Body.Contains(randomCoord));

                fruits.Add(new Square(
                    randomCoord.X,
                    randomCoord.Y,
                    255,             // Color Alpha
                    rando.Next(255), // Color Red
                    rando.Next(255), // Color Green
                    rando.Next(255)) // Color Blue
                    );
            }
        }
    }
}
