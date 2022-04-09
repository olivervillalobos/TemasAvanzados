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
    public partial class Computadoras: Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");
        public Computadoras()
        {
            InitializeComponent();
        }

        private void Computadoras_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT COUNT(Id_Computadora) FROM Computadora", connection);
                connection.Open();
                comando.CommandText = "SELECT COUNT(Id_Computadora) FROM Computadora";
                Object temp = comando.ExecuteScalar();
                Int32 comp = (Int32)comando.ExecuteScalar();
                if(comp <= 1 )
                {
                    btn_Disminuir.Enabled = false;
                    btn_Incrementar.Enabled = true;
                }
                if (comp > 49)
                {
                    btn_Disminuir.Enabled = true;
                    btn_Incrementar.Enabled = false;
                }
                lblComputadoras.Text = temp.ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_Incrementar_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand altas = new SqlCommand("INSERT INTO Computadora(Id_Computadora) VALUES ((SELECT MAX(Id_Computadora)+1 FROM Computadora))", connection);
            altas.ExecuteNonQuery();
            MessageBox.Show("Se ha agregado un ordenador con exito.");
            connection.Close();

            Computadoras com = new Computadoras();
            this.Hide();
            com.Show();
        }

        private void btn_Disminuir_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand altas = new SqlCommand("DELETE FROM Computadora WHERE Id_Computadora = (SELECT MAX(Id_Computadora) FROM Computadora);", connection);
            altas.ExecuteNonQuery();
            MessageBox.Show("Se ha eliminado un ordenador con exito.");
            connection.Close();

            Computadoras com = new Computadoras();
            this.Hide();
            com.Show();
        }
    }
}
