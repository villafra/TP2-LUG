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
    public partial class frmUsuarios : Form
    {
        BLL_Turno oBLL_Turno;
        BE_Turno oBE_Turno;
        public frmTurnos()
        {
            InitializeComponent();
            oBE_Turno = new BE_Turno();
            oBLL_Turno = new BLL_Turno();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvUsuarios);
            Aspecto.FormatearGRP(grpUsuarios);
            Aspecto.FormatearDGV(dgvMozosEnturno);
        }

        private void Nuevo()
        {
            try
            {
                oBE_Turno.Codigo = 0;
                oBE_Turno.NombreTurno = txtNombreTurno.Text;
                oBE_Turno.HoraInicio = dtpHoraInicio.Value;
                oBE_Turno.HoraFin = dtpHoraFin.Value;

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
                oBE_Turno.Codigo = Convert.ToInt32(txtCodigo.Text);
                oBE_Turno.NombreTurno = txtNombreTurno.Text;
                oBE_Turno.HoraInicio = dtpHoraInicio.Value;
                oBE_Turno.HoraFin = dtpHoraFin.Value;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvUsuarios, oBLL_Turno.Listar());
            Aspecto.DGVTurnos(dgvUsuarios);
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBE_Turno = (BE_Turno)dgvUsuarios.SelectedRows[0].DataBoundItem;
            txtCodigo.Text = oBE_Turno.Codigo.ToString();
            txtNombreTurno.Text = oBE_Turno.NombreTurno;
            dtpHoraInicio.Value = oBE_Turno.HoraInicio;
            dtpHoraFin.Value = oBE_Turno.HoraFin;
            lblCantidad.Text = oBLL_Turno.CantidadMozosEnTurno(oBE_Turno).ToString();
            prgCantidad.Value = oBLL_Turno.CantidadMozosEnTurno(oBE_Turno);
            Calculos.RefreshGrilla(dgvMozosEnturno, oBLL_Turno.ListarObjeto(oBE_Turno).Mozos);
            Aspecto.DGVTurnosMozos(dgvMozosEnturno);
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                oBLL_Turno.Guardar(oBE_Turno);
                ActualizarListado();
                Calculos.BorrarCampos(grpUsuarios);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnModificarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                Viejo();
                oBLL_Turno.Guardar(oBE_Turno);
                ActualizarListado();
                Calculos.BorrarCampos(grpUsuarios);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            Viejo();
            if (Calculos.EstaSeguro("Eliminar", oBE_Turno.Codigo, oBE_Turno.ToString()))
            {
                if (oBLL_Turno.Baja(oBE_Turno) == false)
                {
                    Calculos.MsgBox("No se puede dar de baja un turno con Mozos Asignados");
                }
                else
                {
                    ActualizarListado();
                    Calculos.BorrarCampos(grpUsuarios);
                }

            }
        }
    }
}
