namespace Presentación
{
    partial class frmPlatos
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
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.grpPlatos = new System.Windows.Forms.GroupBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.ComboClase = new System.Windows.Forms.ComboBox();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.prgFrecuencia = new System.Windows.Forms.ProgressBar();
            this.lblFrecuenciaPlato = new System.Windows.Forms.Label();
            this.dgvPedidosConPlat = new System.Windows.Forms.DataGridView();
            this.btnEliminarPlato = new System.Windows.Forms.Button();
            this.btnModificarPlato = new System.Windows.Forms.Button();
            this.btnNuevoPlato = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.grpPlatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosConPlat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.AllowUserToAddRows = false;
            this.dgvPlatos.AllowUserToDeleteRows = false;
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Location = new System.Drawing.Point(5, 53);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.ReadOnly = true;
            this.dgvPlatos.RowHeadersWidth = 51;
            this.dgvPlatos.RowTemplate.Height = 24;
            this.dgvPlatos.Size = new System.Drawing.Size(653, 254);
            this.dgvPlatos.TabIndex = 0;
            this.dgvPlatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlatos_CellContentClick);
            // 
            // grpPlatos
            // 
            this.grpPlatos.Controls.Add(this.txtStock);
            this.grpPlatos.Controls.Add(this.lblStock);
            this.grpPlatos.Controls.Add(this.txtCosto);
            this.grpPlatos.Controls.Add(this.lblCosto);
            this.grpPlatos.Controls.Add(this.ComboClase);
            this.grpPlatos.Controls.Add(this.ComboTipo);
            this.grpPlatos.Controls.Add(this.lblClase);
            this.grpPlatos.Controls.Add(this.lblTipo);
            this.grpPlatos.Controls.Add(this.txtNombre);
            this.grpPlatos.Controls.Add(this.lblNombre);
            this.grpPlatos.Controls.Add(this.txtCodigo);
            this.grpPlatos.Controls.Add(this.lblCodigo);
            this.grpPlatos.Controls.Add(this.lblCantidad);
            this.grpPlatos.Controls.Add(this.prgFrecuencia);
            this.grpPlatos.Controls.Add(this.lblFrecuenciaPlato);
            this.grpPlatos.Location = new System.Drawing.Point(12, 313);
            this.grpPlatos.Name = "grpPlatos";
            this.grpPlatos.Size = new System.Drawing.Size(826, 185);
            this.grpPlatos.TabIndex = 1;
            this.grpPlatos.TabStop = false;
            this.grpPlatos.Text = "Platos";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(482, 146);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(118, 22);
            this.txtCosto.TabIndex = 22;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(479, 114);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(42, 16);
            this.lblCosto.TabIndex = 21;
            this.lblCosto.Text = "Costo";
            // 
            // ComboClase
            // 
            this.ComboClase.FormattingEnabled = true;
            this.ComboClase.Items.AddRange(new object[] {
            "Gral.",
            "Vegetariano",
            "Vegano"});
            this.ComboClase.Location = new System.Drawing.Point(246, 144);
            this.ComboClase.Name = "ComboClase";
            this.ComboClase.Size = new System.Drawing.Size(215, 24);
            this.ComboClase.TabIndex = 20;
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Entrada",
            "Plato Principal",
            "Guarnición",
            "Postre"});
            this.ComboTipo.Location = new System.Drawing.Point(37, 142);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(173, 24);
            this.ComboTipo.TabIndex = 19;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(256, 114);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(42, 16);
            this.lblClase.TabIndex = 17;
            this.lblClase.Text = "Clase";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(41, 114);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "Tipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(248, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 22);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(256, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(47, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 22);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(44, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(715, 89);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(14, 16);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "0";
            // 
            // prgFrecuencia
            // 
            this.prgFrecuencia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prgFrecuencia.Location = new System.Drawing.Point(663, 124);
            this.prgFrecuencia.Name = "prgFrecuencia";
            this.prgFrecuencia.Size = new System.Drawing.Size(157, 42);
            this.prgFrecuencia.Step = 1;
            this.prgFrecuencia.TabIndex = 9;
            // 
            // lblFrecuenciaPlato
            // 
            this.lblFrecuenciaPlato.AutoSize = true;
            this.lblFrecuenciaPlato.Location = new System.Drawing.Point(694, 33);
            this.lblFrecuenciaPlato.Name = "lblFrecuenciaPlato";
            this.lblFrecuenciaPlato.Size = new System.Drawing.Size(67, 16);
            this.lblFrecuenciaPlato.TabIndex = 8;
            this.lblFrecuenciaPlato.Text = "Frecuecia";
            this.lblFrecuenciaPlato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPedidosConPlat
            // 
            this.dgvPedidosConPlat.AllowUserToAddRows = false;
            this.dgvPedidosConPlat.AllowUserToDeleteRows = false;
            this.dgvPedidosConPlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosConPlat.Location = new System.Drawing.Point(664, 53);
            this.dgvPedidosConPlat.Name = "dgvPedidosConPlat";
            this.dgvPedidosConPlat.ReadOnly = true;
            this.dgvPedidosConPlat.RowHeadersWidth = 51;
            this.dgvPedidosConPlat.RowTemplate.Height = 24;
            this.dgvPedidosConPlat.Size = new System.Drawing.Size(174, 254);
            this.dgvPedidosConPlat.TabIndex = 5;
            // 
            // btnEliminarPlato
            // 
            this.btnEliminarPlato.BackgroundImage = global::Presentación.Properties.Resources.Picture16;
            this.btnEliminarPlato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarPlato.FlatAppearance.BorderSize = 0;
            this.btnEliminarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPlato.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlato.ForeColor = System.Drawing.Color.Gold;
            this.btnEliminarPlato.Location = new System.Drawing.Point(738, 504);
            this.btnEliminarPlato.Name = "btnEliminarPlato";
            this.btnEliminarPlato.Size = new System.Drawing.Size(100, 93);
            this.btnEliminarPlato.TabIndex = 4;
            this.btnEliminarPlato.UseVisualStyleBackColor = true;
            this.btnEliminarPlato.Click += new System.EventHandler(this.btnEliminarPlato_Click);
            // 
            // btnModificarPlato
            // 
            this.btnModificarPlato.BackgroundImage = global::Presentación.Properties.Resources.Picture15;
            this.btnModificarPlato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarPlato.FlatAppearance.BorderSize = 0;
            this.btnModificarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPlato.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPlato.ForeColor = System.Drawing.Color.Gold;
            this.btnModificarPlato.Location = new System.Drawing.Point(373, 504);
            this.btnModificarPlato.Name = "btnModificarPlato";
            this.btnModificarPlato.Size = new System.Drawing.Size(100, 93);
            this.btnModificarPlato.TabIndex = 3;
            this.btnModificarPlato.UseVisualStyleBackColor = true;
            this.btnModificarPlato.Click += new System.EventHandler(this.btnModificarPlato_Click);
            // 
            // btnNuevoPlato
            // 
            this.btnNuevoPlato.BackgroundImage = global::Presentación.Properties.Resources.cordero;
            this.btnNuevoPlato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoPlato.FlatAppearance.BorderSize = 0;
            this.btnNuevoPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPlato.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPlato.ForeColor = System.Drawing.Color.Gold;
            this.btnNuevoPlato.Location = new System.Drawing.Point(12, 504);
            this.btnNuevoPlato.Name = "btnNuevoPlato";
            this.btnNuevoPlato.Size = new System.Drawing.Size(100, 93);
            this.btnNuevoPlato.TabIndex = 2;
            this.btnNuevoPlato.UseVisualStyleBackColor = true;
            this.btnNuevoPlato.Click += new System.EventHandler(this.btnNuevoPlato_Click);
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(561, 65);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(118, 22);
            this.txtStock.TabIndex = 24;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(558, 33);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 23;
            this.lblStock.Text = "Stock";
            // 
            // frmPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 609);
            this.Controls.Add(this.dgvPedidosConPlat);
            this.Controls.Add(this.btnEliminarPlato);
            this.Controls.Add(this.btnModificarPlato);
            this.Controls.Add(this.btnNuevoPlato);
            this.Controls.Add(this.grpPlatos);
            this.Controls.Add(this.dgvPlatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlatos";
            this.Text = "Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.grpPlatos.ResumeLayout(false);
            this.grpPlatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosConPlat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.GroupBox grpPlatos;
        private System.Windows.Forms.Label lblFrecuenciaPlato;
        private System.Windows.Forms.ProgressBar prgFrecuencia;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnNuevoPlato;
        private System.Windows.Forms.Button btnModificarPlato;
        private System.Windows.Forms.Button btnEliminarPlato;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvPedidosConPlat;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox ComboClase;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
    }
}