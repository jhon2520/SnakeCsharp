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
    public partial class FormDificultad : Form
    {
        public FormDificultad()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StaticData.NivelJuego = (int)this.nUD.Value;
            this.Close();
        }

        private void FormDificultad_Load(object sender, EventArgs e)
        {
            this.nUD.Value = StaticData.NivelJuego;
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

    }
}
