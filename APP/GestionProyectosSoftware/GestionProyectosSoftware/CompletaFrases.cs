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
    public partial class CompletaFrases : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");


        public CompletaFrases()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand update = new SqlCommand("UPDATE Puntajes set promedio = p.Puntos_Puzzle + k.Puntos_Piano + f.Puntos_CompletaFrases + " +
                    "c.Puntos_Colores + n.Puntos_Numeros + l.Puntos_Letras from Puzzle p, Piano k, CompletaFrases f, Colores c, Numeros n, Letras l " +
                    "WHERE (p.Id_Puzzle = Puntajes.Id_Puzzle) AND (k.Id_Piano = Puntajes.Id_Piano) AND (f.Id_CompletaFrases = Puntajes.Id_CompletaFrases) AND" +
                    " (c.Id_Colores = Puntajes.Id_Colores) AND (n.Id_Numeros = Puntajes.Id_Numeros) AND (l.Id_Letras = Puntajes.Id_Letras)", connection);
                update.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }

            try
            {
                connection.Open();
                SqlCommand prom = new SqlCommand("UPDATE Alumno set promedio = p.promedio from Puntajes p WHERE p.Id_Puntaje = Alumno.Id_Puntaje", connection);
                prom.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
            this.Close();
            Form frmMenu = new Menu();
            frmMenu.Show();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {

            txtbox.Text = txtbox.Text + "Q";

        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "W";
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "E";
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "R";
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "T";
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "Y";
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "U";
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "I";
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "O";
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "P";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "A";
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "S";
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "D";
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "F";
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "G";
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "H";
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "J";
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "K";
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "L";
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "Ñ";
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "Z";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "X";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "C";
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "V";
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "B";
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "N";
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + "M";
        }

        //Funcion que retorna un arreglo de 10 palabras random sacadas de un arreglo previamente establecido
        private String[] palabraRandom(String[] array)
        {
            Random rnd = new Random();
            List<int> orden = Enumerable.Range(0, 20).OrderBy(i => rnd.Next()).Take(10).ToList();
            String[] palabras = new String[10];
            for(int i = 0; i < 10; i++)
            {
                palabras[i] = array[orden[i]];
            }
            return palabras;
        }

        private void bt_Verificar_Click(object sender, EventArgs e)
        {

        }
    }
}
