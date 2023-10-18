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
    public partial class FrmEliminar : Form
    {
        public ListaProductos lista;
        public FrmEliminar(ListaProductos lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void FrmEliminarcs_Load(object sender, EventArgs e)
        {
            PublicarProductos();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lsBProductos.SelectedIndex;

            if (indice >= 0)
            {

                Producto producto = this.lista.ListaDeProductos[indice];

                Eliminar(producto);
                PublicarProductos();
            }



        }
        public void PublicarProductos()
        {
            this.lsBProductos.Items.Clear();
            foreach (Producto p in this.lista.ListaDeProductos)
            {
                lsBProductos.Items.Add(p);
            }
        }
        public bool Eliminar(Producto p)
        {
            return lista - p;
        }
    }

}
