using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_GIT_telegrama_con_compañero
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
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;
            int i = 0;

            //Leo el telegrama1
            textoTelegrama = txtTelegrama.Text;
            //creando conflicto
            // telegrama urgente? hecho el cambio de cbUrgente a rdUrgente
            if (rdUrgente.Checked)
                tipoTelegrama = 'u';
            // para poder seleccionar uno u otro añado rdOrdinario tamb
            else if (rdOrdinario.Checked)
                tipoTelegrama = 'o';

            //Obtengo el número de palabras que forma el telegrama
            char[] texto = textoTelegrama.ToCharArray();

            //Si el telegrama es ordinario
            for (i = 0; i < textoTelegrama.Length; i++)
            {
                if (textoTelegrama[i].ToString() == " ")
                    numPalabras++;
            }
            /*Sumamos una palabra de más al contar solo los espacios entre palabras
            para que nos cuente la última también.
            */
            numPalabras++;
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            else

            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            //Mostramos el precio1
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void rdOrdinario_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
