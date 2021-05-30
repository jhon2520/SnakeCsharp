
namespace Snake
{
    partial class Form1
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
            this.pbxBackgroundGame = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundGame)).BeginInit();
            this.SuspendLayout();
            // 
            // velocimetro
            // 
            this.velocimetro.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxBackgroundGame
            // 
            this.pbxBackgroundGame.Location = new System.Drawing.Point(188, 23);
            this.pbxBackgroundGame.Name = "pbxBackgroundGame";
            this.pbxBackgroundGame.Size = new System.Drawing.Size(300, 300);
            this.pbxBackgroundGame.TabIndex = 0;
            this.pbxBackgroundGame.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(475, 326);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(13, 13);
            this.lblPoint.TabIndex = 2;
            this.lblPoint.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 366);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxBackgroundGame);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer velocimetro;
        private System.Windows.Forms.PictureBox pbxBackgroundGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPoint;
    }
}

