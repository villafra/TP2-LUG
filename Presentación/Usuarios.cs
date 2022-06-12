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
        public frmUsuarios()
        {
            InitializeComponent();
            oBLL_Login = new BLL_Login();
            ActualizarListado();
            Aspecto.FormatearDGV(dgvUsuarios);
            Aspecto.FormatearGRP(grpUsuarios);
        }

        private void Nuevo()
        {
            try
            {
              

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
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvUsuarios, oBLL_Login.Listar());
            Aspecto.DGVTurnos(dgvUsuarios);
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
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

        private void btnModificarTurno_Click(object sender, EventArgs e)
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

        private void btnEliminarTurno_Click(object sender, EventArgs e)
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
    }
}
