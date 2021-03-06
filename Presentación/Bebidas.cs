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
        BLL_Pedido oBLL_Pedido;
        public frmBebidas()
        {
            InitializeComponent();
            oBLL_Bebida = new BLL_Bebida();
            oBLL_Bebida_Alcohólica = new BLL_Bebida_Alcohólica();
            oBE_Bebida = new BE_Bebida();
            oBE_Bebida_Alcohólica = new BE_Bebida_Alcohólica();
            oBLL_Pedido = new BLL_Pedido();
            Calculos.DataSourceCombo(comboTipo, Enum.GetNames(typeof(BE_Bebida.Tipo)), "TipoBebidas");
            ActualizarListado();
            Aspecto.FormatearDGV(dgvBebidas);
            Aspecto.FormatearDGV(dgvPedidosConBeb);
            Aspecto.FormatearGRP(grpBebidas);
        }

        private void Nuevo()
        {
            try
            {
                if (comboTipo.SelectedIndex < 3)
                {
                    oBE_Bebida.Codigo = 0;
                    oBE_Bebida.Nombre = txtNombre.Text;
                    oBE_Bebida.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), comboTipo.Text);
                    oBE_Bebida.Presentación = Convert.ToDecimal(txtPresentacion.Text);
                    oBE_Bebida.CostoUnitario = Convert.ToDecimal(txtPrecio.Text);
                    oBE_Bebida.Stock = 0;
                }
                else
                {
                    oBE_Bebida_Alcohólica.Codigo = 0;
                    oBE_Bebida_Alcohólica.Nombre = txtNombre.Text;
                    oBE_Bebida_Alcohólica.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), comboTipo.Text);
                    oBE_Bebida_Alcohólica.Presentación = Convert.ToDecimal(txtPresentacion.Text);
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
                    oBE_Bebida.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), comboTipo.Text);
                    oBE_Bebida.Presentación = Convert.ToDecimal(txtPresentacion.Text);
                    oBE_Bebida.CostoUnitario = Convert.ToDecimal(txtPrecio.Text);
                    oBE_Bebida.Stock = Convert.ToInt32(lblCantidad.Text);
                }
                else
                {
                    oBE_Bebida_Alcohólica.Codigo = Convert.ToInt32(txtCodigo.Text);
                    oBE_Bebida_Alcohólica.Nombre = txtNombre.Text;
                    oBE_Bebida_Alcohólica.Tipo_Bebida = (BE_Bebida.Tipo)Enum.Parse(typeof(BE_Bebida.Tipo), comboTipo.Text);
                    oBE_Bebida_Alcohólica.Presentación = Convert.ToDecimal(txtPresentacion.Text);
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
            try
            {
                Aspecto.DGVBebidas(dgvBebidas);
            }
            catch { }
        }

        private void btnNuevaBebida_Click(object sender, EventArgs e)
        {
            try
            {
                if (Calculos.ValidarDecimal(txtPrecio.Text)&&Calculos.ValidarDecimal(txtPresentacion.Text))
                {
                    Nuevo();
                    if (comboTipo.SelectedIndex < 3)
                    {
                        if (oBLL_Bebida.Guardar(oBE_Bebida))
                        {
                            Calculos.MsgBoxAlta(oBE_Bebida.Nombre);
                        }
                        else
                        {
                            Calculos.MsgBoxNoAlta(oBE_Bebida.Nombre);
                        }
                        
                    }
                    else
                    {
                        if (Calculos.ValidarDecimal(txtABV.Text))
                        {
                            if (oBLL_Bebida_Alcohólica.Guardar(oBE_Bebida_Alcohólica))
                            {
                                Calculos.MsgBoxAlta(oBE_Bebida_Alcohólica.Nombre);
                            }
                            else
                            {
                                Calculos.MsgBoxNoAlta(oBE_Bebida_Alcohólica.Nombre);
                            }
                            
                        }
                        else { Calculos.MsgBox("El campo ABV no tiene el formato correcto"); }
                       
                    }
                    ActualizarListado();
                    Calculos.BorrarCampos(grpBebidas);
                }
                else
                {
                    Calculos.MsgBox("El campo no tiene el formato correcto");
                }
              
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
                    if (Calculos.ValidarDecimal(oBE_Bebida.Presentación.ToString()) && Calculos.ValidarDecimal(oBE_Bebida.CostoUnitario.ToString()))
                    {
                        if (oBLL_Bebida.Guardar(oBE_Bebida))
                        {
                            ActualizarListado();
                            Calculos.BorrarCampos(grpBebidas);
                            Calculos.MsgBoxMod(oBE_Bebida.Nombre);
                        }
                        else
                        {
                            Calculos.MsgBoxNoMod(oBE_Bebida.Nombre);
                        }
                       
                    }
                    else
                    {
                        Calculos.MsgBox("El campo no tiene el formato correcto");
                    }
                }
                else
                {
                    if (Calculos.ValidarDecimal(oBE_Bebida_Alcohólica.Presentación.ToString()) && Calculos.ValidarDecimal(oBE_Bebida_Alcohólica.CostoUnitario.ToString()) && Calculos.ValidarDecimal(oBE_Bebida_Alcohólica.GraduaciónAlcoholica.ToString()))
                    {
                        if (oBLL_Bebida_Alcohólica.Guardar(oBE_Bebida_Alcohólica))
                        {
                            ActualizarListado();
                            Calculos.BorrarCampos(grpBebidas);
                            Calculos.MsgBoxMod(oBE_Bebida_Alcohólica.Nombre);
                        }
                        else
                        {
                            Calculos.MsgBoxNoMod(oBE_Bebida_Alcohólica.Nombre);
                        }
                        
                    }
                    else
                    {
                        Calculos.MsgBox("El campo no tiene el formato correcto");
                    }
                        
                }
                
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
                if (Calculos.EstaSeguro("Eliminar", oBE_Bebida.Codigo, oBE_Bebida.Nombre))
                {
                    if (!oBLL_Bebida.ExisteActivo(oBE_Bebida))
                    {
                        if (oBLL_Bebida.Baja(oBE_Bebida))
                        {
                            ActualizarListado();
                            Calculos.BorrarCampos(grpBebidas);
                            Calculos.MsgBoxBaja(oBE_Bebida.Nombre);
                        }
                        else
                        {
                            Calculos.MsgBoxNoBaja(oBE_Bebida.Nombre);
                        }
                        
                    }
                    else
                    {
                        Calculos.MsgBoxBajaNegativa(oBE_Bebida.Nombre);
                    }

                }
            }
            else
            {
                if (Calculos.EstaSeguro("Eliminar", oBE_Bebida_Alcohólica.Codigo, oBE_Bebida_Alcohólica.Nombre))
                {
                    if (!oBLL_Bebida_Alcohólica.ExisteActivo(oBE_Bebida_Alcohólica))
                    {
                        if (oBLL_Bebida_Alcohólica.Baja(oBE_Bebida_Alcohólica))
                        {
                            ActualizarListado();
                            Calculos.BorrarCampos(grpBebidas);
                            Calculos.MsgBoxBaja(oBE_Bebida_Alcohólica.Nombre);
                        }
                        else
                        {
                            Calculos.MsgBoxNoBaja(oBE_Bebida_Alcohólica.Nombre);
                        }
                        
                    }
                    else
                    {
                        Calculos.MsgBoxBajaNegativa(oBE_Bebida_Alcohólica.Nombre);
                    }
                }
            }
        }

        private void dgvBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBE_Bebida = (BE_Bebida)dgvBebidas.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = oBE_Bebida.Codigo.ToString();
                txtNombre.Text = oBE_Bebida.Nombre;
                txtPrecio.Text = oBE_Bebida.CostoUnitario.ToString();
                comboTipo.Text = oBE_Bebida.Tipo_Bebida.ToString();
                txtPresentacion.Text = oBE_Bebida.Presentación.ToString();
                lblCantidad.Text = oBE_Bebida.Stock.ToString();
                prgCantidad.Value = oBE_Bebida.Stock;
                if (oBE_Bebida is BE_Bebida_Alcohólica)
                {
                    txtABV.Text = (oBE_Bebida as BE_Bebida_Alcohólica).GraduaciónAlcoholica.ToString();
                }
                else
                {
                    txtABV.Text = "";
                }
                Calculos.RefreshGrilla(dgvPedidosConBeb, oBLL_Pedido.BebidaEnPedidos(oBE_Bebida));
                Aspecto.DGVPedidosXBebidas(dgvPedidosConBeb);
            }
            catch { }
        }

        private void comboTipo_TextChanged(object sender, EventArgs e)
        {
            if (comboTipo.SelectedIndex >= 3)
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
                oBE_Bebida = (BE_Bebida)dgvBebidas.SelectedRows[0].DataBoundItem;

                if (oBE_Bebida is BE_Bebida_Alcohólica)
                {
                    if (Calculos.EstaSeguro("Agregar Stock de Bebida", oBE_Bebida.Codigo, oBE_Bebida.ToString()))
                    {
                        int Cantidad;
                        bool numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                        while (!numero)
                        {
                            numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                        }
                        if (Cantidad < prgCantidad.Maximum)
                        {
                            (oBE_Bebida as BE_Bebida_Alcohólica).AgregarStock(Cantidad);
                            oBLL_Bebida_Alcohólica.Guardar((oBE_Bebida as BE_Bebida_Alcohólica));
                        }
                        else
                        {
                            Calculos.MsgBox("La máxima cantidad permitida para bebidas es de " + prgCantidad.Maximum.ToString());
                        }


                    }
                }
                else
                {
                    if (Calculos.EstaSeguro("Agregar Stock de Bebida", oBE_Bebida.Codigo, oBE_Bebida.ToString()))
                    {
                        int Cantidad = -1;
                        bool numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                        while (!numero)
                        {
                            numero = Int32.TryParse(Interaction.InputBox("Ingrese Cantidad a Agregar", "Agregar Stock"), out Cantidad);
                        }
                        if (Cantidad < prgCantidad.Maximum)
                        {
                            oBE_Bebida.AgregarStock(Cantidad);
                            oBLL_Bebida.Guardar(oBE_Bebida);
                        }
                        else
                        {
                            Calculos.MsgBox("La máxima cantidad permitida para bebidas es de " + prgCantidad.Maximum.ToString());
                        }
                          
                    }
                }
                Calculos.MsgBox("Stock Agregado");
            }
            catch { }
            finally
            {
                ActualizarListado();
            }
        }

        private void txtABV_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarLetras(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarNumeros(e);
        }

        private void frmBebidas_Activated(object sender, EventArgs e)
        {
            ActualizarListado();
        }
    }
}
