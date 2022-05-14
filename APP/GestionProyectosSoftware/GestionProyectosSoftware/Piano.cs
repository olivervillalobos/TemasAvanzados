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

        //Para saber si la tecla ingresada es mayuscula
        int asciiMinus = 32;
        //Arreglo para la relacion con el teclado y los botones
        string[,] TecladoSonido = new string[25, 2]
        {
          {"Z", "c4"},{"S","cs4"},{"X","d4"},{"D","ds4"},
          {"C", "e4"},{"V","f4"},{"G","fs4"},{"B","g4"},
          {"H", "gs4"},{"N", "a4"},{"J", "as4"},{"M", "b4"},
          {"Q", "c5"},{"2","cs5"},{"W", "d5"},{"3","ds5"},
          {"E","e5"},{"R", "f5"},{"5","fs5"},{"T", "g5"},
          {"6","gs5"},{"Y", "a5"},{"7", "as5"},{"U", "b5"},{"I","c6"},
          
          
        };
        String nombreBoton;
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

            lbl_Nota.Visible = false;
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
                MessageBox.Show("Ocurrió un error!");
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
                MessageBox.Show("Ocurrió un error!");

            }
        }
        //OLIVER PONER EN PANTALLA QUE NOTA ES
        private void c4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Do";

        }

        private void d4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Re";

        }

        private void e4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Mi";

        }

        private void f4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Fa";

        }

        private void g4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Sol";

        }

        private void a4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "La";

        }

        private void b4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Si";

        }

        private void c5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Do";

        }

        private void d5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Re";

        }

        private void e5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Mi";

        }

        private void f5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Fa";

        }

        private void g5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Sol";

        }

        private void a5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "La";

        }

        private void b5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Si";

        }

        private void c6_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Do";

        }

        private void cs4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Reb";

        }

        private void ds4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Mib";

        }

        private void fs4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Solb";

        }

        private void gs4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Lab";

        }

        private void as4_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Sib";

        }

        private void cs5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Reb";

        }

        private void ds5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Mib";

        }

        private void fs5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Solb";

        }

        private void gs5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Lab";

        }

        private void as5_Click(object sender, EventArgs e)
        {
            lbl_Nota.Visible = true;
            lbl_Nota.Text = "Sib";

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
                    lbl_Nota.Visible = true;
                    nombreBoton = TecladoSonido[x, 1];
                    Console.WriteLine(nombreBoton);
                    string temp;
                    if(nombreBoton == "c4")
                    {
                        temp = "Do";
                        lbl_Nota.Text = temp;
                    }
                    else if(nombreBoton == "d4")
                    {
                        temp = "Re";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "e4")
                    {
                        temp = "Mi";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "f4")
                    {
                        temp = "Fa";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "g4")
                    {
                        temp = "Sol";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "a4")
                    {
                        temp = "La";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "b4")
                    {
                        temp = "Si";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "c5")
                    {
                        temp = "Do";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "d5")
                    {
                        temp = "Re";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "e5")
                    {
                        temp = "Mi";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "f5")
                    {
                        temp = "Fa";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "g5")
                    {
                        temp = "Sol";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "a5")
                    {
                        temp = "La";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "b5")
                    {
                        temp = "Si";
                        lbl_Nota.Text = temp;
                    }
                    else if (nombreBoton == "c6")
                    {
                        temp = "Do";
                        lbl_Nota.Text = temp;
                    }
                    //Q
                    else if (nombreBoton == "cs4")
                    {
                        temp = "Reb";
                        lbl_Nota.Text = temp;
                    }
                    //W
                    else if (nombreBoton == "ds4")
                    {
                        temp = "Mib";
                        lbl_Nota.Text = temp;
                    }
                    //E
                    else if (nombreBoton == "fs4")
                    {
                        temp = "Solb";
                        lbl_Nota.Text = temp;
                    }
                    //R
                    else if (nombreBoton == "gs4")
                    {
                        temp = "Lab";
                        lbl_Nota.Text = temp;
                    }
                    //T
                    else if (nombreBoton == "as4")
                    {
                        temp = "Sib";
                        lbl_Nota.Text = temp;
                    }
                    //Y
                    else if (nombreBoton == "cs4")
                    {
                        temp = "Reb";
                        lbl_Nota.Text = temp;
                    }
                    //U
                    else if (nombreBoton == "ds4")
                    {
                        temp = "Mib";
                        lbl_Nota.Text = temp;
                    }
                    //I
                    else if (nombreBoton == "fs5")
                    {
                        temp = "Solb";
                        lbl_Nota.Text = temp;
                    }
                    //O
                    else if (nombreBoton == "gs5")
                    {
                        temp = "Lab";
                        lbl_Nota.Text = temp;
                    }
                    //P
                    else if (nombreBoton == "as5")
                    {
                        temp = "Sib";
                        lbl_Nota.Text = temp;
                    }
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

        private void buttonAlternar_Click(object sender, EventArgs e)
        {
 
            foreach (Control boton in panel1.Controls)
            {
                string key = ((Button)boton).Text;
                string tag = ((Button)boton).Tag.ToString();
                if ( tag == "4")
                {
                    if (NotasTecladoOctava1.ContainsKey(key))
                    {
                        ((Button)boton).Text = NotasTecladoOctava1[key];
                    }
                    else 
                    {
                        ((Button)boton).Text = getKey(NotasTecladoOctava1, key);
                    }
                }
                if (tag == "5")
                {
                    if (NotasTecladoOctava2.ContainsKey(key))
                    {
                        ((Button)boton).Text = NotasTecladoOctava2[key];

                    }
                    else
                    {
                        ((Button)boton).Text = getKey(NotasTecladoOctava2, key);
                    }
                }
                if (tag == "6")
                {
                    if (NotasTecladoOctava3.ContainsKey(key))
                    {
                        ((Button)boton).Text = NotasTecladoOctava3[key];

                    }
                    else
                    {
                        ((Button)boton).Text = getKey(NotasTecladoOctava3, key);
                    }
                }
            }
        }

    }  

}
