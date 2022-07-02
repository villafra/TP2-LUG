namespace Presentación
{
    partial class frmInformes
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
            this.dgvHistórico = new System.Windows.Forms.DataGridView();
            this.grpFiltrar = new System.Windows.Forms.GroupBox();
            this.ComboEmpleado = new System.Windows.Forms.ComboBox();
            this.btnBuscarXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistórico)).BeginInit();
            this.grpFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistórico
            // 
            this.dgvHistórico.AllowUserToAddRows = false;
            this.dgvHistórico.AllowUserToDeleteRows = false;
            this.dgvHistórico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistórico.Location = new System.Drawing.Point(12, 168);
            this.dgvHistórico.Name = "dgvHistórico";
            this.dgvHistórico.ReadOnly = true;
            this.dgvHistórico.RowHeadersWidth = 51;
            this.dgvHistórico.RowTemplate.Height = 24;
            this.dgvHistórico.Size = new System.Drawing.Size(823, 407);
            this.dgvHistórico.TabIndex = 0;
            // 
            // grpFiltrar
            // 
            this.grpFiltrar.Controls.Add(this.chkFecha);
            this.grpFiltrar.Controls.Add(this.ComboEmpleado);
            this.grpFiltrar.Controls.Add(this.btnBuscarXML);
            this.grpFiltrar.Controls.Add(this.label1);
            this.grpFiltrar.Controls.Add(this.dtpFechaInicio);
            this.grpFiltrar.Controls.Add(this.lblFechaNacimiento);
            this.grpFiltrar.Controls.Add(this.dtpFechaFin);
            this.grpFiltrar.Controls.Add(this.comboTurno);
            this.grpFiltrar.Controls.Add(this.lblTurno);
            this.grpFiltrar.Controls.Add(this.lblNombre);
            this.grpFiltrar.Location = new System.Drawing.Point(9, 12);
            this.grpFiltrar.Name = "grpFiltrar";
            this.grpFiltrar.Size = new System.Drawing.Size(826, 150);
            this.grpFiltrar.TabIndex = 1;
            this.grpFiltrar.TabStop = false;
            this.grpFiltrar.Text = "Filtrar Por";
            // 
            // ComboEmpleado
            // 
            this.ComboEmpleado.FormattingEnabled = true;
            this.ComboEmpleado.Location = new System.Drawing.Point(9, 54);
            this.ComboEmpleado.Name = "ComboEmpleado";
            this.ComboEmpleado.Size = new System.Drawing.Size(249, 24);
            this.ComboEmpleado.TabIndex = 29;
            // 
            // btnBuscarXML
            // 
            this.btnBuscarXML.BackgroundImage = global::Presentación.Properties.Resources.escaneo_dactilar;
            this.btnBuscarXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarXML.FlatAppearance.BorderSize = 0;
            this.btnBuscarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarXML.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarXML.ForeColor = System.Drawing.Color.Gold;
            this.btnBuscarXML.Location = new System.Drawing.Point(720, 26);
            this.btnBuscarXML.Name = "btnBuscarXML";
            this.btnBuscarXML.Size = new System.Drawing.Size(100, 93);
            this.btnBuscarXML.TabIndex = 4;
            this.btnBuscarXML.UseVisualStyleBackColor = true;
            this.btnBuscarXML.Click += new System.EventHandler(this.btnBuscarXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hasta";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(554, 46);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaInicio.TabIndex = 27;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(551, 18);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(48, 16);
            this.lblFechaNacimiento.TabIndex = 26;
            this.lblFechaNacimiento.Text = "Desde";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(559, 114);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaFin.TabIndex = 25;
            // 
            // comboTurno
            // 
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(9, 113);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(158, 24);
            this.comboTurno.TabIndex = 24;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(6, 86);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(42, 16);
            this.lblTurno.TabIndex = 23;
            this.lblTurno.Text = "Turno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 16);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Empleado";
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(307, 82);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(169, 20);
            this.chkFecha.TabIndex = 30;
            this.chkFecha.Text = "Usar Rango de Fechas";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.grpFiltrar);
            this.Controls.Add(this.dgvHistórico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistórico)).EndInit();
            this.grpFiltrar.ResumeLayout(false);
            this.grpFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistórico;
        private System.Windows.Forms.GroupBox grpFiltrar;
        private System.Windows.Forms.Button btnBuscarXML;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox comboTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox ComboEmpleado;
        private System.Windows.Forms.CheckBox chkFecha;
    }
}