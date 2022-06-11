namespace Presentación
{
    partial class frmReservas
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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.dgvMesasDisponibles = new System.Windows.Forms.DataGridView();
            this.lblAsignarMesa = new System.Windows.Forms.Label();
            this.lblCancelarReserva = new System.Windows.Forms.Label();
            this.lblEditarMesa = new System.Windows.Forms.Label();
            this.btnEditarMesa = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnAsignarMesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(22, 26);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.Size = new System.Drawing.Size(374, 338);
            this.dgvReservas.TabIndex = 1;
            // 
            // dgvMesasDisponibles
            // 
            this.dgvMesasDisponibles.AllowUserToAddRows = false;
            this.dgvMesasDisponibles.AllowUserToDeleteRows = false;
            this.dgvMesasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesasDisponibles.Location = new System.Drawing.Point(464, 26);
            this.dgvMesasDisponibles.Name = "dgvMesasDisponibles";
            this.dgvMesasDisponibles.ReadOnly = true;
            this.dgvMesasDisponibles.RowHeadersWidth = 51;
            this.dgvMesasDisponibles.RowTemplate.Height = 24;
            this.dgvMesasDisponibles.Size = new System.Drawing.Size(341, 338);
            this.dgvMesasDisponibles.TabIndex = 2;
            // 
            // lblAsignarMesa
            // 
            this.lblAsignarMesa.AutoSize = true;
            this.lblAsignarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarMesa.Location = new System.Drawing.Point(170, 394);
            this.lblAsignarMesa.Name = "lblAsignarMesa";
            this.lblAsignarMesa.Size = new System.Drawing.Size(190, 25);
            this.lblAsignarMesa.TabIndex = 5;
            this.lblAsignarMesa.Text = "<== Asignar Mesa";
            // 
            // lblCancelarReserva
            // 
            this.lblCancelarReserva.AutoSize = true;
            this.lblCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarReserva.Location = new System.Drawing.Point(167, 495);
            this.lblCancelarReserva.Name = "lblCancelarReserva";
            this.lblCancelarReserva.Size = new System.Drawing.Size(229, 25);
            this.lblCancelarReserva.TabIndex = 6;
            this.lblCancelarReserva.Text = "<== Cancelar Reserva";
            // 
            // lblEditarMesa
            // 
            this.lblEditarMesa.AutoSize = true;
            this.lblEditarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarMesa.Location = new System.Drawing.Point(610, 394);
            this.lblEditarMesa.Name = "lblEditarMesa";
            this.lblEditarMesa.Size = new System.Drawing.Size(172, 25);
            this.lblEditarMesa.TabIndex = 7;
            this.lblEditarMesa.Text = "<== Editar Mesa";
            // 
            // btnEditarMesa
            // 
            this.btnEditarMesa.BackgroundImage = global::Presentación.Properties.Resources.Picture20;
            this.btnEditarMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarMesa.FlatAppearance.BorderSize = 0;
            this.btnEditarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMesa.Location = new System.Drawing.Point(464, 370);
            this.btnEditarMesa.Name = "btnEditarMesa";
            this.btnEditarMesa.Size = new System.Drawing.Size(108, 79);
            this.btnEditarMesa.TabIndex = 8;
            this.btnEditarMesa.UseVisualStyleBackColor = true;
            this.btnEditarMesa.Click += new System.EventHandler(this.btnEditarMesa_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.BackgroundImage = global::Presentación.Properties.Resources.Picture19;
            this.btnCancelarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarReserva.FlatAppearance.BorderSize = 0;
            this.btnCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReserva.Location = new System.Drawing.Point(33, 471);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(108, 79);
            this.btnCancelarReserva.TabIndex = 4;
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnAsignarMesa
            // 
            this.btnAsignarMesa.BackgroundImage = global::Presentación.Properties.Resources.mesa_redonda;
            this.btnAsignarMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAsignarMesa.FlatAppearance.BorderSize = 0;
            this.btnAsignarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarMesa.Location = new System.Drawing.Point(33, 370);
            this.btnAsignarMesa.Name = "btnAsignarMesa";
            this.btnAsignarMesa.Size = new System.Drawing.Size(108, 79);
            this.btnAsignarMesa.TabIndex = 3;
            this.btnAsignarMesa.UseVisualStyleBackColor = true;
            this.btnAsignarMesa.Click += new System.EventHandler(this.btnAsignarMesa_Click);
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 562);
            this.Controls.Add(this.btnEditarMesa);
            this.Controls.Add(this.lblEditarMesa);
            this.Controls.Add(this.lblCancelarReserva);
            this.Controls.Add(this.lblAsignarMesa);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnAsignarMesa);
            this.Controls.Add(this.dgvMesasDisponibles);
            this.Controls.Add(this.dgvReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservas";
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridView dgvMesasDisponibles;
        private System.Windows.Forms.Button btnAsignarMesa;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Label lblAsignarMesa;
        private System.Windows.Forms.Label lblCancelarReserva;
        private System.Windows.Forms.Label lblEditarMesa;
        private System.Windows.Forms.Button btnEditarMesa;
    }
}