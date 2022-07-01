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
        BE_Login oBE_Login;
        BLL_Turno oBLL_Turno;
        BLL_Mozo oBLL_Mozo;
        public frmInformes()
        {
            InitializeComponent();
            oBLL_Login = new BLL_Login();
            oBLL_Turno = new BLL_Turno();
            oBLL_Mozo = new BLL_Mozo();
            Calculos.DataSourceCombo(comboTurno, oBLL_Turno.Listar(), "NombreTurno");
            Calculos.DataSourceCombo(ComboEmpleado, oBLL_Mozo.Listartodo(), "Empleado");
            ActualizarListado();
            Aspecto.FormatearDGV(dgvHistórico);
            Aspecto.FormatearGRP(grpFiltrar);
        }

        private void Nuevo()
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void Viejo()
        {
            try
            {
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado());
            //Aspecto.DGVMozos(dgvHistórico);
        }
       
        private void dgvMozos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                
            }
            catch { }
        }

        private void btnBuscarXML_Click(object sender, EventArgs e)
        {
            //Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado((ComboEmpleado.SelectedItem as BE_Empleado)));
            //Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado((comboTurno.SelectedItem as BE_Turno)));
            Calculos.RefreshGrilla(dgvHistórico, oBLL_Login.DevolverListado(dtpFechaIngreso.Value.Date));
        }
    }
}
