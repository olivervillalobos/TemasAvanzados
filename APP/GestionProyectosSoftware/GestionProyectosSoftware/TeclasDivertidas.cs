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
    public partial class TeclasDivertidas : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");
        string[] words = { "PERRO", "GATO", "PEZ", "CIELO", "CARRO" };
        int points;
        int correct = 0;
        int incorrect = 0;
        int count = 0;
        Sonido miSonido = new Sonido();

        public TeclasDivertidas()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            enabled();
            words = palabraRandom(words);
            lblword.Text = words[count];
            txtword.Focus();
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
            List<int> orden = Enumerable.Range(0, array.Length).OrderBy(i => rnd.Next()).Take(array.Length).ToList();
            String[] palabras = new String[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                palabras[i] = array[orden[i]];
            }
            return palabras;
        }

        private void bt_Verificar_Click(object sender, EventArgs e)
        {
            if (bt_Verificar.Text == "Verificar")
            {
                count++;
                if (count >= words.Length)
                {
                    if (txtword.Text == "")
                    {
                        lblword.Text = "ESCRIBE LA PALABRA";
                        lblword.BackColor = Color.LightYellow;
                        count--;
                        bt_Verificar.Text = "Volver";
                    }
                    //correcto
                    else if (txtword.Text == lblword.Text)
                    {
                        correct++;
                        lblword.BackColor = Color.LightGreen;
                        txtword.Text = null;
                    }
                    //incorrecto
                    else
                    {
                        incorrect++;
                        lblword.BackColor = Color.LightCoral;
                        txtword.Text = null;
                    }
                    lblcorrect.Text = "Correcto: " + correct;
                    lblincorrect.Text = "Incorrecto: " + incorrect;

                    if (correct != 0)
                    {
                        points = correct * 10;
                        upload(points);

                    }
                    else if (correct == 0)
                    {
                        upload(0);
                    }

                    if (correct > incorrect)
                    {
                        //audioganador
                        miSonido.reproducirSonido("Aprobado");
                        MessageBox.Show("GANASTE\nPuntaje: " + points);
                        txtword.Text = null;
                        //INSERTAR UPDATE DEL PUNTAJE
                    }
                    else if (incorrect > correct)
                    {
                        //audioperdiste
                        miSonido.reproducirSonido("NoAprobado");
                        if (correct == 0)
                        {
                            MessageBox.Show("PERDISTE\nPuntaje: 0");
                        }
                        else
                        {
                            MessageBox.Show("PERDISTE\nPuntaje: " + points);
                        }
                        txtword.Text = null;
                        //INSERTAR UPDATE DEL PUNTAJE
                    }

                    count = 0;
                    lblword.Text = "PALABRA";
                    lblword.BackColor = Color.Gainsboro;
                    correct = 0;
                    incorrect = 0;
                    points = 0;
                    lblcorrect.Text = "Correcto: " + correct;
                    lblincorrect.Text = "Incorrecto: " + incorrect;
                    times_played();
                    disable();
                }
                else
                {
                    if (txtword.Text == "")
                    { 
                        lblword.Text = "ESCRIBE LA PALABRA";
                        lblword.BackColor = Color.LightYellow;
                        count--;
                        bt_Verificar.Text = "Volver";
                    }
                    //correcto
                    else if (txtword.Text == lblword.Text)
                    {
                        correct++;
                        if (count < words.Length)
                        {
                            miSonido.reproducirSonido("Correcto");
                            lblword.BackColor = Color.LightGreen;
                            bt_Verificar.Text = "Siguiente";
                        }
                        txtword.Text = null;
                    }
                    //incorrecto
                    else
                    {
                        incorrect++;
                        if (count < words.Length)
                        {
                            miSonido.reproducirSonido("Incorrecto");
                            lblword.BackColor = Color.LightCoral;
                            bt_Verificar.Text = "Siguiente";
                        }
                        txtword.Text = null;
                    }
                    lblcorrect.Text = "Correcto: " + correct;
                    lblincorrect.Text = "Incorrecto: " + incorrect;
                }   
            }
            else
            {
                lblword.Text = words[count];
                lblword.BackColor = Color.Gainsboro;
                bt_Verificar.Text = "Verificar";
            }
            txtword.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtword.Text = "";
        }

        private void TeclasDivertidas_Load(object sender, EventArgs e)
        {
            disable();
        }

        public void times_played()
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE CompletaFrases set Veces_Jugadas = (Veces_Jugadas + 1) WHERE Id_CompletaFrases = @Id_CompletaFrases", connection);
                altas.Parameters.AddWithValue("Id_CompletaFrases", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }

        public void enabled()
        {
            txtword.Visible = true;
            txtword.Enabled = true;
            lblword.Enabled = true;
            bt_Verificar.Enabled = true;
            txtword.Text = "";
        }

        public void disable()
        {
            txtword.Visible = false;
            txtword.Enabled = false;
            lblword.Enabled = false;
            bt_Verificar.Enabled = false;
        }

        public void upload(int valor)
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE CompletaFrases set Puntos_CompletaFrases = (Puntos_CompletaFrases + " + valor + ") WHERE Id_CompletaFrases = @Id_CompletaFrases", connection);
                altas.Parameters.AddWithValue("Id_CompletaFrases", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }


    }
}
