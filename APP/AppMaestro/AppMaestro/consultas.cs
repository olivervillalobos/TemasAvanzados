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


namespace AppMaestro
{
    public partial class consultas : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");
        public consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbopcion.SelectedIndex == 1)
                {
                    connection.Open();
                    SqlCommand consulta = new SqlCommand("SELECT A.Id_Alumno, A.Apellido_Paterno, A.Apellido_Materno, A.Nombres, A.Id_Grupo, A.Id_Computadora, CO. Veces_Jugadas as 'Colores Jugadas', CO. Puntos_Colores as 'Colores Puntos', NU. Veces_Jugadas as 'Numeros Jugadas', NU. Puntos_Numeros as 'Numeros Puntos',LE. Veces_Jugadas as 'Letras Jugadas', LE. Puntos_Letras as 'Letras Puntos', P. Promedio FROM Puntajes P FULL JOIN Alumno A ON A.Id_Puntaje = P.Id_Puntaje FULL JOIN Colores CO ON CO. Id_Colores = P. Id_Colores FULL JOIN Numeros NU ON NU. Id_Numeros = P. Id_Numeros FULL JOIN Letras LE ON LE. Id_Letras = P. Id_Letras WHERE P.Id_Puntaje = @Id_Puntaje", connection);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    consulta.Parameters.AddWithValue("@Id_Puntaje", txtconsulta.Text);
                    adaptador.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataConsulta.DataSource = tabla;
                    connection.Close();
                }
                else if (cbopcion.SelectedIndex == 0)
                {
                    connection.Open();
                    SqlCommand consulta = new SqlCommand("SELECT * FROM Alumno WHERE Id_Grupo = @Id_Grupo", connection);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    consulta.Parameters.AddWithValue("@Id_Grupo", txtconsulta.Text);
                    adaptador.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataConsulta.DataSource = tabla;
                    connection.Close();
                }
                else if (cbopcion.SelectedIndex == 2)
                {
                    connection.Open();
                    SqlCommand consulta = new SqlCommand("SELECT A.Id_Alumno, A.Apellido_Paterno, A.Apellido_Materno, A.Nombres, A.Id_Grupo, A.Id_Computadora, CO. Id_Colores ,CO. Veces_Jugadas as 'Colores Jugadas', CO. Puntos_Colores as 'Colores Puntos' FROM Puntajes P FULL JOIN Alumno A ON A.Id_Puntaje = P.Id_Puntaje FULL JOIN Colores CO ON CO. Id_Colores = P. Id_Colores", connection);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataConsulta.DataSource = tabla;
                    connection.Close();
                }
                else if (cbopcion.SelectedIndex == 3)
                {
                    connection.Open();
                    SqlCommand consulta = new SqlCommand("SELECT A.Id_Alumno, A.Apellido_Paterno, A.Apellido_Materno, A.Nombres, A.Id_Grupo, A.Id_Computadora, NU. Id_Numeros, NU. Veces_Jugadas as 'Numeros Jugadas',NU. Puntos_Numeros as 'Numeros Puntos' FROM Puntajes P FULL JOIN Alumno A ON A.Id_Puntaje = P.Id_Puntaje FULL JOIN Numeros NU ON NU. Id_Numeros = P. Id_Numeros", connection);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataConsulta.DataSource = tabla;
                    connection.Close();
                }
                else if (cbopcion.SelectedIndex == 4)
                {
                    connection.Open();
                    SqlCommand consulta = new SqlCommand("SELECT A.Id_Alumno, A.Apellido_Paterno, A.Apellido_Materno, A.Nombres, A.Id_Grupo, A.Id_Computadora, LE. Id_Letras, LE. Veces_Jugadas as 'Letras Jugadas', LE. Puntos_Letras as 'Letras Puntos' FROM Puntajes P FULL JOIN Alumno A ON A.Id_Puntaje = P.Id_Puntaje FULL JOIN Letras LE ON LE. Id_Letras = P. Id_Letras", connection);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataConsulta.DataSource = tabla;
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }

        private void cbopcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbopcion.SelectedIndex == 1)
            {
                txtconsulta.Show();
                MessageBox.Show("Ingrese el ID del alumno.");
            }
            else if(cbopcion.SelectedIndex == 0)
            {
                txtconsulta.Show();
                MessageBox.Show("Ingrese el ID del grupo.");
            }
            else if (cbopcion.SelectedIndex == 2)
            {
                txtconsulta.Hide();
            }
            else if (cbopcion.SelectedIndex == 3)
            {
                txtconsulta.Hide();
            }
            else if (cbopcion.SelectedIndex == 4)
            {
                txtconsulta.Hide();
            }
        }

        private void consultas_Load(object sender, EventArgs e)
        {
            txtconsulta.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
