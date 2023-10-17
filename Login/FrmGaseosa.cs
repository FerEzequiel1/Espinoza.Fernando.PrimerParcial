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
            bool nombre = base.VerificarNombreTipo();

            if (marca != "no" && nombre)
            {
                Gaseosa gaseosa = new Gaseosa(base.txtNombre.Text,base.txtTipo.Text, (EMarca)Enum.Parse(typeof(EMarca), marca),(int)base.nUDCantidad.Value,(float)base.nUDPrecio.Value,(float)this.nUDMililitros.Value,this.txtSabor.Text);

                if (base.Comparar(gaseosa))
                {
                    MessageBox.Show($"El producto que intenta ingresar ya existe", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    base.agregar(gaseosa);
                    base.LimpiarCampos();
                }
            }
        }
    }
}
