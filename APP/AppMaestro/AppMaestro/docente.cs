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
    public partial class docente : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        public docente()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("INSERT INTO Docente(Apellido_Paterno,Apellido_Materno," +
                    "Nombres) VALUES (@Apellido_Paterno,@Apellido_Materno,@Nombres)", connection);
                altas.Parameters.AddWithValue("Apellido_Paterno", txt_ApellidoPaterno.Text);
                altas.Parameters.AddWithValue("Apellido_Materno", txt_ApellidoMaterno.Text);
                altas.Parameters.AddWithValue("Nombres", txt_Nombre.Text);
                altas.ExecuteNonQuery();
                txt_ApellidoPaterno.Text = "";
                txt_ApellidoMaterno.Text = "";
                txt_Nombre.Text = "";
                MessageBox.Show("Se han ingresado los datos con exito.");
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
