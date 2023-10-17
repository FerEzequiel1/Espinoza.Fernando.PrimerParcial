using Control_de_ingresos;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class FrmInicio : Form
    {
        internal Usuario usuario;
        public ListaProductos listaDeProductos;
        public FrmInicio()
        {
            InitializeComponent();
        }
        public FrmInicio(Usuario usuario) : this()
        {
            this.usuario = usuario;
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = this.usuario.ToString();



            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Mayorista Trapal";

            this.listaDeProductos = Producto.Deserializar(path);

            PublicarProductos();


        }

        private void gaseosaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmGaseosa frmGaseosa = new FrmGaseosa();
            frmGaseosa.ShowDialog();



        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rbCantidad.Checked && rbMayor.Checked)
            {
                listaDeProductos.OrdenPorPrecioCantidad("Descendente", "Cantidad");
            }
            else if (rbCantidad.Checked && !rbMayor.Checked)
            {
                listaDeProductos.OrdenPorPrecioCantidad("Ascendente", "Cantidad");

            }
            else if (!rbCantidad.Checked && rbMayor.Checked)
            {
                listaDeProductos.OrdenPorPrecioCantidad("Descendente", "Precio total");
            }
            else
            {
                listaDeProductos.OrdenPorPrecioCantidad("Ascendente", "Precio total");
            }

            lstProductos.Items.Clear();
            PublicarProductos();
        }

        public void PublicarProductos()
        {
            foreach (Producto p in this.listaDeProductos.ListaDeProductos)
            {
                lstProductos.Items.Add(p);
                lstProductos.Items.Add("\n");
            }
        }
    }
}
