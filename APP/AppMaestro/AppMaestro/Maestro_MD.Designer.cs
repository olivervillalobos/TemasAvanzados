namespace AppMaestro
{
    partial class Maestro_MD
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
            this.button3 = new System.Windows.Forms.Button();
            this.data_docente = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoMaterno = new System.Windows.Forms.Label();
            this.txt_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoPaterno = new System.Windows.Forms.Label();
            this.cb_Docente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_docente)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(26, 328);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 33);
            this.button3.TabIndex = 45;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // data_docente
            // 
            this.data_docente.AllowUserToOrderColumns = true;
            this.data_docente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_docente.Location = new System.Drawing.Point(225, 28);
            this.data_docente.Margin = new System.Windows.Forms.Padding(2);
            this.data_docente.Name = "data_docente";
            this.data_docente.RowHeadersWidth = 51;
            this.data_docente.RowTemplate.Height = 24;
            this.data_docente.Size = new System.Drawing.Size(518, 370);
            this.data_docente.TabIndex = 44;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(26, 365);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 33);
            this.button5.TabIndex = 43;
            this.button5.Text = "Regresar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(15, 235);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(181, 20);
            this.txt_Nombre.TabIndex = 40;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(15, 204);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(55, 13);
            this.lbl_Nombre.TabIndex = 39;
            this.lbl_Nombre.Text = "Nombre(s)";
            // 
            // txt_ApellidoMaterno
            // 
            this.txt_ApellidoMaterno.Location = new System.Drawing.Point(15, 172);
            this.txt_ApellidoMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ApellidoMaterno.Name = "txt_ApellidoMaterno";
            this.txt_ApellidoMaterno.Size = new System.Drawing.Size(181, 20);
            this.txt_ApellidoMaterno.TabIndex = 38;
            // 
            // lbl_ApellidoMaterno
            // 
            this.lbl_ApellidoMaterno.AutoSize = true;
            this.lbl_ApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ApellidoMaterno.ForeColor = System.Drawing.Color.White;
            this.lbl_ApellidoMaterno.Location = new System.Drawing.Point(15, 148);
            this.lbl_ApellidoMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ApellidoMaterno.Name = "lbl_ApellidoMaterno";
            this.lbl_ApellidoMaterno.Size = new System.Drawing.Size(86, 13);
            this.lbl_ApellidoMaterno.TabIndex = 37;
            this.lbl_ApellidoMaterno.Text = "Apellido Materno";
            // 
            // txt_ApellidoPaterno
            // 
            this.txt_ApellidoPaterno.Location = new System.Drawing.Point(15, 111);
            this.txt_ApellidoPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ApellidoPaterno.Name = "txt_ApellidoPaterno";
            this.txt_ApellidoPaterno.Size = new System.Drawing.Size(181, 20);
            this.txt_ApellidoPaterno.TabIndex = 36;
            // 
            // lbl_ApellidoPaterno
            // 
            this.lbl_ApellidoPaterno.AutoSize = true;
            this.lbl_ApellidoPaterno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ApellidoPaterno.ForeColor = System.Drawing.Color.White;
            this.lbl_ApellidoPaterno.Location = new System.Drawing.Point(15, 81);
            this.lbl_ApellidoPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ApellidoPaterno.Name = "lbl_ApellidoPaterno";
            this.lbl_ApellidoPaterno.Size = new System.Drawing.Size(84, 13);
            this.lbl_ApellidoPaterno.TabIndex = 35;
            this.lbl_ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // cb_Docente
            // 
            this.cb_Docente.FormattingEnabled = true;
            this.cb_Docente.Location = new System.Drawing.Point(15, 46);
            this.cb_Docente.Name = "cb_Docente";
            this.cb_Docente.Size = new System.Drawing.Size(181, 21);
            this.cb_Docente.TabIndex = 47;
            this.cb_Docente.SelectedIndexChanged += new System.EventHandler(this.cb_Docente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Id Docente";
            // 
            // Maestro_MD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppMaestro.Properties.Resources.bg_maestros_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 427);
            this.Controls.Add(this.cb_Docente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.data_docente);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_ApellidoMaterno);
            this.Controls.Add(this.lbl_ApellidoMaterno);
            this.Controls.Add(this.txt_ApellidoPaterno);
            this.Controls.Add(this.lbl_ApellidoPaterno);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Maestro_MD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro_MD";
            this.Load += new System.EventHandler(this.Maestro_MD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_docente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView data_docente;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_ApellidoMaterno;
        private System.Windows.Forms.Label lbl_ApellidoMaterno;
        private System.Windows.Forms.TextBox txt_ApellidoPaterno;
        private System.Windows.Forms.Label lbl_ApellidoPaterno;
        private System.Windows.Forms.ComboBox cb_Docente;
        private System.Windows.Forms.Label label1;
    }
}