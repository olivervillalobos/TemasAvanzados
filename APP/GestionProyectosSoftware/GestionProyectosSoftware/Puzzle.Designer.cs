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
            this.components = new System.ComponentModel.Container();
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
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            this.btnRegresar.Location = new System.Drawing.Point(670, 132);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(128, 37);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // bt21
            // 
            this.bt21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bt21.Image = ((System.Drawing.Image)(resources.GetObject("bt21.Image")));
            this.bt21.Location = new System.Drawing.Point(46, 49);
            this.bt21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt21.Name = "bt21";
            this.bt21.Size = new System.Drawing.Size(120, 130);
            this.bt21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt21.TabIndex = 14;
            this.bt21.TabStop = false;
            this.bt21.Click += new System.EventHandler(this.bt21_Click);
            // 
            // spiderman
            // 
            this.spiderman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spiderman.Image = ((System.Drawing.Image)(resources.GetObject("spiderman.Image")));
            this.spiderman.Location = new System.Drawing.Point(182, 49);
            this.spiderman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spiderman.Name = "spiderman";
            this.spiderman.Size = new System.Drawing.Size(120, 130);
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
            this.sanrio.Location = new System.Drawing.Point(316, 49);
            this.sanrio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sanrio.Name = "sanrio";
            this.sanrio.Size = new System.Drawing.Size(120, 130);
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
            this.rb_1_facil.Location = new System.Drawing.Point(506, 62);
            this.rb_1_facil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_1_facil.Name = "rb_1_facil";
            this.rb_1_facil.Size = new System.Drawing.Size(47, 17);
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
            this.rb_2_normal.Location = new System.Drawing.Point(506, 102);
            this.rb_2_normal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_2_normal.Name = "rb_2_normal";
            this.rb_2_normal.Size = new System.Drawing.Size(58, 17);
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
            this.rb_3_dificil.Location = new System.Drawing.Point(506, 143);
            this.rb_3_dificil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_3_dificil.Name = "rb_3_dificil";
            this.rb_3_dificil.Size = new System.Drawing.Size(50, 17);
            this.rb_3_dificil.TabIndex = 19;
            this.rb_3_dificil.TabStop = true;
            this.rb_3_dificil.Text = "Dificil";
            this.rb_3_dificil.UseVisualStyleBackColor = false;
            // 
            // panel_puzzle
            // 
            this.panel_puzzle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_puzzle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_puzzle.Location = new System.Drawing.Point(46, 199);
            this.panel_puzzle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_puzzle.Name = "panel_puzzle";
            this.panel_puzzle.Size = new System.Drawing.Size(557, 547);
            this.panel_puzzle.TabIndex = 20;
            // 
            // panel_pieces
            // 
            this.panel_pieces.AutoScroll = true;
            this.panel_pieces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_pieces.Location = new System.Drawing.Point(628, 199);
            this.panel_pieces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_pieces.Name = "panel_pieces";
            this.panel_pieces.Size = new System.Drawing.Size(282, 547);
            this.panel_pieces.TabIndex = 21;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.White;
            this.lblPuntos.Location = new System.Drawing.Point(780, 96);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(70, 20);
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
            this.label3.Location = new System.Drawing.Point(780, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Puntaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(650, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = ":";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.White;
            this.lblMinutos.Location = new System.Drawing.Point(625, 93);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(29, 20);
            this.lblMinutos.TabIndex = 27;
            this.lblMinutos.Text = "00";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.White;
            this.lblSegundos.Location = new System.Drawing.Point(660, 93);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(29, 20);
            this.lblSegundos.TabIndex = 26;
            this.lblSegundos.Text = "00";
            // 
            // lblmilisegundos
            // 
            this.lblmilisegundos.AutoSize = true;
            this.lblmilisegundos.BackColor = System.Drawing.Color.Transparent;
            this.lblmilisegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmilisegundos.ForeColor = System.Drawing.Color.White;
            this.lblmilisegundos.Location = new System.Drawing.Point(695, 93);
            this.lblmilisegundos.Name = "lblmilisegundos";
            this.lblmilisegundos.Size = new System.Drawing.Size(39, 20);
            this.lblmilisegundos.TabIndex = 25;
            this.lblmilisegundos.Text = "000";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(647, 62);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(67, 20);
            this.lblTiempo.TabIndex = 24;
            this.lblTiempo.Text = "Tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(683, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = ":";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionProyectosSoftware.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 794);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Timer timer;
    }
}