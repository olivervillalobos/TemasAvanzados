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
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

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
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
            logins();
        }

        public void logins()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id_Computadora, Id_Alumno FROM Inicio_Sesion WHERE Id_Computadora = '" + txt_idComputadora.Text + "' AND Id_Alumno = '" + txt_idAlumno.Text + "'", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    global.id_user = Convert.ToInt32(txt_idAlumno.Text);
                    MessageBox.Show("Bienvenido.");
                    this.Hide();
                    Form menu = new Menu();
                    menu.Show();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("No se encontro su usuario.");
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("No se logro la conexion.");
                connection.Close();
            }
        }
    }
}
