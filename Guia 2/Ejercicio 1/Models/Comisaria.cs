using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Ejercicio_1.Models
{
    internal class Comisaria
    {
        Policia[] agentes = new Policia[2];
        ArrayList incidentes = new ArrayList();
        Guardia[] Guardias = new Guardia[2];
        public int cantidadincidentes { get; private set; } = 0;
        int cont = 0;

        public bool AsignarPolicia(Policia agente)
        {
            bool bandera;
            if (agente != null)
            {
                agentes[cont] = agente;
                bandera = true;
                cont++;
            }
            else
            {
                bandera = false;
            }
            return bandera;
            
        }

        public Policia VerAgente(int numeroplaca)
        {
            Policia oficial = null;
            for(int i=0; i<cont; i++)
            {
                if (agentes[i].numeroplaca == numeroplaca)
                {
                    oficial = agentes[i];
                }
            }
            return oficial;
        }

        public void RegistrarIncidente(Policia oficial, Persona sujeto, string motivo, int h, int m, int tipoincidente)
        {
            incidentes.Add(new Incidente(oficial, tipoincidente, sujeto, motivo, h, m));
            cantidadincidentes++;
        }

        public void AsignarGuardia(int numero, int h1, int m1, int tiempominutos, Policia oficial)
        {
            if(numero == 1)
            {
                Guardias[0].AsignarPolicia(oficial, h1, m1, tiempominutos);
            }
            else if(numero == 2)
            {
                Guardias[1].AsignarPolicia(oficial, h1, m1, tiempominutos);
            }
        }

        public Incidente VerIncidente(int idx)
        {
            if (idx >= 0 && idx < incidentes.Count)
            {
                return (Incidente)incidentes[idx];
            }
            else
            {
                return null;
            }
        }


    }
}
