using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaTema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string textoTelegrama;
            string textoLimpio;

            //! La variable tipoTelegrama solo se declara
            char tipoTelegrama;
            int numPalabras = 1;
            double coste;

            //! Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            //! Formateo la cadena recogida del textBox
            textoLimpio = textoTelegrama.Replace(" \n", " ");

            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';

            //! Obtengo el número de palabras que forma el telegrama
            for (int i = 0; i < textoLimpio.Length; i++) {
                if (textoLimpio[i] == ' ')
                    numPalabras++;
            }

            //? El Programa entra en la instrucción condicional
            if (tipoTelegrama == 'o' && textoTelegrama != "") {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    //! Esta línea de código se tenía que modificar
                    coste = 2.5 + 0.5 * (numPalabras - 10);

                // Si el telegrama es urgente
            } else if (tipoTelegrama == 'u' && textoTelegrama != "") {

                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);

            } else {

                coste = 0;
            }

            txtPrecio.Text = coste.ToString() + " euros";

        }
    }
}
