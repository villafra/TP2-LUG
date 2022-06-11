using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

using BE;
using BLL;
using Calculo;
using Estética;

namespace Presentación
{
    public partial class frmBebidas : Form
    {
        BLL_Bebida oBLL_Bebida;
        BLL_Bebida_Alcohólica oBLL_Bebida_Alcohólica;
        BE_Bebida oBE_Bebida;
        BE_Bebida_Alcohólica oBE_Bebida_Alcohólica;
        public frmBebidas()
        {
            InitializeComponent();
            oBLL_Bebida = new BLL_Bebida();
            oBLL_Bebida_Alcohólica = new BLL_Bebida_Alcohólica();
            oBE_Bebida = new BE_Bebida();
            oBE_Bebida_Alcohólica = new BE_Bebida_Alcohólica();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvBebidas);
            Aspecto.FormatearGRP(grpBebidas);
        }

        private void Nuevo()
        {
            try
            {
                if (txtABV.Text == "")
                {
                    oBE_Bebida.Codigo = 0;
                    oBE_Bebida.Nombre = txtNombre.Text;
                    oBE_Bebida.Tipo = comboTipo.SelectedItem.ToString();
                    oBE_Bebida.Presentación = txtPresentacion.Text;
                    oBE_Bebida.CostoUnitario = Convert.ToDecimal(txtPrecio.Text);
                    oBE_Bebida.Stock = 0;
                }
                else
                {
                    oBE_Bebida_Alcohólica.Codigo = 0;
                    oBE_Bebida_Alcohólica.Nombre = txtNombre.Text;
                    oBE_Bebida_Alcohólica.Tipo = comboTipo.SelectedItem.ToString();
                    oBE_Bebida_Alcohólica.Presentación = txtPresentacion.Text;
                    oBE_Bebida_Alcohólica.CostoUnitario = Convert.ToDecimal(txtPrecio.Text);
                    oBE_Bebida_Alcohólica.GraduaciónAlcoholica = Convert.ToDecimal(txtABV.Text);
                    oBE_Bebida_Alcohólica.Stock = 0;
                }
                

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
                if (txtABV.Text == "")
                {
                    oBE_Bebida.Codigo = Convert.ToInt32(txtCodigo.Text);
                    oBE_Bebida.Nombre = txtNombre.Text;
                    oBE_Bebida.Tipo = comboTipo.SelectedItem.ToString();
                    oBE_Bebida.Presentación = txtPresentacion.Text;
                    oBE_Bebida.CostoUnitario = Convert.ToDecimal(txtPrecio.Text);
                    oBE_Bebida.Stock = Convert.ToInt32(lblCantidad.Text);
                }
                else
                {
                    oBE_Bebida_Alcohólica.Codigo = Convert.ToInt32(txtCodigo.Text);
                    oBE_Bebida_Alcohólica.Nombre = txtNombre.Text;
                    oBE_Bebida_Alcohólica.Tipo = comboTipo.SelectedItem.ToString();
                    oBE_Bebida_Alcohólica.Presentación = txtPresentacion.Text;
                    oBE_Bebida_Alcohólica.CostoUnitario = Convert.ToDecimal(txtPrecio.Text);
                    oBE_Bebida_Alcohólica.GraduaciónAlcoholica = Convert.ToDecimal(txtABV.Text);
                    oBE_Bebida_Alcohólica.Stock = Convert.ToInt32(lblCantidad.Text);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvBebidas, oBLL_Bebida.Listar());
            Aspecto.DGVBebidas(dgvBebidas);
        }

        private void btnNuevaBebida_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                if (txtABV.Text == "")
                {
                    oBLL_Bebida.Guardar(oBE_Bebida);
                }
                else
                {
                    oBLL_Bebida_Alcohólica.Guardar(oBE_Bebida_Alcohólica);
                }
                ActualizarListado();
                Calculos.BorrarCampos(grpBebidas);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnModificarBebida_Click(object sender, EventArgs e)
        {
            try
            {
                Viejo();
                if (txtABV.Text == "")
                {
                    oBLL_Bebida.Guardar(oBE_Bebida);
                }
                else
                {
                    oBLL_Bebida_Alcohólica.Guardar(oBE_Bebida_Alcohólica);
                }
                ActualizarListado();
                Calculos.BorrarCampos(grpBebidas);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnEliminarBebida_Click(object sender, EventArgs e)
        {
            Viejo();
            if (txtABV.Text == "")
            {
                if (Calculos.EstaSeguro("Eliminar", oBE_Bebida.Codigo, oBE_Bebida.ToString()))
                {
                    oBLL_Bebida.Baja(oBE_Bebida);
                    ActualizarListado();
                    Calculos.BorrarCampos(grpBebidas);
                }
            }
            else
            {
                if (Calculos.EstaSeguro("Eliminar", oBE_Bebida_Alcohólica.Codigo, oBE_Bebida_Alcohólica.ToString()))
                {
                    oBLL_Bebida_Alcohólica.Baja(oBE_Bebida_Alcohólica);
                    ActualizarListado();
                    Calculos.BorrarCampos(grpBebidas);
                }
            }
        }

        private void dgvBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBebidas.SelectedRows[0].Cells[2].Value.ToString() == "Alcoholica")
                {
                    oBE_Bebida_Alcohólica = (BE_Bebida_Alcohólica)dgvBebidas.SelectedRows[0].DataBoundItem;
                    txtCodigo.Text = oBE_Bebida_Alcohólica.Codigo.ToString();
                    txtNombre.Text = oBE_Bebida_Alcohólica.Nombre;
                    txtPrecio.Text = oBE_Bebida_Alcohólica.CostoUnitario.ToString();
                    txtABV.Text = oBE_Bebida_Alcohólica.GraduaciónAlcoholica.ToString();
                    comboTipo.Text = oBE_Bebida_Alcohólica.Tipo.ToString();
                    txtPresentacion.Text = oBE_Bebida_Alcohólica.Presentación;
                    lblCantidad.Text = oBE_Bebida_Alcohólica.Stock.ToString();
                    prgCantidad.Value = oBE_Bebida_Alcohólica.Stock;
                }
                else
                {
                    oBE_Bebida = (BE_Bebida)dgvBebidas.SelectedRows[0].DataBoundItem;
                    txtCodigo.Text = oBE_Bebida.Codigo.ToString();
                    txtNombre.Text = oBE_Bebida.Nombre;
                    txtPrecio.Text = oBE_Bebida.CostoUnitario.ToString();
                    comboTipo.Text = oBE_Bebida.Tipo.ToString();
                    txtPresentacion.Text = oBE_Bebida.Presentación;
                    lblCantidad.Text = oBE_Bebida.Stock.ToString();
                    txtABV.Text = "";
                    prgCantidad.Value = oBE_Bebida.Stock;
                }



            }
            catch { }
        }

        private void comboTipo_TextChanged(object sender, EventArgs e)
        {
            if (comboTipo.Text == "Alcoholica")
            {
                txtABV.Enabled = true;
            }
            else
            {
                txtABV.Enabled = false;
            }
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboTipo.Text == "Alcoholica")
                {
                    oBE_Bebida_Alcohólica = (BE_Bebida_Alcohólica)dgvBebidas.SelectedRows[0].DataBoundItem;
                    if (Calculos.EstaSeguro("Agregar Stock de Bebida", oBE_Bebida_Alcohólica.Codigo, oBE_Bebida_Alcohólica.ToString()))
                    {
                        int Cantidad;
                        bool numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                        while (!numero)
                        {
                            numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                        }
                        oBE_Bebida_Alcohólica.AgregarStock(Cantidad);
                        oBLL_Bebida_Alcohólica.Guardar(oBE_Bebida_Alcohólica);

                    }
                }
                else
                {
                    oBE_Bebida = (BE_Bebida)dgvBebidas.SelectedRows[0].DataBoundItem;
                    if (Calculos.EstaSeguro("Agregar Stock de Bebida", oBE_Bebida.Codigo, oBE_Bebida.ToString()))
                    {
                        int Cantidad;
                        bool numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                        while (!numero)
                        {
                            numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                        }
                        oBE_Bebida.AgregarStock(Cantidad);
                        oBLL_Bebida.Guardar(oBE_Bebida);
                        Calculos.MsgBox("Stock Agregado");
                    }
                }
            }
            catch { }
            finally
            {
                ActualizarListado();
            }
        }
    }
}
