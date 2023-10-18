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
    public partial class FrmGaseosaPorMayor : FrmAgregarProducto
    {
        public FrmGaseosaPorMayor(ListaProductos lista) : base(lista)
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string marca = base.VerificarMarca();
            bool chancho = VerificarArtesanal();
            bool nombre = base.VerificarNombreTipo();

            if (marca != "no" && chancho && nombre)
            {

                GaseosaPorMayor gaseosaPorMayor = new GaseosaPorMayor(base.txtNombre.Text, base.txtTipo.Text, (EMarca)Enum.Parse(typeof(EMarca), marca), (int)base.nUDCantidad.Value, (float)base.nUDPrecio.Value, (float)this.nUDMLL.Value, this.txtSabor.Text, (int)this.nUDUnidades.Value);

                if (base.Comparar(gaseosaPorMayor))
                {
                    MessageBox.Show($"El producto que intenta ingresar ya existe", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    base.agregar(gaseosaPorMayor);
                    base.LimpiarCampos();
                }
            }
        }
        private bool VerificarArtesanal()
        {
            bool valor = false;

            if (this.txtArtesanal.Text == "Si" || this.txtArtesanal.Text == "No")
            {
                valor = true;
            }
            else
            {
                MessageBox.Show($"Debe responder con Si/No tiene chancho.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            return valor;
        }
    }
}
