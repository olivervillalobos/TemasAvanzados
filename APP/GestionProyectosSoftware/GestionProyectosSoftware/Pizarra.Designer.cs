
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
            this.SuspendLayout();
            // 
            // Lienzo
            // 
            this.Lienzo.BackColor = System.Drawing.Color.Transparent;
            this.Lienzo.Location = new System.Drawing.Point(110, 89);
            this.Lienzo.Name = "Lienzo";
            this.Lienzo.Size = new System.Drawing.Size(586, 358);
            this.Lienzo.TabIndex = 0;
            this.Lienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lienzo_MouseDown);
            this.Lienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lienzo_MouseMove);
            this.Lienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lienzo_MouseUp);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(392, 35);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(114, 41);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Negro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color: ";
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.Location = new System.Drawing.Point(12, 110);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(75, 23);
            this.btnRojo.TabIndex = 3;
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVerde.Location = new System.Drawing.Point(12, 139);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(75, 23);
            this.btnVerde.TabIndex = 4;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnPurpura
            // 
            this.btnPurpura.BackColor = System.Drawing.Color.Purple;
            this.btnPurpura.Location = new System.Drawing.Point(12, 226);
            this.btnPurpura.Name = "btnPurpura";
            this.btnPurpura.Size = new System.Drawing.Size(75, 23);
            this.btnPurpura.TabIndex = 5;
            this.btnPurpura.UseVisualStyleBackColor = false;
            this.btnPurpura.Click += new System.EventHandler(this.btnPurpura_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Location = new System.Drawing.Point(12, 168);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(75, 23);
            this.btnAzul.TabIndex = 5;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnNaranja
            // 
            this.btnNaranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNaranja.Location = new System.Drawing.Point(12, 197);
            this.btnNaranja.Name = "btnNaranja";
            this.btnNaranja.Size = new System.Drawing.Size(75, 23);
            this.btnNaranja.TabIndex = 6;
            this.btnNaranja.UseVisualStyleBackColor = false;
            this.btnNaranja.Click += new System.EventHandler(this.btnNaranja_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.BackColor = System.Drawing.Color.Black;
            this.btnNegro.Location = new System.Drawing.Point(12, 255);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(75, 23);
            this.btnNegro.TabIndex = 7;
            this.btnNegro.UseVisualStyleBackColor = false;
            this.btnNegro.Click += new System.EventHandler(this.btnNegro_Click);
            // 
            // Pizarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 468);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnNaranja);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnPurpura);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.Lienzo);
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
    }
}