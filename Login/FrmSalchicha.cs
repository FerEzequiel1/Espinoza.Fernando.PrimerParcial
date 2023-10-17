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
    public partial class FrmSalchicha : FrmAgregarProducto
    {
        public FrmSalchicha(ListaProductos lista) : base(lista)
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = base.VerificarMarca();
            bool chancho = VerificarChancho();
            bool nombre = base.VerificarNombreTipo();

            if (marca != "no" && chancho && nombre)
            {
                Salchicha salchicha = new Salchicha(base.txtNombre.Text, base.txtTipo.Text, (EMarca)Enum.Parse(typeof(EMarca), marca), (int)base.nUDCantidad.Value, (float)base.nUDPrecio.Value, (int)this.nUDUnidades.Value, this.txtChancho.Text);
                base.agregar(salchicha);
                base.LimpiarCampos();
            }
        }
        private bool VerificarChancho()
        {
            bool valor = false;

            if (this.txtChancho.Text == "si" || this.txtChancho.Text == "no")
            {
                valor = true;  
            }
            else
            {
                MessageBox.Show($"Debe responder con si/no tiene chancho.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            return valor;

        }
    }
}
