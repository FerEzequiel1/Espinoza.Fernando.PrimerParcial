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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = VerificarMarca();
            if (marca != "no")
            {
                Gaseosa gaseosa = new Gaseosa(this.txtNombre.Text, this.txtTipo.Text, (EMarca)Enum.Parse(typeof(EMarca), marca), (int)this.nUDCantidad.Value, (float)this.nUDPrecio.Value, (float)this.nUDMililitros.Value, this.txtSabor.Text);
                agregar(gaseosa);
                LimpiarCampos();

            }
        }
        public bool agregar(Producto p)
        {
            return lista + p;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string VerificarMarca()
        {
            string rta = "no";

            if (cmbMarca.SelectedItem != null)
            {
                rta = cmbMarca.SelectedItem.ToString();

            }

            return rta;
        }
        private void LimpiarCampos()
        {

            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.GroupBox grupo)
                {
                    foreach (Control control1 in grupo.Controls)
                    {
                        if (control1 is System.Windows.Forms.TextBox textBox)
                        {
                            textBox.Text = "";
                        }
                        else if (control1 is System.Windows.Forms.NumericUpDown numerico)
                        {
                            numerico.Value = 1;
                        }
                        else
                        {
                            cmbMarca.Text = "Ingrese una opción";
                        }

                    }
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
