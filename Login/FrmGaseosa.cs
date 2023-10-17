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
    public partial class FrmGaseosa : FrmAgregarProducto
    {
        public FrmGaseosa(ListaProductos lista) : base(lista)
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = base.VerificarMarca();

            if (marca != "no")
            {
                Gaseosa gaseosa = new Gaseosa(base.txtNombre.Text,base.txtTipo.Text, (EMarca)Enum.Parse(typeof(EMarca), marca),(int)base.nUDCantidad.Value,(float)base.nUDPrecio.Value,(float)this.nUDMililitros.Value,this.txtSabor.Text);
                base.agregar(gaseosa);
                base.LimpiarCampos();
            }
        }
    }
}
