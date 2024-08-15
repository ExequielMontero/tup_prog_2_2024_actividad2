using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Persona
    {
        private int dni;
        private string nombre;

        public int Dni { get; private set; }
        public int Nombre { get; private set; }

        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

    }
}
