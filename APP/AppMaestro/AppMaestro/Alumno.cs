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
    public partial class Alumno : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        public Alumno()
        {
            InitializeComponent();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT Id_Grupo FROM Grupo", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cb_Grupo.Items.Add(registro["Id_Grupo"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (cb_Grupo.SelectedItem == null)
            {
                cb_IdComputadora.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM Alumno", connection);
            connection.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = consulta;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            data_Alumno.DataSource = tabla;
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void cb_Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Grupo.SelectedItem != null)
            {
                cb_IdComputadora.Enabled = true; 
                cb_IdComputadora.Items.Clear();
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM Computadora except(SELECT C.Id_Computadora FROM Computadora C FULL " +
                        "JOIN Alumno A ON A.Id_Computadora = C.Id_Computadora WHERE A.Id_Alumno is NOT NULL AND A.Id_Grupo = @Id_Grupo)", connection);
                    connection.Open();
                    comando.Parameters.AddWithValue("Id_Grupo", cb_Grupo.Text);
                    SqlDataReader registro = comando.ExecuteReader();
                    while (registro.Read())
                    {
                        cb_IdComputadora.Items.Add(registro["Id_Computadora"].ToString());
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                cb_IdComputadora.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear Id_Colores
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Colores(Id_Colores,Veces_Jugadas,Puntos_Colores) VALUES ((SELECT MAX(Id_Colores)+1 FROM Colores),0,0)", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos o a ingresado un valor en una llave secundaria no autorizado. Colores");
                connection.Close();
            }

            //Crear IdLetras
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Letras(Id_Letras,Veces_Jugadas,Puntos_Letras) VALUES ((SELECT MAX(Id_Letras)+1 FROM Letras),0,0)", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos o a ingresado un valor en una llave secundaria no autorizado. Letras");
                connection.Close();
            }
            //Crear Id Numeros
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Numeros(Id_Numeros,Veces_Jugadas,Puntos_Numeros) VALUES ((SELECT MAX(Id_Numeros)+1 FROM Numeros),0,0)", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos o a ingresado un valor en una llave secundaria no autorizado. Numeros");
                connection.Close();
            }
            //Crear Id Completa frases
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO CompletaFrases(Id_CompletaFrases,Veces_Jugadas,Puntos_CompletaFrases) VALUES ((SELECT MAX(Id_CompletaFrases)+1 FROM CompletaFrases),0,0)", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos o a ingresado un valor en una llave secundaria no autorizado. Completa Frases");
                connection.Close();
            }
            //Crear Id Piano
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Piano(Id_Piano,Veces_Jugadas,Puntos_Piano) VALUES ((SELECT MAX(Id_Piano)+1 FROM Piano),0,0)", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos o a ingresado un valor en una llave secundaria no autorizado. Piano");
                connection.Close();
            }
            //Crear Id Puzzle
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Puzzle(Id_Puzzle,Veces_Jugadas,Puntos_Puzzle) VALUES ((SELECT MAX(Id_Puzzle)+1 FROM Puzzle),0,0)", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos o a ingresado un valor en una llave secundaria no autorizado. Puzzle");
                connection.Close();
            }
            //Crear ID Puntaje
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Puntajes(Id_Puntaje, Id_Colores, Id_Numeros, Id_Letras,Id_CompletaFrases,Id_Piano,Id_Puzzle,Promedio) " +
                    "VALUES ((SELECT MAX(Id_Puntaje)+1 FROM Puntajes), (SELECT MAX(Id_Colores) FROM Colores) , (SELECT MAX(Id_Numeros) FROM Numeros), (SELECT MAX(Id_Letras) FROM Letras)," +
                    "(SELECT MAX(Id_CompletaFrases) FROM CompletaFrases), (SELECT MAX(Id_Piano) FROM Piano),(SELECT MAX(Id_Puzzle) FROM Puzzle), 0)", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos o a ingresado un valor en una llave secundaria no autorizado. Puntaje");
                connection.Close();
            }
            //crear alumno
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Alumno(Apellido_Paterno,Apellido_Materno," +
                    "Nombres,Promedio,Id_Puntaje,Id_Grupo,Id_Computadora) VALUES (@Apellido_Paterno,@Apellido_Materno,@Nombres," +
                    "0,(SELECT MAX(Id_Puntaje) FROM Puntajes),@Id_Grupo,@Id_Computadora)", connection);
                altas.Parameters.AddWithValue("Apellido_Paterno", txt_ApellidoPaterno.Text);
                altas.Parameters.AddWithValue("Apellido_Materno", txt_ApellidoMaterno.Text);
                altas.Parameters.AddWithValue("Nombres", txt_Nombre.Text);
                altas.Parameters.AddWithValue("Id_Grupo", cb_Grupo.Text);
                altas.Parameters.AddWithValue("Id_Computadora", cb_IdComputadora.Text);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos o a ingresado un valor en una llave secundaria no autorizado. Alumno");
                connection.Close();
            }
            //crear inicio sesion
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Inicio_Sesion(Id_Sesion, Id_Alumno,Id_Computadora) VALUES ((SELECT MAX(Id_Sesion)+1 FROM Inicio_Sesion),(SELECT MAX(Id_Alumno) FROM Alumno),@Id_Computadora)", connection);
                altas.Parameters.AddWithValue("Id_Computadora", cb_IdComputadora.Text);
                altas.ExecuteNonQuery();
                txt_ApellidoPaterno.Text = "";
                txt_ApellidoMaterno.Text = "";
                txt_Nombre.Text = "";
                cb_Grupo.Text = "";
                cb_IdComputadora.Text = "";
                MessageBox.Show("Se han ingresado los datos con exito.");
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos o a ingresado un valor en una llave secundaria no autorizado. Inicio Sesion");
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //eliminar
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //modificar
        }
    }
}
