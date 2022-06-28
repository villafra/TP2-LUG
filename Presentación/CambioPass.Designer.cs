namespace Presentación
{
    partial class CambioPass
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
            this.cambiarPass1 = new Presentación.CambiarPass();
            this.SuspendLayout();
            // 
            // cambiarPass1
            // 
            this.cambiarPass1.Location = new System.Drawing.Point(22, 20);
            this.cambiarPass1.Name = "cambiarPass1";
            this.cambiarPass1.Size = new System.Drawing.Size(334, 262);
            this.cambiarPass1.TabIndex = 0;
            // 
            // CambioPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 302);
            this.Controls.Add(this.cambiarPass1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambioPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambioPass";
            this.ResumeLayout(false);

        }

        #endregion

        private CambiarPass cambiarPass1;
    }
}