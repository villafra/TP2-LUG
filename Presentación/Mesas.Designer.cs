namespace Presentación
{
    partial class frmMesas
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
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.grpMesas = new System.Windows.Forms.GroupBox();
            this.txtCodigoMesa = new System.Windows.Forms.TextBox();
            this.lblCodigoMesa = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.prgBarOcupación = new System.Windows.Forms.ProgressBar();
            this.lblOcupación = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rdbReservada = new System.Windows.Forms.RadioButton();
            this.RdbOcupada = new System.Windows.Forms.RadioButton();
            this.rdbDisponible = new System.Windows.Forms.RadioButton();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.btnEliminarMesa = new System.Windows.Forms.Button();
            this.btnModificarMesa = new System.Windows.Forms.Button();
            this.btnNuevaMesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.grpMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Location = new System.Drawing.Point(98, 53);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersWidth = 51;
            this.dgvMesas.RowTemplate.Height = 24;
            this.dgvMesas.Size = new System.Drawing.Size(651, 254);
            this.dgvMesas.TabIndex = 0;
            this.dgvMesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_CellContentClick);
            // 
            // grpMesas
            // 
            this.grpMesas.Controls.Add(this.txtCodigoMesa);
            this.grpMesas.Controls.Add(this.lblCodigoMesa);
            this.grpMesas.Controls.Add(this.lblPorcentaje);
            this.grpMesas.Controls.Add(this.prgBarOcupación);
            this.grpMesas.Controls.Add(this.lblOcupación);
            this.grpMesas.Controls.Add(this.lblEstado);
            this.grpMesas.Controls.Add(this.rdbReservada);
            this.grpMesas.Controls.Add(this.RdbOcupada);
            this.grpMesas.Controls.Add(this.rdbDisponible);
            this.grpMesas.Controls.Add(this.txtCapacidad);
            this.grpMesas.Controls.Add(this.lblCapacidad);
            this.grpMesas.Controls.Add(this.txtNumeroMesa);
            this.grpMesas.Controls.Add(this.lblNumeroMesa);
            this.grpMesas.Location = new System.Drawing.Point(12, 313);
            this.grpMesas.Name = "grpMesas";
            this.grpMesas.Size = new System.Drawing.Size(826, 185);
            this.grpMesas.TabIndex = 1;
            this.grpMesas.TabStop = false;
            this.grpMesas.Text = "Mesas";
            // 
            // txtCodigoMesa
            // 
            this.txtCodigoMesa.Enabled = false;
            this.txtCodigoMesa.Location = new System.Drawing.Point(27, 63);
            this.txtCodigoMesa.Name = "txtCodigoMesa";
            this.txtCodigoMesa.Size = new System.Drawing.Size(136, 22);
            this.txtCodigoMesa.TabIndex = 12;
            this.txtCodigoMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigoMesa
            // 
            this.lblCodigoMesa.AutoSize = true;
            this.lblCodigoMesa.Location = new System.Drawing.Point(24, 33);
            this.lblCodigoMesa.Name = "lblCodigoMesa";
            this.lblCodigoMesa.Size = new System.Drawing.Size(107, 16);
            this.lblCodigoMesa.TabIndex = 11;
            this.lblCodigoMesa.Text = "Codigo de Mesa";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(362, 106);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(26, 16);
            this.lblPorcentaje.TabIndex = 10;
            this.lblPorcentaje.Text = "0%";
            // 
            // prgBarOcupación
            // 
            this.prgBarOcupación.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prgBarOcupación.Location = new System.Drawing.Point(248, 133);
            this.prgBarOcupación.Name = "prgBarOcupación";
            this.prgBarOcupación.Size = new System.Drawing.Size(188, 42);
            this.prgBarOcupación.TabIndex = 9;
            // 
            // lblOcupación
            // 
            this.lblOcupación.AutoSize = true;
            this.lblOcupación.Location = new System.Drawing.Point(259, 106);
            this.lblOcupación.Name = "lblOcupación";
            this.lblOcupación.Size = new System.Drawing.Size(72, 16);
            this.lblOcupación.TabIndex = 8;
            this.lblOcupación.Text = "Ocupación";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(609, 33);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // rdbReservada
            // 
            this.rdbReservada.AutoSize = true;
            this.rdbReservada.Location = new System.Drawing.Point(499, 117);
            this.rdbReservada.Name = "rdbReservada";
            this.rdbReservada.Size = new System.Drawing.Size(96, 20);
            this.rdbReservada.TabIndex = 6;
            this.rdbReservada.TabStop = true;
            this.rdbReservada.Text = "Reservada";
            this.rdbReservada.UseVisualStyleBackColor = true;
            // 
            // RdbOcupada
            // 
            this.RdbOcupada.AutoSize = true;
            this.RdbOcupada.Location = new System.Drawing.Point(683, 117);
            this.RdbOcupada.Name = "RdbOcupada";
            this.RdbOcupada.Size = new System.Drawing.Size(84, 20);
            this.RdbOcupada.TabIndex = 5;
            this.RdbOcupada.TabStop = true;
            this.RdbOcupada.Text = "Ocupada";
            this.RdbOcupada.UseVisualStyleBackColor = true;
            // 
            // rdbDisponible
            // 
            this.rdbDisponible.AutoSize = true;
            this.rdbDisponible.Location = new System.Drawing.Point(612, 64);
            this.rdbDisponible.Name = "rdbDisponible";
            this.rdbDisponible.Size = new System.Drawing.Size(93, 20);
            this.rdbDisponible.TabIndex = 4;
            this.rdbDisponible.TabStop = true;
            this.rdbDisponible.Text = "Disponible";
            this.rdbDisponible.UseVisualStyleBackColor = true;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(27, 147);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(136, 22);
            this.txtCapacidad.TabIndex = 3;
            this.txtCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(41, 117);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(74, 16);
            this.lblCapacidad.TabIndex = 2;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.Location = new System.Drawing.Point(248, 63);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.Size = new System.Drawing.Size(136, 22);
            this.txtNumeroMesa.TabIndex = 1;
            this.txtNumeroMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Location = new System.Drawing.Point(245, 33);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(111, 16);
            this.lblNumeroMesa.TabIndex = 0;
            this.lblNumeroMesa.Text = "Numero de Mesa";
            // 
            // btnEliminarMesa
            // 
            this.btnEliminarMesa.BackgroundImage = global::Presentación.Properties.Resources.Picture2;
            this.btnEliminarMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarMesa.FlatAppearance.BorderSize = 0;
            this.btnEliminarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMesa.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMesa.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMesa.Location = new System.Drawing.Point(738, 504);
            this.btnEliminarMesa.Name = "btnEliminarMesa";
            this.btnEliminarMesa.Size = new System.Drawing.Size(100, 93);
            this.btnEliminarMesa.TabIndex = 4;
            this.btnEliminarMesa.UseVisualStyleBackColor = true;
            this.btnEliminarMesa.Click += new System.EventHandler(this.btnEliminarMesa_Click);
            // 
            // btnModificarMesa
            // 
            this.btnModificarMesa.BackgroundImage = global::Presentación.Properties.Resources.Picture1;
            this.btnModificarMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarMesa.FlatAppearance.BorderSize = 0;
            this.btnModificarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMesa.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMesa.ForeColor = System.Drawing.Color.White;
            this.btnModificarMesa.Location = new System.Drawing.Point(373, 504);
            this.btnModificarMesa.Name = "btnModificarMesa";
            this.btnModificarMesa.Size = new System.Drawing.Size(100, 93);
            this.btnModificarMesa.TabIndex = 3;
            this.btnModificarMesa.UseVisualStyleBackColor = true;
            this.btnModificarMesa.Click += new System.EventHandler(this.btnModificarMesa_Click);
            // 
            // btnNuevaMesa
            // 
            this.btnNuevaMesa.BackgroundImage = global::Presentación.Properties.Resources.mesa_de_comedor;
            this.btnNuevaMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaMesa.FlatAppearance.BorderSize = 0;
            this.btnNuevaMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaMesa.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMesa.ForeColor = System.Drawing.Color.White;
            this.btnNuevaMesa.Location = new System.Drawing.Point(12, 504);
            this.btnNuevaMesa.Name = "btnNuevaMesa";
            this.btnNuevaMesa.Size = new System.Drawing.Size(100, 93);
            this.btnNuevaMesa.TabIndex = 2;
            this.btnNuevaMesa.UseVisualStyleBackColor = true;
            this.btnNuevaMesa.Click += new System.EventHandler(this.btnNuevaMesa_Click);
            // 
            // frmMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.btnEliminarMesa);
            this.Controls.Add(this.btnModificarMesa);
            this.Controls.Add(this.btnNuevaMesa);
            this.Controls.Add(this.grpMesas);
            this.Controls.Add(this.dgvMesas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMesas";
            this.Text = "Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.grpMesas.ResumeLayout(false);
            this.grpMesas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.GroupBox grpMesas;
        private System.Windows.Forms.TextBox txtNumeroMesa;
        private System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.RadioButton rdbReservada;
        private System.Windows.Forms.RadioButton RdbOcupada;
        private System.Windows.Forms.RadioButton rdbDisponible;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblOcupación;
        private System.Windows.Forms.ProgressBar prgBarOcupación;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnNuevaMesa;
        private System.Windows.Forms.Button btnModificarMesa;
        private System.Windows.Forms.Button btnEliminarMesa;
        private System.Windows.Forms.TextBox txtCodigoMesa;
        private System.Windows.Forms.Label lblCodigoMesa;
    }
}