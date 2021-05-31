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
    public partial class FormAviso : Form
    {
        public FormAviso(string mensaje)
        {
            InitializeComponent();
            this.lblMensaje.Text = mensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
