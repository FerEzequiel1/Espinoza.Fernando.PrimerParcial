using Control_de_ingresos;
using System.IO;
using System;
using System.Text.Json;


namespace Login
{
    public partial class FrmVerificacion : Form
    {
        private Usuario usuario;

        public Usuario UsuarioIngresante
        {
            get { return usuario; }
        }
        public FrmVerificacion()
        {
            InitializeComponent();
        }

        public FrmVerificacion(Usuario usuario) : this()
        {
            this.usuario = usuario;
            this.txtUsuario.Focus();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.usuario = this.Verificar();
            this.DialogResult = DialogResult.OK;
        }

        private Usuario Verificar()
        {
            Usuario rta = null;

            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Users\ferna\source\repos\Espinoza.Fernando.Ezequiel\DataUsuarios.json"))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;

                string json_str = sr.ReadToEnd();

                List<Usuario> users = JsonSerializer.Deserialize<List<Usuario>>(json_str, opciones);

                foreach (Usuario item in users)
                {
                    if (item.correo == this.txtUsuario.Text && item.clave == this.txtContraseña.Text)
                    {
                        rta = item;
                        break;
                    }
                }
            }
            return rta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
        }
    }
}