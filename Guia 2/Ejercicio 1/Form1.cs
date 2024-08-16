using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Comisaria micomisaria;
        ListaIncidentes resultados = new ListaIncidentes();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string persona = tbPersona.Text;
            int dni = Convert.ToInt32(tbDni.Text);
            Persona actual = new Persona(dni, persona);
            int tipoincidente = Convert.ToInt32(cbIncidente.SelectedIndex);
            int h = Convert.ToInt32(nuDesdeJ.Value);
            int m = Convert.ToInt32(nuHastaJ.Value);
            string motivo = tbMotivo.Text;
            int placa = Convert.ToInt32(cbPlaca.Text);
            Policia miagente = micomisaria.VerAgente(placa);
            micomisaria.RegistrarIncidente(miagente, actual, motivo, h, m, tipoincidente);
            cbPlaca.SelectedIndex = -1;
            nuDesdeJ.Value = 12;
            nuHastaJ.Value = 59;
            tbPersona.Clear();
            tbDni.Clear();
            cbIncidente.SelectedIndex = -1;
            tbMotivo.Clear();
            btnIncidentes.Enabled = true;
        }

        private void btnComisaria_Click(object sender, EventArgs e)
        {
            micomisaria = new Comisaria();
            Policia policia1 = new Policia(44763336, "Exequiel Montero", 2323);
            Policia policia2 = new Policia(43937001, "Gonzalo Montero", 2324);
            micomisaria.AsignarPolicia(policia1);
            micomisaria.AsignarPolicia(policia2);
            btnComisaria.Enabled = false;
        }

        private void btnGuardia_Click(object sender, EventArgs e)
        {
            int placa = Convert.ToInt32(cbPlaca.Text);
            int h = Convert.ToInt32(nuDesdeH.Value);
            int m = Convert.ToInt32(nuHastaH.Value);
            int duracion = Convert.ToInt32(nuDuracion.Value);
            int guardia = Convert.ToInt32(nuGuardia.Value);
            Policia miagente = micomisaria.VerAgente(placa);

            micomisaria.AsignarGuardia(placa, h, m, duracion, miagente);
            cbPlaca.SelectedIndex = -1;
            nuDesdeH.Value = 12;
            nuHastaH.Value = 59;
            nuDuracion.Value = 1;

        }

        private void btnIncidentes_Click(object sender, EventArgs e)
        {
            Incidente actual;
            for(int i=0; i<micomisaria.cantidadincidentes; i++)
            {
                actual = micomisaria.VerIncidente(i);
                if(actual.tipoincidente == 0)
                {
                    resultados.lbResultados.Items.Add($"Incidente de Tipo: Robo");
                    resultados.lbResultados.Items.Add($"A nombre de: {actual.sujeto.nombre}, Dni:{actual.sujeto.dni}");
                    resultados.lbResultados.Items.Add($"Oficial a cargo: {actual.oficialacargo.nombre}, Dni: {actual.oficialacargo.dni}, Numero de placa: {actual.oficialacargo.numeroplaca}");
                    resultados.lbResultados.Items.Add($"Motivo: {actual.motivo}");
                    resultados.lbResultados.Items.Add($"Horario del incidente: {actual.hora}:{actual.minuto}hs");
                    resultados.lbResultados.Items.Add($"-------------------------------------------------------------------");
                }
                else if(actual.tipoincidente == 1)
                {
                    resultados.lbResultados.Items.Add($"Incidente de Tipo: Homicidio");
                    resultados.lbResultados.Items.Add($"A nombre de: {actual.sujeto.nombre}, Dni:{actual.sujeto.dni}");
                    resultados.lbResultados.Items.Add($"Oficial a cargo: {actual.oficialacargo.nombre}, Dni: {actual.oficialacargo.dni}, Numero de placa: {actual.oficialacargo.numeroplaca}");
                    resultados.lbResultados.Items.Add($"Motivo: {actual.motivo}");
                    resultados.lbResultados.Items.Add($"Horario del incidente: {actual.hora}:{actual.minuto}hs");
                    resultados.lbResultados.Items.Add($"-------------------------------------------------------------------");
                }
                else if(actual.tipoincidente == 2)
                {
                    resultados.lbResultados.Items.Add($"Incidente de Tipo: Disturbio Publico");
                    resultados.lbResultados.Items.Add($"A nombre de: {actual.sujeto.nombre}, Dni:{actual.sujeto.dni}");
                    resultados.lbResultados.Items.Add($"Oficial a cargo: {actual.oficialacargo.nombre}, Dni: {actual.oficialacargo.dni}, Numero de placa: {actual.oficialacargo.numeroplaca}");
                    resultados.lbResultados.Items.Add($"Motivo: {actual.motivo}");
                    resultados.lbResultados.Items.Add($"Horario del incidente: {actual.hora}:{actual.minuto}hs");
                    resultados.lbResultados.Items.Add($"-------------------------------------------------------------------");
                }

            }
            if (micomisaria.cantidadincidentes > 0)
            {
                resultados.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se registro ningun incidente aun");
            }
            resultados.lbResultados.Items.Clear();
        }
    }
}
