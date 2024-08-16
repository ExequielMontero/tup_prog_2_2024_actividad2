using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Policia
    {
        public int dni { get; private set; }
        public string nombre { get; private set; }
        public int numeroplaca { get; private set; }

        public Policia(int dni, string nombre, int numeroplaca)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.numeroplaca = numeroplaca;
        }

        public string VerDatos()
        {
            return $"Policia: {nombre}, Dni: {dni}, Numero de placa: {numeroplaca}";
        }

    }
}
