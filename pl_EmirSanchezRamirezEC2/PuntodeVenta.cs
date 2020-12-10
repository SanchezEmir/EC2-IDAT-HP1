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
    public partial class PuntodeVenta : Form
    {
        private Modal objModal = null;
        private SegundaParte objDos = null;
        private terceraParte objTres = null;
        public PuntodeVenta()
        {
            InitializeComponent();
        }

        private void tsmiOperaciones_Click(object sender, EventArgs e)
        {
            
            
        }

        void CerrarFormularioDeProductos(object sender, FormClosedEventArgs e)
        {
            
            objModal = null;
            objDos = null;
            objTres = null;
            
        }

        private void tsmiMantenimiento_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiVentas_Click(object sender, EventArgs e)
        {
            if (objModal == null)
            {

                objModal = new Modal();

                objModal.MdiParent = this;

                objModal.FormClosed += new FormClosedEventHandler(CerrarFormularioDeProductos);

                objModal.Show();
            }
            else
            {
                objModal.Activate();
            }
            tsslEstado.Text = "Esta en la Opcion: "+tsmiVentas.Text;
        }

        private void tsmiAlmacen_Click(object sender, EventArgs e)
        {
            tsmiVentas.PerformClick();
            tsslEstado.Text = "Esta en la Opcion: " + tsmiAlmacen.Text;
        }

        private void tsmiProductos_Click(object sender, EventArgs e)
        {
            tsmiVentas.PerformClick();
            tsslEstado.Text = "Esta en la Opcion: " + tsmiProductos.Text;
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            tsmiVentas.PerformClick();
            tsslEstado.Text = "Esta en la Opcion: " + tsmiClientes.Text;
        }

        private void PuntodeVenta_Load(object sender, EventArgs e)
        {

        }

        private void segundaParteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objDos == null)
            {

                objDos = new SegundaParte();

                objDos.MdiParent = this;

                objDos.FormClosed += new FormClosedEventHandler(CerrarFormularioDeProductos);

                objDos.Show();
            }
            else
            {
                objDos.Activate();
            }
            tsslEstado.Text = "Esta en la Opcion: " + segundaParteToolStripMenuItem.Text;
        }

        private void terceraParteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objTres == null)
            {

                objTres = new terceraParte();

                objTres.MdiParent = this;

                objTres.FormClosed += new FormClosedEventHandler(CerrarFormularioDeProductos);

                objTres.Show();
            }
            else
            {
                objTres.Activate();
            }
            tsslEstado.Text = "Esta en la Opcion: " + terceraParteToolStripMenuItem.Text;
        }
    }
}
