using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_EmirSanchezRamirezEC2
{
    public partial class SegundaParte : Form
    {
        private int[] lNumerosEnteros = new int[10];
        //contador
        private int contador = 0;
        //variable global
        private int nEnteros;

        public SegundaParte()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SegundaParte_Load(object sender, EventArgs e)
        {

        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {

            nEnteros=  Convert.ToInt32(txtNumeroEntero.Text);

            contador++;

            if (contador <= 10)
            {
                //agregar a la lista
                lsbNumerosEnteros.Items.Add(nEnteros.ToString());
                //agregamos al arrego
                lNumerosEnteros[contador - 1] = nEnteros;
            }
            else
            {
                MessageBox.Show("Solo se admite 10 numeros enteros","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            txtNumeroEntero.Focus();
            
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            nEnteros = Convert.ToInt32(txtNumeroEntero.Text);
            int contp = 0;

            for (int i = 0; i < 10; i++)

            {
                if(lNumerosEnteros[i] % 2 == 0)
                {
                    contp++;
                }
            }

            int[] lpares = new int[contp];
            contp = 0;
            for (int j = 0; j < 10; j++)
            {
                if (lNumerosEnteros[j] % 2 == 0)
                {
                    lpares[contp] = lNumerosEnteros[j];
                    contp++;
                }
            }

            for (int k = 0; k < contp; k++)
            {
                MessageBox.Show("Lista de pares: "+lpares[k],"Pares",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            

        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            nEnteros = Convert.ToInt32(txtNumeroEntero.Text);
            int conti = 0;

            for (int i = 0; i < 10; i++)

            {
                if (lNumerosEnteros[i] % 2 != 0)
                {
                    conti++;
                }
            }

            int[] lpares = new int[conti];
            conti = 0;
            for (int j = 0; j < 10; j++)
            {
                if (lNumerosEnteros[j] % 2 != 0)
                {
                    lpares[conti] = lNumerosEnteros[j];
                    conti++;
                }
            }

            for (int k = 0; k < conti; k++)
            {
                MessageBox.Show("Lista de impares: " + lpares[k].ToString(), "Impares", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
