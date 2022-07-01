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
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistórico)).BeginInit();
            this.grpFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistórico
            // 
            this.dgvHistórico.AllowUserToAddRows = false;
            this.dgvHistórico.AllowUserToDeleteRows = false;
            this.dgvHistórico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistórico.Location = new System.Drawing.Point(12, 204);
            this.dgvHistórico.Name = "dgvHistórico";
            this.dgvHistórico.ReadOnly = true;
            this.dgvHistórico.RowHeadersWidth = 51;
            this.dgvHistórico.RowTemplate.Height = 24;
            this.dgvHistórico.Size = new System.Drawing.Size(823, 371);
            this.dgvHistórico.TabIndex = 0;
            this.dgvHistórico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMozos_CellContentClick);
            // 
            // grpFiltrar
            // 
            this.grpFiltrar.Controls.Add(this.ComboEmpleado);
            this.grpFiltrar.Controls.Add(this.btnBuscarXML);
            this.grpFiltrar.Controls.Add(this.label1);
            this.grpFiltrar.Controls.Add(this.dtpFechaIngreso);
            this.grpFiltrar.Controls.Add(this.lblFechaNacimiento);
            this.grpFiltrar.Controls.Add(this.dtpFechaNacimiento);
            this.grpFiltrar.Controls.Add(this.comboTurno);
            this.grpFiltrar.Controls.Add(this.lblTurno);
            this.grpFiltrar.Controls.Add(this.lblNombre);
            this.grpFiltrar.Location = new System.Drawing.Point(9, 12);
            this.grpFiltrar.Name = "grpFiltrar";
            this.grpFiltrar.Size = new System.Drawing.Size(826, 186);
            this.grpFiltrar.TabIndex = 1;
            this.grpFiltrar.TabStop = false;
            this.grpFiltrar.Text = "Filtrar Por";
            // 
            // ComboEmpleado
            // 
            this.ComboEmpleado.FormattingEnabled = true;
            this.ComboEmpleado.Location = new System.Drawing.Point(25, 54);
            this.ComboEmpleado.Name = "ComboEmpleado";
            this.ComboEmpleado.Size = new System.Drawing.Size(158, 24);
            this.ComboEmpleado.TabIndex = 29;
            // 
            // btnBuscarXML
            // 
            this.btnBuscarXML.BackgroundImage = global::Presentación.Properties.Resources.BorrarMozo;
            this.btnBuscarXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarXML.FlatAppearance.BorderSize = 0;
            this.btnBuscarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarXML.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarXML.ForeColor = System.Drawing.Color.Gold;
            this.btnBuscarXML.Location = new System.Drawing.Point(698, 47);
            this.btnBuscarXML.Name = "btnBuscarXML";
            this.btnBuscarXML.Size = new System.Drawing.Size(100, 93);
            this.btnBuscarXML.TabIndex = 4;
            this.btnBuscarXML.UseVisualStyleBackColor = true;
            this.btnBuscarXML.Click += new System.EventHandler(this.btnBuscarXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hasta";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(287, 138);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaIngreso.TabIndex = 27;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(289, 26);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(48, 16);
            this.lblFechaNacimiento.TabIndex = 26;
            this.lblFechaNacimiento.Text = "Desde";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(287, 56);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaNacimiento.TabIndex = 25;
            // 
            // comboTurno
            // 
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(25, 125);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(158, 24);
            this.comboTurno.TabIndex = 24;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(22, 98);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(42, 16);
            this.lblTurno.TabIndex = 23;
            this.lblTurno.Text = "Turno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
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
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox ComboEmpleado;
    }
}