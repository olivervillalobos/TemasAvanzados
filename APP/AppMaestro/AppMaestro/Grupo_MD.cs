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
    public partial class Grupo_MD : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        public Grupo_MD()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.Show();
            this.Hide();
        }

        private void Grupo_MD_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT Id_Grupo FROM Grupo", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cbgrupo.Items.Add(registro["Id_Grupo"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if(cbgrupo.SelectedItem == null)
            {
                txtdocente.Enabled = false;
            }

            try
            {
                SqlCommand consulta = new SqlCommand("SELECT D.Id_Docente,D.Apellido_Paterno, D.Apellido_Materno, D.Nombres, G.Id_Grupo from Docente D left outer join Grupo G ON D.Id_Docente = G.Id_Docente", connection);
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
                MessageBox.Show(ex.ToString());
            }
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM Grupo", connection);
                connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                data_Grupo.DataSource = tabla;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbgrupo.SelectedItem != null)
            {
                txtdocente.Enabled = true;

                txtdocente.Text = null;

                try
                {
                    SqlCommand comando = new SqlCommand("SELECT Id_Docente FROM Grupo WHERE Id_Grupo = @Id_Grupo", connection);
                    connection.Open();
                    comando.Parameters.AddWithValue("Id_Grupo", cbgrupo.Text);
                    SqlDataReader registro = comando.ExecuteReader();
                    while (registro.Read())
                    {
                        txtdocente.Text = registro["Id_Docente"].ToString();
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
                txtdocente.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdocente.Text != null)
                {
                    connection.Open();
                    SqlCommand altas = new SqlCommand("UPDATE Grupo SET Id_Docente = @Id_Docente WHERE Id_Grupo = @Id_Grupo", connection);
                    altas.Parameters.AddWithValue("Id_Grupo", cbgrupo.Text);
                    altas.Parameters.AddWithValue("Id_Docente", txtdocente.Text);
                    altas.ExecuteNonQuery();
                    connection.Close();

                    txtdocente.Text = "";
                    MessageBox.Show("Se han modificado los datos del grupo " + cbgrupo.Text);
                    cbgrupo.Items.Clear();

                    Grupo_MD md = new Grupo_MD();
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
                MessageBox.Show("Ha ingresado valores no permitidos.");
                connection.Close();
            }
        }
    }
}
