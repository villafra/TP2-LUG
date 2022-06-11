namespace Presentación
{
    partial class frmTurnos
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
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.grpTurnos = new System.Windows.Forms.GroupBox();
            this.dgvMozosEnturno = new System.Windows.Forms.DataGridView();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtNombreTurno = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.prgCantidad = new System.Windows.Forms.ProgressBar();
            this.lblCantMozos = new System.Windows.Forms.Label();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnModificarTurno = new System.Windows.Forms.Button();
            this.btnNuevoTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.grpTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozosEnturno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AllowUserToAddRows = false;
            this.dgvTurnos.AllowUserToDeleteRows = false;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(139, 53);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.RowHeadersWidth = 51;
            this.dgvTurnos.RowTemplate.Height = 24;
            this.dgvTurnos.Size = new System.Drawing.Size(568, 254);
            this.dgvTurnos.TabIndex = 0;
            this.dgvTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellContentClick);
            // 
            // grpTurnos
            // 
            this.grpTurnos.Controls.Add(this.dgvMozosEnturno);
            this.grpTurnos.Controls.Add(this.lblHoraFin);
            this.grpTurnos.Controls.Add(this.dtpHoraFin);
            this.grpTurnos.Controls.Add(this.lblHoraInicio);
            this.grpTurnos.Controls.Add(this.dtpHoraInicio);
            this.grpTurnos.Controls.Add(this.txtNombreTurno);
            this.grpTurnos.Controls.Add(this.lblNombre);
            this.grpTurnos.Controls.Add(this.txtCodigo);
            this.grpTurnos.Controls.Add(this.lblCodigo);
            this.grpTurnos.Controls.Add(this.lblCantidad);
            this.grpTurnos.Controls.Add(this.prgCantidad);
            this.grpTurnos.Controls.Add(this.lblCantMozos);
            this.grpTurnos.Location = new System.Drawing.Point(12, 313);
            this.grpTurnos.Name = "grpTurnos";
            this.grpTurnos.Size = new System.Drawing.Size(826, 185);
            this.grpTurnos.TabIndex = 1;
            this.grpTurnos.TabStop = false;
            this.grpTurnos.Text = "Turnos";
            // 
            // dgvMozosEnturno
            // 
            this.dgvMozosEnturno.AllowUserToAddRows = false;
            this.dgvMozosEnturno.AllowUserToDeleteRows = false;
            this.dgvMozosEnturno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMozosEnturno.Location = new System.Drawing.Point(536, 19);
            this.dgvMozosEnturno.Name = "dgvMozosEnturno";
            this.dgvMozosEnturno.ReadOnly = true;
            this.dgvMozosEnturno.RowHeadersWidth = 51;
            this.dgvMozosEnturno.RowTemplate.Height = 24;
            this.dgvMozosEnturno.Size = new System.Drawing.Size(284, 146);
            this.dgvMozosEnturno.TabIndex = 5;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(198, 117);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(77, 16);
            this.lblHoraFin.TabIndex = 28;
            this.lblHoraFin.Text = "Hora de Fin";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(201, 145);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(121, 22);
            this.dtpHoraFin.TabIndex = 27;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(24, 117);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(90, 16);
            this.lblHoraInicio.TabIndex = 26;
            this.lblHoraInicio.Text = "Hora de Inicio";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(27, 145);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(121, 22);
            this.dtpHoraInicio.TabIndex = 25;
            // 
            // txtNombreTurno
            // 
            this.txtNombreTurno.Location = new System.Drawing.Point(201, 63);
            this.txtNombreTurno.Name = "txtNombreTurno";
            this.txtNombreTurno.Size = new System.Drawing.Size(102, 22);
            this.txtNombreTurno.TabIndex = 14;
            this.txtNombreTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(198, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(37, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 22);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(89, 16);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo Turno";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(427, 91);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(14, 16);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "0";
            // 
            // prgCantidad
            // 
            this.prgCantidad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prgCantidad.Location = new System.Drawing.Point(360, 125);
            this.prgCantidad.Maximum = 7;
            this.prgCantidad.Name = "prgCantidad";
            this.prgCantidad.Size = new System.Drawing.Size(157, 42);
            this.prgCantidad.Step = 1;
            this.prgCantidad.TabIndex = 9;
            // 
            // lblCantMozos
            // 
            this.lblCantMozos.AutoSize = true;
            this.lblCantMozos.Location = new System.Drawing.Point(357, 33);
            this.lblCantMozos.Name = "lblCantMozos";
            this.lblCantMozos.Size = new System.Drawing.Size(104, 32);
            this.lblCantMozos.TabIndex = 8;
            this.lblCantMozos.Text = "Cantidad de \r\nMozos En Turno";
            this.lblCantMozos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.BackgroundImage = global::Presentación.Properties.Resources.Picture11;
            this.btnEliminarTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarTurno.FlatAppearance.BorderSize = 0;
            this.btnEliminarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTurno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTurno.ForeColor = System.Drawing.Color.Gold;
            this.btnEliminarTurno.Location = new System.Drawing.Point(738, 504);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(100, 93);
            this.btnEliminarTurno.TabIndex = 4;
            this.btnEliminarTurno.UseVisualStyleBackColor = true;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // btnModificarTurno
            // 
            this.btnModificarTurno.BackgroundImage = global::Presentación.Properties.Resources.Picture12;
            this.btnModificarTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarTurno.FlatAppearance.BorderSize = 0;
            this.btnModificarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTurno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTurno.ForeColor = System.Drawing.Color.Gold;
            this.btnModificarTurno.Location = new System.Drawing.Point(373, 504);
            this.btnModificarTurno.Name = "btnModificarTurno";
            this.btnModificarTurno.Size = new System.Drawing.Size(100, 93);
            this.btnModificarTurno.TabIndex = 3;
            this.btnModificarTurno.UseVisualStyleBackColor = true;
            this.btnModificarTurno.Click += new System.EventHandler(this.btnModificarTurno_Click);
            // 
            // btnNuevoTurno
            // 
            this.btnNuevoTurno.BackgroundImage = global::Presentación.Properties.Resources.Picture10;
            this.btnNuevoTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoTurno.FlatAppearance.BorderSize = 0;
            this.btnNuevoTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTurno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTurno.ForeColor = System.Drawing.Color.Gold;
            this.btnNuevoTurno.Location = new System.Drawing.Point(12, 504);
            this.btnNuevoTurno.Name = "btnNuevoTurno";
            this.btnNuevoTurno.Size = new System.Drawing.Size(100, 93);
            this.btnNuevoTurno.TabIndex = 2;
            this.btnNuevoTurno.UseVisualStyleBackColor = true;
            this.btnNuevoTurno.Click += new System.EventHandler(this.btnNuevoTurno_Click);
            // 
            // frmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.btnEliminarTurno);
            this.Controls.Add(this.btnModificarTurno);
            this.Controls.Add(this.btnNuevoTurno);
            this.Controls.Add(this.grpTurnos);
            this.Controls.Add(this.dgvTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurnos";
            this.Text = "Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.grpTurnos.ResumeLayout(false);
            this.grpTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozosEnturno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.GroupBox grpTurnos;
        private System.Windows.Forms.Label lblCantMozos;
        private System.Windows.Forms.ProgressBar prgCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnNuevoTurno;
        private System.Windows.Forms.Button btnModificarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreTurno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DataGridView dgvMozosEnturno;
    }
}