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
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form alumno = new Alumno();
            alumno.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dice la cantidad de alumnos
            try
            {
                SqlCommand comando = new SqlCommand("SELECT COUNT(Id_Alumno) FROM Alumno", connection);
                connection.Open();
                comando.CommandText = "SELECT COUNT(Id_Alumno) FROM Alumno";
                Object temp = comando.ExecuteScalar();
                lblAlumno.Text = temp.ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Computadoras com = new Computadoras();
            com.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            docente doc = new docente();
            doc.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultas cons = new consultas();
            cons.Show();
            this.Hide();
        }
    }
}
