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
    public partial class frmPedidos : Form
    {
        BLL_Pedido oBLL_Pedido;
        BE_Pedido oBE_Pedido;
        BLL_Plato oBLL_Plato;
        BE_Plato oBE_Plato;
        BLL_Bebida oBLL_Bebida;
        BE_Bebida oBE_Bebida;
        public frmPedidos()
        {
            InitializeComponent();
            oBLL_Pedido = new BLL_Pedido();
            oBE_Pedido = new BE_Pedido();
            oBLL_Bebida = new BLL_Bebida();
            oBLL_Plato = new BLL_Plato();
            oBE_Bebida = new BE_Bebida();
            oBE_Plato = new BE_Plato();
            Aspecto.FormatearDGV(dgvPedidos);
            Aspecto.FormatearDGV(dgvBebidas);
            Aspecto.FormatearDGV(dgvPlatos);
            Aspecto.FormatearDGV(dgvMozo);
            Aspecto.FormatearDGV(dgvMesa);
            Aspecto.FormatearControlInterno(lblCancelarPedido);
            Aspecto.FormatearControlInterno(lblCerrarPedido);
            Aspecto.FormatearControlInterno(lblCosto);
            ActualizarListado();
        }
        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvPedidos, oBLL_Pedido.Listar());
            Aspecto.DGVPedidos(dgvPedidos);
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<BE_Mozo> mozo = new List<BE_Mozo>();
            List<BE_Mesa> mesa = new List<BE_Mesa>();
            try
            {
                oBE_Pedido = (BE_Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;
                Calculos.RefreshGrilla(dgvBebidas,oBE_Pedido.Bebidas);
                Calculos.RefreshGrilla(dgvPlatos,oBE_Pedido.Platos);
                mozo.Add(oBE_Pedido.CodigoMozo);
                Calculos.RefreshGrilla(dgvMozo, mozo);
                mesa.Add(oBE_Pedido.CodigoMesa);
                Calculos.RefreshGrilla(dgvMesa, mesa);
                Aspecto.DGVBebidasPedidos(dgvBebidas);
                Aspecto.DGVPlatosPedidos(dgvPlatos);
                Aspecto.DGVMozoXPedido(dgvMozo);
                Aspecto.DGVMesaXPedido(dgvMesa);
            }
            catch { }
            
        }

        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                oBE_Pedido = (BE_Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;
                oBLL_Pedido.CalcularMonto(oBE_Pedido);
                oBLL_Pedido.Guardar(oBE_Pedido);
                ActualizarListado();
            }
            catch { }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            try
            {         
                oBE_Pedido = (BE_Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;
                if (Calculos.EstaSeguro("Cancelar Pedido", oBE_Pedido.Codigo, oBE_Pedido.ToString()))
                {
                    oBLL_Pedido.Baja(oBE_Pedido);
                    ActualizarListado();
                }

                
            }
            catch { }
        }

        private void btnActualizarCosto_Click(object sender, EventArgs e)
        {
            try
            {
                oBE_Pedido = (BE_Pedido)dgvPedidos.SelectedRows[0].DataBoundItem;
                oBLL_Pedido.CalcularMonto(oBE_Pedido);
                ActualizarListado();
            }
            catch
            {

            }

        }
    }
}
