using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_1.Models
{
    internal class Incidente
    {
        private string motivo;
        private int hora;
        private int minuto;
        private string tipoincidente;
        private Persona sujeto;
        private Policia oficial;
        public string Motivo { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public string Tipoincidente { get; set; }
        public Persona Sujeto { get; }
        public Policia Oficial  { get; }
       
        public Incidente(Policia oficial, Persona sujeto, string tipoincidente, int minuto, int hora, string motivo)
        {
            this.sujeto = sujeto;
            this.oficial = oficial;
            this.tipoincidente = tipoincidente;
            this.minuto = minuto;
            this.hora = hora;
            this.motivo = motivo;

        }

        public string verdescripcion()
        {
            return $"Tipo de incidente: {tipoincidente}, Motivo: {motivo}, Oficial a cargo: {oficial.Nombre}, Persona denunciante: {sujeto.Nombre}";

        }



    }
}
