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
    public partial class FormVentanaPrincipal : Form
    {
        Game game;

        public FormVentanaPrincipal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            game = new Game(pbxBackgroundGame,lblPoint,lblMensaje);
            SetLevel();
            velocimetro.Enabled = true;


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!game.isLost)
            {
                ValidateBtnInit();
                game.Next();
                game.Show();
                game.MensajesLabel();
            }
            else
            {
                velocimetro.Enabled = false;
                FormAviso formAviso = new FormAviso("¡Qué pelota! PERDISTE");
                formAviso.Show();
                this.btnIniciar.Enabled = true;
            }
        }
        private void ValidateBtnInit()
        {
            if(velocimetro.Enabled == true) 
            {
                this.btnIniciar.Enabled = false;
            }

        }
        private void SetLevel()
        {
            if(StaticData.NivelJuego == 10) { this.velocimetro.Interval = 1;}
            else if (StaticData.NivelJuego == 9) { this.velocimetro.Interval = 10;}
            else if (StaticData.NivelJuego == 8) { this.velocimetro.Interval = 30;}
            else if (StaticData.NivelJuego == 7) { this.velocimetro.Interval = 70;}
            else if (StaticData.NivelJuego == 6) { this.velocimetro.Interval = 100;}
            else if (StaticData.NivelJuego == 5) { this.velocimetro.Interval = 200;}
            else if (StaticData.NivelJuego == 4) { this.velocimetro.Interval = 300; }
            else if (StaticData.NivelJuego == 3) { this.velocimetro.Interval = 400; }
            else if (StaticData.NivelJuego == 2) { this.velocimetro.Interval = 500; }
            else if (StaticData.NivelJuego == 1) { this.velocimetro.Interval = 600; }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Se necesitan dos métodos para el movimiento uno cuando está la cabeza sola a la cual se le permite libremente y el otro método
            //cuando se ha agregado cuerpo en la serpiente ya que no se le puede permitir que si por ejemplo está yendo hacia la derecha y se presione
            //la izquierda, el juepo pierda porque se toma como que la serpiente se chocó con ella misma.
            if(game.SnakeCount == 1){OnlyHeadMove(sender, e);}
            else { HeadWithBodyMove(sender, e); }

            //Código para pausar el juego cuando se presion la tecla enter
            PauseGame(sender, e);
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

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void PauseGame(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && velocimetro.Enabled == true) 
            {
                this.lblPause.Visible = true;
                velocimetro.Stop();
                velocimetro.Enabled = false;
                
            }
            else 
            {
                this.lblPause.Visible = false;
                velocimetro.Start();
                velocimetro.Enabled = true;
            }
        }

        private void FormVentanaPrincipal_Load(object sender, EventArgs e)
        {
            this.lblNombreJugador.Text = StaticData.Nombre;
            StaticData.NivelJuego = 1;
        }

        private void btnCambiarNivel_Click(object sender, EventArgs e)
        {
            FormDificultad formDificultad = new FormDificultad();
            formDificultad.ShowDialog();
            this.btnIniciar.Enabled = true;
            this.btnIniciar.PerformClick();
        }
    }
}
