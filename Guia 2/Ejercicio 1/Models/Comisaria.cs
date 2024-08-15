using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Comisaria
    {

        int cont = 0;
        Policia[] milista = new Policia[1];
        Guardia[] guardias = new Guardia[1];
        ArrayList incidentes = new ArrayList();


        public Guardia[] Guardias { get; }

        public Comisaria()
        {
            Guardia guardia1 = new Guardia();
            Guardia guardia2 = new Guardia();
            guardias[0] = guardia1;
            guardias[1] = guardia2;
        }


        public bool AsignarPolicia(Policia oficiales)
        {
            bool bandera = false;

            if (cont < 2)
            {
                milista[cont] = oficiales;
                bandera = true;
                cont++;
            }
            else
            {
                cont = 0;
            }

            return bandera;
        }

        public Policia veragente(int numeroplaca)
        {

            Policia actual = null;
            for (int i = 0; i < cont; i++)
            {
                if (milista[i].Numeroplaca == numeroplaca)
                {
                    actual = milista[i];
                }
                else
                {
                    actual = null;
                }
            }
            return actual;
        }

        public void registrarincidente(Policia oficial, Persona sujeto, string tipoincidente, int minuto, int hora, string motivo)
        {
            Incidente nombreincidente;
            nombreincidente = new Incidente(oficial, sujeto, tipoincidente, minuto, hora, motivo);
            incidentes.Add(nombreincidente);
        }



    }
}
