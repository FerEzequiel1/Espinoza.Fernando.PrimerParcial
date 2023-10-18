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
    public partial class FrmAarroz : FrmAgregarProducto
    {
        /// <summary>
        /// Formulario donde se va a completar los datos pedidos para poder crear un producto tipo Aarroz
        /// </summary>
        public FrmAarroz(ListaProductos lista) : base(lista)
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se verifica a travez de los métodos si cumplen con los tipos de datos correctos para la creación del producto
            string marca = base.VerificarMarca();
            bool nombre = base.VerificarNombreTipo();

            if (marca != "no" && nombre)
            {
                Arroz arroz = new Arroz(base.txtNombre.Text, base.txtTipo.Text, (EMarca)Enum.Parse(typeof(EMarca), marca), (int)base.nUDCantidad.Value, (float)base.nUDPrecio.Value, this.txtOrigen.Text, this.txtProveedor.Text);

                //Se verifica que el producto ingresado no exita en la listaDeProductos del formulario principal
                //Si esta no se agrega y se informa.Caso contrario lo agrega y se recetean los campos del formulario
                if (base.Comparar(arroz))
                {
                    MessageBox.Show($"El producto que intenta ingresar ya existe", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    base.agregar(arroz);
                    base.LimpiarCampos();
                    MessageBox.Show($"El producto ah sido ingresado con éxito", "ADMIRACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
