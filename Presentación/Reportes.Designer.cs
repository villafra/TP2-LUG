namespace Presentación
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bEReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repViewRestó = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelreport = new System.Windows.Forms.Panel();
            this.grpReportesPedido = new System.Windows.Forms.GroupBox();
            this.btnRecuperarReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.comboMozo = new System.Windows.Forms.ComboBox();
            this.lblMozo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bEReporteBindingSource)).BeginInit();
            this.panelreport.SuspendLayout();
            this.grpReportesPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // bEReporteBindingSource
            // 
            this.bEReporteBindingSource.DataSource = typeof(BE.BE_Pedido);
            // 
            // repViewRestó
            // 
            this.repViewRestó.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.repViewRestó.BackgroundImage = global::Presentación.Properties.Resources.Picture3;
            this.repViewRestó.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.repViewRestó.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repViewRestó.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "Pedidos";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.bEReporteBindingSource;
            this.repViewRestó.LocalReport.DataSources.Add(reportDataSource1);
            this.repViewRestó.LocalReport.DataSources.Add(reportDataSource2);
            this.repViewRestó.LocalReport.ReportEmbeddedResource = "Presentación.Reporte.rdlc";
            this.repViewRestó.Location = new System.Drawing.Point(0, 0);
            this.repViewRestó.Name = "repViewRestó";
            this.repViewRestó.ServerReport.BearerToken = null;
            this.repViewRestó.Size = new System.Drawing.Size(844, 492);
            this.repViewRestó.TabIndex = 20;
            // 
            // panelreport
            // 
            this.panelreport.BackgroundImage = global::Presentación.Properties.Resources.Picture3;
            this.panelreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelreport.Controls.Add(this.repViewRestó);
            this.panelreport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelreport.Location = new System.Drawing.Point(0, 114);
            this.panelreport.Name = "panelreport";
            this.panelreport.Size = new System.Drawing.Size(844, 492);
            this.panelreport.TabIndex = 21;
            // 
            // grpReportesPedido
            // 
            this.grpReportesPedido.Controls.Add(this.btnRecuperarReporte);
            this.grpReportesPedido.Controls.Add(this.label1);
            this.grpReportesPedido.Controls.Add(this.dtpFechaFin);
            this.grpReportesPedido.Controls.Add(this.lblFechaNacimiento);
            this.grpReportesPedido.Controls.Add(this.dtpFechaInicio);
            this.grpReportesPedido.Controls.Add(this.comboMozo);
            this.grpReportesPedido.Controls.Add(this.lblMozo);
            this.grpReportesPedido.Location = new System.Drawing.Point(12, 3);
            this.grpReportesPedido.Name = "grpReportesPedido";
            this.grpReportesPedido.Size = new System.Drawing.Size(820, 105);
            this.grpReportesPedido.TabIndex = 22;
            this.grpReportesPedido.TabStop = false;
            this.grpReportesPedido.Text = "Filtrar Por";
            // 
            // btnRecuperarReporte
            // 
            this.btnRecuperarReporte.BackgroundImage = global::Presentación.Properties.Resources.analitica;
            this.btnRecuperarReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecuperarReporte.FlatAppearance.BorderSize = 0;
            this.btnRecuperarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarReporte.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarReporte.ForeColor = System.Drawing.Color.Gold;
            this.btnRecuperarReporte.Location = new System.Drawing.Point(699, 21);
            this.btnRecuperarReporte.Name = "btnRecuperarReporte";
            this.btnRecuperarReporte.Size = new System.Drawing.Size(76, 62);
            this.btnRecuperarReporte.TabIndex = 35;
            this.btnRecuperarReporte.UseVisualStyleBackColor = true;
            this.btnRecuperarReporte.Click += new System.EventHandler(this.btnRecuperarReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Hasta";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(502, 61);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaFin.TabIndex = 33;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(321, 31);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(48, 16);
            this.lblFechaNacimiento.TabIndex = 32;
            this.lblFechaNacimiento.Text = "Desde";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(319, 61);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaInicio.TabIndex = 31;
            // 
            // comboMozo
            // 
            this.comboMozo.FormattingEnabled = true;
            this.comboMozo.Location = new System.Drawing.Point(33, 59);
            this.comboMozo.Name = "comboMozo";
            this.comboMozo.Size = new System.Drawing.Size(219, 24);
            this.comboMozo.TabIndex = 30;
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Location = new System.Drawing.Point(30, 31);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(40, 16);
            this.lblMozo.TabIndex = 29;
            this.lblMozo.Text = "Mozo";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(844, 606);
            this.Controls.Add(this.grpReportesPedido);
            this.Controls.Add(this.panelreport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "Layout";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bEReporteBindingSource)).EndInit();
            this.panelreport.ResumeLayout(false);
            this.grpReportesPedido.ResumeLayout(false);
            this.grpReportesPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer repViewRestó;
        private System.Windows.Forms.Panel panelreport;
        private System.Windows.Forms.GroupBox grpReportesPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox comboMozo;
        private System.Windows.Forms.Label lblMozo;
        private System.Windows.Forms.Button btnRecuperarReporte;
        private System.Windows.Forms.BindingSource bEReporteBindingSource;
    }
}