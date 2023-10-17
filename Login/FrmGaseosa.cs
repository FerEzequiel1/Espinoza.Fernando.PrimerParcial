using Control_de_ingresos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class FrmGaseosa : Form
    {
        internal Usuario usuario;
        internal ListaProductos lista;
        public FrmGaseosa(Usuario usuario, ListaProductos lista)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.lista = lista;
        }

        private void aarrozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAarroz frmAarroz = new FrmAarroz();
            frmAarroz.ShowDialog();
            this.Close();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gaseosa gaseosa = new Gaseosa();
            agregar(gaseosa);

            

        }
        public bool agregar(Producto p)
        {
            return lista + p;
        }
    }
}
