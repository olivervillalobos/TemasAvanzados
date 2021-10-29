using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectosSoftware
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Pizarra = new Pizarra();
            Pizarra.Show();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmNumeros = new Numeros();
            frmNumeros.Show();
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmLetras = new Letras();
            frmLetras.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmConfirmar = new ConfirmarCierreSesion();
            frmConfirmar.Show();
        }
    }
}
