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

            int valor = 0;
            

            if (int.TryParse(txtNumeroEntero.Text, out valor))
            {
                contador++;
            }
            else
            {
                MessageBox.Show("Ingresa solo numeros enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumeroEntero.SelectAll();
                txtNumeroEntero.Focus();
                return;
                
            }
                
            if (contador <= 10)
            {
                    //agregar a la lista
                    lsbNumerosEnteros.Items.Add(txtNumeroEntero.Text.ToString());
                    //agregamos al arrego
                    lNumerosEnteros[contador - 1] = Convert.ToInt32( txtNumeroEntero.Text.ToString());
            }
            else
            {
                    MessageBox.Show("Solo se admite 10 numeros enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNumeroEntero.SelectAll();
            txtNumeroEntero.Focus();
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            
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

            string juntaPares = string.Empty;

            for (int k = 0; k < contp; k++)
            {
                juntaPares = k < 1 ? lpares[k].ToString() : juntaPares + ", " + lpares[k].ToString();
            }

            MessageBox.Show("Lista de pares: " + juntaPares, "Pares", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            
            int conti = 0;

            for (int i = 0; i < 10; i++)

            {
                if (lNumerosEnteros[i] % 2 != 0)
                {
                    conti++;
                }
            }

            int[] limpares = new int[conti];
            conti = 0;

            for (int j = 0; j < 10; j++)
            {
                if (lNumerosEnteros[j] % 2 != 0)
                {
                    limpares[conti] = lNumerosEnteros[j];
                    conti++;
                }
            }

            string juntaImpares = string.Empty;

            for (int k = 0; k < conti; k++)
            {
                if (k < 1)
                {
                    juntaImpares = limpares[k].ToString();
                }
                else
                {
                    juntaImpares += ", " + limpares[k].ToString();
                }
            }

            MessageBox.Show("Lista de impares: " + juntaImpares, "Impares", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
