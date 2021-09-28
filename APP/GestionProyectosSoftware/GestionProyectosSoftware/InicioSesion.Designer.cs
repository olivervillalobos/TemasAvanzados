
namespace GestionProyectosSoftware
{
    partial class InicioSesion
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
            this.btnInicia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(133, 223);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(75, 23);
            this.btnInicia.TabIndex = 0;
            this.btnInicia.Text = "Iniciar";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(133, 280);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 425);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInicia);
            this.Name = "InicioSesion";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.Button btnSalir;
    }
}

