using Control_de_ingresos;
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

            ListaProductos listaDeProductos = Producto.Deserializar(path);
            foreach (Producto p in listaDeProductos.ListaDeProductos)
            {
                lstProductos.Items.Add(p);
                lstProductos.Items.Add("\n");
            }


        }
    }
}
