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
        BLL_Mozo oBLL_Mozo;
        BE_Mozo oBE_Mozo;
        BLL_Turno oBLL_Turno;
        BE_Turno oBE_Turno;
        public frmInformes()
        {
            InitializeComponent();
            oBLL_Mozo = new BLL_Mozo();
            oBE_Mozo = new BE_Mozo();
            oBLL_Turno = new BLL_Turno();
            oBE_Turno = new BE_Turno();
            Calculos.DataSourceCombo(comboTurno, oBLL_Turno.Listar(), "NombreTurno");
            ActualizarListado();
            Aspecto.FormatearDGV(dgvMozos);
            Aspecto.FormatearGRP(grpMozos);
        }

        private void Nuevo()
        {
            try
            {
                oBE_Mozo.Codigo = 0;
                oBE_Mozo.DNI = Int32.Parse(txtDNI.Text);
                oBE_Mozo.Nombre = txtNombre.Text;
                oBE_Mozo.Apellido = txtApellido.Text;
                oBE_Mozo.FechaNacimiento = dtpFechaNacimiento.Value;
                oBE_Mozo.Edad = oBE_Mozo.CalcularAños(oBE_Mozo.FechaNacimiento);
                oBE_Mozo.FechaIngreso = dtpFechaIngreso.Value;
                oBE_Mozo.Antiguedad = oBE_Mozo.CalcularAños(oBE_Mozo.FechaIngreso);
                oBE_Mozo.Turno = (BE_Turno)comboTurno.SelectedItem;
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
                oBE_Mozo.Codigo = Convert.ToInt32(txtLegajo.Text);
                oBE_Mozo.DNI = Int32.Parse(txtDNI.Text);
                oBE_Mozo.Nombre = txtNombre.Text;
                oBE_Mozo.Apellido = txtApellido.Text;
                oBE_Mozo.FechaNacimiento = dtpFechaNacimiento.Value;
                oBE_Mozo.Edad = oBE_Mozo.CalcularAños(oBE_Mozo.FechaNacimiento);
                oBE_Mozo.FechaIngreso = dtpFechaIngreso.Value;
                oBE_Mozo.Antiguedad = oBE_Mozo.CalcularAños(oBE_Mozo.FechaIngreso);
                oBE_Mozo.Turno = (BE_Turno)comboTurno.SelectedItem;
                oBLL_Mozo.Guardar(oBE_Mozo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvMozos, oBLL_Mozo.Listar());
            Aspecto.DGVMozos(dgvMozos);
        }
        private void btnNuevaMozo_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                if (Calculos.LargoDNI(oBE_Mozo.DNI.ToString())&&Calculos.ValidarNombrePersonal(oBE_Mozo.Nombre)&&Calculos.ValidarApellido(oBE_Mozo.Apellido))
                {
                    oBLL_Mozo.Guardar(oBE_Mozo);
                    ActualizarListado();
                    Calculos.BorrarCampos(grpMozos);
                }
                else
                {
                    Calculos.MsgBox("El DNI no tiene el formato correcto");
                }
 
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnModificarMozo_Click(object sender, EventArgs e)
        {
            try
            {
                Viejo();
                oBLL_Mozo.Guardar(oBE_Mozo);
                ActualizarListado();
                Calculos.BorrarCampos(grpMozos);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void dgvMozos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBE_Mozo = (BE_Mozo)dgvMozos.SelectedRows[0].DataBoundItem;
                txtLegajo.Text = oBE_Mozo.Codigo.ToString();
                txtDNI.Text = oBE_Mozo.DNI.ToString();
                txtNombre.Text = oBE_Mozo.Nombre;
                txtApellido.Text = oBE_Mozo.Apellido;
                dtpFechaNacimiento.Value = oBE_Mozo.FechaNacimiento;
                dtpFechaIngreso.Value = oBE_Mozo.FechaIngreso;
                comboTurno.Text = oBE_Mozo.Turno.NombreTurno;
                int rank = oBLL_Mozo.DevolverPuntuacion(oBE_Mozo);
                lblPuntuación.Text = rank.ToString();
                prgBaRanking.Value = rank;
                
            }
            catch { }
        }

        private void btnEliminarMozo_Click(object sender, EventArgs e)
        {
            Viejo();
            if (Calculos.EstaSeguro("Eliminar", oBE_Mozo.Codigo, oBE_Mozo.ToString()))
            {
                oBLL_Mozo.Baja(oBE_Mozo);
                ActualizarListado();
                Calculos.BorrarCampos(grpMozos);
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarEntero(e);
        }
    }
}
