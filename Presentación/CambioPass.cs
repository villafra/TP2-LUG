using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estética;

namespace Presentación
{
    public partial class CambioPass : Form
    {
        private string usuario;
        public CambioPass()
        {
            InitializeComponent();
            Aspecto.FormatearCambioPass(this, this.Width, this.Height);
        }
        public void Usuario(string user)
        {
            usuario = user;
            cambiarPass1.user = usuario;
        }
    }
}
