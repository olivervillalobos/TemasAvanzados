namespace AppMaestro
{
    partial class Computadoras
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
            this.lblComputadoras = new System.Windows.Forms.Label();
            this.btn_Incrementar = new System.Windows.Forms.Button();
            this.btn_Disminuir = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblComputadoras
            // 
            this.lblComputadoras.AutoSize = true;
            this.lblComputadoras.BackColor = System.Drawing.Color.Transparent;
            this.lblComputadoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 199.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputadoras.ForeColor = System.Drawing.Color.White;
            this.lblComputadoras.Location = new System.Drawing.Point(472, 66);
            this.lblComputadoras.Name = "lblComputadoras";
            this.lblComputadoras.Size = new System.Drawing.Size(528, 377);
            this.lblComputadoras.TabIndex = 13;
            this.lblComputadoras.Text = "00";
            // 
            // btn_Incrementar
            // 
            this.btn_Incrementar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Incrementar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Incrementar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incrementar.ForeColor = System.Drawing.Color.Black;
            this.btn_Incrementar.Location = new System.Drawing.Point(12, 11);
            this.btn_Incrementar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Incrementar.Name = "btn_Incrementar";
            this.btn_Incrementar.Size = new System.Drawing.Size(431, 190);
            this.btn_Incrementar.TabIndex = 14;
            this.btn_Incrementar.Text = "Incrementar";
            this.btn_Incrementar.UseVisualStyleBackColor = false;
            this.btn_Incrementar.Click += new System.EventHandler(this.btn_Incrementar_Click);
            // 
            // btn_Disminuir
            // 
            this.btn_Disminuir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Disminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Disminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disminuir.ForeColor = System.Drawing.Color.Black;
            this.btn_Disminuir.Location = new System.Drawing.Point(12, 219);
            this.btn_Disminuir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Disminuir.Name = "btn_Disminuir";
            this.btn_Disminuir.Size = new System.Drawing.Size(431, 190);
            this.btn_Disminuir.TabIndex = 15;
            this.btn_Disminuir.Text = "Disminuir";
            this.btn_Disminuir.UseVisualStyleBackColor = false;
            this.btn_Disminuir.Click += new System.EventHandler(this.btn_Disminuir_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 453);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(431, 62);
            this.button5.TabIndex = 18;
            this.button5.Text = "R e g r e s a r";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Computadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppMaestro.Properties.Resources.bg_maestros_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 526);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_Disminuir);
            this.Controls.Add(this.btn_Incrementar);
            this.Controls.Add(this.lblComputadoras);
            this.DoubleBuffered = true;
            this.Name = "Computadoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computadoras";
            this.Load += new System.EventHandler(this.Computadoras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComputadoras;
        private System.Windows.Forms.Button btn_Incrementar;
        private System.Windows.Forms.Button btn_Disminuir;
        private System.Windows.Forms.Button button5;
    }
}