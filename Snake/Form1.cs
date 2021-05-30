using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game = new Game(pbxBackgroundGame,lblPoint);
            velocimetro.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!game.isLost)
            {
                game.Next();
                game.Show();
            }
            else
            {
                velocimetro.Enabled = false;
                MessageBox.Show("Perdiste por feo");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Se necesitan dos métodos para el movimiento uno cuando está la cabeza sola a la cual se le permite libremente y el otro método
            //cuando se ha agregado cuerpo en la serpiente ya que no se le puede permitir que si por ejemplo está yendo hacia la derecha y se presione
            //la izquierda, el juepo pierda porque se toma como que la serpiente se chocó con ella misma.
            if(game.SnakeCount == 1){OnlyHeadMove(sender, e);}
            else { HeadWithBodyMove(sender, e); }
        }

        private void OnlyHeadMove(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W){game.actualDirection = Game.Direction.Up;}
            if (e.KeyCode == Keys.S){game.actualDirection = Game.Direction.Down;}
            if (e.KeyCode == Keys.A){game.actualDirection = Game.Direction.Left;}
            if (e.KeyCode == Keys.D){game.actualDirection = Game.Direction.Right;}
        }

        private void HeadWithBodyMove(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && game.actualDirection != Game.Direction.Down){game.actualDirection = Game.Direction.Up;}
            if (e.KeyCode == Keys.S && game.actualDirection != Game.Direction.Up){game.actualDirection = Game.Direction.Down;}
            if (e.KeyCode == Keys.A && game.actualDirection != Game.Direction.Right){game.actualDirection = Game.Direction.Left;}
            if (e.KeyCode == Keys.D && game.actualDirection != Game.Direction.Left){game.actualDirection = Game.Direction.Right;}
        }

    }
}
