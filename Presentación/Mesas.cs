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
    public partial class frmMesas : Form
    {
        BLL_Mesa oBLL_Mesa;
        BE_Mesa oBE_Mesa;
        public frmMesas()
        {
            InitializeComponent();
            oBE_Mesa = new BE_Mesa();
            oBLL_Mesa = new BLL_Mesa();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvMesas);
            Aspecto.FormatearGRP(grpMesas);
        }

        private void Nuevo()
        {
            try
            {
                oBE_Mesa.Codigo = 0;
                oBE_Mesa.NroDeMesa = Convert.ToInt32(txtNumeroMesa.Text);
                oBE_Mesa.Capacidad = Convert.ToInt32(txtCapacidad.Text);
                oBE_Mesa.Estado = VerChecked(rdbDisponible, RdbOcupada, rdbReservada).Text;
                oBE_Mesa.CantidadComensales = 0;


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
                oBE_Mesa.Codigo = Convert.ToInt32(txtCodigoMesa.Text);
                oBE_Mesa.NroDeMesa = Convert.ToInt32(txtNumeroMesa.Text);
                oBE_Mesa.Capacidad = Convert.ToInt32(txtCapacidad.Text);
                oBE_Mesa.Estado = VerChecked(rdbDisponible, RdbOcupada, rdbReservada).Text;
                oBE_Mesa.CantidadComensales = prgBarOcupación.Value;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvMesas, oBLL_Mesa.Listar());
            Aspecto.DGVMesas(dgvMesas);
        }

        private RadioButton VerChecked(RadioButton rdbDisponible, RadioButton RdbOcupada, RadioButton rdbReservada)
        {
            if (rdbDisponible.Checked == true)
            {
                return rdbDisponible;
            }
            else if (RdbOcupada.Checked == true)
            {
                return RdbOcupada;
            }
            else
            {
                return rdbReservada;
            }
        }

        private void btnNuevaMesa_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                oBLL_Mesa.Guardar(oBE_Mesa);
                ActualizarListado();
                Calculos.BorrarCampos(grpMesas);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnModificarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                Viejo();
                oBLL_Mesa.Guardar(oBE_Mesa);
                ActualizarListado();
                Calculos.BorrarCampos(grpMesas);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {
            Viejo();
            if (Calculos.EstaSeguro("Eliminar", oBE_Mesa.Codigo, oBE_Mesa.ToString()))
            {
                if (oBLL_Mesa.Baja(oBE_Mesa) == false)
                {
                    Calculos.MsgBox("No se puede dar de baja una mesa activa");
                }
                else
                {
                    ActualizarListado();
                    Calculos.BorrarCampos(grpMesas);
                }

            }
        }

        private void dgvMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBE_Mesa = (BE_Mesa)dgvMesas.SelectedRows[0].DataBoundItem;
                txtCodigoMesa.Text = oBE_Mesa.Codigo.ToString();
                txtNumeroMesa.Text = oBE_Mesa.NroDeMesa.ToString();
                txtCapacidad.Text = oBE_Mesa.Capacidad.ToString();
                if (oBE_Mesa.Estado == "Disponible")
                {
                    rdbDisponible.Checked = true;
                }
                else if (oBE_Mesa.Estado == "Ocupada")
                {
                    RdbOcupada.Checked = true;
                }
                else
                {
                    rdbDisponible.Checked = true;
                }
                lblPorcentaje.Text = (Math.Round((double)oBE_Mesa.CantidadComensales / oBE_Mesa.Capacidad * 100, 1)).ToString() + "%";
                prgBarOcupación.Maximum = oBE_Mesa.Capacidad;
                prgBarOcupación.Value = oBE_Mesa.CantidadComensales;

            }
            catch { }
        }
    }
}
