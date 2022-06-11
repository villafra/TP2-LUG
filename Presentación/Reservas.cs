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
    public partial class frmReservas : Form
    {
        BLL_Reserva oBLL_Reserva;
        BE_Reserva oBE_Reserva;
        BLL_Mesa oBLL_Mesa;
        BE_Mesa oBE_Mesa;
        public frmReservas()
        {
            InitializeComponent();
            oBLL_Reserva = new BLL_Reserva();
            oBE_Reserva = new BE_Reserva();
            oBLL_Mesa = new BLL_Mesa();
            oBE_Mesa = new BE_Mesa();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvReservas);
            Aspecto.FormatearDGV(dgvMesasDisponibles);
            Aspecto.FormatearControlInterno(lblAsignarMesa);
            Aspecto.FormatearControlInterno(lblCancelarReserva);
            Aspecto.FormatearControlInterno(lblEditarMesa);
        }

        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvReservas, oBLL_Reserva.Listar());
            Aspecto.DGVReservas(dgvReservas);
            Calculos.RefreshGrilla(dgvMesasDisponibles, oBLL_Mesa.ListarDisponibles());
            Aspecto.DGVMesasDisponibles(dgvMesasDisponibles);
        }

        private void btnAsignarMesa_Click(object sender, EventArgs e)
        {
            oBE_Mesa = (BE_Mesa)dgvMesasDisponibles.SelectedRows[0].DataBoundItem;
            oBE_Reserva = (BE_Reserva)dgvReservas.SelectedRows[0].DataBoundItem;
            if (oBE_Reserva.MesaReservada == null)
            {
                if (oBE_Reserva.CantidadDeComensales <= oBE_Mesa.Capacidad)
                {
                    if (oBLL_Reserva.Guardar(oBE_Reserva, oBE_Mesa))
                    {
                        oBE_Reserva.MesaReservada = oBE_Mesa;
                        ActualizarListado();
                    }

                }
                else
                {
                    Calculos.MsgBox("La Cantidad de Comensales supera la\ncapacidad máxima de la mesa elegida");
                }

            }
            else
            {
                Calculos.MsgBox("La Reserva ya tiene una mesa asignada");
            }
        }

        private void btnEditarMesa_Click(object sender, EventArgs e)
        {
            oBE_Mesa = (BE_Mesa)dgvMesasDisponibles.SelectedRows[0].DataBoundItem;
            oBE_Reserva = (BE_Reserva)dgvReservas.SelectedRows[0].DataBoundItem;
            if (oBE_Reserva.MesaReservada != null)
            {
                if (oBE_Reserva.CantidadDeComensales <= oBE_Mesa.Capacidad)
                {
                    if (oBLL_Reserva.Modificar(oBE_Reserva, oBE_Mesa))
                    {
                        oBE_Reserva.MesaReservada = oBE_Mesa;
                        ActualizarListado();
                    }

                }
                else
                {
                    Calculos.MsgBox("La Cantidad de Comensales supera la\ncapacidad máxima de la mesa elegida");
                }
            }
            else
            {
                Calculos.MsgBox("La Reserva no tiene ninguna mesa asignada para modificar.");
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            oBE_Reserva = (BE_Reserva)dgvReservas.SelectedRows[0].DataBoundItem;
            if (Calculos.EstaSeguro("Cancelar Reserva", oBE_Reserva.Codigo, oBE_Reserva.ToString()))
            {
                oBLL_Reserva.Baja(oBE_Reserva);
                ActualizarListado();
            }
        }
    }
}
