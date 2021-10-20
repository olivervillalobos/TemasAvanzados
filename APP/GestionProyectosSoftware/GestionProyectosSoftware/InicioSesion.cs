using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionProyectosSoftware
{
    public partial class InicioSesion : Form
    {
        public int Id_Computadora;
        public int Id_Alumno;
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            try
            {
                Id_Computadora = 0;
                Id_Alumno = 0;

                Id_Computadora = Convert.ToInt32(txt_idComputadora.Text);
                Id_Alumno = Convert.ToInt32(txt_idAlumno.Text);

                if ((Id_Computadora != 0) && (Id_Alumno != 0))
                {
                    this.Hide();
                    Form menu = new Menu();
                    menu.Show();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Ha sucedido un error: Llene todo los campos.");
                }
            }
            catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Ha sucedido un error: Solo se permiten caracteres numericos.");
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            conexion sqlconexion = new conexion();
            sqlconexion.abrir();

            txt_idComputadora.Text = "0";
            txt_idAlumno.Text = "0";
        }
    }
}
