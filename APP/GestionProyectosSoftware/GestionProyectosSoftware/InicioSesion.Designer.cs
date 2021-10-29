
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
            this.txt_idComputadora = new System.Windows.Forms.TextBox();
            this.txt_idAlumno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInicia
            // 
            this.btnInicia.BackColor = System.Drawing.Color.Transparent;
            this.btnInicia.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button_login;
            this.btnInicia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicia.FlatAppearance.BorderSize = 0;
            this.btnInicia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicia.Location = new System.Drawing.Point(240, 427);
            this.btnInicia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(187, 53);
            this.btnInicia.TabIndex = 0;
            this.btnInicia.Text = "INICIAR";
            this.btnInicia.UseVisualStyleBackColor = false;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button_login;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(240, 487);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(187, 50);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txt_idComputadora
            // 
            this.txt_idComputadora.BackColor = System.Drawing.Color.LightGray;
            this.txt_idComputadora.Location = new System.Drawing.Point(120, 350);
            this.txt_idComputadora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idComputadora.Name = "txt_idComputadora";
            this.txt_idComputadora.Size = new System.Drawing.Size(196, 22);
            this.txt_idComputadora.TabIndex = 2;
            // 
            // txt_idAlumno
            // 
            this.txt_idAlumno.BackColor = System.Drawing.Color.LightGray;
            this.txt_idAlumno.Location = new System.Drawing.Point(361, 350);
            this.txt_idAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idAlumno.Name = "txt_idAlumno";
            this.txt_idAlumno.Size = new System.Drawing.Size(196, 22);
            this.txt_idAlumno.TabIndex = 3;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 702);
            this.Controls.Add(this.txt_idAlumno);
            this.Controls.Add(this.txt_idComputadora);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInicia);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txt_idComputadora;
        private System.Windows.Forms.TextBox txt_idAlumno;
    }
}

