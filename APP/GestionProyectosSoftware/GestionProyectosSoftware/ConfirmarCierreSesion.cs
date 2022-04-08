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
    public partial class ConfirmarCierreSesion : Form
    {
        public ConfirmarCierreSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form frmInicio = new InicioSesion();
            this.Close();
            frmInicio.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmMenu = new Menu();
            frmMenu.Show();
        }
    }
}