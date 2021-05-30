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
        public Direction actualDirection;
        public void RandomDirection()
        {
            //Este método le da una dirección aleatoria inicial al juego
            Direction[] validDirections = new[] {Direction.Up,Direction.Down,Direction.Left,Direction.Right};
            actualDirection = validDirections[random.Next(validDirections.Length)];
        }
        private int InitialPositionX
        {
            get
            {
                //Valor inicial de arranque de la serpiente
                // Si deseara que inicie en la mirad return lengthMap / 2;
                return random.Next(0,lengthMap -1);
            }
        }
        private int InitialPositionY
        {
            get{return random.Next(0, lengthMap-1);}
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
        public int SnakeCount
        {
            get
            {
                return snake.Count;
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
            //Crea un punto inicial, le agrega una posición aleatoria x y y y lo agrega a la lista de cuadrados(snake)
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
            RebootPoints();
        }

        private void RebootPoints()
        {
            this.points = 0;
        }

        public void Show()
        {
            //El siguiente código hace lo siguiente
            /*
             Va a ir recorriendo todo el mapa que estaría ubicado dentro del pictureBox, si una posición x y y es la misma que la posición
            aleatoria en la que está la variable snake (la cual en el método reset inicia aleatoriamiente ya que se le agregó el square aleatorio)
            si el valor recorrido por los ciclos for tiene las mismas coordenadas que el punto aleatorio inicial, este punto se pintara de negro
            pero si no, se pintará de blanco
             */

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
            //mostrar comida:
            /*
             La comida sigue siendo una clase de tipo square con coordenadas x y y el cual también se llena de manera aleatoria
            al inicial ya que se inicia también con los parámetros random 
             
             */
            if (food != null) { PaintPixel(bitmap, food.x, food.y, Color.Green); }


            //La imagen del picture box va a ser el mapa de bit que se creó
            pictureBox.Image = bitmap;

            InitPoints();
        }

        private void InitPoints() => Label.Text = points.ToString();


        public void Next()
        {
            //Si no hay comida enotnces esta se debe crear, en cada tick del timer se valida si hay o no hay comida ya que el método
            // Next() y el método show(); siempre se ejecutar en el tick del timer

            if(food == null)
            {
                GetFood();
            }
            GetHistorySnake();

            switch (actualDirection)
            {
                //Como snake es una lista de squares, snaque[0] sería la cabeza
                case Direction.Right:
                    {
                        //si la posición de la cabeza está al  borde entonces que apareza por el lado opuesto
                        //de la pantalla
                       if(snake[0].x == (lengthMap -1)){snake[0].x = 0;}
                       //De lo contrario, siga moviéndose
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
                        //Valores negativos en y, en el marco de referencia de un forma es ir hacia arriba
                        else { snake[0].y--; }
                        break;
                    }
                case Direction.Down:
                    {
                        if (snake[0].y == (lengthMap - 1)) { snake[0].y = 0; }
                        //Valores positivos en y, en el marco de referencia de un forma es ir hacia abajo
                        else { snake[0].y++; }
                        break;
                    }
            }

            GetNextMoveSnake();

            SnakeEating();
        }

        //El siguiente método sirve para hacer que todo lo que esté después de la cabeza siga el mismo movimiento de la misma,
        //si hay más de un cuadro, o sea más que sólo la cabeza, la posición en x y y de dicho cuadro de más va a ser las coordenadas del 
        //cuando anterior al mismo. Este método se ejecuta en cada tick del timer

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

        /*
         Este método guarda la posición anterior de la cabeza de la serviente para que el pixel en cola que le sigue siga 
        la misma posición, este se ejecuta en cada tick del timer
         
         */

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
            //si la posición de la cabeza en x  y y es la misma que la comida entonces la comida se hace null para luego crear otra, se aumenta 
            //los puntos y se agrega este elemento a la lista que representa la serpiente 

            if(snake[0].x == food.x && snake[0].y == food.y)
            {
                food = null;
                this.points++;

                //Ya que se comió la comida, se crea un nuevo objeto cuadrado el cual va a estar en la posición dentro de la lista un valor
                //menor a la cantidad de elementos ya que por ejemplo, pueden haber 3 cuadros ya unidos pero como las listas empiezan en 
                //0 este debe ir la posición (conteo de elementos - 1) las coordenadas de estos serán las coordenadas del último punto guardado
                //este método se ejecuta en cada tick del timer
                Square lastSquare = snake[snake.Count - 1];
                Square objetSquare = new Square(lastSquare.x_old, lastSquare.y_old);
                snake.Add(objetSquare);
            }
        }

        private void GetFood()
        {
            //Este método crea una nueva comida haciéndolo de manera aleatoria

            int x = random.Next(0,lengthMap -1);
            int y = random.Next(0, lengthMap - 1);

            food = new Square(x, y);

        }

        //Este método pinta un cuadro  de bits según el color que se escoja, en este caso que la escala es 10 hace un doble ciclo para multiplicar
        // 10 * 10 
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


}
