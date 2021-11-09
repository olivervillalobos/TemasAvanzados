
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
            this.btnColores.BackColor = System.Drawing.Color.Transparent;
            this.btnColores.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button;
            this.btnColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColores.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnColores.FlatAppearance.BorderSize = 0;
            this.btnColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColores.ForeColor = System.Drawing.Color.White;
            this.btnColores.Location = new System.Drawing.Point(320, 309);
            this.btnColores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(153, 44);
            this.btnColores.TabIndex = 0;
            this.btnColores.Text = "COLORES";
            this.btnColores.UseVisualStyleBackColor = false;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // btnNumeros
            // 
            this.btnNumeros.BackColor = System.Drawing.Color.Transparent;
            this.btnNumeros.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button;
            this.btnNumeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumeros.FlatAppearance.BorderSize = 0;
            this.btnNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumeros.ForeColor = System.Drawing.Color.White;
            this.btnNumeros.Location = new System.Drawing.Point(557, 309);
            this.btnNumeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(149, 44);
            this.btnNumeros.TabIndex = 1;
            this.btnNumeros.Text = "NÚMEROS";
            this.btnNumeros.UseVisualStyleBackColor = false;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.BackColor = System.Drawing.Color.Transparent;
            this.btnLetras.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button;
            this.btnLetras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetras.FlatAppearance.BorderSize = 0;
            this.btnLetras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetras.ForeColor = System.Drawing.Color.White;
            this.btnLetras.Location = new System.Drawing.Point(799, 309);
            this.btnLetras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(155, 44);
            this.btnLetras.TabIndex = 2;
            this.btnLetras.Text = "LETRAS";
            this.btnLetras.UseVisualStyleBackColor = false;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1048, 34);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(169, 49);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 617);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnNumeros);
            this.Controls.Add(this.btnColores);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}