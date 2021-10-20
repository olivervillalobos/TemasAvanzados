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
    class conexion
    {
        string cadena = "Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschoo;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999";
        public SqlConnection conexionBD = new SqlConnection();
        InicioSesion inicio_sesion = new InicioSesion();
        

        public conexion()
        {
            conexionBD.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conexionBD.Open();
                System.Windows.Forms.MessageBox.Show("Conexion abierta.");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al abrir base de datos " + ex.Message);
                Application.Exit();
            }
        }
        public void cerrar()
        {
            conexionBD.Close();
            Application.Exit();
        }
    }
}
