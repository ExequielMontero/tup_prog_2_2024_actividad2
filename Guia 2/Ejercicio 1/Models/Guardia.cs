using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Guardia
    {
        private int horadesde;
        private int minutodesde;
        private int horahasta;
        private int minutohasta;
        private int cantidadminutos;
        private Policia oficial;

        public int Horadesde { get; }
        public int Minutodesde { get; }
        
        public int Horahasta { get; }
        public int Minutohasta { get; }
        public int Cantidadminutos { get; }

        public Guardia()
        {
        }

        public void AsignarPolicia(Policia oficialenturno, int horaen, int minuent, int totalminutos)
        {
            horadesde = horaen;
            minutodesde = minuent;
            oficial = oficialenturno;
            cantidadminutos = totalminutos;
        }

    }
}
