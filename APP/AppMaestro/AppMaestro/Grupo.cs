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
    public partial class Grupo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        public Grupo()
        {
            InitializeComponent();
        }

        private void Grupo_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT Id_Docente FROM Docente", connection);
                connection.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cbDocente.Items.Add(registro["Id_Docente"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT D.Apellido_Paterno, D.Apellido_Materno, D.Nombres, G.Id_Grupo from Docente D left outer join Grupo G ON D.Id_Docente = G.Id_Docente", connection);
                connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                data_docente.DataSource = tabla;
                connection.Close();
            }
            catch(Exception ex)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Grupo(Id_Grupo,Id_Docente) VALUES (@Id_Grupo,@Id_Docente)", connection);
                altas.Parameters.AddWithValue("Id_Grupo", txtgrupo.Text);
                altas.Parameters.AddWithValue("Id_Docente", cbDocente.Text);
                altas.ExecuteNonQuery();
                txtgrupo.Text = "";
                cbDocente.Text = "";
                MessageBox.Show("Se han ingresado los datos con exito.");
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //eliminar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //modificar
        }
    }
}
