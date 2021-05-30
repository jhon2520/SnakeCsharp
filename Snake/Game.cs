using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class Game
    {
        public int scale = 10;
        public int lengthMap = 30;
        private int[,] squares;
        private List<Square> snake;
        PictureBox pictureBox;
        Label Label;
        public enum Direction{Right,Down,Left,Up}
        private Square food = null;
        private Random random = new Random();
        private int points = 0;

        //get a random initial position

        public Direction actualDirection; // Direction.Right;

        public void RandomDirection()
        {
            Direction[] validDirections = new[] {Direction.Up,Direction.Down,Direction.Left,Direction.Right};
            actualDirection = validDirections[random.Next(validDirections.Length)];
        }

        private int InitialPositionX
        {
            get
            {
                return lengthMap / 2;
            }
        }
        private int InitialPositionY
        {
            get
            {
                return lengthMap / 2;
            }
        }

        public bool isLost
        {
            get
            {
                foreach (Square square in snake)
                {
                    if (snake.Where(d=>d.y == square.y && d.x ==square.x && square != d).Count() > 0) { return true; }
                }
                return false;
            }
        }


        public Game(PictureBox pictureBox, Label label)
        {
            this.pictureBox = pictureBox;
            this.Label = label;
            RandomDirection();
            Reset();
        }

        public void Reset()
        {
            snake = new List<Square>();
            Square square = new Square(InitialPositionX,InitialPositionY);
            snake.Add(square);

            squares = new int[lengthMap, lengthMap];

            for (int j = 0; j < lengthMap; j++)
            {
                for (int i = 0; i < lengthMap; i++)
                {
                    squares[i, j] = 0;
                }
            }
            this.points = 0;
        }

        public void Show()
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            for (int j = 0; j < lengthMap; j++)
            {
                for (int i = 0; i < lengthMap; i++)
                {
                    if(snake.Where(d=>d.x == i && d.y ==j).Count()>0)
                    {
                        PaintPixel(bitmap, i, j, Color.Black);
                    }
                    else
                    {
                        PaintPixel(bitmap, i, j, Color.White);
                    }
                }
            }
            //mostrar comidad
            if (food != null) { PaintPixel(bitmap, food.x, food.y, Color.Green); }

            pictureBox.Image = bitmap;


            Label.Text = points.ToString();
        }

        public void Next()
        {

            if(food == null)
            {
                GetFood();
            }
            GetHistorySnake();

            switch (actualDirection)
            {
                case Direction.Right:
                    {
                       if(snake[0].x == (lengthMap -1)){snake[0].x = 0;}
                        else { snake[0].x++; }
                        break;
                    }
                case Direction.Left:
                    {
                        if (snake[0].x == 0) { snake[0].x = lengthMap - 1; }
                        else { snake[0].x--; }
                        break;
                    }
                case Direction.Up:
                    {
                        if (snake[0].y == 0) { snake[0].y = lengthMap - 1; }
                        else { snake[0].y--; }
                        break;
                    }
                case Direction.Down:
                    {
                        if (snake[0].y == (lengthMap - 1)) { snake[0].y = 0; }
                        else { snake[0].y++; }
                        break;
                    }
            }

            GetNextMoveSnake();

            SnakeEating();
        }

        private void GetNextMoveSnake()
        {
            if (snake.Count > 1)
            {
                for (int i = 1; i < snake.Count; i++)
                {
                    snake[i].x = snake[i - 1].x_old;
                    snake[i].y = snake[i - 1].y_old;

                }
            }
        }

        private void GetHistorySnake()
        {
            foreach (Square square in snake)
            {
                square.x_old = square.x;
                square.y_old = square.y;
            }
        }

        private void SnakeEating()
        {
            if(snake[0].x == food.x && snake[0].y == food.y)
            {
                food = null;
                this.points++;

                //asginando nuevo elemento a la serpiente
                Square lastSquare = snake[snake.Count - 1];
                Square objetSquare = new Square(lastSquare.x_old, lastSquare.y_old);
                snake.Add(objetSquare);
            }
        }

        private void GetFood()
        {
            int x = random.Next(0,lengthMap -1);
            int y = random.Next(0, lengthMap - 1);

            food = new Square(x, y);

        }

        private void PaintPixel(Bitmap bitmap,int x , int y, Color color)
        {
            for (int j = 0; j < scale; j++)
            {
                for (int i = 0; i < scale; i++)
                {
                    bitmap.SetPixel(i + (x * scale), j + (y * scale), color);
                }
            }
        }

    }

    public class Square
    {
        public int x, y, x_old,y_old;

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.x_old = x;
            this.y_old = y;
        }
    }
}
