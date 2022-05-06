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
    public partial class Maestro_MD : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        public Maestro_MD()
        {
            InitializeComponent();
        }

        private void Maestro_MD_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM Docente", connection);
                connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                data_docente.DataSource = tabla;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                SqlCommand comando = new SqlCommand("SELECT Id_Docente FROM Docente", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cb_Docente.Items.Add(registro["Id_Docente"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (cb_Docente.SelectedItem == null)
            {
                txt_ApellidoMaterno.Enabled = false;
                txt_ApellidoPaterno.Enabled = false;
                txt_Nombre.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            docente doc = new docente();
            doc.Show();
        }

        private void cb_Docente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Docente.SelectedItem != null)
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
                        "Nombres FROM Docente WHERE  Id_Docente = @Id_Docente", connection);
                    connection.Open();
                    comando.Parameters.AddWithValue("Id_Docente", cb_Docente.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_ApellidoMaterno.Text != null && txt_ApellidoPaterno.Text != null && txt_Nombre.Text != null)
                {
                    connection.Open();
                    SqlCommand altas = new SqlCommand("UPDATE Docente SET Apellido_Paterno = @Apellido_Paterno, " +
                        "Apellido_Materno = @Apellido_Materno, Nombres = @Nombres WHERE Id_Docente = @Id_Docente", connection);
                    altas.Parameters.AddWithValue("Id_Docente", cb_Docente.Text);
                    altas.Parameters.AddWithValue("Apellido_Paterno", txt_ApellidoPaterno.Text);
                    altas.Parameters.AddWithValue("Apellido_Materno", txt_ApellidoMaterno.Text);
                    altas.Parameters.AddWithValue("Nombres", txt_Nombre.Text);
                    altas.ExecuteNonQuery();
                    connection.Close();

                    txt_ApellidoPaterno.Text = "";
                    txt_ApellidoMaterno.Text = "";
                    txt_Nombre.Text = "";
                    MessageBox.Show("Se han modificado los datos del docente con numero de control " + cb_Docente.Text);
                    cb_Docente.Items.Clear();

                    Maestro_MD md = new Maestro_MD();
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
