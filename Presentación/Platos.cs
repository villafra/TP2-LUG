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
    public partial class frmPlatos : Form
    {
        BLL_Plato oBLL_Plato;
        BE_Plato oBE_Plato;
        public frmPlatos()
        {
            InitializeComponent();
            oBE_Plato = new BE_Plato();
            oBLL_Plato = new BLL_Plato();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvPlatos);
            Aspecto.FormatearGRP(grpPlatos);

        }

        private void Nuevo()
        {
            try
            {
                oBE_Plato.Codigo = 0;
                oBE_Plato.Tipo = ComboTipo.SelectedItem.ToString();
                oBE_Plato.Nombre = txtNombre.Text;
                oBE_Plato.Clase= ComboClase.SelectedItem.ToString();
                oBE_Plato.CostoUnitario = Convert.ToDecimal(txtCosto.Text);
                oBE_Plato.Stock = 0;


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
                oBE_Plato.Codigo = Convert.ToInt32(txtCodigo.Text);
                oBE_Plato.Tipo = ComboTipo.SelectedItem.ToString();
                oBE_Plato.Nombre = txtNombre.Text;
                oBE_Plato.Clase = ComboClase.Text;
                oBE_Plato.CostoUnitario = Convert.ToDecimal(txtCosto.Text);
                oBE_Plato.Stock = Convert.ToInt32(txtStock.Text);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvPlatos, oBLL_Plato.Listar());
            Aspecto.DGVPlatos(dgvPlatos);
        }

        private void dgvPlatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBE_Plato = (BE_Plato)dgvPlatos.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = oBE_Plato.Codigo.ToString();
                txtNombre.Text = oBE_Plato.Nombre;
                ComboTipo.Text = oBE_Plato.Tipo;
                ComboClase.Text = oBE_Plato.Clase;
                txtCosto.Text = oBE_Plato.CostoUnitario.ToString();
                txtStock.Text = oBE_Plato.Stock.ToString();
                lblCantidad.Text = oBLL_Plato.PromedioPlatoEnPedido(oBE_Plato).ToString() + "%";
                prgFrecuencia.Value = Convert.ToInt32(Math.Round(oBLL_Plato.PromedioPlatoEnPedido(oBE_Plato), 0));
                
            }
            catch { }
        }

        private void btnNuevoPlato_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                oBLL_Plato.Guardar(oBE_Plato);
                ActualizarListado();
                Calculos.BorrarCampos(grpPlatos);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnModificarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                Viejo();
                oBLL_Plato.Guardar(oBE_Plato);
                ActualizarListado();
                Calculos.BorrarCampos(grpPlatos);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnEliminarPlato_Click(object sender, EventArgs e)
        {
            Viejo();
            if (Calculos.EstaSeguro("Eliminar", oBE_Plato.Codigo, oBE_Plato.ToString()))
            {
                if (oBLL_Plato.Baja(oBE_Plato) == false)
                {
                    Calculos.MsgBox("No se puede dar de baja un plato dentro de un pedido activo");
                }
                else
                {
                    ActualizarListado();
                    Calculos.BorrarCampos(grpPlatos);
                }

            }
        }
    }
}
