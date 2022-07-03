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
using Microsoft.VisualBasic;

namespace Presentación
{
    public partial class frmPlatos : Form
    {
        BLL_Plato oBLL_Plato;
        BE_Plato oBE_Plato;
        BLL_Pedido oBLL_Pedido;
        public frmPlatos()
        {
            InitializeComponent();
            oBE_Plato = new BE_Plato();
            oBLL_Plato = new BLL_Plato();
            oBLL_Pedido = new BLL_Pedido();
            ActualizarListado();
            Calculos.DataSourceCombo(ComboTipo, Enum.GetNames(typeof(BE_Plato.Tipo)), "TipoPlatos");
            Calculos.DataSourceCombo(ComboClase, Enum.GetNames(typeof(BE_Plato.Clasificación)), "ClasiPlatos");
            Aspecto.FormatearDGV(dgvPlatos);
            Aspecto.FormatearDGV(dgvPedidosConPlat);
            Aspecto.FormatearGRP(grpPlatos);

        }

        private void Nuevo()
        {
            try
            {
                oBE_Plato.Codigo = 0;
                oBE_Plato.Tipo_Plato = (BE_Plato.Tipo)Enum.Parse(typeof(BE_Plato.Tipo), ComboTipo.Text);
                oBE_Plato.Nombre = txtNombre.Text;
                oBE_Plato.Clasificacion= (BE_Plato.Clasificación)Enum.Parse(typeof(BE_Plato.Clasificación), ComboClase.Text);
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
                oBE_Plato.Tipo_Plato = (BE_Plato.Tipo)Enum.Parse(typeof(BE_Plato.Tipo), ComboTipo.Text);
                oBE_Plato.Nombre = txtNombre.Text;
                oBE_Plato.Clasificacion = (BE_Plato.Clasificación)Enum.Parse(typeof(BE_Plato.Clasificación), ComboClase.Text);
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
            try {Aspecto.DGVPlatos(dgvPlatos); }
            catch { }
        }

        private void dgvPlatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBE_Plato = (BE_Plato)dgvPlatos.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = oBE_Plato.Codigo.ToString();
                txtNombre.Text = oBE_Plato.Nombre;
                ComboTipo.Text = oBE_Plato.Tipo_Plato.ToString();
                ComboClase.Text = oBE_Plato.Clasificacion.ToString();
                txtCosto.Text = oBE_Plato.CostoUnitario.ToString();
                txtStock.Text = oBE_Plato.Stock.ToString();
                double promedio = oBLL_Plato.PromedioPlatoEnPedido(oBE_Plato);
                lblCantidad.Text = promedio.ToString() + "%";
                prgFrecuencia.Value = Convert.ToInt32(Math.Round(promedio, 0));
                Calculos.RefreshGrilla(dgvPedidosConPlat, oBLL_Pedido.PlatoEnPedidos(oBE_Plato));
                Aspecto.DGVPedidosXPlatos(dgvPedidosConPlat);
            }
            catch { }
        }

        private void btnNuevoPlato_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                if (!oBLL_Plato.Existe(oBE_Plato))
                {
                    if (oBLL_Plato.Guardar(oBE_Plato))
                    {
                        Calculos.BorrarCampos(grpPlatos);
                        Calculos.MsgBoxAlta(oBE_Plato.Nombre);
                    }
                    else
                    {
                        Calculos.MsgBoxNoAlta(oBE_Plato.Nombre);
                    }
                }
                else
                {
                    Calculos.MsgBoxSiExiste(oBE_Plato.Nombre);
                }
                
                
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
            finally
            {
                ActualizarListado();
            }
        }

        private void btnModificarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                Viejo();
                if (!oBLL_Plato.Existe(oBE_Plato))
                {
                    if (oBLL_Plato.Guardar(oBE_Plato))
                    {
                        Calculos.BorrarCampos(grpPlatos);
                        Calculos.MsgBoxMod(oBE_Plato.Nombre);
                    }
                    else
                    {
                        Calculos.MsgBoxNoMod(oBE_Plato.Nombre);
                    }
                }
                else
                {
                    Calculos.MsgBoxSiExiste(oBE_Plato.Nombre);
                }
                
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
            finally
            {
                ActualizarListado();
            }
        }

        private void btnEliminarPlato_Click(object sender, EventArgs e)
        {
            Viejo();
            try
            {
                if (Calculos.EstaSeguro("Eliminar", oBE_Plato.Codigo, oBE_Plato.Nombre))
                {
                    if (!oBLL_Plato.ExisteActivo(oBE_Plato))
                    {
                        if (oBLL_Plato.Baja(oBE_Plato))
                        {
                            Calculos.BorrarCampos(grpPlatos);
                            Calculos.MsgBoxBaja(oBE_Plato.Nombre);
                        }
                        else
                        {
                            Calculos.MsgBoxNoBaja(oBE_Plato.Nombre);
                        }
                    }
                    else
                    {
                        Calculos.MsgBoxBajaNegativa(oBE_Plato.Nombre);

                    }
                }
            }
            catch(Exception ex)
            {
                Calculos.MsgBox(ex.Message);
            }
            finally
            {
                ActualizarListado();
            }
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (Calculos.EstaSeguro("Agregar Stock de Plato", oBE_Plato.Codigo, oBE_Plato.ToString()))
                {
                    int Cantidad;
                    bool numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                    while (!numero)
                    {
                        numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                    }
                    oBE_Plato.AgregarStock(Cantidad);
                    oBLL_Plato.Guardar(oBE_Plato);
                    Calculos.MsgBox("Stock Agregado");
                }
            }
            catch (Exception ex){ Calculos.MsgBox(ex.Message); }
            finally
            {
                ActualizarListado();
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarLetras(e);
        }

        private void frmPlatos_Activated(object sender, EventArgs e)
        {
            ActualizarListado();
        }
    }
}
