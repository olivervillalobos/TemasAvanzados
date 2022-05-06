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
    public partial class Alumno_MD : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        public Alumno_MD()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form alumno = new Alumno();
            alumno.Show();
        }

        private void Alumno_MD_Load(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

            try
            {
                SqlCommand comando = new SqlCommand("SELECT Id_Alumno FROM Alumno", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cb_Alumno.Items.Add(registro["Id_Alumno"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (cb_Alumno.SelectedItem == null)
            {
                txt_ApellidoMaterno.Enabled = false;
                txt_ApellidoPaterno.Enabled = false;
                txt_Nombre.Enabled = false; 
            }
        }

        private void cb_Alumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Alumno.SelectedItem != null)
            {
                txt_ApellidoMaterno.Enabled = true;
                txt_ApellidoPaterno.Enabled = true;
                txt_Nombre.Enabled = true;

                txt_ApellidoMaterno.Text = null;
                txt_ApellidoPaterno.Text = null;
                txt_Nombre.Text = null;
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT Apellido_Paterno,Apellido_Materno," +
                        "Nombres FROM Alumno WHERE  Id_Alumno = @Id_Alumno", connection);
                    connection.Open();
                    comando.Parameters.AddWithValue("Id_Alumno", cb_Alumno.Text);
                    SqlDataReader registro = comando.ExecuteReader();
                    while (registro.Read())
                    {
                        txt_ApellidoPaterno.Text = registro["Apellido_Paterno"].ToString();
                        txt_ApellidoMaterno.Text = registro["Apellido_Materno"].ToString();
                        txt_Nombre.Text = registro["Nombres"].ToString();
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
                txt_ApellidoMaterno.Enabled = false;
                txt_ApellidoPaterno.Enabled = false;
                txt_Nombre.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                //ELIMINA   INICIO SESION
                SqlCommand INICIO_SESION = new SqlCommand("DELETE FROM Inicio_Sesion where Id_Alumno = @Id_Alumno", connection);
                INICIO_SESION.Parameters.AddWithValue("Id_Alumno", cb_Alumno.Text);
                INICIO_SESION.ExecuteNonQuery();
                //ELIMINA USUARIO
                SqlCommand ALUMNO = new SqlCommand("DELETE FROM Alumno WHERE Id_Alumno = @Id_Alumno", connection);
                ALUMNO.Parameters.AddWithValue("Id_Alumno", cb_Alumno.Text);
                ALUMNO.ExecuteNonQuery();
                //ELIMINA   PUNTAJES
                SqlCommand PUNTAJES = new SqlCommand("DELETE FROM Puntajes where Id_Puntaje = @Id_Puntaje", connection);
                PUNTAJES.Parameters.AddWithValue("Id_Puntaje", cb_Alumno.Text);
                PUNTAJES.ExecuteNonQuery();
                //ELIMINA   COLORES
                SqlCommand COLOR = new SqlCommand("DELETE FROM Colores where Id_Colores = @Id_Colores", connection);
                COLOR.Parameters.AddWithValue("Id_Colores", cb_Alumno.Text);
                COLOR.ExecuteNonQuery();
                //ELIMINA   LETRAS
                SqlCommand LETRAS = new SqlCommand("DELETE FROM Letras where Id_Letras = @Id_Letras", connection);
                LETRAS.Parameters.AddWithValue("Id_Letras", cb_Alumno.Text);
                LETRAS.ExecuteNonQuery();
                //ELIMINA   NUMEROS
                SqlCommand NUMEROS = new SqlCommand("DELETE FROM Numeros where Id_Numeros = @Id_Numeros", connection);
                NUMEROS.Parameters.AddWithValue("Id_Numeros", cb_Alumno.Text);
                NUMEROS.ExecuteNonQuery();
                //ELIMINA   PUZZLE
                SqlCommand PUZZLE = new SqlCommand("DELETE FROM Puzzle where Id_Puzzle = @Id_Puzzle", connection);
                PUZZLE.Parameters.AddWithValue("Id_Puzzle", cb_Alumno.Text);
                PUZZLE.ExecuteNonQuery();
                //ELIMINA   COMPLETAFRASES
                SqlCommand COMPLETAFRASES = new SqlCommand("DELETE FROM CompletaFrases where Id_CompletaFrases = @Id_CompletaFrases", connection);
                COMPLETAFRASES.Parameters.AddWithValue("Id_CompletaFrases", cb_Alumno.Text);
                COMPLETAFRASES.ExecuteNonQuery();
                //ELIMINA   PIANO
                SqlCommand PIANO = new SqlCommand("DELETE FROM Piano where Id_Piano = @Id_Piano", connection);
                PIANO.Parameters.AddWithValue("Id_Piano", cb_Alumno.Text);
                PIANO.ExecuteNonQuery();

                connection.Close();

                txt_ApellidoPaterno.Text = "";
                txt_ApellidoMaterno.Text = "";
                txt_Nombre.Text = "";
                MessageBox.Show("Se ha eliminado el estudiante con numero de control " + cb_Alumno.Text);
                cb_Alumno.Items.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }

            Alumno_MD md = new Alumno_MD();
            this.Hide();
            md.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_ApellidoMaterno.Text != null && txt_ApellidoPaterno.Text != null && txt_Nombre.Text != null)
                {
                    connection.Open();
                    SqlCommand altas = new SqlCommand("UPDATE Alumno SET Apellido_Paterno = @Apellido_Paterno, " +
                        "Apellido_Materno = @Apellido_Materno, Nombres = @Nombres WHERE Id_Alumno = @Id_Alumno", connection);
                    altas.Parameters.AddWithValue("Id_Alumno", cb_Alumno.Text);
                    altas.Parameters.AddWithValue("Apellido_Paterno", txt_ApellidoPaterno.Text);
                    altas.Parameters.AddWithValue("Apellido_Materno", txt_ApellidoMaterno.Text);
                    altas.Parameters.AddWithValue("Nombres", txt_Nombre.Text);
                    altas.ExecuteNonQuery();
                    connection.Close();

                    txt_ApellidoPaterno.Text = "";
                    txt_ApellidoMaterno.Text = "";
                    txt_Nombre.Text = "";
                    MessageBox.Show("Se han modificado los datos del estudiante con numero de control " + cb_Alumno.Text);
                    cb_Alumno.Items.Clear();

                    Alumno_MD md = new Alumno_MD();
                    this.Hide();
                    md.Show();
                }
                else
                {
                    MessageBox.Show("No puede dejar campos vacios.");
                }
            }
            catch
            {
                MessageBox.Show("Ha ingresado valores no permitidos. Alumno");
                connection.Close();
            }
        }
    }
}
