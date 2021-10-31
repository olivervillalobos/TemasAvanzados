
namespace AppMaestro
{
    partial class docente
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
            this.data_docente = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoMaterno = new System.Windows.Forms.Label();
            this.txt_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoPaterno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_docente)).BeginInit();
            this.SuspendLayout();
            // 
            // data_docente
            // 
            this.data_docente.AllowUserToOrderColumns = true;
            this.data_docente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_docente.Location = new System.Drawing.Point(300, 48);
            this.data_docente.Name = "data_docente";
            this.data_docente.RowHeadersWidth = 51;
            this.data_docente.RowTemplate.Height = 24;
            this.data_docente.Size = new System.Drawing.Size(691, 455);
            this.data_docente.TabIndex = 32;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "Regresar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(175, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(10, 201);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(240, 22);
            this.txt_Nombre.TabIndex = 24;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(10, 163);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(75, 17);
            this.lbl_Nombre.TabIndex = 23;
            this.lbl_Nombre.Text = "Nombre(s)";
            // 
            // txt_ApellidoMaterno
            // 
            this.txt_ApellidoMaterno.Location = new System.Drawing.Point(10, 123);
            this.txt_ApellidoMaterno.Name = "txt_ApellidoMaterno";
            this.txt_ApellidoMaterno.Size = new System.Drawing.Size(240, 22);
            this.txt_ApellidoMaterno.TabIndex = 22;
            // 
            // lbl_ApellidoMaterno
            // 
            this.lbl_ApellidoMaterno.AutoSize = true;
            this.lbl_ApellidoMaterno.Location = new System.Drawing.Point(10, 93);
            this.lbl_ApellidoMaterno.Name = "lbl_ApellidoMaterno";
            this.lbl_ApellidoMaterno.Size = new System.Drawing.Size(114, 17);
            this.lbl_ApellidoMaterno.TabIndex = 21;
            this.lbl_ApellidoMaterno.Text = "Apellido Materno";
            // 
            // txt_ApellidoPaterno
            // 
            this.txt_ApellidoPaterno.Location = new System.Drawing.Point(10, 48);
            this.txt_ApellidoPaterno.Name = "txt_ApellidoPaterno";
            this.txt_ApellidoPaterno.Size = new System.Drawing.Size(240, 22);
            this.txt_ApellidoPaterno.TabIndex = 20;
            // 
            // lbl_ApellidoPaterno
            // 
            this.lbl_ApellidoPaterno.AutoSize = true;
            this.lbl_ApellidoPaterno.Location = new System.Drawing.Point(10, 11);
            this.lbl_ApellidoPaterno.Name = "lbl_ApellidoPaterno";
            this.lbl_ApellidoPaterno.Size = new System.Drawing.Size(112, 17);
            this.lbl_ApellidoPaterno.TabIndex = 19;
            this.lbl_ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 525);
            this.Controls.Add(this.data_docente);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_ApellidoMaterno);
            this.Controls.Add(this.lbl_ApellidoMaterno);
            this.Controls.Add(this.txt_ApellidoPaterno);
            this.Controls.Add(this.lbl_ApellidoPaterno);
            this.Name = "docente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "docente";
            ((System.ComponentModel.ISupportInitialize)(this.data_docente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_docente;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_ApellidoMaterno;
        private System.Windows.Forms.Label lbl_ApellidoMaterno;
        private System.Windows.Forms.TextBox txt_ApellidoPaterno;
        private System.Windows.Forms.Label lbl_ApellidoPaterno;
    }
}