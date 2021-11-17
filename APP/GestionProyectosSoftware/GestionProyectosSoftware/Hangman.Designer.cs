
namespace GestionProyectosSoftware
{
    partial class Hangman
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
            this.layoutLetras = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblperdiste = new System.Windows.Forms.Label();
            this.labelAdivina = new System.Windows.Forms.Label();
            this.botoninicio = new System.Windows.Forms.PictureBox();
            this.imagenestetica = new System.Windows.Forms.PictureBox();
            this.ahorcadoPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.botoninicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenestetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahorcadoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutLetras
            // 
            this.layoutLetras.Location = new System.Drawing.Point(12, 95);
            this.layoutLetras.Name = "layoutLetras";
            this.layoutLetras.Size = new System.Drawing.Size(547, 298);
            this.layoutLetras.TabIndex = 0;
            // 
            // layoutPalabra
            // 
            this.layoutPalabra.Location = new System.Drawing.Point(131, 411);
            this.layoutPalabra.Name = "layoutPalabra";
            this.layoutPalabra.Size = new System.Drawing.Size(657, 53);
            this.layoutPalabra.TabIndex = 2;
            // 
            // lblperdiste
            // 
            this.lblperdiste.AutoSize = true;
            this.lblperdiste.Location = new System.Drawing.Point(573, 60);
            this.lblperdiste.Name = "lblperdiste";
            this.lblperdiste.Size = new System.Drawing.Size(60, 17);
            this.lblperdiste.TabIndex = 4;
            this.lblperdiste.Text = "Perdiste";
            // 
            // labelAdivina
            // 
            this.labelAdivina.AutoSize = true;
            this.labelAdivina.Location = new System.Drawing.Point(12, 60);
            this.labelAdivina.Name = "labelAdivina";
            this.labelAdivina.Size = new System.Drawing.Size(121, 17);
            this.labelAdivina.TabIndex = 5;
            this.labelAdivina.Text = "Adivina la palabra";
            // 
            // botoninicio
            // 
            this.botoninicio.Location = new System.Drawing.Point(12, 7);
            this.botoninicio.Name = "botoninicio";
            this.botoninicio.Size = new System.Drawing.Size(547, 50);
            this.botoninicio.TabIndex = 6;
            this.botoninicio.TabStop = false;
            this.botoninicio.Click += new System.EventHandler(this.botoninicio_Click);
            // 
            // imagenestetica
            // 
            this.imagenestetica.Location = new System.Drawing.Point(12, 411);
            this.imagenestetica.Name = "imagenestetica";
            this.imagenestetica.Size = new System.Drawing.Size(100, 53);
            this.imagenestetica.TabIndex = 3;
            this.imagenestetica.TabStop = false;
            // 
            // ahorcadoPB
            // 
            this.ahorcadoPB.Location = new System.Drawing.Point(576, 95);
            this.ahorcadoPB.Name = "ahorcadoPB";
            this.ahorcadoPB.Size = new System.Drawing.Size(212, 298);
            this.ahorcadoPB.TabIndex = 1;
            this.ahorcadoPB.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botoninicio);
            this.Controls.Add(this.labelAdivina);
            this.Controls.Add(this.lblperdiste);
            this.Controls.Add(this.imagenestetica);
            this.Controls.Add(this.layoutPalabra);
            this.Controls.Add(this.ahorcadoPB);
            this.Controls.Add(this.layoutLetras);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Hangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botoninicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenestetica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahorcadoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutLetras;
        private System.Windows.Forms.PictureBox ahorcadoPB;
        private System.Windows.Forms.FlowLayoutPanel layoutPalabra;
        private System.Windows.Forms.PictureBox imagenestetica;
        private System.Windows.Forms.Label lblperdiste;
        private System.Windows.Forms.Label labelAdivina;
        private System.Windows.Forms.PictureBox botoninicio;
        private System.Windows.Forms.Button button1;
    }
}