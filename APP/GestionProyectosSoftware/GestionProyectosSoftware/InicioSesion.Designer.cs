
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
            this.lbIDcomputadora = new System.Windows.Forms.Label();
            this.lblIDalumno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(177, 349);
            this.btnInicia.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(100, 28);
            this.btnInicia.TabIndex = 0;
            this.btnInicia.Text = "Iniciar";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(177, 428);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txt_idComputadora
            // 
            this.txt_idComputadora.Location = new System.Drawing.Point(76, 131);
            this.txt_idComputadora.Name = "txt_idComputadora";
            this.txt_idComputadora.Size = new System.Drawing.Size(319, 22);
            this.txt_idComputadora.TabIndex = 2;
            // 
            // txt_idAlumno
            // 
            this.txt_idAlumno.Location = new System.Drawing.Point(76, 216);
            this.txt_idAlumno.Name = "txt_idAlumno";
            this.txt_idAlumno.Size = new System.Drawing.Size(319, 22);
            this.txt_idAlumno.TabIndex = 3;
            // 
            // lbIDcomputadora
            // 
            this.lbIDcomputadora.AutoSize = true;
            this.lbIDcomputadora.Location = new System.Drawing.Point(73, 92);
            this.lbIDcomputadora.Name = "lbIDcomputadora";
            this.lbIDcomputadora.Size = new System.Drawing.Size(138, 21);
            this.lbIDcomputadora.TabIndex = 4;
            this.lbIDcomputadora.Text = "ID Computadora";
            // 
            // lblIDalumno
            // 
            this.lblIDalumno.AutoSize = true;
            this.lblIDalumno.Location = new System.Drawing.Point(73, 177);
            this.lblIDalumno.Name = "lblIDalumno";
            this.lblIDalumno.Size = new System.Drawing.Size(99, 21);
            this.lblIDalumno.TabIndex = 5;
            this.lblIDalumno.Text = "No. Control";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 523);
            this.Controls.Add(this.lblIDalumno);
            this.Controls.Add(this.lbIDcomputadora);
            this.Controls.Add(this.txt_idAlumno);
            this.Controls.Add(this.txt_idComputadora);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInicia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InicioSesion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txt_idComputadora;
        private System.Windows.Forms.TextBox txt_idAlumno;
        private System.Windows.Forms.Label lbIDcomputadora;
        private System.Windows.Forms.Label lblIDalumno;
    }
}

