using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1.Models
{
    internal class Guardia
    {
        public int horadesde { get; private set; }
        public int minutodesde { get; private set; }
        public int horahasta { get; private set; }
        public int minutohasta { get; private set;}
        public int cantidadminutos { get; private set; }
        public Policia oficialasignado { get; private set; }


        public Guardia()
        {

        }

        public void AsignarPolicia(Policia oficial, int h, int m, int cantm)
        {
            
                oficialasignado = oficial;
                horadesde = h;
                minutodesde = m;
                cantidadminutos = cantm;


        }


    }
}
