using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Ejercicio_1.Models
{
    internal class Incidente
    {
        public string motivo { get; set; }
        public int hora { get; set; }
        public int minuto { get; set; }
        public int tipoincidente { get; private set; }
        public Persona sujeto { get; private set; }
        public Policia oficialacargo { get; private set; }

        public Incidente(Policia oficial, int tipoincidente, Persona sujeto, string motivo, int h, int m)
        {
            this.oficialacargo = oficial;
            this.tipoincidente = tipoincidente;
            this.sujeto = sujeto;
            this.motivo = motivo;
            hora = h;
            minuto = m;
        }

        public string VerDatos()
        {
            string datos = "";
            switch (tipoincidente)
            {
                case 0:
                    {
                        datos = $"Tipo incidente: Robo, Motivo: {motivo}, Horarios: {hora}: {minuto}hs, Policia: {oficialacargo}, Sujeto: {sujeto}";
                    }
                    break;
                case 1:
                    {
                        datos = $"Tipo incidente: Homicidio, Motivo: {motivo}, Horarios: {hora}: {minuto}hs, Policia: {oficialacargo}, Sujeto: {sujeto}";
                    }
                    break;
                case 2:
                    {
                        datos = $"Tipo incidente: Disturbio Publico, Motivo: {motivo}, Horarios: {hora}: {minuto}hs, Policia: {oficialacargo}, Sujeto: {sujeto}";
                    }
                    break;
            }
            return datos;
        }
    }

}
