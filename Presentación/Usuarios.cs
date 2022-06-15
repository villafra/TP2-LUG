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
    public partial class frmUsuarios : Form
    {
        BLL_Login oBLL_Login;
        BE_Login oBE_Login;
        BE_Empleado oBE_Empleado;
        BLL_Mozo oBLL_Mozo;
        public frmUsuarios()
        {
            InitializeComponent();
            oBLL_Login = new BLL_Login();
            oBLL_Mozo = new BLL_Mozo();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvUsuarios);
            Aspecto.FormatearGRP(grpUsuarios);
        }

        private void Nuevo()
        {
            try
            {
                oBE_Login = new BE_Login(oBE_Empleado, oBLL_Login.GenerarUsuario(oBE_Empleado), oBLL_Login.AutoGenerarPass());
                oBLL_Login.Guardar(oBE_Login);
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
                oBE_Login = new BE_Login(Int32.Parse(txtCodigo.Text), oBE_Empleado, txtUsuario.Text, txtPass.Text, Int32.Parse(lblCantidad.Text));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ActualizarListado()
        {
            //Calculos.RefreshGrilla(dgvUsuarios, oBLL_Login.Listar());
            //Calculos.RefreshGrilla(dgvUsuarios, oBLL_Mozo.Listartodo());
            //Aspecto.DGVTurnos(dgvUsuarios);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBE_Login = (BE_Login)dgvUsuarios.CurrentRow.DataBoundItem;
            txtCodigo.Text = oBE_Login.Codigo.ToString();
            txtUsuario.Text = oBE_Login.Usuario;
            txtPass.Text = oBE_Login.Password;
            txtLegajo.Text = oBE_Login.Empleado.Codigo.ToString();
            txtNombre.Text = oBE_Login.Empleado.Nombre;
            txtApellido.Text = oBE_Login.Empleado.Apellido;
            lblCantidad.Text = oBE_Login.CantidadIntentos.ToString();
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                oBLL_Login.Guardar(oBE_Login);
                ActualizarListado();
                Calculos.BorrarCampos(grpUsuarios);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                Viejo();
                oBLL_Login.Guardar(oBE_Login);
                ActualizarListado();
                Calculos.BorrarCampos(grpUsuarios);
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            Viejo();
            if (Calculos.EstaSeguro("Eliminar", oBE_Login.Codigo, oBE_Login.ToString()))
            {
                if (oBLL_Login.Baja(oBE_Login) == false)
                {
                    Calculos.MsgBox("No se puede dar de baja un turno con Mozos Asignados");
                }
                else
                {
                    ActualizarListado();
                    Calculos.BorrarCampos(grpUsuarios);
                }

            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBE_Empleado = (BE_Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
        }
    }
}
