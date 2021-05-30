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
        public int lengthMap = 40;
        private int[,] squares;
        private List<Square> snake;
        PictureBox pictureBox;
        Label Label;

        public enum Direction
        {
            Right,
            Down,
            Left,
            Up
        }

        private Square food = null;
        private Random Random = new Random();
        private int points = 0;

        public Direction actualDirection = Direction.Right;

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

        public Game(PictureBox pictureBox, Label label)
        {
            this.pictureBox = pictureBox;
            this.Label = label;
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
            SnakeEating();
        }

        private void SnakeEating()
        {
            if(snake[0].x == food.x && snake[0].y == food.y)
            {
                food = null;
                this.points++;
            }
        }

        private void GetFood()
        {
            int x = Random.Next(0,lengthMap -1);
            int y = Random.Next(0, lengthMap - 1);

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
        public int x, y;

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
