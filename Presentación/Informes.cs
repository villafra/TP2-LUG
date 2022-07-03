using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Calculo;
using Estética;

namespace Presentación
{
    public partial class frmInformes : Form
    {
        BLL_Login oBLL_Login;
        BLL_Turno oBLL_Turno;
        BLL_Mozo oBLL_Mozo;
        public frmInformes()
        {
            InitializeComponent();
            oBLL_Login = new BLL_Login();
            oBLL_Turno = new BLL_Turno();
            oBLL_Mozo = new BLL_Mozo();
            Calculos.DataSourceCombo(comboTurno, oBLL_Turno.Listar(), "NombreTurno");
            Calculos.DataSourceCombo(ComboEmpleado, oBLL_Mozo.Listartodo(), null);
            ActualizarListado();
            Aspecto.FormatearDGV(dgvHistórico);
            Aspecto.FormatearGRP(grpFiltrar);
        }

      

        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado());
            Aspecto.DGVLogins(dgvHistórico);
        }
       
        private void btnBuscarXML_Click(object sender, EventArgs e)
        {
            ElegirQuery();
            
        }

        private void ElegirQuery()
        {

            if (chkFecha.Checked)
            {
                if (dtpFechaInicio.Value.Date == dtpFechaFin.Value.Date)
                {
                    Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado(dtpFechaInicio.Value.Date));
                }
                else
                {
                    Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado(dtpFechaInicio.Value.Date, dtpFechaFin.Value.Date));
                }
            }
            else
            {
                if (comboTurno.Text == "" && ComboEmpleado.Text != "")
                {
                    Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado((ComboEmpleado.SelectedItem as BE_Empleado)));
                }
                else if (ComboEmpleado.Text == "" && comboTurno.Text != "")
                {
                    Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado((comboTurno.SelectedItem as BE_Turno)));
                }
                else if (comboTurno.Text == "" && ComboEmpleado.Text == "")
                {
                    Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado());
                }
                else
                {
                    Calculos.MsgBox("Por favor ingrese sólo un filtro por vez.");
                }
            }
            Aspecto.DGVLogins(dgvHistórico);
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.Checked)
            {
                comboTurno.Enabled = false;
                ComboEmpleado.Enabled = false;
            }
            else
            {
                comboTurno.Enabled = true;
                ComboEmpleado.Enabled = true;
            }
        }

        private void frmInformes_Activated(object sender, EventArgs e)
        {
            ActualizarListado();
        }
    }
}
