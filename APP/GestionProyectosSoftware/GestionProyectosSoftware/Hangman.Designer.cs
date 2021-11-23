
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.layoutLetras = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblperdiste = new System.Windows.Forms.Label();
            this.labelAdivina = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botoninicio = new System.Windows.Forms.PictureBox();
            this.imagenestetica = new System.Windows.Forms.PictureBox();
            this.ahorcadoPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.botoninicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenestetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahorcadoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutLetras
            // 
            this.layoutLetras.BackColor = System.Drawing.Color.Transparent;
            this.layoutLetras.Location = new System.Drawing.Point(41, 111);
            this.layoutLetras.Margin = new System.Windows.Forms.Padding(2);
            this.layoutLetras.Name = "layoutLetras";
            this.layoutLetras.Size = new System.Drawing.Size(450, 242);
            this.layoutLetras.TabIndex = 0;
            // 
            // layoutPalabra
            // 
            this.layoutPalabra.BackColor = System.Drawing.Color.Transparent;
            this.layoutPalabra.Location = new System.Drawing.Point(158, 368);
            this.layoutPalabra.Margin = new System.Windows.Forms.Padding(2);
            this.layoutPalabra.Name = "layoutPalabra";
            this.layoutPalabra.Size = new System.Drawing.Size(582, 88);
            this.layoutPalabra.TabIndex = 2;
            // 
            // lblperdiste
            // 
            this.lblperdiste.AutoSize = true;
            this.lblperdiste.BackColor = System.Drawing.Color.Transparent;
            this.lblperdiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperdiste.ForeColor = System.Drawing.Color.White;
            this.lblperdiste.Location = new System.Drawing.Point(570, 127);
            this.lblperdiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblperdiste.Name = "lblperdiste";
            this.lblperdiste.Size = new System.Drawing.Size(98, 20);
            this.lblperdiste.TabIndex = 4;
            this.lblperdiste.Text = "PERDISTE";
            // 
            // labelAdivina
            // 
            this.labelAdivina.AutoSize = true;
            this.labelAdivina.BackColor = System.Drawing.Color.Transparent;
            this.labelAdivina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdivina.ForeColor = System.Drawing.Color.White;
            this.labelAdivina.Location = new System.Drawing.Point(166, 89);
            this.labelAdivina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdivina.Name = "labelAdivina";
            this.labelAdivina.Size = new System.Drawing.Size(161, 20);
            this.labelAdivina.TabIndex = 5;
            this.labelAdivina.Text = "¡Adivina la palabra!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(518, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botoninicio
            // 
            this.botoninicio.BackColor = System.Drawing.Color.Transparent;
            this.botoninicio.Location = new System.Drawing.Point(134, 40);
            this.botoninicio.Margin = new System.Windows.Forms.Padding(2);
            this.botoninicio.Name = "botoninicio";
            this.botoninicio.Size = new System.Drawing.Size(230, 41);
            this.botoninicio.TabIndex = 6;
            this.botoninicio.TabStop = false;
            this.botoninicio.Click += new System.EventHandler(this.botoninicio_Click);
            // 
            // imagenestetica
            // 
            this.imagenestetica.BackColor = System.Drawing.Color.Transparent;
            this.imagenestetica.Location = new System.Drawing.Point(41, 368);
            this.imagenestetica.Margin = new System.Windows.Forms.Padding(2);
            this.imagenestetica.Name = "imagenestetica";
            this.imagenestetica.Size = new System.Drawing.Size(103, 88);
            this.imagenestetica.TabIndex = 3;
            this.imagenestetica.TabStop = false;
            // 
            // ahorcadoPB
            // 
            this.ahorcadoPB.BackColor = System.Drawing.Color.Transparent;
            this.ahorcadoPB.Location = new System.Drawing.Point(495, 111);
            this.ahorcadoPB.Margin = new System.Windows.Forms.Padding(2);
            this.ahorcadoPB.Name = "ahorcadoPB";
            this.ahorcadoPB.Size = new System.Drawing.Size(245, 242);
            this.ahorcadoPB.TabIndex = 1;
            this.ahorcadoPB.TabStop = false;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botoninicio);
            this.Controls.Add(this.labelAdivina);
            this.Controls.Add(this.lblperdiste);
            this.Controls.Add(this.imagenestetica);
            this.Controls.Add(this.layoutPalabra);
            this.Controls.Add(this.ahorcadoPB);
            this.Controls.Add(this.layoutLetras);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hangman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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