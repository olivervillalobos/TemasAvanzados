
namespace AppMaestro
{
    partial class Grupo
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
            this.data_Grupo = new System.Windows.Forms.DataGridView();
            this.lblgrupo = new System.Windows.Forms.Label();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbDocente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_docente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Grupo)).BeginInit();
            this.SuspendLayout();
            // 
            // data_docente
            // 
            this.data_docente.AllowUserToOrderColumns = true;
            this.data_docente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_docente.Location = new System.Drawing.Point(312, 12);
            this.data_docente.Name = "data_docente";
            this.data_docente.RowHeadersWidth = 51;
            this.data_docente.RowTemplate.Height = 24;
            this.data_docente.Size = new System.Drawing.Size(691, 236);
            this.data_docente.TabIndex = 33;
            // 
            // data_Grupo
            // 
            this.data_Grupo.AllowUserToOrderColumns = true;
            this.data_Grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Grupo.Location = new System.Drawing.Point(312, 274);
            this.data_Grupo.Name = "data_Grupo";
            this.data_Grupo.RowHeadersWidth = 51;
            this.data_Grupo.RowTemplate.Height = 24;
            this.data_Grupo.Size = new System.Drawing.Size(691, 241);
            this.data_Grupo.TabIndex = 34;
            // 
            // lblgrupo
            // 
            this.lblgrupo.AutoSize = true;
            this.lblgrupo.Location = new System.Drawing.Point(12, 12);
            this.lblgrupo.Name = "lblgrupo";
            this.lblgrupo.Size = new System.Drawing.Size(65, 17);
            this.lblgrupo.TabIndex = 35;
            this.lblgrupo.Text = "ID Grupo";
            // 
            // txtgrupo
            // 
            this.txtgrupo.Location = new System.Drawing.Point(15, 36);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(263, 22);
            this.txtgrupo.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID Docente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbDocente
            // 
            this.cbDocente.FormattingEnabled = true;
            this.cbDocente.Location = new System.Drawing.Point(15, 116);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(263, 24);
            this.cbDocente.TabIndex = 42;
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 527);
            this.Controls.Add(this.cbDocente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgrupo);
            this.Controls.Add(this.lblgrupo);
            this.Controls.Add(this.data_Grupo);
            this.Controls.Add(this.data_docente);
            this.Name = "Grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo";
            this.Load += new System.EventHandler(this.Grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_docente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Grupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_docente;
        private System.Windows.Forms.DataGridView data_Grupo;
        private System.Windows.Forms.Label lblgrupo;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbDocente;
    }
}