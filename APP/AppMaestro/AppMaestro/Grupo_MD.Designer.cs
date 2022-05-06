namespace AppMaestro
{
    partial class Grupo_MD
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
            this.button5 = new System.Windows.Forms.Button();
            this.cbgrupo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdocente = new System.Windows.Forms.TextBox();
            this.lblgrupo = new System.Windows.Forms.Label();
            this.data_Grupo = new System.Windows.Forms.DataGridView();
            this.data_docente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_Grupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_docente)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(28, 204);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 36);
            this.button5.TabIndex = 54;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbgrupo
            // 
            this.cbgrupo.FormattingEnabled = true;
            this.cbgrupo.Location = new System.Drawing.Point(12, 69);
            this.cbgrupo.Margin = new System.Windows.Forms.Padding(2);
            this.cbgrupo.Name = "cbgrupo";
            this.cbgrupo.Size = new System.Drawing.Size(198, 21);
            this.cbgrupo.TabIndex = 53;
            this.cbgrupo.SelectedIndexChanged += new System.EventHandler(this.cbDocente_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(28, 244);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 36);
            this.button3.TabIndex = 52;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID Docente";
            // 
            // txtdocente
            // 
            this.txtdocente.Location = new System.Drawing.Point(11, 132);
            this.txtdocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtdocente.Name = "txtdocente";
            this.txtdocente.Size = new System.Drawing.Size(198, 20);
            this.txtdocente.TabIndex = 48;
            // 
            // lblgrupo
            // 
            this.lblgrupo.AutoSize = true;
            this.lblgrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblgrupo.ForeColor = System.Drawing.Color.White;
            this.lblgrupo.Location = new System.Drawing.Point(9, 37);
            this.lblgrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgrupo.Name = "lblgrupo";
            this.lblgrupo.Size = new System.Drawing.Size(50, 13);
            this.lblgrupo.TabIndex = 47;
            this.lblgrupo.Text = "ID Grupo";
            // 
            // data_Grupo
            // 
            this.data_Grupo.AllowUserToOrderColumns = true;
            this.data_Grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Grupo.Location = new System.Drawing.Point(234, 223);
            this.data_Grupo.Margin = new System.Windows.Forms.Padding(2);
            this.data_Grupo.Name = "data_Grupo";
            this.data_Grupo.RowHeadersWidth = 51;
            this.data_Grupo.RowTemplate.Height = 24;
            this.data_Grupo.Size = new System.Drawing.Size(518, 196);
            this.data_Grupo.TabIndex = 46;
            // 
            // data_docente
            // 
            this.data_docente.AllowUserToOrderColumns = true;
            this.data_docente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_docente.Location = new System.Drawing.Point(234, 10);
            this.data_docente.Margin = new System.Windows.Forms.Padding(2);
            this.data_docente.Name = "data_docente";
            this.data_docente.RowHeadersWidth = 51;
            this.data_docente.RowTemplate.Height = 24;
            this.data_docente.Size = new System.Drawing.Size(518, 192);
            this.data_docente.TabIndex = 45;
            // 
            // Grupo_MD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppMaestro.Properties.Resources.bg_maestros_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 428);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cbgrupo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdocente);
            this.Controls.Add(this.lblgrupo);
            this.Controls.Add(this.data_Grupo);
            this.Controls.Add(this.data_docente);
            this.MaximizeBox = false;
            this.Name = "Grupo_MD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo_MD";
            this.Load += new System.EventHandler(this.Grupo_MD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Grupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_docente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbgrupo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdocente;
        private System.Windows.Forms.Label lblgrupo;
        private System.Windows.Forms.DataGridView data_Grupo;
        private System.Windows.Forms.DataGridView data_docente;
    }
}