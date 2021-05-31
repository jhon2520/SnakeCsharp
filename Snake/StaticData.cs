using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class StaticData
    {
        private static string nombre;
        private static int nivelJuego;

        public static string Nombre { get => nombre; set => nombre = value; }
        public static int NivelJuego { get => nivelJuego; set => nivelJuego = value; }
    }
}
