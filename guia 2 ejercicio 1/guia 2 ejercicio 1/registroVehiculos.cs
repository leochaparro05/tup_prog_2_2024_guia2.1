using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_2_ejercicio_1
{
    internal class registroVehiculos
    {
        public string Patente { get; private set; }
        public string Serie { get; private set; }

        public persona Propietario;
        public registroVehiculos(string patente, persona propietario, string serie) 
        {
            Patente = patente;
            Serie = serie;
            Propietario = propietario;
        }
        public string Verdetalle()
        {
            return $"Patente: {Patente}, Nro serie: {Serie}, Nombre{Propietario.Nombre}, DNI:({Propietario.DNI})";
        }


    }
}
