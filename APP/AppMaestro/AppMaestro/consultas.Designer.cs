
namespace AppMaestro
{
    partial class consultas
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
            this.cbopcion = new System.Windows.Forms.ComboBox();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // cbopcion
            // 
            this.cbopcion.FormattingEnabled = true;
            this.cbopcion.Items.AddRange(new object[] {
            "Grupo",
            "Alumno",
            "Colores",
            "Numeros",
            "Letras"});
            this.cbopcion.Location = new System.Drawing.Point(12, 12);
            this.cbopcion.Name = "cbopcion";
            this.cbopcion.Size = new System.Drawing.Size(121, 24);
            this.cbopcion.TabIndex = 0;
            this.cbopcion.SelectedIndexChanged += new System.EventHandler(this.cbopcion_SelectedIndexChanged);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Location = new System.Drawing.Point(153, 14);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(701, 22);
            this.txtconsulta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(982, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataConsulta
            // 
            this.dataConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsulta.Location = new System.Drawing.Point(12, 52);
            this.dataConsulta.Name = "dataConsulta";
            this.dataConsulta.RowHeadersWidth = 51;
            this.dataConsulta.RowTemplate.Height = 24;
            this.dataConsulta.Size = new System.Drawing.Size(982, 414);
            this.dataConsulta.TabIndex = 4;
            // 
            // consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 519);
            this.Controls.Add(this.dataConsulta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.cbopcion);
            this.Name = "consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultas";
            this.Load += new System.EventHandler(this.consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbopcion;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataConsulta;
    }
}