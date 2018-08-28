using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador()
        {
            Nombre = "Kakaroto";
            Numero = "2";
        }
        public Jugador(string nombre)
        {
            Nombre = nombre;
            Numero = "69";
        }
    }
}
