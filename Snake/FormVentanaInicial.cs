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
    public partial class FormVentanaInicial : Form
    {
        public FormVentanaInicial()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(tbxNombreJugador.Text != string.Empty && tbxNombreJugador.Text != "Ingrese su nombre")
            {
                StaticData.Nombre = this.tbxNombreJugador.Text;
                FormVentanaPrincipal formVentanaPrincipal = new FormVentanaPrincipal();
                this.Hide();
                formVentanaPrincipal.ShowDialog();
            }
            else
            {
                FormAviso formAviso = new FormAviso("Ingrese su nombre");
                formAviso.ShowDialog();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void tbxNombreJugador_Enter(object sender, EventArgs e)
        {
            this.tbxNombreJugador.Text = string.Empty;
        }
    }
}
