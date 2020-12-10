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
            //if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            //{
                //MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //e.Handled = true;
                //return;
            //}
        }

        private void SegundaParte_Load(object sender, EventArgs e)
        {

        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            

            int nEnteros = Convert.ToInt32(txtNumeroEntero.Text);

            

            contador++;

            if (contador <= 10)
            {
                //agregar a la lista
                lsbNumerosEnteros.Items.Add(nEnteros.ToString());
                //agregamos al arrego
                lNumerosEnteros[contador - 1] = nEnteros;
                //recorremos el arreglo
                for (int i = 0; i<=10; i++)
                {

                }

            }
            else
            {
                MessageBox.Show("Solo se admite 10 numeros enteros","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }
    }
}
