
namespace AppMaestro
{
    partial class Alumno
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
            this.lbl_ApellidoPaterno = new System.Windows.Forms.Label();
            this.txt_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txt_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoMaterno = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Grupo = new System.Windows.Forms.Label();
            this.lbl_IdComputadora = new System.Windows.Forms.Label();
            this.cb_Grupo = new System.Windows.Forms.ComboBox();
            this.cb_IdComputadora = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.data_Alumno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_Alumno)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ApellidoPaterno
            // 
            this.lbl_ApellidoPaterno.AutoSize = true;
            this.lbl_ApellidoPaterno.Location = new System.Drawing.Point(12, 12);
            this.lbl_ApellidoPaterno.Name = "lbl_ApellidoPaterno";
            this.lbl_ApellidoPaterno.Size = new System.Drawing.Size(112, 17);
            this.lbl_ApellidoPaterno.TabIndex = 2;
            this.lbl_ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // txt_ApellidoPaterno
            // 
            this.txt_ApellidoPaterno.Location = new System.Drawing.Point(12, 42);
            this.txt_ApellidoPaterno.Name = "txt_ApellidoPaterno";
            this.txt_ApellidoPaterno.Size = new System.Drawing.Size(240, 22);
            this.txt_ApellidoPaterno.TabIndex = 3;
            // 
            // txt_ApellidoMaterno
            // 
            this.txt_ApellidoMaterno.Location = new System.Drawing.Point(12, 112);
            this.txt_ApellidoMaterno.Name = "txt_ApellidoMaterno";
            this.txt_ApellidoMaterno.Size = new System.Drawing.Size(240, 22);
            this.txt_ApellidoMaterno.TabIndex = 5;
            // 
            // lbl_ApellidoMaterno
            // 
            this.lbl_ApellidoMaterno.AutoSize = true;
            this.lbl_ApellidoMaterno.Location = new System.Drawing.Point(12, 78);
            this.lbl_ApellidoMaterno.Name = "lbl_ApellidoMaterno";
            this.lbl_ApellidoMaterno.Size = new System.Drawing.Size(114, 17);
            this.lbl_ApellidoMaterno.TabIndex = 4;
            this.lbl_ApellidoMaterno.Text = "Apellido Materno";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(12, 185);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(240, 22);
            this.txt_Nombre.TabIndex = 7;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(12, 155);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(75, 17);
            this.lbl_Nombre.TabIndex = 6;
            this.lbl_Nombre.Text = "Nombre(s)";
            // 
            // lbl_Grupo
            // 
            this.lbl_Grupo.AutoSize = true;
            this.lbl_Grupo.Location = new System.Drawing.Point(12, 225);
            this.lbl_Grupo.Name = "lbl_Grupo";
            this.lbl_Grupo.Size = new System.Drawing.Size(48, 17);
            this.lbl_Grupo.TabIndex = 8;
            this.lbl_Grupo.Text = "Grupo";
            // 
            // lbl_IdComputadora
            // 
            this.lbl_IdComputadora.AutoSize = true;
            this.lbl_IdComputadora.Location = new System.Drawing.Point(12, 300);
            this.lbl_IdComputadora.Name = "lbl_IdComputadora";
            this.lbl_IdComputadora.Size = new System.Drawing.Size(108, 17);
            this.lbl_IdComputadora.TabIndex = 10;
            this.lbl_IdComputadora.Text = "Id Computadora";
            // 
            // cb_Grupo
            // 
            this.cb_Grupo.FormattingEnabled = true;
            this.cb_Grupo.Location = new System.Drawing.Point(15, 259);
            this.cb_Grupo.Name = "cb_Grupo";
            this.cb_Grupo.Size = new System.Drawing.Size(237, 24);
            this.cb_Grupo.TabIndex = 11;
            // 
            // cb_IdComputadora
            // 
            this.cb_IdComputadora.FormattingEnabled = true;
            this.cb_IdComputadora.Location = new System.Drawing.Point(15, 340);
            this.cb_IdComputadora.Name = "cb_IdComputadora";
            this.cb_IdComputadora.Size = new System.Drawing.Size(237, 24);
            this.cb_IdComputadora.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(138, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 465);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Regresar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // data_Alumno
            // 
            this.data_Alumno.AllowUserToOrderColumns = true;
            this.data_Alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Alumno.Location = new System.Drawing.Point(297, 33);
            this.data_Alumno.Name = "data_Alumno";
            this.data_Alumno.RowHeadersWidth = 51;
            this.data_Alumno.RowTemplate.Height = 24;
            this.data_Alumno.Size = new System.Drawing.Size(691, 455);
            this.data_Alumno.TabIndex = 18;
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 520);
            this.Controls.Add(this.data_Alumno);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_IdComputadora);
            this.Controls.Add(this.cb_Grupo);
            this.Controls.Add(this.lbl_IdComputadora);
            this.Controls.Add(this.lbl_Grupo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_ApellidoMaterno);
            this.Controls.Add(this.lbl_ApellidoMaterno);
            this.Controls.Add(this.txt_ApellidoPaterno);
            this.Controls.Add(this.lbl_ApellidoPaterno);
            this.Name = "Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Alumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ApellidoPaterno;
        private System.Windows.Forms.TextBox txt_ApellidoPaterno;
        private System.Windows.Forms.TextBox txt_ApellidoMaterno;
        private System.Windows.Forms.Label lbl_ApellidoMaterno;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Grupo;
        private System.Windows.Forms.Label lbl_IdComputadora;
        private System.Windows.Forms.ComboBox cb_Grupo;
        private System.Windows.Forms.ComboBox cb_IdComputadora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView data_Alumno;
    }
}