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
    public partial class frmCocina : Form
    {
        BLL_Cocina oBLL_Cocina;
        BE_Cocina oBE_Cocina;
        BLL_Turno oBLL_Turno;
        BE_Turno oBE_Turno;
        public frmCocina()
        {
            InitializeComponent();
            oBLL_Cocina = new BLL_Cocina();
            oBE_Cocina = new BE_Cocina();
            oBLL_Turno = new BLL_Turno();
            oBE_Turno = new BE_Turno();
            Calculos.DataSourceCombo(comboTurno, oBLL_Turno.Listar(), "NombreTurno");
            Calculos.DataSourceCombo(comboPuesto, Enum.GetNames(typeof(BE_Empleado.Puesto_Cocina)), "PuestoCocina");
            ActualizarListado();
            Aspecto.FormatearDGV(dgvCocina);
            Aspecto.FormatearGRP(grpCocina);
        }

        private void Nuevo()
        {
            try
            {
                oBE_Cocina.Codigo = 0;
                oBE_Cocina.DNI = Int32.Parse(txtDNI.Text);
                oBE_Cocina.Nombre = txtNombre.Text;
                oBE_Cocina.Apellido = txtApellido.Text;
                oBE_Cocina.FechaNacimiento = dtpFechaNacimiento.Value;
                oBE_Cocina.Edad = oBE_Cocina.CalcularAños(oBE_Cocina.FechaNacimiento);
                oBE_Cocina.FechaIngreso = dtpFechaIngreso.Value;
                oBE_Cocina.Antiguedad = oBE_Cocina.CalcularAños(oBE_Cocina.FechaIngreso);
                oBE_Cocina.Turno = (BE_Turno)comboTurno.SelectedItem;
                oBE_Cocina.Puesto = (BE_Empleado.Puesto_Cocina)Enum.Parse(typeof(BE_Empleado.Puesto_Cocina), comboPuesto.Text);
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
                oBE_Cocina.Codigo = Convert.ToInt32(txtLegajo.Text);
                oBE_Cocina.DNI = Int32.Parse(txtDNI.Text);
                oBE_Cocina.Nombre = txtNombre.Text;
                oBE_Cocina.Apellido = txtApellido.Text;
                oBE_Cocina.FechaNacimiento = dtpFechaNacimiento.Value;
                oBE_Cocina.Edad = oBE_Cocina.CalcularAños(oBE_Cocina.FechaNacimiento);
                oBE_Cocina.FechaIngreso = dtpFechaIngreso.Value;
                oBE_Cocina.Antiguedad = oBE_Cocina.CalcularAños(oBE_Cocina.FechaIngreso);
                oBE_Cocina.Turno = (BE_Turno)comboTurno.SelectedItem;
                oBE_Cocina.Puesto = (BE_Empleado.Puesto_Cocina)Enum.Parse(typeof(BE_Empleado.Puesto_Cocina), comboPuesto.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void ActualizarListado()
        {
            Calculos.RefreshGrilla(dgvCocina, oBLL_Cocina.Listar());
            Aspecto.DGVCocinas(dgvCocina);
        }
        private void btnNuevoCocina_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo();
                if (Calculos.LargoDNI(oBE_Cocina.DNI.ToString())&&Calculos.ValidarNombrePersonal(oBE_Cocina.Nombre)&&Calculos.ValidarApellido(oBE_Cocina.Apellido))
                {
                    if (!oBLL_Cocina.Existe(oBE_Cocina))
                    {
                        if (oBLL_Cocina.Guardar(oBE_Cocina))
                        {
                            ActualizarListado();
                            Calculos.BorrarCampos(grpCocina);
                            Calculos.MsgBoxAlta(oBE_Cocina.ToString());
                        }
                        else
                        {
                            Calculos.MsgBoxNoAlta(oBE_Cocina.ToString());
                        }
                        
                    }
                    else
                    {
                        Calculos.MsgBoxNoAlta(oBE_Cocina.ToString());
                    }
                }
                else
                {
                    Calculos.MsgBox("El DNI no tiene el formato correcto");
                }
 
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
        }

        private void btnModificarCocina_Click(object sender, EventArgs e)
        {
            try
            {
                Viejo();
                if (!oBLL_Cocina.Existe(oBE_Cocina))
                {
                    if (oBLL_Cocina.Guardar(oBE_Cocina))
                    {
                        Calculos.BorrarCampos(grpCocina);
                        Calculos.MsgBoxMod(oBE_Cocina.ToString());
                    }
                    else
                    {
                        Calculos.MsgBoxNoMod(oBE_Cocina.ToString());
                    }
                    
                }
                else
                {
                    Calculos.MsgBoxSiExisteDNI(oBE_Cocina.ToString());
                }
            }
            catch (Exception ex)
            {

                Calculos.MsgBox(ex.Message);
            }
            finally { ActualizarListado(); }
        }

        private void dgvCocina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBE_Cocina = (BE_Cocina)dgvCocina.SelectedRows[0].DataBoundItem;
                txtLegajo.Text = oBE_Cocina.Codigo.ToString();
                txtDNI.Text = oBE_Cocina.DNI.ToString();
                txtNombre.Text = oBE_Cocina.Nombre;
                txtApellido.Text = oBE_Cocina.Apellido;
                dtpFechaNacimiento.Value = oBE_Cocina.FechaNacimiento;
                dtpFechaIngreso.Value = oBE_Cocina.FechaIngreso;
                comboTurno.Text = oBE_Cocina.Turno.NombreTurno;
                comboPuesto.Text = oBE_Cocina.Puesto.ToString();
                int rank = oBLL_Cocina.DevolverPuntuacion(oBE_Cocina);
                lblPuntuación.Text = rank.ToString();
                prgBaRanking.Value = rank;
                
            }
            catch { }
        }

        private void btnEliminarCocina_Click(object sender, EventArgs e)
        {
            Viejo();
            if (Calculos.EstaSeguro("Eliminar", oBE_Cocina.Codigo, oBE_Cocina.ToString()))
            {
                if (oBLL_Cocina.Baja(oBE_Cocina))
                {
                    ActualizarListado();
                    Calculos.BorrarCampos(grpCocina);
                    Calculos.MsgBoxBaja(oBE_Cocina.ToString());
                }
                else
                {
                    Calculos.MsgBoxNoBaja(oBE_Cocina.ToString());
                }
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarEntero(e);
        }

        private void frmCocina_Activated(object sender, EventArgs e)
        {
            ActualizarListado();
        }
    }
}
