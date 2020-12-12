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
    public partial class terceraParte : Form
    {

        private int contador = 0;
        private int[] lNumerosEnteros = new int[10];

        public terceraParte()
        {
            InitializeComponent();
        }

        private void terceraParte_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtNumeros.Text, out int valor))
            {
                contador++;
            }
            else
            {
                MessageBox.Show("Ingresa solo numeros enteros", "Alerta", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtNumeros.SelectAll();
                txtNumeros.Focus();
                return;
            }


            if (contador <= 10)
            {
                //agregar a la lista
                lsbNumeros.Items.Add(txtNumeros.Text.ToString());
                //agregamos al arrego
                lNumerosEnteros[contador - 1] = Convert.ToInt32(txtNumeros.Text.ToString());
            }
            else
            {
                MessageBox.Show("Solo se admite 10 numeros enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNumeros.SelectAll();
            txtNumeros.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lsbNumeros.Items.Clear();
            Array.Sort(lNumerosEnteros);
            for (int i = 0; i < 10; i++)
            {
                lsbNumeros.Items.Add(lNumerosEnteros[i]);
            }
        }
    }
}
