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
using System.Windows;

namespace GestionProyectosSoftware
{
    public partial class Piano : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");
        SoundPlayer player = new SoundPlayer();
        Queue<Thread> threadQueue = new Queue<Thread>();
        int SustainMiliseconds = 2000;
        //Para saber si la tecla ingresada es mayuscula
        int asciiMinus = 32;
        //Arreglo para la relacion con el teclado y los botones
        string[,] TecladoSonido = new string[25, 2]
        {
          {"A","d4"},{"B", "d5"},{"C","g4"},{"D", "a4"},{"E","fs4"},{"F", "c5"},{"G","e5"},{"H", "g5"},
          {"I","fs5"},{"J", "b5"},{"K","c6"},{"M", "a5"},{"N", "f5"},{"O","gs5"},{"P", "as5"},{"Q","cs4"},
          {"R", "gs4"},{"S","f4"},{"T", "as4"},{"U","ds4"},{"V", "b4"},{"W","ds4"},{"X", "e4"},{"Y","cs5"},
          {"Z", "c4"}
        };
        String nombreBoton;
        WindowsMediaPlayer mediaplayer = new WindowsMediaPlayer();
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

        private void TeclaPresionada(object sender, KeyEventArgs e)
        {
            //Convierte a String el valor de la tecla presionada
            String myCharValue = Char.ConvertFromUtf32(e.KeyValue);

                //Recorre el arreglo para buscar la letra
                for (int x = 0; x < 25; x++)
                {
                    /*En caso de encontrar la letra, se le asigna el nombre que tiene
                    asignado el boton con la tecla*/
                   if (TecladoSonido[x, 0].Equals(myCharValue))
                    {
                        nombreBoton = TecladoSonido[x, 1];
                        Console.WriteLine(nombreBoton);
                    }   
                }
                //MessageBox.Show("Tecla Presionada");
                //Cambiar de color el boton para hacer efecto de "Presionado"
                foreach (Button boton in panel1.Controls)
                {
                    if(boton.Name == nombreBoton)
                    {
                        boton.BackColor = Color.Gray;
                        /*Reproduce la nota utilizando el metodo utilizado
                        cuando se da clic al boton*/
                        TocarNota(boton,null);
                    }
                }
        }

        private void TeclaLiberada(object sender, KeyEventArgs e)
        {
            //Volver al color original la tecla presionada
            foreach (Button boton in panel1.Controls)
            {
                if (boton.Name == nombreBoton)
                {
                    boton.BackColor = Color.White;
                }
            }

            //Solo para las teclas negras
            cs4.BackColor = Color.Black;
            ds4.BackColor = Color.Black;
            fs4.BackColor = Color.Black;
            gs4.BackColor = Color.Black;
            as4.BackColor = Color.Black;
            cs5.BackColor = Color.Black;
            ds5.BackColor = Color.Black;
            fs5.BackColor = Color.Black;
            gs5.BackColor = Color.Black;
            as5.BackColor = Color.Black;

            nombreBoton = "";
        }
    }
}
