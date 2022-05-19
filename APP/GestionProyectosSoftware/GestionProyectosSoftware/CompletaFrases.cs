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
        string[] words = { "PERRO", "GATO", "PEZ", "CIELO", "CARRO" };

        int correct = 0;
        int incorrect = 0;
        int count = 0;
        

        public CompletaFrases()
        {
            InitializeComponent();
            lblword.Text = words[count];
            txtword.Focus();
            txtword.CharacterCasing = CharacterCasing.Upper;
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

            txtword.Text = txtword.Text + "Q";

        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "W";
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "E";
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "R";
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "T";
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "Y";
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "U";
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "I";
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "O";
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "P";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "A";
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "S";
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "D";
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "F";
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "G";
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "H";
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "J";
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "K";
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "L";
        }

        private void buttonÑ_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "Ñ";
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "Z";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "X";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "C";
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "V";
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "B";
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "N";
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            txtword.Text = txtword.Text + "M";
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
            count++;
            if (count >= words.Length)
            {
                //correcto
                if (txtword.Text == lblword.Text)
                {
                    correct++;
                    txtword.Text = null;
                }
                //incorrecto
                else
                {
                    incorrect++;
                    txtword.Text = null;
                }
                lblcorrect.Text = "Correcto: " + correct;
                lblincorrect.Text = "Incorrecto: " + incorrect;
                if (correct > incorrect)
                {
                    //audioganador
                    MessageBox.Show("GANASTE");
                    txtword.Text = null;
                    //INSERTAR UPDATE DEL PUNTAJE
                }
                else if (incorrect > correct)
                {
                    //audioperdiste
                    MessageBox.Show("PERDISTE");
                    txtword.Text = null;
                    //INSERTAR UPDATE DEL PUNTAJE
                }
                count = 0;
                lblword.Text = words[count];
                correct = 0;
                incorrect = 0;
                lblcorrect.Text = "Correcto: " + correct;
                lblincorrect.Text = "Incorrecto: " + incorrect;
            }
            else
            {
                //correcto
                if (txtword.Text == lblword.Text)
                {
                    correct++;
                    if (count < words.Length)
                    {
                        lblword.Text = words[count];
                    }
                    txtword.Text = null;
                }
                //incorrecto
                else
                {
                    incorrect++;
                    if (count < words.Length)
                    {
                        lblword.Text = words[count];
                    }
                    txtword.Text = null;
                }
                lblcorrect.Text = "Correcto: " + correct;
                lblincorrect.Text = "Incorrecto: " + incorrect;
            }
            txtword.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtword.Text = "";
        }
    }
}
