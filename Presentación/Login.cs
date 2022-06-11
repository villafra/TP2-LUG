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
using Calculo;

namespace Presentación
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Aspecto.FormatearLogin(this, grpLogin, this.Width, this.Height);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Hide();
            frm.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Calculos.Salir();
        }
    }
}
