namespace Presentación
{
    partial class frmUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.prgCantidad = new System.Windows.Forms.ProgressBar();
            this.lblCantMozos = new System.Windows.Forms.Label();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnModificarTurno = new System.Windows.Forms.Button();
            this.btnNuevoTurno = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 44);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(398, 254);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellContentClick);
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.textBox2);
            this.grpUsuarios.Controls.Add(this.label2);
            this.grpUsuarios.Controls.Add(this.textBox1);
            this.grpUsuarios.Controls.Add(this.label1);
            this.grpUsuarios.Controls.Add(this.txtApellido);
            this.grpUsuarios.Controls.Add(this.lblApellido);
            this.grpUsuarios.Controls.Add(this.txtNombre);
            this.grpUsuarios.Controls.Add(this.lblNombre);
            this.grpUsuarios.Controls.Add(this.txtLegajo);
            this.grpUsuarios.Controls.Add(this.lblLegajo);
            this.grpUsuarios.Controls.Add(this.lblCantidad);
            this.grpUsuarios.Controls.Add(this.prgCantidad);
            this.grpUsuarios.Controls.Add(this.lblCantMozos);
            this.grpUsuarios.Location = new System.Drawing.Point(12, 313);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(826, 185);
            this.grpUsuarios.TabIndex = 1;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Turnos";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(347, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(99, 22);
            this.textBox2.TabIndex = 28;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(205, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Usuario";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(250, 143);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(148, 22);
            this.txtApellido.TabIndex = 24;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(247, 113);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 23;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(41, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 22);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Location = new System.Drawing.Point(41, 63);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(99, 22);
            this.txtLegajo.TabIndex = 20;
            this.txtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(38, 33);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(49, 16);
            this.lblLegajo.TabIndex = 19;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(699, 69);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(14, 16);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "0";
            // 
            // prgCantidad
            // 
            this.prgCantidad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prgCantidad.Location = new System.Drawing.Point(634, 123);
            this.prgCantidad.Maximum = 7;
            this.prgCantidad.Name = "prgCantidad";
            this.prgCantidad.Size = new System.Drawing.Size(157, 42);
            this.prgCantidad.Step = 1;
            this.prgCantidad.TabIndex = 9;
            // 
            // lblCantMozos
            // 
            this.lblCantMozos.AutoSize = true;
            this.lblCantMozos.Location = new System.Drawing.Point(660, 18);
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
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(437, 44);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(398, 254);
            this.dgvEmpleados.TabIndex = 5;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnEliminarTurno);
            this.Controls.Add(this.btnModificarTurno);
            this.Controls.Add(this.btnNuevoTurno);
            this.Controls.Add(this.grpUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.Label lblCantMozos;
        private System.Windows.Forms.ProgressBar prgCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnNuevoTurno;
        private System.Windows.Forms.Button btnModificarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}