﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }

        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Jugadores = new List<Jugador>();
            Nombre = "Equipo nuevo";
            Ciudad = "Ciudad nueva";
            Entrenador = "Entrenador nuevo";
        }

        public Equipo(string nombre)
        {
            Jugadores = new List<Jugador>();
            Nombre = nombre;
            Ciudad = "Ciudad nueva";
            Entrenador = "Entrenador nuevo";
        }
    }
}
