namespace Presentación
{
    partial class frmCocina
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
            this.dgvCocina = new System.Windows.Forms.DataGridView();
            this.grpCocina = new System.Windows.Forms.GroupBox();
            this.comboPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblPuntuación = new System.Windows.Forms.Label();
            this.prgBaRanking = new System.Windows.Forms.ProgressBar();
            this.lblRanking = new System.Windows.Forms.Label();
            this.btnEliminarCocina = new System.Windows.Forms.Button();
            this.btnModificarCocina = new System.Windows.Forms.Button();
            this.btnNuevoCocina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCocina)).BeginInit();
            this.grpCocina.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCocina
            // 
            this.dgvCocina.AllowUserToAddRows = false;
            this.dgvCocina.AllowUserToDeleteRows = false;
            this.dgvCocina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCocina.Location = new System.Drawing.Point(12, 53);
            this.dgvCocina.Name = "dgvCocina";
            this.dgvCocina.ReadOnly = true;
            this.dgvCocina.RowHeadersWidth = 51;
            this.dgvCocina.RowTemplate.Height = 24;
            this.dgvCocina.Size = new System.Drawing.Size(823, 254);
            this.dgvCocina.TabIndex = 0;
            this.dgvCocina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCocina_CellContentClick);
            // 
            // grpCocina
            // 
            this.grpCocina.Controls.Add(this.comboPuesto);
            this.grpCocina.Controls.Add(this.lblPuesto);
            this.grpCocina.Controls.Add(this.label1);
            this.grpCocina.Controls.Add(this.dtpFechaIngreso);
            this.grpCocina.Controls.Add(this.lblFechaNacimiento);
            this.grpCocina.Controls.Add(this.dtpFechaNacimiento);
            this.grpCocina.Controls.Add(this.comboTurno);
            this.grpCocina.Controls.Add(this.lblTurno);
            this.grpCocina.Controls.Add(this.txtApellido);
            this.grpCocina.Controls.Add(this.lblApellido);
            this.grpCocina.Controls.Add(this.txtNombre);
            this.grpCocina.Controls.Add(this.lblNombre);
            this.grpCocina.Controls.Add(this.txtDNI);
            this.grpCocina.Controls.Add(this.lblDNI);
            this.grpCocina.Controls.Add(this.txtLegajo);
            this.grpCocina.Controls.Add(this.lblLegajo);
            this.grpCocina.Controls.Add(this.lblPuntuación);
            this.grpCocina.Controls.Add(this.prgBaRanking);
            this.grpCocina.Controls.Add(this.lblRanking);
            this.grpCocina.Location = new System.Drawing.Point(12, 313);
            this.grpCocina.Name = "grpCocina";
            this.grpCocina.Size = new System.Drawing.Size(826, 185);
            this.grpCocina.TabIndex = 1;
            this.grpCocina.TabStop = false;
            this.grpCocina.Text = "Cocina";
            // 
            // comboPuesto
            // 
            this.comboPuesto.FormattingEnabled = true;
            this.comboPuesto.Location = new System.Drawing.Point(617, 141);
            this.comboPuesto.Name = "comboPuesto";
            this.comboPuesto.Size = new System.Drawing.Size(188, 24);
            this.comboPuesto.TabIndex = 30;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(614, 113);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(49, 16);
            this.lblPuesto.TabIndex = 29;
            this.lblPuesto.Text = "Puesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha de Ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(455, 63);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaIngreso.TabIndex = 27;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(289, 33);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(95, 16);
            this.lblFechaNacimiento.TabIndex = 26;
            this.lblFechaNacimiento.Text = "Fecha de Nac.";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(287, 63);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaNacimiento.TabIndex = 25;
            // 
            // comboTurno
            // 
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Location = new System.Drawing.Point(433, 141);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(158, 24);
            this.comboTurno.TabIndex = 24;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(430, 113);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(42, 16);
            this.lblTurno.TabIndex = 23;
            this.lblTurno.Text = "Turno";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(222, 143);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(186, 22);
            this.txtApellido.TabIndex = 18;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(219, 113);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(27, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 22);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(163, 63);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(102, 22);
            this.txtDNI.TabIndex = 14;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(160, 33);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(30, 16);
            this.lblDNI.TabIndex = 13;
            this.lblDNI.Text = "DNI";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Location = new System.Drawing.Point(27, 63);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(99, 22);
            this.txtLegajo.TabIndex = 12;
            this.txtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(24, 33);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(49, 16);
            this.lblLegajo.TabIndex = 11;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblPuntuación
            // 
            this.lblPuntuación.AutoSize = true;
            this.lblPuntuación.Location = new System.Drawing.Point(737, 18);
            this.lblPuntuación.Name = "lblPuntuación";
            this.lblPuntuación.Size = new System.Drawing.Size(14, 16);
            this.lblPuntuación.TabIndex = 10;
            this.lblPuntuación.Text = "0";
            // 
            // prgBaRanking
            // 
            this.prgBaRanking.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prgBaRanking.Location = new System.Drawing.Point(617, 49);
            this.prgBaRanking.Maximum = 10;
            this.prgBaRanking.Name = "prgBaRanking";
            this.prgBaRanking.Size = new System.Drawing.Size(188, 42);
            this.prgBaRanking.Step = 1;
            this.prgBaRanking.TabIndex = 9;
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Location = new System.Drawing.Point(634, 18);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(73, 16);
            this.lblRanking.TabIndex = 8;
            this.lblRanking.Text = "Puntuación";
            // 
            // btnEliminarCocina
            // 
            this.btnEliminarCocina.BackgroundImage = global::Presentación.Properties.Resources.Picture25;
            this.btnEliminarCocina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCocina.FlatAppearance.BorderSize = 0;
            this.btnEliminarCocina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCocina.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCocina.ForeColor = System.Drawing.Color.Gold;
            this.btnEliminarCocina.Location = new System.Drawing.Point(738, 504);
            this.btnEliminarCocina.Name = "btnEliminarCocina";
            this.btnEliminarCocina.Size = new System.Drawing.Size(100, 93);
            this.btnEliminarCocina.TabIndex = 4;
            this.btnEliminarCocina.UseVisualStyleBackColor = true;
            this.btnEliminarCocina.Click += new System.EventHandler(this.btnEliminarCocina_Click);
            // 
            // btnModificarCocina
            // 
            this.btnModificarCocina.BackgroundImage = global::Presentación.Properties.Resources.Picture24;
            this.btnModificarCocina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCocina.FlatAppearance.BorderSize = 0;
            this.btnModificarCocina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCocina.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCocina.ForeColor = System.Drawing.Color.Gold;
            this.btnModificarCocina.Location = new System.Drawing.Point(373, 504);
            this.btnModificarCocina.Name = "btnModificarCocina";
            this.btnModificarCocina.Size = new System.Drawing.Size(100, 93);
            this.btnModificarCocina.TabIndex = 3;
            this.btnModificarCocina.UseVisualStyleBackColor = true;
            this.btnModificarCocina.Click += new System.EventHandler(this.btnModificarCocina_Click);
            // 
            // btnNuevoCocina
            // 
            this.btnNuevoCocina.BackgroundImage = global::Presentación.Properties.Resources.cocina;
            this.btnNuevoCocina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoCocina.FlatAppearance.BorderSize = 0;
            this.btnNuevoCocina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCocina.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCocina.ForeColor = System.Drawing.Color.Gold;
            this.btnNuevoCocina.Location = new System.Drawing.Point(12, 504);
            this.btnNuevoCocina.Name = "btnNuevoCocina";
            this.btnNuevoCocina.Size = new System.Drawing.Size(100, 93);
            this.btnNuevoCocina.TabIndex = 2;
            this.btnNuevoCocina.UseVisualStyleBackColor = true;
            this.btnNuevoCocina.Click += new System.EventHandler(this.btnNuevoCocina_Click);
            // 
            // frmCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.btnEliminarCocina);
            this.Controls.Add(this.btnModificarCocina);
            this.Controls.Add(this.btnNuevoCocina);
            this.Controls.Add(this.grpCocina);
            this.Controls.Add(this.dgvCocina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCocina";
            this.Text = "Mesas";
            this.Activated += new System.EventHandler(this.frmCocina_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCocina)).EndInit();
            this.grpCocina.ResumeLayout(false);
            this.grpCocina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCocina;
        private System.Windows.Forms.GroupBox grpCocina;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.ProgressBar prgBaRanking;
        private System.Windows.Forms.Label lblPuntuación;
        private System.Windows.Forms.Button btnNuevoCocina;
        private System.Windows.Forms.Button btnModificarCocina;
        private System.Windows.Forms.Button btnEliminarCocina;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.ComboBox comboTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox comboPuesto;
        private System.Windows.Forms.Label lblPuesto;
    }
}