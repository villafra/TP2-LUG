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
    public partial class frmTurnos : Form
    {
        BLL_Turno oBLL_Turno;
        BE_Turno oBE_Turno;
        BLL_Mozo oBLL_Mozo;
        public frmTurnos()
        {
            InitializeComponent();
            oBE_Turno = new BE_Turno();
            oBLL_Turno = new BLL_Turno();
            oBLL_Mozo = new BLL_Mozo();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvTurnos);
            Aspecto.FormatearGRP(grpTurnos);
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
            Calculos.RefreshGrilla(dgvTurnos, oBLL_Turno.Listar());
            Aspecto.DGVTurnos(dgvTurnos);
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBE_Turno = (BE_Turno)dgvTurnos.SelectedRows[0].DataBoundItem;
            txtCodigo.Text = oBE_Turno.Codigo.ToString();
            txtNombreTurno.Text = oBE_Turno.NombreTurno;
            dtpHoraInicio.Value = oBE_Turno.HoraInicio;
            dtpHoraFin.Value = oBE_Turno.HoraFin;
            int Cantidad = oBLL_Turno.CantidadEmpleadosEnTurno(oBE_Turno);
            lblCantidad.Text = Cantidad.ToString();
            prgCantidad.Value = Cantidad;
            Calculos.RefreshGrilla(dgvMozosEnturno, oBLL_Mozo.ListarMozosXTurno(oBE_Turno));
            try
            {
                Aspecto.DGVTurnosMozos(dgvMozosEnturno);
            }
            catch { }
           
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                if (!oBLL_Turno.Existe(oBE_Turno))
                {
                    if (oBLL_Turno.Guardar(oBE_Turno))
                    {
                        ActualizarListado();
                        Calculos.BorrarCampos(grpTurnos);
                        Calculos.MsgBoxAlta(oBE_Turno.NombreTurno);
                    }
                    else
                    {
                        Calculos.MsgBoxNoAlta(oBE_Turno.NombreTurno);
                    }
                    
                }
                else
                {
                    Calculos.MsgBoxSiExiste(oBE_Turno.NombreTurno);
                }
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
                if (!oBLL_Turno.Existe(oBE_Turno))
                {
                    if (oBLL_Turno.Guardar(oBE_Turno))
                    {
                        ActualizarListado();
                        Calculos.BorrarCampos(grpTurnos);
                        Calculos.MsgBoxMod(oBE_Turno.NombreTurno);
                    }
                    else
                    {
                        Calculos.MsgBoxNoMod(oBE_Turno.NombreTurno);
                    }
                    
                }
                else
                {
                    Calculos.MsgBoxSiExiste(oBE_Turno.NombreTurno);
                }

            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            Viejo();
            if (Calculos.EstaSeguro("Eliminar", oBE_Turno.Codigo, oBE_Turno.NombreTurno))
            {
                if (!oBLL_Turno.ExisteActivo(oBE_Turno))
                {
                    if (oBLL_Turno.Baja(oBE_Turno))
                    {
                        ActualizarListado();
                        Calculos.BorrarCampos(grpTurnos);
                        Calculos.MsgBoxBaja(oBE_Turno.NombreTurno);
                    }
                    else
                    {
                        Calculos.MsgBoxNoAlta(oBE_Turno.NombreTurno);
                    }
                    
                }
                else
                {
                    Calculos.MsgBoxBajaNegativa(oBE_Turno.NombreTurno);
                }

            }
        }

        private void txtNombreTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarLetras(e);
        }

        private void frmTurnos_Activated(object sender, EventArgs e)
        {
            ActualizarListado();
        }
    }
}
