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
            this.btnSeePass = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.prgCantidad = new System.Windows.Forms.ProgressBar();
            this.lblCantMozos = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnNuevoUser = new System.Windows.Forms.Button();
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
            this.dgvUsuarios.Location = new System.Drawing.Point(450, 53);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(388, 254);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.btnSeePass);
            this.grpUsuarios.Controls.Add(this.txtPass);
            this.grpUsuarios.Controls.Add(this.label2);
            this.grpUsuarios.Controls.Add(this.btnReset);
            this.grpUsuarios.Controls.Add(this.txtCodigo);
            this.grpUsuarios.Controls.Add(this.label3);
            this.grpUsuarios.Controls.Add(this.txtUsuario);
            this.grpUsuarios.Controls.Add(this.label1);
            this.grpUsuarios.Controls.Add(this.txtMail);
            this.grpUsuarios.Controls.Add(this.lblApellido);
            this.grpUsuarios.Controls.Add(this.txtNombre);
            this.grpUsuarios.Controls.Add(this.lblNombre);
            this.grpUsuarios.Controls.Add(this.txtLegajo);
            this.grpUsuarios.Controls.Add(this.lblLegajo);
            this.grpUsuarios.Controls.Add(this.prgCantidad);
            this.grpUsuarios.Controls.Add(this.lblCantMozos);
            this.grpUsuarios.Location = new System.Drawing.Point(12, 313);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(826, 185);
            this.grpUsuarios.TabIndex = 1;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Turnos";
            // 
            // btnSeePass
            // 
            this.btnSeePass.BackgroundImage = global::Presentación.Properties.Resources.eye;
            this.btnSeePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeePass.FlatAppearance.BorderSize = 0;
            this.btnSeePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeePass.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeePass.ForeColor = System.Drawing.Color.Gold;
            this.btnSeePass.Location = new System.Drawing.Point(566, 45);
            this.btnSeePass.Name = "btnSeePass";
            this.btnSeePass.Size = new System.Drawing.Size(63, 58);
            this.btnSeePass.TabIndex = 37;
            this.btnSeePass.UseVisualStyleBackColor = true;
            this.btnSeePass.Click += new System.EventHandler(this.btnSeePass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(397, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(163, 22);
            this.txtPass.TabIndex = 36;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Password";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Presentación.Properties.Resources.reset;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Gold;
            this.btnReset.Location = new System.Drawing.Point(715, 121);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 58);
            this.btnReset.TabIndex = 6;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(32, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 22);
            this.txtCodigo.TabIndex = 30;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Codigo";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(203, 64);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(125, 22);
            this.txtUsuario.TabIndex = 26;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Usuario";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(407, 143);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(222, 22);
            this.txtMail.TabIndex = 24;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(404, 113);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 16);
            this.lblApellido.TabIndex = 23;
            this.lblApellido.Text = "e-Mail";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(203, 143);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 22);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(200, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 16);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Empleado";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Location = new System.Drawing.Point(32, 143);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(99, 22);
            this.txtLegajo.TabIndex = 20;
            this.txtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(29, 113);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(49, 16);
            this.lblLegajo.TabIndex = 19;
            this.lblLegajo.Text = "Legajo";
            // 
            // prgCantidad
            // 
            this.prgCantidad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prgCantidad.Location = new System.Drawing.Point(660, 64);
            this.prgCantidad.Maximum = 5;
            this.prgCantidad.Name = "prgCantidad";
            this.prgCantidad.Size = new System.Drawing.Size(157, 42);
            this.prgCantidad.Step = 1;
            this.prgCantidad.TabIndex = 9;
            // 
            // lblCantMozos
            // 
            this.lblCantMozos.AutoSize = true;
            this.lblCantMozos.Location = new System.Drawing.Point(683, 18);
            this.lblCantMozos.Name = "lblCantMozos";
            this.lblCantMozos.Size = new System.Drawing.Size(83, 32);
            this.lblCantMozos.TabIndex = 8;
            this.lblCantMozos.Text = "Cantidad de \r\nIntentos";
            this.lblCantMozos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 53);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(432, 254);
            this.dgvEmpleados.TabIndex = 5;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.BackgroundImage = global::Presentación.Properties.Resources.Picture41;
            this.btnEliminarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarUser.FlatAppearance.BorderSize = 0;
            this.btnEliminarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUser.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUser.ForeColor = System.Drawing.Color.Gold;
            this.btnEliminarUser.Location = new System.Drawing.Point(738, 504);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(100, 93);
            this.btnEliminarUser.TabIndex = 4;
            this.btnEliminarUser.UseVisualStyleBackColor = true;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackgroundImage = global::Presentación.Properties.Resources.Picture61;
            this.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.Gold;
            this.btnEditUser.Location = new System.Drawing.Point(373, 504);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(100, 93);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnNuevoUser
            // 
            this.btnNuevoUser.BackgroundImage = global::Presentación.Properties.Resources.Picture31;
            this.btnNuevoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoUser.FlatAppearance.BorderSize = 0;
            this.btnNuevoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUser.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUser.ForeColor = System.Drawing.Color.Gold;
            this.btnNuevoUser.Location = new System.Drawing.Point(12, 504);
            this.btnNuevoUser.Name = "btnNuevoUser";
            this.btnNuevoUser.Size = new System.Drawing.Size(100, 93);
            this.btnNuevoUser.TabIndex = 2;
            this.btnNuevoUser.UseVisualStyleBackColor = true;
            this.btnNuevoUser.Click += new System.EventHandler(this.btnNuevoUser_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnEliminarUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnNuevoUser);
            this.Controls.Add(this.grpUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "Mesas";
            this.Activated += new System.EventHandler(this.frmUsuarios_Activated);
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
        private System.Windows.Forms.Button btnNuevoUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnEliminarUser;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSeePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
    }
}