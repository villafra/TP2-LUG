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
    public partial class frmUsuarios : Form
    {
        BLL_Login oBLL_Login;
        BE_Login oBE_Login;
        BE_Empleado oBE_Empleado;
        BLL_Mozo oBLL_Mozo;
        private bool cambiopass;
        public frmUsuarios()
        {
            InitializeComponent();
            oBLL_Login = new BLL_Login();
            oBLL_Mozo = new BLL_Mozo();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvUsuarios);
            Aspecto.FormatearDGV(dgvEmpleados);
            Aspecto.FormatearGRP(grpUsuarios);
        }

        private void Nuevo()
        {
            try
            {
                oBE_Empleado = (BE_Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                string mail = Interaction.InputBox("Ingrese el e-Mail", "Restó");
                oBE_Login = new BE_Login(oBE_Empleado, oBLL_Login.GenerarUsuario(oBE_Empleado), oBLL_Login.AutoGenerarPass(), mail);
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
                oBE_Empleado = (BE_Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                if (cambiopass)
                {
                    oBE_Login = new BE_Login(Int32.Parse(txtCodigo.Text), oBE_Empleado, txtUsuario.Text, oBLL_Login.EncriptarPass(txtPass.Text), txtMail.Text, prgCantidad.Value);
                }
                else
                {
                    oBE_Login = new BE_Login(Int32.Parse(txtCodigo.Text), oBE_Empleado, txtUsuario.Text, txtPass.Text, txtMail.Text, prgCantidad.Value);
                }              
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvUsuarios, oBLL_Login.Listar());
            Calculos.RefreshGrilla(dgvEmpleados, oBLL_Mozo.Listartodo());
            Aspecto.DGVEmpleados(dgvEmpleados);
            Aspecto.DGVLogin(dgvUsuarios);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBE_Login = (BE_Login)dgvUsuarios.CurrentRow.DataBoundItem;
            txtCodigo.Text = oBE_Login.Codigo.ToString();
            txtUsuario.Text = oBE_Login.Usuario;
            txtPass.Text = oBE_Login.Password;
            txtLegajo.Text = oBE_Login.Empleado.Codigo.ToString();
            txtNombre.Text = oBE_Login.Empleado.ToString();
            txtMail.Text = oBE_Login.eMail;
            prgCantidad.Value = oBE_Login.CantidadIntentos;
            cambiopass = false;
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                if (Calculos.ValidarMail(oBE_Login.eMail))
                {
                    if (!oBLL_Login.Existe(oBE_Login))
                    {
                        if (oBLL_Login.Guardar(oBE_Login))
                        {
                            Calculos.BorrarCampos(grpUsuarios);
                            Calculos.MsgBoxAlta(oBE_Login.Usuario);
                        }
                        else
                        {
                            Calculos.MsgBoxNoAlta(oBE_Login.Usuario);
                        }
                        
                    }
                    else
                    {
                        Calculos.MsgBoxSiExiste(oBE_Login.Usuario);
                    }
                }
                else
                {
                    Calculos.MsgBox("Ingrese un Mail válido");
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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (Calculos.ValidarMail(txtMail.Text))
                {
                    Viejo();
                    if (!oBLL_Login.Existe(oBE_Login))
                    {
                        if (oBLL_Login.Guardar(oBE_Login))
                        {
                            Calculos.BorrarCampos(grpUsuarios);
                            Calculos.MsgBoxMod(oBE_Login.Usuario);
                        }
                        else
                        {
                            Calculos.MsgBoxNoMod(oBE_Login.Usuario);
                        }
                    }
                    else
                    {
                        Calculos.MsgBoxSiExiste(oBE_Login.Usuario);
                    }

                }
                else
                {
                    Calculos.MsgBox("Ingrese un Mail válido.");
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

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            try
            {
                Viejo();
                if (Calculos.EstaSeguro("Eliminar", oBE_Login.Codigo, oBE_Login.Usuario))
                {
                    if (!oBLL_Login.ExisteActivo(oBE_Login))
                    {
                        if (oBLL_Login.Baja(oBE_Login))
                        {
                            Calculos.BorrarCampos(grpUsuarios);
                            Calculos.MsgBoxBaja(oBE_Login.Usuario);
                        }
                        else
                        {
                            Calculos.MsgBoxNoBaja(oBE_Login.Usuario);
                        }
                    }
                    else
                    {
                        Calculos.MsgBoxBajaNegativa(oBE_Login.Usuario);
                    }
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

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBE_Empleado = (BE_Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (oBLL_Login.ResetCounter(oBE_Login))
            {
                prgCantidad.Value = oBE_Login.CantidadIntentos;
            }
            
        }

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            Calculos.MsgBox(oBLL_Login.DesencriptarPass(txtPass.Text));
        }

        private bool ingreso;

        private void txtPass_Click(object sender, EventArgs e)
        {
            if (ingreso)
            {
                txtPass.SelectAll();
            }

            ingreso = false;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.SelectAll();
            ingreso = true;
        }

        private void frmUsuarios_Activated(object sender, EventArgs e)
        {
            ActualizarListado();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            cambiopass = true;
        }
    }
}
