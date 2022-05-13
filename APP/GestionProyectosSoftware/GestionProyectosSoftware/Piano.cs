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
using System.Media;
using WMPLib;
using System.Threading;

namespace GestionProyectosSoftware
{
    public partial class Piano : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");
        SoundPlayer player = new SoundPlayer();
        Queue<Thread> threadQueue = new Queue<Thread>();
        int SustainMiliseconds = 2000;
        bool SeMuestranNotas = true;
        WindowsMediaPlayer mediaplayer = new WindowsMediaPlayer();       

        Dictionary<String, String> NotasTecladoOctava1 = new Dictionary<string, string> {
            {"Do","Z"},
            {"Do#","S"},
            {"Re","X"},
            {"Re#","D"},
            {"Mi","C"},
            {"Fa","V"},
            {"Fa#","G"},
            {"Sol","B"},
            {"Sol#","H"},
            {"La","N"},
            {"La#","J"},
            {"Si","M"},
        };

        Dictionary<String, String> NotasTecladoOctava2 = new Dictionary<string, string> {
            {"Do","Q"},
            {"Do#","2"},
            {"Re","W"},
            {"Re#","3"},
            {"Mi","E"},
            {"Fa","R"},
            {"Fa#","5"},
            {"Sol","T"},
            {"Sol#","6"},
            {"La","Y"},
            {"La#","7"},
            {"Si","U"},
        };

        Dictionary<String, String> NotasTecladoOctava3 = new Dictionary<string, string>
        {
                {"Do","I"}
        };

        public Piano()
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
            player.Stop();
            mediaplayer.controls.stop();
            this.Close();
            Form frmMenu = new Menu();
            frmMenu.Show();
        }

        private void Piano_Load(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                ((Button)control).Click += TocarNota;
            }

        }
        public void TocarNota(Object sender, EventArgs e)
        {
            try
            {
                
                if(threadQueue.Count >= 8)
                {
                   
                    threadQueue.ElementAt(0).Abort();
                    threadQueue.Dequeue();
                }
                
                
                if (SustainCheck.Checked)
                {
                    
                    Thread thread = new Thread(new ParameterizedThreadStart(Sustain));
                    threadQueue.Enqueue(thread);
                    threadQueue.ElementAt(threadQueue.Count - 1).Start(sender);
                    
                }
                else
                {
                    player.SoundLocation = Application.StartupPath + "\\piano\\" + ((Button)sender).Name.ToString().Replace("s", "-") + ".wav";
                    player.Play();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        public void Sustain(object obj)
        {
            try
            {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                player.URL = Application.StartupPath + "\\piano\\" + ((Button)obj).Name.ToString().Replace("s", "-") + ".wav";
                player.controls.play();
                Thread.Sleep(SustainMiliseconds);
                player.controls.stop();
                player.close();
            }catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());

            }
        }
        //OLIVER PONER EN PANTALLA QUE NOTA ES
        private void c4_Click(object sender, EventArgs e)
        {

        }

        private void d4_Click(object sender, EventArgs e)
        {

        }

        private void e4_Click(object sender, EventArgs e)
        {

        }

        private void f4_Click(object sender, EventArgs e)
        {

        }

        private void g4_Click(object sender, EventArgs e)
        {

        }

        private void a4_Click(object sender, EventArgs e)
        {

        }

        private void b4_Click(object sender, EventArgs e)
        {

        }

        private void c5_Click(object sender, EventArgs e)
        {

        }

        private void d5_Click(object sender, EventArgs e)
        {

        }

        private void e5_Click(object sender, EventArgs e)
        {

        }

        private void f5_Click(object sender, EventArgs e)
        {

        }

        private void g5_Click(object sender, EventArgs e)
        {

        }

        private void a5_Click(object sender, EventArgs e)
        {

        }

        private void b5_Click(object sender, EventArgs e)
        {

        }

        private void c6_Click(object sender, EventArgs e)
        {

        }

        private void cs4_Click(object sender, EventArgs e)
        {

        }

        private void ds4_Click(object sender, EventArgs e)
        {

        }

        private void fs4_Click(object sender, EventArgs e)
        {

        }

        private void gs4_Click(object sender, EventArgs e)
        {

        }

        private void as4_Click(object sender, EventArgs e)
        {

        }

        private void cs5_Click(object sender, EventArgs e)
        {

        }

        private void ds5_Click(object sender, EventArgs e)
        {

        }

        private void fs5_Click(object sender, EventArgs e)
        {

        }

        private void gs5_Click(object sender, EventArgs e)
        {

        }

        private void as5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlternar_Click(object sender, EventArgs e)
        {
            foreach (Button btn in panel1.Controls)
            {
                if (SeMuestranNotas) {
                    if (NotasTecladoOctava1.ContainsKey(btn.Text))
                    {
                        btn.Text = getKey(NotasTecladoOctava1, btn.Text);
                    }
                    SeMuestranNotas = false;
                }
                else
                {
                    if (NotasTecladoOctava1.ContainsValue(btn.Text)) {
                        btn.Text = getKey(NotasTecladoOctava1,btn.Text);
                    }
                }
            }
        }

        public string getKey(Dictionary<String,String> dictionary, string value)
        {
            var keys = dictionary.Keys;
            foreach(string key in keys)
            {
                if (dictionary[key] == value)
                {
                    return key;
                }
            }
            return "";
        }
    }
}
