using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Policia
    {
        private int dni;
        private string nombre;
        private int numeroplaca;

        public int Dni { get; private set;}
        public int Nombre { get; private set; }
        public int Numeroplaca { get; private set; }
        public Policia(int dni, string nombre, int numeroplaca)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.numeroplaca = numeroplaca;
        }


    }
}
