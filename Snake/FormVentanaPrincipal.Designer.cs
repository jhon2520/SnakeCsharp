
namespace Snake
{
    partial class FormVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.velocimetro = new System.Windows.Forms.Timer(this.components);
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.pbxBackgroundGame = new System.Windows.Forms.PictureBox();
            this.dragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblNombreJugador = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.dragPnlSuperior = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragLbl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCambiarNivel = new System.Windows.Forms.Button();
            this.lblPause = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundGame)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // velocimetro
            // 
            this.velocimetro.Interval = 10;
            this.velocimetro.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(8)))));
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(169)))), ((int)(((byte)(8)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(120, 405);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(300, 28);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar Juego";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.BackColor = System.Drawing.Color.Transparent;
            this.lblPoint.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.White;
            this.lblPoint.Location = new System.Drawing.Point(353, 79);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(67, 17);
            this.lblPoint.TabIndex = 2;
            this.lblPoint.Text = "0";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbxBackgroundGame
            // 
            this.pbxBackgroundGame.BackColor = System.Drawing.Color.Transparent;
            this.pbxBackgroundGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBackgroundGame.Location = new System.Drawing.Point(120, 99);
            this.pbxBackgroundGame.Name = "pbxBackgroundGame";
            this.pbxBackgroundGame.Size = new System.Drawing.Size(300, 300);
            this.pbxBackgroundGame.TabIndex = 0;
            this.pbxBackgroundGame.TabStop = false;
            // 
            // dragForm
            // 
            this.dragForm.Fixed = true;
            this.dragForm.Horizontal = true;
            this.dragForm.TargetControl = this;
            this.dragForm.Vertical = true;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 6;
            this.elipseForm.TargetControl = this;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(189)))), ((int)(((byte)(8)))));
            this.pnlSuperior.Controls.Add(this.lblNombreJugador);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Controls.Add(this.lblTittle);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(532, 59);
            this.pnlSuperior.TabIndex = 3;
            // 
            // lblNombreJugador
            // 
            this.lblNombreJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreJugador.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreJugador.ForeColor = System.Drawing.Color.White;
            this.lblNombreJugador.Location = new System.Drawing.Point(100, 39);
            this.lblNombreJugador.Name = "lblNombreJugador";
            this.lblNombreJugador.Size = new System.Drawing.Size(333, 19);
            this.lblNombreJugador.TabIndex = 6;
            this.lblNombreJugador.Text = "Nombre Jugador";
            this.lblNombreJugador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(8)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(169)))), ((int)(((byte)(8)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(499, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 29);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(165, 6);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(202, 31);
            this.lblTittle.TabIndex = 2;
            this.lblTittle.Text = "SNAKE GAME";
            // 
            // dragPnlSuperior
            // 
            this.dragPnlSuperior.Fixed = true;
            this.dragPnlSuperior.Horizontal = true;
            this.dragPnlSuperior.TargetControl = this.pnlSuperior;
            this.dragPnlSuperior.Vertical = true;
            // 
            // dragLbl
            // 
            this.dragLbl.Fixed = true;
            this.dragLbl.Horizontal = true;
            this.dragLbl.TargetControl = this.lblTittle;
            this.dragLbl.Vertical = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(5, 456);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(365, 22);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Bievenido";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnCambiarNivel);
            this.panel2.Location = new System.Drawing.Point(64, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 280);
            this.panel2.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(-1, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 49);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(-1, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 49);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-2, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 49);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Snake.Properties.Resources._78970851_puntaje_de_crédito;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-1, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 49);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCambiarNivel
            // 
            this.btnCambiarNivel.BackgroundImage = global::Snake.Properties.Resources.level_up_font;
            this.btnCambiarNivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCambiarNivel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarNivel.Location = new System.Drawing.Point(-1, -2);
            this.btnCambiarNivel.Name = "btnCambiarNivel";
            this.btnCambiarNivel.Size = new System.Drawing.Size(49, 49);
            this.btnCambiarNivel.TabIndex = 0;
            this.btnCambiarNivel.UseVisualStyleBackColor = true;
            this.btnCambiarNivel.Click += new System.EventHandler(this.btnCambiarNivel_Click);
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(211, 226);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(111, 31);
            this.lblPause.TabIndex = 5;
            this.lblPause.Text = "PAUSE";
            this.lblPause.Visible = false;
            // 
            // FormVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.wp2409705;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 483);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pbxBackgroundGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.FormVentanaPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundGame)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer velocimetro;
        private System.Windows.Forms.PictureBox pbxBackgroundGame;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblPoint;
        private Bunifu.Framework.UI.BunifuDragControl dragForm;
        private System.Windows.Forms.Panel pnlSuperior;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl dragPnlSuperior;
        private Bunifu.Framework.UI.BunifuDragControl dragLbl;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCambiarNivel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblNombreJugador;
    }
}

