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
using WMPLib;

namespace GestionProyectosSoftware
{
    public partial class Hangman : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        WindowsMediaPlayer Sonido;
        char[] PalabrasAdivinidas; int Oportunidades; int value;
        char[] PalabraSeleccionada;
        char[] Alfabeto;
        String[] Palabras;

        public Hangman()
        {
            InitializeComponent();
        }
        public void IniciarJuego()
        {
            layoutLetras.Controls.Clear();
            layoutLetras.Enabled = true;
            ahorcadoPB.Image = null;
            lblperdiste.Visible = false;
            Oportunidades = 0;
            value = 0;

            botoninicio.SizeMode = PictureBoxSizeMode.StretchImage;
            botoninicio.Image = Properties.Resources.jugando;
            Palabras = new string[] {"Elefante","Escuela","Alfabeto","Letras", "Burro", "Perro", "Cocina", "Dado", "Fuego", "Gallina", "Hueso", "Irlanda", "Jicama", "Lengua", "Museo", "Numero", "Oso", "Pajaro", "Raton", "Sandia" };
            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            Random rnd = new Random();
            int IndicePalabraSeleccionada = rnd.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasAdivinidas = PalabraSeleccionada;

            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button letra = new Button();
                letra.Tag = "";
                letra.Text = LetraAlfabeto.ToString();
                letra.Width = 60;
                letra.Height = 40;
                letra.Click += Compara;
                letra.ForeColor = Color.White;
                letra.Font = new Font(letra.Font.Name, 15, FontStyle.Bold);
                letra.BackgroundImageLayout = ImageLayout.Center;
                letra.BackColor = Color.Black;
                letra.Name = LetraAlfabeto.ToString();
                layoutLetras.Controls.Add(letra);
            }

            layoutPalabra.Controls.Clear();

            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
            {
                Button word = new Button();
                word.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                word.Width = 46;
                word.Height = 80;
                word.ForeColor = Color.White;
                word.Text = "-";
                word.Font = new Font(word.Font.Name, 32, FontStyle.Bold);
                word.BackgroundImageLayout = ImageLayout.Center;
                word.BackColor = Color.Transparent;
                word.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                word.Name = "Adivinado" + IndiceValorLetra.ToString();
                word.BackgroundImageLayout = ImageLayout.Stretch;
                word.FlatAppearance.BorderSize = 0;
                word.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
                layoutPalabra.Controls.Add(word);
            }
        }

        void Compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;
            string botonletra = btn.Text;
            switch (botonletra)
            {
                case "A":
                    ReproducirLetra(botonletra);
                    break;
                default:
                    ReproducirLetra(botonletra);
                    break;
            }

            for (int IndiceRevisar = 0; IndiceRevisar < PalabrasAdivinidas.Length; IndiceRevisar++)
            {
                if (PalabrasAdivinidas[IndiceRevisar] == Char.Parse(btn.Text))
                {
                    Button tbx = this.Controls.Find("Adivinado" + IndiceRevisar, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinidas[IndiceRevisar].ToString();
                    PalabrasAdivinidas[IndiceRevisar] = '-';
                    encontrado = true;
                }
            }

            bool ganaste = true;

            for (int gano = 0; gano < PalabrasAdivinidas.Length; gano++)
            {
                if (PalabrasAdivinidas[gano] != '-')
                {
                    ganaste = false;
                }
            }

            if(ganaste) 
            {
                Reproducir(100);

                botoninicio.SizeMode = PictureBoxSizeMode.StretchImage;
                MessageBox.Show("Ganaste"); botoninicio.Image = Properties.Resources.jugar;
                if (Oportunidades == 0)
                {
                    value = 10;
                }
                if (Oportunidades == 1)
                {
                    value = 8;

                }
                if (Oportunidades == 2)
                {
                    value = 6;

                }
                if (Oportunidades == 3)
                {
                    value = 4;

                }
                if (Oportunidades == 4)
                {
                    value = 3;

                }
                if (Oportunidades == 5)
                {
                    value = 2;
                }
                if (Oportunidades == 6)
                {
                    value = 1;
                }
                try
                {
                    connection.Open();
                    SqlCommand altas = new SqlCommand("UPDATE Letras set Puntos_Letras = ( Puntos_Letras + @value) WHERE Id_Letras = @Id_Letras", connection);
                    altas.Parameters.AddWithValue("value", value);
                    altas.Parameters.AddWithValue("Id_Letras", global.id_user);
                    altas.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    connection.Close();
                }

            }
            
            if(!encontrado)
            {
                Oportunidades = Oportunidades + 1;
                switch(Oportunidades)
                {
                    case 1:
                        ahorcadoPB.Image = Properties.Resources.ahorcado_7;
                        ahorcadoPB.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 2:
                        ahorcadoPB.Image = Properties.Resources.ahorcado_6;
                        ahorcadoPB.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3:
                        ahorcadoPB.Image = Properties.Resources.ahorcado_5;
                        ahorcadoPB.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 4:
                        ahorcadoPB.Image = Properties.Resources.ahorcado_4;
                        ahorcadoPB.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 5:
                        ahorcadoPB.Image = Properties.Resources.ahorcado_3;
                        ahorcadoPB.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 6:
                        ahorcadoPB.Image = Properties.Resources.ahorcado_2;
                        ahorcadoPB.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 7:
                        ahorcadoPB.Image = Properties.Resources.ahorcado_1;
                        ahorcadoPB.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    default:
                        break;
                }
                
                if(Oportunidades == 7)
                {
                    Reproducir(100);
                    lblperdiste.Visible = true;
                    for (int i = 0; i < PalabraSeleccionada.Length; i++)
                    {
                        Button let = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                        let.Text = let.Tag.ToString();
                    }

                    layoutLetras.Enabled = false;
                    botoninicio.SizeMode = PictureBoxSizeMode.StretchImage;
                    botoninicio.Image = Properties.Resources.jugar;
                }
            }
        }
        private void Hangman_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void botoninicio_Click(object sender, EventArgs e)
        {
            IniciarJuego();
            veces_jugas();
        }

        public void veces_jugas()
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Letras set Veces_Jugadas = (Veces_Jugadas + 1) WHERE Id_Letras = @Id_Letras", connection);
                altas.Parameters.AddWithValue("Id_Letras", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Puntajes set promedio = c.Puntos_Colores + n.Puntos_Numeros + l.Puntos_Letras from Colores c, Numeros n, Letras l WHERE (c.Id_Colores = Puntajes.Id_Colores) AND (n.Id_Numeros = Puntajes.Id_Numeros) AND (l.Id_Letras = Puntajes.Id_Letras)", connection);
                altas.ExecuteNonQuery();
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
                SqlCommand altas = new SqlCommand("UPDATE Alumno set promedio = p.promedio from Puntajes p WHERE p.Id_Puntaje = Alumno.Id_Puntaje", connection);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        public void Reproducir(int Numero)
        {
            Sonido = new WindowsMediaPlayer();
            Sonido.URL = Application.StartupPath + @"\mp3\" + Numero + ".mp3";
            Sonido.controls.play();
        }

        public void ReproducirLetra(string Letra)
        {
            Sonido = new WindowsMediaPlayer();
            Sonido.URL = Application.StartupPath + @"\mp3\Alfabeto\" + Letra + ".mp3";
            Sonido.controls.play();
        }

    }
}
