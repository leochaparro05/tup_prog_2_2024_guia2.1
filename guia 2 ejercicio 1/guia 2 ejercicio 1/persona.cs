using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_2_ejercicio_1
{
    internal class persona
    {
        public int DNI { get; set; }
        public string Nombre { get; private set; }
        public persona (int dni, string nombre)
           {DNI = dni;
            Nombre = nombre;
           }
    }
}
