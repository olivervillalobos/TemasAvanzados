using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WMPLib;

namespace GestionProyectosSoftware
{
    public partial class Memorama : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        WindowsMediaPlayer Sonido;
        TimeSpan Tiempo;
        int TamColumnasFilas = 5;
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;
        Stopwatch Crono = new Stopwatch();

        public Memorama()
        {
            InitializeComponent();
            iniciarJuego();
        }

        public void iniciarJuego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            CantidadDeCartasVolteadas = 0;
            PanelJuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamColumnasFilas;
            tablaPanel.ColumnCount = TamColumnasFilas-1;
            for (int i = 0; i < TamColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;

            for (var i = 0; i < TamColumnasFilas-1; i++)
            {
                for (var j = 0; j < TamColumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.carta;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(tablaPanel);

        }
        private void btnCarta_Click(object sender, EventArgs e)
        {
            Crono.Start();
            tmrTiempo.Enabled=true;
            if (CartasSeleccionadas.Count < 2)
            {
                var CartasSeleccionadasUsuario = (PictureBox)sender;

                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                //  2 Veces se realizo el evento del click
                if (CartasSeleccionadas.Count == 2 )
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);
                    if (CartasSeleccionadas[0] == CartasSeleccionadas[1])
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        if (Carta1 != Carta2)
                        {
                            timer1.Enabled = true;
                            timer1.Start();
                        }
                        else
                        {
                            CantidadDeCartasVolteadas++;
                            if (CantidadDeCartasVolteadas > 9)
                            {
                                tmrTiempo.Stop();
                                Crono.Stop();
                                Reproducir(100);
                                if (Convert.ToInt32(lblSegundos.Text) <= 40 && Convert.ToInt32(lblMinutos.Text) == 0)
                                {
                                    lblPuntos.Visible = true;
                                    lblPuntos.Text = "10";
                                    upload1();
                                }
                                else
                                {
                                    if (Convert.ToInt32(lblSegundos.Text) <= 50 && Convert.ToInt32(lblMinutos.Text) == 0)
                                    {
                                        lblPuntos.Visible = true;
                                        lblPuntos.Text = "7";
                                        upload2();
                                    }
                                    else
                                    {
                                        lblPuntos.Visible = true;
                                        lblPuntos.Text = "4";
                                        upload3();
                                    }

                                }
                                MessageBox.Show("El juego terminó");
                            }
                            CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                            CartasSeleccionadas.Clear();

                        }
                    }
                }
            }

        }
        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);
            Random rnd = new Random();
            switch (NumeroImagen)
            {  
                case 0:
                    TmpImg = Properties.Resources._1uno;
                    Reproducir(1);
                    break;
                case 1:
                    TmpImg = Properties.Resources._2dos;
                    Reproducir(2);
                    break;
                case 2:
                    TmpImg = Properties.Resources._3tres;
                    Reproducir(3);
                    break;
                case 3:
                    TmpImg = Properties.Resources._4cuatro;
                    Reproducir(4);
                    break;
                case 4:
                    TmpImg = Properties.Resources._5cinco;
                    Reproducir(5);
                    break;
                case 5:
                    TmpImg = Properties.Resources._6seis;
                    Reproducir(6);
                    break;
                case 6:
                    TmpImg = Properties.Resources._7siete;
                    Reproducir(7);
                    break;
                case 7:
                    TmpImg = Properties.Resources._8ocho;
                    Reproducir(8);
                    break;
                case 8:
                    TmpImg = Properties.Resources._9nueve;
                    Reproducir(9);
                    break;
                case 9:
                    TmpImg = Properties.Resources._0cero;
                    Reproducir(0);
                    break;
            }
            return TmpImg;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoGirarCarta = 10;
            if (TiempoGirarCarta == 10)
            {
                CartaTemporal1.Image = Properties.Resources.carta;
                CartaTemporal2.Image = Properties.Resources.carta;
                CartasSeleccionadas.Clear();
                TiempoGirarCarta = 0;
                timer1.Stop();

            }
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            Tiempo = new TimeSpan(0,0,0,0,(int)Crono.ElapsedMilliseconds);
            lblmilisegundos.Text =Tiempo.Milliseconds.ToString();
            lblSegundos.Text = Tiempo.Seconds.ToString().Length < 2 ? "0" + Tiempo.Seconds.ToString() : Tiempo.Seconds.ToString();
            lblMinutos.Text = Tiempo.Minutes.ToString().Length < 2 ? "0" + Tiempo.Minutes.ToString() : Tiempo.Minutes.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Tiempo = new TimeSpan(0, 0, 0, 0, 0);
            tmrTiempo.Stop();
            Crono.Reset();
            lblMinutos.Text = "00";
            lblSegundos.Text = "00";
            lblmilisegundos.Text = "000";
            lblPuntos.Text = "0";
            lblPuntos.Visible = false;
            veces_jugas();
            iniciarJuego();
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
            Form frmMenu = new Menu();
            frmMenu.Show();
        }

        public void upload1()
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Numeros set Puntos_Numeros = ( Puntos_Numeros + 10) WHERE Id_Numeros = @Id_Numeros", connection);
                altas.Parameters.AddWithValue("Id_Numeros", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }
        public void upload2()
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Numeros set Puntos_Numeros = ( Puntos_Numeros + 7) WHERE Id_Numeros = @Id_Numeros", connection);
                altas.Parameters.AddWithValue("Id_Numeros", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }
        public void upload3()
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Numeros set Puntos_Numeros = ( Puntos_Numeros + 4) WHERE Id_Numeros = @Id_Numeros", connection);
                altas.Parameters.AddWithValue("Id_Numeros", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }
        public void veces_jugas()
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Numeros set Veces_Jugadas = (Veces_Jugadas + 1) WHERE Id_Numeros = @Id_Numeros", connection);
                altas.Parameters.AddWithValue("Id_Numeros", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }

        public void Reproducir(int Numero)
        {
            Sonido = new WindowsMediaPlayer();
            Sonido.URL = Application.StartupPath + @"\mp3\" + Numero + ".mp3";
            Sonido.controls.play();
        }
    }
}
