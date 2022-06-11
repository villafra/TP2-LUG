namespace Presentación
{
    partial class frmPedidos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.lblCerrarPedido = new System.Windows.Forms.Label();
            this.lblCancelarPedido = new System.Windows.Forms.Label();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnCerrarPedido = new System.Windows.Forms.Button();
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(22, 26);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(516, 338);
            this.dgvPedidos.TabIndex = 1;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.AllowUserToAddRows = false;
            this.dgvPlatos.AllowUserToDeleteRows = false;
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Location = new System.Drawing.Point(544, 26);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.ReadOnly = true;
            this.dgvPlatos.RowHeadersWidth = 51;
            this.dgvPlatos.RowTemplate.Height = 24;
            this.dgvPlatos.Size = new System.Drawing.Size(303, 262);
            this.dgvPlatos.TabIndex = 2;
            // 
            // lblCerrarPedido
            // 
            this.lblCerrarPedido.AutoSize = true;
            this.lblCerrarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarPedido.Location = new System.Drawing.Point(170, 394);
            this.lblCerrarPedido.Name = "lblCerrarPedido";
            this.lblCerrarPedido.Size = new System.Drawing.Size(191, 25);
            this.lblCerrarPedido.TabIndex = 5;
            this.lblCerrarPedido.Text = "<== Cerrar Pedido";
            // 
            // lblCancelarPedido
            // 
            this.lblCancelarPedido.AutoSize = true;
            this.lblCancelarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarPedido.Location = new System.Drawing.Point(167, 495);
            this.lblCancelarPedido.Name = "lblCancelarPedido";
            this.lblCancelarPedido.Size = new System.Drawing.Size(217, 25);
            this.lblCancelarPedido.TabIndex = 6;
            this.lblCancelarPedido.Text = "<== Cancelar Pedido";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackgroundImage = global::Presentación.Properties.Resources.Picture21;
            this.btnCancelarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarPedido.FlatAppearance.BorderSize = 0;
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPedido.Location = new System.Drawing.Point(33, 471);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(108, 79);
            this.btnCancelarPedido.TabIndex = 4;
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnCerrarPedido
            // 
            this.btnCerrarPedido.BackgroundImage = global::Presentación.Properties.Resources.pedido_en_linea__1_;
            this.btnCerrarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarPedido.FlatAppearance.BorderSize = 0;
            this.btnCerrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPedido.Location = new System.Drawing.Point(33, 370);
            this.btnCerrarPedido.Name = "btnCerrarPedido";
            this.btnCerrarPedido.Size = new System.Drawing.Size(108, 79);
            this.btnCerrarPedido.TabIndex = 3;
            this.btnCerrarPedido.UseVisualStyleBackColor = true;
            this.btnCerrarPedido.Click += new System.EventHandler(this.btnCerrarPedido_Click);
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AllowUserToAddRows = false;
            this.dgvBebidas.AllowUserToDeleteRows = false;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Location = new System.Drawing.Point(544, 294);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.ReadOnly = true;
            this.dgvBebidas.RowHeadersWidth = 51;
            this.dgvBebidas.RowTemplate.Height = 24;
            this.dgvBebidas.Size = new System.Drawing.Size(303, 262);
            this.dgvBebidas.TabIndex = 7;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 562);
            this.Controls.Add(this.dgvBebidas);
            this.Controls.Add(this.lblCancelarPedido);
            this.Controls.Add(this.lblCerrarPedido);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnCerrarPedido);
            this.Controls.Add(this.dgvPlatos);
            this.Controls.Add(this.dgvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.Button btnCerrarPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Label lblCerrarPedido;
        private System.Windows.Forms.Label lblCancelarPedido;
        private System.Windows.Forms.DataGridView dgvBebidas;
    }
}