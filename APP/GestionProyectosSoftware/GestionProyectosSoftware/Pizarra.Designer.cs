
namespace GestionProyectosSoftware
{
    partial class Pizarra
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
            this.Lienzo = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnPurpura = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnNaranja = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnBlanco = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnRosa = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCambiarFondo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lienzo
            // 
            this.Lienzo.BackColor = System.Drawing.Color.Transparent;
            this.Lienzo.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.poyo;
            this.Lienzo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Lienzo.Location = new System.Drawing.Point(220, 110);
            this.Lienzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lienzo.Name = "Lienzo";
            this.Lienzo.Size = new System.Drawing.Size(937, 441);
            this.Lienzo.TabIndex = 0;
            this.Lienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lienzo_MouseDown);
            this.Lienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lienzo_MouseMove);
            this.Lienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lienzo_MouseUp);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(676, 42);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(148, 52);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Negro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(504, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color: ";
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Transparent;
            this.btnRojo.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.rojo;
            this.btnRojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRojo.FlatAppearance.BorderSize = 0;
            this.btnRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRojo.Location = new System.Drawing.Point(73, 244);
            this.btnRojo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(125, 37);
            this.btnRojo.TabIndex = 3;
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Transparent;
            this.btnVerde.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.verde;
            this.btnVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerde.FlatAppearance.BorderSize = 0;
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerde.Location = new System.Drawing.Point(73, 362);
            this.btnVerde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(125, 37);
            this.btnVerde.TabIndex = 4;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnPurpura
            // 
            this.btnPurpura.BackColor = System.Drawing.Color.Transparent;
            this.btnPurpura.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.morado;
            this.btnPurpura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurpura.FlatAppearance.BorderSize = 0;
            this.btnPurpura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurpura.Location = new System.Drawing.Point(73, 441);
            this.btnPurpura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPurpura.Name = "btnPurpura";
            this.btnPurpura.Size = new System.Drawing.Size(125, 37);
            this.btnPurpura.TabIndex = 5;
            this.btnPurpura.UseVisualStyleBackColor = false;
            this.btnPurpura.Click += new System.EventHandler(this.btnPurpura_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Transparent;
            this.btnAzul.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.azul;
            this.btnAzul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzul.FlatAppearance.BorderSize = 0;
            this.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzul.Location = new System.Drawing.Point(73, 401);
            this.btnAzul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(125, 37);
            this.btnAzul.TabIndex = 5;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnNaranja
            // 
            this.btnNaranja.BackColor = System.Drawing.Color.Transparent;
            this.btnNaranja.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.naranja;
            this.btnNaranja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNaranja.FlatAppearance.BorderSize = 0;
            this.btnNaranja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaranja.Location = new System.Drawing.Point(73, 283);
            this.btnNaranja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNaranja.Name = "btnNaranja";
            this.btnNaranja.Size = new System.Drawing.Size(125, 37);
            this.btnNaranja.TabIndex = 6;
            this.btnNaranja.UseVisualStyleBackColor = false;
            this.btnNaranja.Click += new System.EventHandler(this.btnNaranja_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.BackColor = System.Drawing.Color.Transparent;
            this.btnNegro.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.negro;
            this.btnNegro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNegro.FlatAppearance.BorderSize = 0;
            this.btnNegro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegro.Location = new System.Drawing.Point(73, 165);
            this.btnNegro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(125, 37);
            this.btnNegro.TabIndex = 7;
            this.btnNegro.UseVisualStyleBackColor = false;
            this.btnNegro.Click += new System.EventHandler(this.btnNegro_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.BackColor = System.Drawing.Color.Transparent;
            this.btnCafe.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.café;
            this.btnCafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCafe.FlatAppearance.BorderSize = 0;
            this.btnCafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCafe.Location = new System.Drawing.Point(73, 204);
            this.btnCafe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(125, 37);
            this.btnCafe.TabIndex = 11;
            this.btnCafe.UseVisualStyleBackColor = false;
            this.btnCafe.Click += new System.EventHandler(this.btnCafe_Click);
            // 
            // btnBlanco
            // 
            this.btnBlanco.BackColor = System.Drawing.Color.Transparent;
            this.btnBlanco.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.blanco;
            this.btnBlanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlanco.FlatAppearance.BorderSize = 0;
            this.btnBlanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlanco.Location = new System.Drawing.Point(73, 126);
            this.btnBlanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(125, 37);
            this.btnBlanco.TabIndex = 10;
            this.btnBlanco.UseVisualStyleBackColor = false;
            this.btnBlanco.Click += new System.EventHandler(this.btnBlanco_Click);
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.BackColor = System.Drawing.Color.Transparent;
            this.btnAmarillo.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.amarillo;
            this.btnAmarillo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAmarillo.FlatAppearance.BorderSize = 0;
            this.btnAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmarillo.Location = new System.Drawing.Point(73, 322);
            this.btnAmarillo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(125, 37);
            this.btnAmarillo.TabIndex = 8;
            this.btnAmarillo.UseVisualStyleBackColor = false;
            this.btnAmarillo.Click += new System.EventHandler(this.btnAmarillo_Click);
            // 
            // btnRosa
            // 
            this.btnRosa.BackColor = System.Drawing.Color.Transparent;
            this.btnRosa.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.rosa;
            this.btnRosa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRosa.FlatAppearance.BorderSize = 0;
            this.btnRosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRosa.Location = new System.Drawing.Point(73, 480);
            this.btnRosa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRosa.Name = "btnRosa";
            this.btnRosa.Size = new System.Drawing.Size(125, 37);
            this.btnRosa.TabIndex = 9;
            this.btnRosa.UseVisualStyleBackColor = false;
            this.btnRosa.Click += new System.EventHandler(this.btnRosa_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(73, 42);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(169, 49);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCambiarFondo
            // 
            this.btnCambiarFondo.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarFondo.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button;
            this.btnCambiarFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCambiarFondo.FlatAppearance.BorderSize = 0;
            this.btnCambiarFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarFondo.ForeColor = System.Drawing.Color.White;
            this.btnCambiarFondo.Location = new System.Drawing.Point(1012, 42);
            this.btnCambiarFondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCambiarFondo.Name = "btnCambiarFondo";
            this.btnCambiarFondo.Size = new System.Drawing.Size(169, 49);
            this.btnCambiarFondo.TabIndex = 13;
            this.btnCambiarFondo.Text = "Cambiar Fondo";
            this.btnCambiarFondo.UseVisualStyleBackColor = false;
            this.btnCambiarFondo.Click += new System.EventHandler(this.btnCambiarFondo_Click);
            // 
            // Pizarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 617);
            this.Controls.Add(this.btnCambiarFondo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCafe);
            this.Controls.Add(this.btnNaranja);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnBlanco);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnRosa);
            this.Controls.Add(this.btnPurpura);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.Lienzo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pizarra";
            this.Text = "Pizarra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Lienzo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnPurpura;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnNaranja;
        private System.Windows.Forms.Button btnNegro;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnBlanco;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Button btnRosa;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCambiarFondo;
    }
}