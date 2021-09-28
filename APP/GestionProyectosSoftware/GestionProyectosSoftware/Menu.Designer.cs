
namespace GestionProyectosSoftware
{
    partial class Menu
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
            this.btnColores = new System.Windows.Forms.Button();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColores
            // 
            this.btnColores.Location = new System.Drawing.Point(37, 144);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(75, 23);
            this.btnColores.TabIndex = 0;
            this.btnColores.Text = "Colores";
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.Location = new System.Drawing.Point(177, 143);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(75, 23);
            this.btnNumeros.TabIndex = 1;
            this.btnNumeros.Text = "Numeros";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Location = new System.Drawing.Point(320, 143);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(75, 23);
            this.btnLetras.TabIndex = 2;
            this.btnLetras.Text = "Letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(319, 12);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(127, 23);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 320);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.btnColores);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}