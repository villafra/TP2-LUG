namespace Presentación
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.panelMenuIzq = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picboxPanel = new System.Windows.Forms.PictureBox();
            this.btnLayout = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.mStripMenu = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MozosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cocinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenuIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPanel)).BeginInit();
            this.mStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaImagenes
            // 
            this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
            this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.ListaImagenes.Images.SetKeyName(0, "informe-seo.png");
            this.ListaImagenes.Images.SetKeyName(1, "pedido-en-linea.png");
            this.ListaImagenes.Images.SetKeyName(2, "reserva.png");
            this.ListaImagenes.Images.SetKeyName(3, "logout.png");
            this.ListaImagenes.Images.SetKeyName(4, "restaurant.png");
            this.ListaImagenes.Images.SetKeyName(5, "Picture2.png");
            this.ListaImagenes.Images.SetKeyName(6, "analitica.png");
            // 
            // panelMenuIzq
            // 
            this.panelMenuIzq.Controls.Add(this.btnLogin);
            this.panelMenuIzq.Controls.Add(this.btnPedidos);
            this.panelMenuIzq.Controls.Add(this.btnInformes);
            this.panelMenuIzq.Controls.Add(this.btnSalir);
            this.panelMenuIzq.Controls.Add(this.picboxPanel);
            this.panelMenuIzq.Controls.Add(this.btnLayout);
            this.panelMenuIzq.Controls.Add(this.btnReservas);
            this.panelMenuIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIzq.Location = new System.Drawing.Point(0, 28);
            this.panelMenuIzq.Name = "panelMenuIzq";
            this.panelMenuIzq.Size = new System.Drawing.Size(260, 625);
            this.panelMenuIzq.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.ImageIndex = 5;
            this.btnLogin.ImageList = this.ListaImagenes;
            this.btnLogin.Location = new System.Drawing.Point(26, 460);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(204, 54);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Usuarios";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.ImageIndex = 1;
            this.btnPedidos.ImageList = this.ListaImagenes;
            this.btnPedidos.Location = new System.Drawing.Point(26, 335);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(204, 54);
            this.btnPedidos.TabIndex = 15;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.ImageIndex = 0;
            this.btnInformes.ImageList = this.ListaImagenes;
            this.btnInformes.Location = new System.Drawing.Point(26, 398);
            this.btnInformes.Margin = new System.Windows.Forms.Padding(4);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(204, 54);
            this.btnInformes.TabIndex = 14;
            this.btnInformes.Text = "Histórico Login";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ImageIndex = 3;
            this.btnSalir.ImageList = this.ListaImagenes;
            this.btnSalir.Location = new System.Drawing.Point(26, 536);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 54);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picboxPanel
            // 
            this.picboxPanel.Image = global::Presentación.Properties.Resources.Picture4;
            this.picboxPanel.Location = new System.Drawing.Point(22, 13);
            this.picboxPanel.Margin = new System.Windows.Forms.Padding(4);
            this.picboxPanel.Name = "picboxPanel";
            this.picboxPanel.Size = new System.Drawing.Size(217, 166);
            this.picboxPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPanel.TabIndex = 10;
            this.picboxPanel.TabStop = false;
            // 
            // btnLayout
            // 
            this.btnLayout.ImageIndex = 6;
            this.btnLayout.ImageList = this.ListaImagenes;
            this.btnLayout.Location = new System.Drawing.Point(26, 209);
            this.btnLayout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayout.Name = "btnLayout";
            this.btnLayout.Size = new System.Drawing.Size(204, 54);
            this.btnLayout.TabIndex = 6;
            this.btnLayout.Text = "Reportes";
            this.btnLayout.UseVisualStyleBackColor = true;
            this.btnLayout.Click += new System.EventHandler(this.btnLayout_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.ImageIndex = 2;
            this.btnReservas.ImageList = this.ListaImagenes;
            this.btnReservas.Location = new System.Drawing.Point(26, 272);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(204, 54);
            this.btnReservas.TabIndex = 7;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // mStripMenu
            // 
            this.mStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.MesasToolStripMenuItem,
            this.MozosToolStripMenuItem,
            this.cocinaToolStripMenuItem,
            this.TurnosToolStripMenuItem,
            this.PlatosToolStripMenuItem,
            this.BebidasToolStripMenuItem});
            this.mStripMenu.Location = new System.Drawing.Point(0, 0);
            this.mStripMenu.Name = "mStripMenu";
            this.mStripMenu.Size = new System.Drawing.Size(1116, 28);
            this.mStripMenu.TabIndex = 1;
            this.mStripMenu.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripSeparator1});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 28);
            this.toolStripMenuItem1.Text = "Menu Principal";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(213, 28);
            this.toolStripMenuItem3.Text = "Loguearse";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 28);
            this.toolStripMenuItem2.Text = "Salir";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // MesasToolStripMenuItem
            // 
            this.MesasToolStripMenuItem.Name = "MesasToolStripMenuItem";
            this.MesasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.MesasToolStripMenuItem.Text = "Mesas";
            this.MesasToolStripMenuItem.Click += new System.EventHandler(this.MesasToolStripMenuItem_Click);
            // 
            // MozosToolStripMenuItem
            // 
            this.MozosToolStripMenuItem.Name = "MozosToolStripMenuItem";
            this.MozosToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.MozosToolStripMenuItem.Text = "Mozos";
            this.MozosToolStripMenuItem.Click += new System.EventHandler(this.MozosToolStripMenuItem_Click);
            // 
            // cocinaToolStripMenuItem
            // 
            this.cocinaToolStripMenuItem.Name = "cocinaToolStripMenuItem";
            this.cocinaToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.cocinaToolStripMenuItem.Text = "Cocina";
            this.cocinaToolStripMenuItem.Click += new System.EventHandler(this.cocinaToolStripMenuItem_Click);
            // 
            // TurnosToolStripMenuItem
            // 
            this.TurnosToolStripMenuItem.Name = "TurnosToolStripMenuItem";
            this.TurnosToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.TurnosToolStripMenuItem.Text = "Turnos";
            this.TurnosToolStripMenuItem.Click += new System.EventHandler(this.TurnosToolStripMenuItem_Click);
            // 
            // PlatosToolStripMenuItem
            // 
            this.PlatosToolStripMenuItem.Name = "PlatosToolStripMenuItem";
            this.PlatosToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.PlatosToolStripMenuItem.Text = "Platos";
            this.PlatosToolStripMenuItem.Click += new System.EventHandler(this.PlatosToolStripMenuItem_Click);
            // 
            // BebidasToolStripMenuItem
            // 
            this.BebidasToolStripMenuItem.Name = "BebidasToolStripMenuItem";
            this.BebidasToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.BebidasToolStripMenuItem.Text = "Bebidas";
            this.BebidasToolStripMenuItem.Click += new System.EventHandler(this.BebidasToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 653);
            this.Controls.Add(this.panelMenuIzq);
            this.Controls.Add(this.mStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mStripMenu;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restó";
            this.panelMenuIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPanel)).EndInit();
            this.mStripMenu.ResumeLayout(false);
            this.mStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnLayout;
        private System.Windows.Forms.PictureBox picboxPanel;
        private System.Windows.Forms.Panel panelMenuIzq;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip mStripMenu;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MozosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem PlatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BebidasToolStripMenuItem;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.ImageList ListaImagenes;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ToolStripMenuItem cocinaToolStripMenuItem;
    }
}