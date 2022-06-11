using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estética;
using Calculo;

namespace Presentación
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            Aspecto.FormatearForm(this, panelMenuIzq, this.Width, this.Height);
            frmBienvenida frm = new frmBienvenida();
            Aspecto.AbrirNuevoForm(this, frm);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Calculos.Salir();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Calculos.Salir();
        }

        private void btnLayout_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmLayout);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmLayout();
                Aspecto.AbrirNuevoForm(this, frm);
            }


        }

        private void MesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMesas);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmMesas();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void MozosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMozos);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmMozos();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void TurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTurnos);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmTurnos();

                Aspecto.AbrirNuevoForm(this, frm);
            }
        }


        private void PlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPlatos);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmPlatos();

                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void BebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBebidas);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmBebidas();

                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmReservas);
            if (frm != null)
            {

                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmReservas();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPedidos);
            if (frm != null)
            {

                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmPedidos();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBienvenida);
            if (frm != null)
            {

                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmBienvenida();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }


        //private void btnInformes_Click(object sender, EventArgs e)
        //{
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmInformes);
        //    if (frm != null)
        //    {

        //        frm.BringToFront();
        //        return;
        //    }
        //    else
        //    {
        //        frm = new frmInformes();
        //        Aspecto.AbrirNuevoForm(this, frm);
        //    }
        //}
    }
}
