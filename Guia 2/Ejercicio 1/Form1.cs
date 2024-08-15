using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Comisaria micomisaria;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComisaria_Click(object sender, EventArgs e)
        {
            micomisaria = new Comisaria();
        }

        private void btnIncidentes_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardia_Click(object sender, EventArgs e)
        {
            int placa = cbPlaca.TabIndex;
            int guardia = Convert.ToInt32(nuGuardia.Value);
            Guardia[] misguardias = micomisaria.Guardias;
            Policia policia1 = new Policia(44763336, "Exequiel Montero", 2323);
            Policia policia2 = new Policia(43937001, "Gonzalo Montero", 2324);
            int horaen = Convert.ToInt32(nuDesdeH.Value);
            int minutoen = Convert.ToInt32(nuHastaH.Value);
            int duracionmin = Convert.ToInt32(nuDuracion);

            if (placa == 0 && guardia==1)
            {
                misguardias[0].AsignarPolicia(policia1, horaen, minutoen, duracionmin);

            }
            else if(placa==0 && guardia==2)
            {
                misguardias[1].AsignarPolicia(policia1, horaen, minutoen, duracionmin);

            }
            else if(placa == 1 && guardia == 1)
            {
                misguardias[0].AsignarPolicia(policia2, horaen, minutoen, duracionmin);

            }
            else if(placa == 1 && guardia == 2)
            {
                misguardias[1].AsignarPolicia(policia2, horaen, minutoen, duracionmin);

            }
        }
    }
}
