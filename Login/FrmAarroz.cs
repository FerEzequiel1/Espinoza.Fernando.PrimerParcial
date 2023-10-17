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
    public partial class FrmAarroz : FrmGaseosa
    {

        public FrmAarroz(Usuario usuario,ListaProductos lista):base(usuario,lista)
        {
            InitializeComponent();
        }
    }
}
