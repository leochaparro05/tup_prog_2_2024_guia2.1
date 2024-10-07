using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_2_ejercicio_1
{
    internal class departamentoVehicular
    {
        public int CantidadRegistros { get; private set; }

        private ArrayList registros = new ArrayList();

        private string serie = "000000001";
        public registroVehiculos registrarVehiculos(persona propietario)
        {
            string patente = generarpatente();
            registroVehiculos nuevovehiculo = new registroVehiculos(patente, propietario, serie);
            registros.Add(nuevovehiculo);
            return nuevovehiculo;
        }

        public registroVehiculos Verregistro(int idx)
        {
            return (registroVehiculos)registros[idx];

        }

        private string generarpatente()
        {
            Random random = new Random();
            char letter1 = (char)random.Next('A', 'Z' + 1);
            char letter2 = (char)random.Next('A', 'Z' + 1);

            int numero = random.Next(100, 999);
            return $"{letter1}{letter2}{numero}";

        }
    }
}
