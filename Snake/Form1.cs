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
            //Aquí puedo colocar que la fecha contraria se bloquee
            if(e.KeyCode == Keys.W){game.actualDirection = Game.Direction.Up;}
            if(e.KeyCode == Keys.S){game.actualDirection = Game.Direction.Down; }
            if(e.KeyCode == Keys.A){game.actualDirection = Game.Direction.Left; }
            if(e.KeyCode == Keys.D){game.actualDirection = Game.Direction.Right; }
        }
    }
}
