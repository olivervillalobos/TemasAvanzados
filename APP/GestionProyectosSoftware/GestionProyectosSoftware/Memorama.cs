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

namespace GestionProyectosSoftware
{
    public partial class Memorama : Form
    {
        
        TimeSpan Tiempo;
        int TamColumnasFilas = 4;
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
            for (int i = 0; i < 8; i++)
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
            tablaPanel.ColumnCount = TamColumnasFilas;
            for (int i = 0; i < TamColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;

            for (var i = 0; i < TamColumnasFilas; i++)
            {
                for (var j = 0; j < TamColumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Palomita;
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
                if (CartasSeleccionadas.Count == 2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);

                    if (Carta1 != Carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        CantidadDeCartasVolteadas++;
                        if (CantidadDeCartasVolteadas > 7)
                        {
                            tmrTiempo.Stop();
                            Crono.Stop();
                            MessageBox.Show("El juego terminó");
                            if (Convert.ToInt32(lblSegundos.Text) <= 40 && Convert.ToInt32(lblMinutos.Text) == 0)
                            {
                                lblPuntos.Visible = true;
                                lblPuntos.Text = "100";
                            }
                            else
                            {
                                if (Convert.ToInt32(lblSegundos.Text) <= 50 && Convert.ToInt32(lblMinutos.Text) == 0)
                                {
                                    lblPuntos.Visible = true;
                                    lblPuntos.Text = "90";
                                }
                                else
                                {
                                    lblPuntos.Visible = true;
                                    lblPuntos.Text = "80";
                                }

                            }
                            
                        }
                        CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();

                    }


                }
            }

        }
        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);
            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.negro;
                    break;
                case 1:
                    TmpImg = Properties.Resources.café;
                    break;
                case 2:
                    TmpImg = Properties.Resources.morado;
                    break;
                case 3:
                    TmpImg = Properties.Resources.azul;
                    break;
                case 4:
                    TmpImg = Properties.Resources.amarillo;
                    break;
                case 5:
                    TmpImg = Properties.Resources.blanco;
                    break;
                case 6:
                    TmpImg = Properties.Resources.rojo;
                    break;
                case 7:
                    TmpImg = Properties.Resources.rosa;
                    break;
            }
            return TmpImg;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoGirarCarta = 10;
            if (TiempoGirarCarta == 10)
            {
                CartaTemporal1.Image = Properties.Resources.Palomita;
                CartaTemporal2.Image = Properties.Resources.Palomita;
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
            iniciarJuego();

        }
    }
}
