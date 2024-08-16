using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_1.Models
{
    internal class Persona
    {
        public int dni {get; private set; }
        public string nombre {get; private set;}

        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public string VerDatos()
        {
            return $"Sujeto: {nombre}, Dni: {dni}";
        }
    }
}
