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
            DateTime fechaActual = DateTime.Now;
            this.lblUsuario.Text = $"{this.usuario.ToString()} {fechaActual.Day}/{fechaActual.Month}/{fechaActual.Year}";

            UsuariosLogeados(this.usuario);

            string path = Path();
            this.listaDeProductos = Producto.Deserializar(path);
            PublicarProductos();



        }

        private void gaseosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormulario("Gaseosa");
        }
        private void arrozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormulario("Aarroz");
        }
        private void salchichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFormulario("Salchica");
        }
        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminar frmEliminar = new FrmEliminar(this.listaDeProductos);
            frmEliminar.StartPosition = FormStartPosition.CenterScreen;
            frmEliminar.ShowDialog();

            if (frmEliminar.DialogResult == DialogResult.OK)
            {
                this.listaDeProductos = frmEliminar.lista;
            }

            PublicarProductos();
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

            PublicarProductos();
        }

        public void PublicarProductos()
        {
            lstProductos.Items.Clear();
            foreach (Producto p in this.listaDeProductos.ListaDeProductos)
            {
                lstProductos.Items.Add(p);
            }
        }

        public void CrearFormulario(string tipo)
        {
            switch (tipo)
            {
                case "Aarroz":

                    FrmAarroz frmAarroz = new FrmAarroz(this.listaDeProductos);
                    frmAarroz.StartPosition = FormStartPosition.CenterScreen;
                    frmAarroz.ShowDialog();
                    ActualizarLista(frmAarroz);
                    break;

                case "Gaseosa":

                    FrmGaseosa frmGaseosa = new FrmGaseosa(this.listaDeProductos);
                    frmGaseosa.StartPosition = FormStartPosition.CenterScreen;
                    frmGaseosa.ShowDialog();
                    ActualizarLista(frmGaseosa);
                    break;

                case "Salchica":

                    FrmSalchicha frmSalchica = new FrmSalchicha(this.listaDeProductos);
                    frmSalchica.StartPosition = FormStartPosition.CenterScreen;
                    frmSalchica.ShowDialog();
                    ActualizarLista(frmSalchica);
                    break;
            }


        }

        public void ActualizarLista(FrmAgregarProducto form)
        {
            if (form.DialogResult == DialogResult.OK)
            {
                this.listaDeProductos = form.lista;
            }
            PublicarProductos();

        }

        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {

            string path = Path();

            Producto.Serializar(this.listaDeProductos, path);
        }

        private string Path()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Mayorista Trapal";

            return path;
        }

        private void UsuariosLogeados(Usuario perfil)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\registro.log";

            try
            {
                // Abre un archivo de registro para escribir (crea uno nuevo o agrega al existente)
                using (StreamWriter logWriter = new StreamWriter(path, true))
                {
                    // Obtiene la fecha y hora actual
                    DateTime fechaHoraActual = DateTime.Now;

                    // Mensaje de registro a escribir en el archivo
                    string mensajeRegistro = $"Nombre:{perfil.nombre} Apellido:{perfil.apellido} Legajo:{perfil.legajo}  Dia de ingreso:{fechaHoraActual:yyyy-MM-dd HH:mm:ss}";

                    // Escribe el mensaje de registro en el archivo
                    logWriter.WriteLine(mensajeRegistro);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al escribir en el archivo de registro: " + ex.Message);
            }

        }

        private void historialDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\registro.log";

            FrmHistorial frmHistorial = new FrmHistorial(path);
            frmHistorial.StartPosition = FormStartPosition.CenterScreen;
            frmHistorial.Show();
            
        }
    }
}
