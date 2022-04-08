namespace GestionProyectosSoftware
{
    partial class Puzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puzzle));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.bt21 = new System.Windows.Forms.PictureBox();
            this.spiderman = new System.Windows.Forms.PictureBox();
            this.sanrio = new System.Windows.Forms.PictureBox();
            this.rb_1_facil = new System.Windows.Forms.RadioButton();
            this.rb_2_normal = new System.Windows.Forms.RadioButton();
            this.rb_3_dificil = new System.Windows.Forms.RadioButton();
            this.panel_puzzle = new System.Windows.Forms.Panel();
            this.panel_pieces = new System.Windows.Forms.Panel();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblmilisegundos = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bt21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiderman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanrio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.button;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(893, 163);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(171, 46);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // bt21
            // 
            this.bt21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bt21.Image = ((System.Drawing.Image)(resources.GetObject("bt21.Image")));
            this.bt21.Location = new System.Drawing.Point(61, 60);
            this.bt21.Name = "bt21";
            this.bt21.Size = new System.Drawing.Size(160, 159);
            this.bt21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt21.TabIndex = 14;
            this.bt21.TabStop = false;
            this.bt21.Click += new System.EventHandler(this.bt21_Click);
            // 
            // spiderman
            // 
            this.spiderman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spiderman.Image = ((System.Drawing.Image)(resources.GetObject("spiderman.Image")));
            this.spiderman.Location = new System.Drawing.Point(243, 60);
            this.spiderman.Name = "spiderman";
            this.spiderman.Size = new System.Drawing.Size(160, 159);
            this.spiderman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spiderman.TabIndex = 15;
            this.spiderman.TabStop = false;
            this.spiderman.Click += new System.EventHandler(this.spiderman_Click);
            // 
            // sanrio
            // 
            this.sanrio.BackColor = System.Drawing.SystemColors.Control;
            this.sanrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sanrio.Image = ((System.Drawing.Image)(resources.GetObject("sanrio.Image")));
            this.sanrio.Location = new System.Drawing.Point(421, 60);
            this.sanrio.Name = "sanrio";
            this.sanrio.Size = new System.Drawing.Size(160, 159);
            this.sanrio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sanrio.TabIndex = 16;
            this.sanrio.TabStop = false;
            this.sanrio.Click += new System.EventHandler(this.sanrio_Click);
            // 
            // rb_1_facil
            // 
            this.rb_1_facil.AutoSize = true;
            this.rb_1_facil.BackColor = System.Drawing.Color.Transparent;
            this.rb_1_facil.ForeColor = System.Drawing.Color.White;
            this.rb_1_facil.Location = new System.Drawing.Point(674, 76);
            this.rb_1_facil.Name = "rb_1_facil";
            this.rb_1_facil.Size = new System.Drawing.Size(57, 20);
            this.rb_1_facil.TabIndex = 17;
            this.rb_1_facil.TabStop = true;
            this.rb_1_facil.Text = "Facil";
            this.rb_1_facil.UseVisualStyleBackColor = false;
            // 
            // rb_2_normal
            // 
            this.rb_2_normal.AutoSize = true;
            this.rb_2_normal.BackColor = System.Drawing.Color.Transparent;
            this.rb_2_normal.ForeColor = System.Drawing.Color.White;
            this.rb_2_normal.Location = new System.Drawing.Point(674, 125);
            this.rb_2_normal.Name = "rb_2_normal";
            this.rb_2_normal.Size = new System.Drawing.Size(72, 20);
            this.rb_2_normal.TabIndex = 18;
            this.rb_2_normal.TabStop = true;
            this.rb_2_normal.Text = "Normal";
            this.rb_2_normal.UseVisualStyleBackColor = false;
            // 
            // rb_3_dificil
            // 
            this.rb_3_dificil.AutoSize = true;
            this.rb_3_dificil.BackColor = System.Drawing.Color.Transparent;
            this.rb_3_dificil.ForeColor = System.Drawing.Color.White;
            this.rb_3_dificil.Location = new System.Drawing.Point(674, 176);
            this.rb_3_dificil.Name = "rb_3_dificil";
            this.rb_3_dificil.Size = new System.Drawing.Size(60, 20);
            this.rb_3_dificil.TabIndex = 19;
            this.rb_3_dificil.TabStop = true;
            this.rb_3_dificil.Text = "Dificil";
            this.rb_3_dificil.UseVisualStyleBackColor = false;
            // 
            // panel_puzzle
            // 
            this.panel_puzzle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_puzzle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_puzzle.Location = new System.Drawing.Point(61, 245);
            this.panel_puzzle.Name = "panel_puzzle";
            this.panel_puzzle.Size = new System.Drawing.Size(742, 673);
            this.panel_puzzle.TabIndex = 20;
            // 
            // panel_pieces
            // 
            this.panel_pieces.AutoScroll = true;
            this.panel_pieces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pieces.Location = new System.Drawing.Point(837, 245);
            this.panel_pieces.Name = "panel_pieces";
            this.panel_pieces.Size = new System.Drawing.Size(375, 673);
            this.panel_pieces.TabIndex = 21;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.White;
            this.lblPuntos.Location = new System.Drawing.Point(1040, 118);
            this.lblPuntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(85, 25);
            this.lblPuntos.TabIndex = 23;
            this.lblPuntos.Text = "Puntaje";
            this.lblPuntos.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1040, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Puntaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(867, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = ":";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.White;
            this.lblMinutos.Location = new System.Drawing.Point(833, 114);
            this.lblMinutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(36, 25);
            this.lblMinutos.TabIndex = 27;
            this.lblMinutos.Text = "00";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.White;
            this.lblSegundos.Location = new System.Drawing.Point(880, 114);
            this.lblSegundos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(36, 25);
            this.lblSegundos.TabIndex = 26;
            this.lblSegundos.Text = "00";
            // 
            // lblmilisegundos
            // 
            this.lblmilisegundos.AutoSize = true;
            this.lblmilisegundos.BackColor = System.Drawing.Color.Transparent;
            this.lblmilisegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmilisegundos.ForeColor = System.Drawing.Color.White;
            this.lblmilisegundos.Location = new System.Drawing.Point(927, 114);
            this.lblmilisegundos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmilisegundos.Name = "lblmilisegundos";
            this.lblmilisegundos.Size = new System.Drawing.Size(48, 25);
            this.lblmilisegundos.TabIndex = 25;
            this.lblmilisegundos.Text = "000";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(863, 76);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(84, 25);
            this.lblTiempo.TabIndex = 24;
            this.lblTiempo.Text = "Tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(911, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = ":";
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblmilisegundos);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_pieces);
            this.Controls.Add(this.panel_puzzle);
            this.Controls.Add(this.rb_3_dificil);
            this.Controls.Add(this.rb_2_normal);
            this.Controls.Add(this.rb_1_facil);
            this.Controls.Add(this.sanrio);
            this.Controls.Add(this.spiderman);
            this.Controls.Add(this.bt21);
            this.Controls.Add(this.btnRegresar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Puzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            ((System.ComponentModel.ISupportInitialize)(this.bt21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiderman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanrio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox bt21;
        private System.Windows.Forms.PictureBox spiderman;
        private System.Windows.Forms.PictureBox sanrio;
        private System.Windows.Forms.RadioButton rb_1_facil;
        private System.Windows.Forms.RadioButton rb_2_normal;
        private System.Windows.Forms.RadioButton rb_3_dificil;
        private System.Windows.Forms.Panel panel_puzzle;
        private System.Windows.Forms.Panel panel_pieces;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblmilisegundos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label2;
    }
}