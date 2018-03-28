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
        static Graphics graphics;
        static Snake mySnake;
        static List<Square> fruits;
        static Random rando;
        static Queue<Direction> movedDirection;
        public static int squareSize = 100;
        static int fruitsCount = 0;
        static int x;
        static int y;
        static int delayTime = 500;
        const int SPEEDINC = 25;
        User_Choice userChoice;

        static int level = 0;

        public Form1()
        {
            userChoice = new User_Choice();
            userChoice.Show();
            this.Visible = false;
            InitializeComponent();
            //this.Enabled = false;
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
            if (userChoice.Visible)
            {
                this.Hide();
                return;
            }
            else if (!this.Visible)
            {
                ResetGame();
                this.Show();
            }

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
                    //return;
                }
                movedDirection.Clear();
            }
            else if (mySnake.Move(mySnake.Body[0].LastMove))
            {
                resetGame = true;
            }
            if (mySnake.AnchorPoint.X < 0 || mySnake.AnchorPoint.Y < 0 ||
                mySnake.AnchorPoint.X >= this.Width - squareSize * 2 || mySnake.AnchorPoint.Y >= this.Height - squareSize * 2)
            {
                
                resetGame = true;

            }
            if (resetGame)
            {
                if (MessageBox.Show($"You ate {mySnake.Body.Count-1} fruits.\nTry again?", "Message!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }

                this.Hide();
                userChoice.Show();
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
            mySnake.EatFruit(fruits);
            SolidBrush brush = new SolidBrush(Color.Black);

            Pen pen = new Pen(Color.Black);
            graphics.FillRectangle(brush, new Rectangle(0, 0, x * squareSize, y * squareSize));
            int count = 1;
            foreach (var item in fruits)
            {
                brush.Color = Color.FromArgb(item.A, item.R, item.G, item.B);
                graphics.FillRectangle(brush, new Rectangle(item.X, item.Y, squareSize, squareSize));
                graphics.DrawRectangle(pen, new Rectangle(item.X, item.Y, squareSize, squareSize));
                graphics.DrawString(count++.ToString(), this.Font, new SolidBrush(Color.Black), item.X + squareSize / 2, item.Y + squareSize / 2);
            }
            
            mySnake.Draw(graphics);
            graphics.DrawString($"{x}x{y},Fruits: {mySnake.Body.Count - 1}, Level: {level}", this.Font, new SolidBrush(Color.Black), x, y * squareSize);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            rando = new Random();
            
            
            //this.Width = x * squareSize;
            //this.Height = y * squareSize;
            ResetGame();
            //this.Width = x * squareSize;
            //this.Height = y * squareSize;
        }

        public void ResetGame()
        {
            level = 0;
            delayTime = 500;
            x = this.Width / squareSize - 1;
            y = this.Height / squareSize - 1;
            movedDirection = new Queue<Direction>();

            mySnake = new Snake(
                new Coord(0, 0),
                1, squareSize,0, 255, 0, 0);

            fruitsCount = 0;
            ResetFruits();
        }

        public void ResetFruits()
        {
            level++;
            fruitsCount++;
            Coord randomCoord;
            fruits = new List<Square>();
            for (int i = 0; i < fruitsCount; i++)
            {
                do
                {
                    randomCoord = new Coord(rando.Next(x) * squareSize, rando.Next(y) * squareSize);
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
