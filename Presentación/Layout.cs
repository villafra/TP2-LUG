using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using Calculo;

namespace Presentación
{
    public partial class frmLayout : Form
    {
        BLL_Reporte oBLL_Reporte;
        BE_Reporte oBE_Reporte;
        BLL_Mozo oBLL_Mozo;
        public frmLayout()
        {
            InitializeComponent();
            oBLL_Reporte = new BLL_Reporte();
            oBE_Reporte = new BE_Reporte();
            oBLL_Mozo = new BLL_Mozo();
            Calculos.DataSourceComboReporte(comboMozo, oBLL_Mozo.Listar(),null);
        }

        private void btnRecuperarReporte_Click(object sender, EventArgs e)
        {
            ActualizarReporte();
        }

        private void ActualizarReporte()
        {
            oBE_Reporte.FechaInicio = dtpFechaInicio.Value;
            oBE_Reporte.FechaFin = dtpFechaFin.Value;
            if (comboMozo.SelectedItem != null)
            {
                oBE_Reporte.Codigo_Mozo = (comboMozo.SelectedValue as BE_Mozo).Codigo;
            }
            this.repViewRestó.LocalReport.DataSources[0].Value = oBLL_Reporte.ListarReportes(oBE_Reporte);
            if (repViewRestó.LocalReport.DataSources[0].Value == null)
            {
                Calculos.MsgBox("No hay datos que coincidan con la busqueda.");
                this.repViewRestó.RefreshReport();
            }
            else 
            { 
                this.repViewRestó.RefreshReport();
                
            }   
        }

        private void frmLayout_Load(object sender, EventArgs e)
        {

        }

        private void bEReporteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
