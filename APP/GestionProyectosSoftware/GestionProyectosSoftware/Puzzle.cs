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
using System.Security.Cryptography;
//using WMPLib;

namespace GestionProyectosSoftware
{
    public partial class Puzzle : Form
    {
        static bool flag = false;
        static string img_temp;
        static int p;
        static string lp;
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");
        int estadoDelJuego = ((int)constantes.EstadoDelJuego.AntesInicio);
        // 5 minutos de prueba
        double minutosPartida = 5;
        // Esta instancia maneja el label del timer en la ventana
        TimeFormat formato;
        //Imagenseleccionada para el rompecabezas
        Image imagen;
        //Para reproducir el sonido
        Sonido miSonido = new Sonido();
        //WindowsMediaPlayer sonido;
        public Puzzle()
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

        private void bt21_Click(object sender, EventArgs e)
        {
            panel_puzzle.BackgroundImage = null;

            /*string folder = Application.StartupPath;
            panel_puzzle.BackgroundImage = Image.FromFile(folder + "\\bt21.jpg");
            */
            //panel_puzzle.BackgroundImage = Properties.Resources.bt21;
            img_temp = "bt21";
            imagen = bt21.Image;
            flag = true;

            spiderman.BorderStyle = BorderStyle.None;
            bt21.BorderStyle = BorderStyle.Fixed3D;
            sanrio.BorderStyle = BorderStyle.None;
        }

        private void spiderman_Click(object sender, EventArgs e)
        {
            panel_puzzle.BackgroundImage = null;
            /*
            string folder = Application.StartupPath;

            panel_puzzle.BackgroundImage = Image.FromFile(folder + "\\spiderman.jpg");
            */
            //panel_puzzle.BackgroundImage = Properties.Resources.spiderman;
            img_temp = "spiderman";
            imagen = spiderman.Image;
            flag = true;

            spiderman.BorderStyle = BorderStyle.Fixed3D;
            bt21.BorderStyle = BorderStyle.None;
            sanrio.BorderStyle = BorderStyle.None;
        }

        private void sanrio_Click(object sender, EventArgs e)
        {
            panel_puzzle.BackgroundImage = null;

            /*
            string folder = Application.StartupPath;

            panel_puzzle.BackgroundImage = Image.FromFile(folder + "\\sanrio.jpg");
            */
            //panel_puzzle.BackgroundImage = Properties.Resources.sanrio;
            img_temp = "sanrio";
            imagen = sanrio.Image;
            flag = true;
            spiderman.BorderStyle = BorderStyle.None;
            bt21.BorderStyle = BorderStyle.None;
            sanrio.BorderStyle = BorderStyle.Fixed3D;
        }

        public void times_played()
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Puzzle set Veces_Jugadas = (Veces_Jugadas + 1) WHERE Id_Puzzle = @Id_Puzzle", connection);
                altas.Parameters.AddWithValue("Id_Puzzle", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            if (estadoDelJuego == ((int)constantes.EstadoDelJuego.Inicio))
            {
                /*Resta 100 milisengudos al timer*/
                formato.update(100);
                /*Cuando se acaba el tiempo se termina el juego*/
                if (formato.GetTiempo() < 0)
                {
                    estadoDelJuego = ((int)constantes.EstadoDelJuego.GameOver);
                    miSonido.reproducirSonido("NoAprobado");
                    MessageBox.Show("Game Over");
                    lblPuntos.Visible = true;
                    lblPuntos.Text = "50";
                    upload(50);
                    times_played();

                }
                else
                {
                    lblMinutos.Text = formato.Minutos();
                    lblSegundos.Text = formato.Segundos();
                    lblmilisegundos.Text = formato.Milisegundos();
                }

                //Facil
                if (pictureBox1.Image != null && pictureBox2.Image != null && pictureBox3.Image != null
                && pictureBox4.Image != null && pictureBox5.Image != null &&
                pictureBox6.Image != null && pictureBox7.Image != null && pictureBox8.Image != null && pictureBox9.Image != null)
                {
                    lblPuntos.Visible = true;
                    estadoDelJuego = ((int)constantes.EstadoDelJuego.GameOver);
                    miSonido.reproducirSonido("Aprobado");
                    MessageBox.Show("Felicidades, completaste el rompecabezas.");
                    if(formato.GetMinuto() >= 4)
                    {
                        lblPuntos.Text = "100";
                        upload(100);

                    }
                    else if (formato.GetMinuto() >= 3)
                    {
                        lblPuntos.Text = "90";
                        upload(90);

                    }
                    else if (formato.GetMinuto() >= 2)
                    {
                        lblPuntos.Text = "80";
                        upload(80);

                    }
                    else if (formato.GetMinuto() >= 1)
                    {
                        lblPuntos.Text = "70";
                        upload(70);

                    }
                    else if (formato.GetMinuto() >= 0)
                    {
                        lblPuntos.Text = "60";
                        upload(60);

                    }
                    times_played();


                }

                //Normal
                else if (pictureBox10.Image != null && pictureBox11.Image != null && pictureBox12.Image != null
                && pictureBox13.Image != null && pictureBox14.Image != null &&
                pictureBox15.Image != null && pictureBox16.Image != null && pictureBox17.Image != null && pictureBox18.Image != null
                && pictureBox19.Image != null && pictureBox20.Image != null && pictureBox21.Image != null
                && pictureBox22.Image != null && pictureBox23.Image != null && pictureBox24.Image != null
                && pictureBox25.Image != null)
                {
                    lblPuntos.Visible = true;
                    estadoDelJuego = ((int)constantes.EstadoDelJuego.GameOver);
                    miSonido.reproducirSonido("Aprobado");
                    MessageBox.Show("Felicidades, completaste el rompecabezas.");
                    if (formato.GetMinuto() >= 4)
                    {
                        lblPuntos.Text = "200";
                        upload(200);

                    }
                    else if (formato.GetMinuto() >= 3)
                    {
                        lblPuntos.Text = "180";
                        upload(180);

                    }
                    else if (formato.GetMinuto() >= 2)
                    {
                        lblPuntos.Text = "160";
                        upload(160);

                    }
                    else if (formato.GetMinuto() >= 1)
                    {
                        lblPuntos.Text = "140";
                        upload(140);

                    }
                    else if (formato.GetMinuto() >= 0)
                    {
                        lblPuntos.Text = "120";
                        upload(120);

                    }
                    times_played();


                }

                //Dificil
                else if (pictureBox26.Image != null && pictureBox27.Image != null && pictureBox28.Image != null
                && pictureBox29.Image != null && pictureBox30.Image != null &&
                pictureBox31.Image != null && pictureBox32.Image != null && pictureBox33.Image != null && pictureBox34.Image != null
                && pictureBox35.Image != null && pictureBox36.Image != null && pictureBox37.Image != null
                && pictureBox38.Image != null && pictureBox39.Image != null && pictureBox40.Image != null
                && pictureBox41.Image != null && pictureBox42.Image != null && pictureBox43.Image != null && pictureBox44.Image != null
                && pictureBox45.Image != null && pictureBox46.Image != null && pictureBox47.Image != null
                && pictureBox48.Image != null && pictureBox49.Image != null && pictureBox50.Image != null)
                {
                    lblPuntos.Visible = true;
                    estadoDelJuego = ((int)constantes.EstadoDelJuego.GameOver);
                    miSonido.reproducirSonido("Aprobado");
                    MessageBox.Show("Felicidades, completaste el rompecabezas.");
                    if (formato.GetMinuto() >= 4)
                    {
                        lblPuntos.Text = "300";
                        upload(300);

                    }
                    else if (formato.GetMinuto() >= 3)
                    {
                        lblPuntos.Text = "270";
                        upload(270);

                    }
                    else if (formato.GetMinuto() >= 2)
                    {
                        lblPuntos.Text = "240";
                        upload(240);

                    }
                    else if (formato.GetMinuto() >= 1)
                    {
                        lblPuntos.Text = "210";
                        upload(210);

                    }
                    else if (formato.GetMinuto() >= 0)
                    {
                        lblPuntos.Text = "180";
                        upload(180);

                    }
                    times_played();


                }
            }

        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            /*Cuando el juego aun no ha iniciado y presionas el botón
             comenzar, entonces comienza el juego*/
            /*Si el juego acabó, darle la oportunidad al usuario de 
            volver a comenzar el juego*/

            lblPuntos.Visible = false;
            lblPuntos.Text = "";

            pictureboxes_Null();

            if(flag != false && (rb_1_facil.Checked || rb_2_normal.Checked || rb_3_dificil.Checked))
            {
                if (estadoDelJuego == (int)constantes.EstadoDelJuego.AntesInicio
                                || estadoDelJuego == (int)constantes.EstadoDelJuego.GameOver || estadoDelJuego == (int)constantes.EstadoDelJuego.Inicio)
                {
                    IniciarTemporizador();
                    estadoDelJuego = ((int)constantes.EstadoDelJuego.Inicio);
                }
                if (rb_1_facil.Checked)
                {
                    panel_pieces.Controls.Clear();
                    CrearPiezas(9);
                    pictureboxesEasy_Visible();
                    pictureboxesEasy_Enable();

                    pictureboxesNorm_NonEnable();
                    pictureboxesNorm_NonVisible();

                    pictureboxesHard_NonEnable();
                    pictureboxesHard_NonVisible();
                }
                else if (rb_2_normal.Checked)
                {
                    panel_pieces.Controls.Clear();
                    CrearPiezasNORMAL(16);
                    pictureboxesNorm_Enable();
                    pictureboxesNorm_Visible();

                    pictureboxesEasy_NonVisible();
                    pictureboxesEasy_NonEnable();

                    pictureboxesHard_NonEnable();
                    pictureboxesHard_NonVisible();
                }
                else if (rb_3_dificil.Checked)
                {
                    panel_pieces.Controls.Clear();
                    CrearPiezasDIFICIL(25);
                    pictureboxesHard_Enable();
                    pictureboxesHard_Visible();

                    pictureboxesEasy_NonVisible();
                    pictureboxesEasy_NonEnable();

                    pictureboxesNorm_NonEnable();
                    pictureboxesNorm_NonVisible();
                }
            }
            else
            {
                MessageBox.Show("Seleccione imagen y dificultad para empezar.");
            }
            
        }

        private void IniciarTemporizador()
        {
            double milisegundosPartida = minutosPartida * 60000;
            formato = new TimeFormat((int)milisegundosPartida);
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(((PictureBox)sender).Image != null)
                ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy | DragDropEffects.Move);

        }
        //FACIL
        private void CrearPiezas(int piezas)
        {
            var imgArray = new Image[piezas];
            var img = imagen;
            Random rnd = new Random();
            List<int> orden = Enumerable.Range(0, piezas).OrderBy(i => rnd.Next()).Take(piezas).ToList();
            
            for (int i = 0; i < 3; i++)
            {
	            for (int j = 0; j < 3; j++)
	            {
		            var index = i * 3 + j;
		            imgArray[index] = new Bitmap(img.Width/3, img.Height/3);
                    imgArray[index].Tag = "picture" + index.ToString();
		            var graphics = Graphics.FromImage(imgArray[index]);
		            graphics.DrawImage(img, new Rectangle(0, 0, img.Width/3, img.Height/3), new Rectangle(i * img.Width/3, j * img.Height/3, img.Width/3, img.Height/3), GraphicsUnit.Pixel);
		            graphics.Dispose();
	            }
            }

            for(p = 0; p < piezas; p++)
            {
	            PictureBox temp = new PictureBox();
	            panel_pieces.Controls.Add(temp);
	            temp.Width = 280;
	            temp.Height = 280;
	            temp.SizeMode = PictureBoxSizeMode.StretchImage;
	            temp.BorderStyle = BorderStyle.FixedSingle;
	            temp.Top = temp.Height * (orden[p]);
                //temp.Left = 30;
                temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
                temp.Image = imgArray[p];                
            }
        }

        //NORMAL
        private void CrearPiezasNORMAL(int piezas)
        {
            var imgArray = new Image[piezas];
            var img = imagen;
            Random rnd = new Random();
            List<int> orden = Enumerable.Range(0, piezas).OrderBy(i => rnd.Next()).Take(piezas).ToList();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = i * 4 + j;
                    imgArray[index] = new Bitmap(img.Width / 4, img.Height / 4);
                    imgArray[index].Tag = "picture" + index.ToString();
                    var graphics = Graphics.FromImage(imgArray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, img.Width / 4, img.Height / 4), new Rectangle(i * img.Width / 4, j * img.Height / 4, img.Width / 4, img.Height / 4), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            for (p = 0; p < 16; p++)
            {
                PictureBox temp = new PictureBox();
                panel_pieces.Controls.Add(temp);
                temp.Width = 280;
                temp.Height = 280;
                temp.SizeMode = PictureBoxSizeMode.StretchImage;
                temp.BorderStyle = BorderStyle.FixedSingle;
                temp.Top = temp.Height * (orden[p]);
                //temp.Left = 40;
                temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
                temp.Image = imgArray[p];
            }
        }

        //DIFICIL
        private void CrearPiezasDIFICIL(int piezas)
        {
            var imgArray = new Image[piezas];
            var img = imagen;
            Random rnd = new Random();
            List<int> orden = Enumerable.Range(0, piezas).OrderBy(i => rnd.Next()).Take(piezas).ToList();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var index = i * 5 + j;
                    imgArray[index] = new Bitmap(img.Width / 5, img.Height / 5);
                    imgArray[index].Tag = "picture" + index.ToString();
                    var graphics = Graphics.FromImage(imgArray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, img.Width / 5, img.Height / 5), new Rectangle(i * img.Width / 5, j * img.Height / 5, img.Width / 5, img.Height / 5), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            for (p = 0; p < 25; p++)
            {
                PictureBox temp = new PictureBox();
                panel_pieces.Controls.Add(temp);
                temp.Width = 280;
                temp.Height = 280;
                temp.SizeMode = PictureBoxSizeMode.StretchImage;
                temp.BorderStyle = BorderStyle.FixedSingle;
                temp.Top = temp.Height * (orden[p]);
                //temp.Left = 50;
                temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
                temp.Image = imgArray[p];
            }
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            picturebox_AllowDrop();

            pictureboxesHard_NonEnable();
            pictureboxesHard_NonVisible();

            pictureboxesEasy_NonVisible();
            pictureboxesEasy_NonEnable();

            pictureboxesNorm_NonEnable();
            pictureboxesNorm_NonVisible();

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            
            lp = "picture0";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox1.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[0]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }

        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture1";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox2.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[1]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture2";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox3.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[2]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture3";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox4.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[3]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture4";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox5.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[4]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture5";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox6.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[5]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture6";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox7.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[6]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture7";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox8.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[7]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox9_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture8";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox9.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[8]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        /*Yo opino que quitemos esto debido al show que tenemos con el panel piezas y la validacion de si la pieza es correcta o no.
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            int ancho = pictureBox2.Width;
            int alto = pictureBox2.Height;
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Width = ancho;
            pictureBox2.Height = alto;
            pictureBox2.Refresh();

        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            int ancho = pictureBox1.Width;
            int alto = pictureBox1.Height;
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Width = ancho;
            pictureBox1.Height = alto;
            pictureBox1.Refresh();

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            int ancho = pictureBox3.Width;
            int alto = pictureBox3.Height;
            pictureBox3.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox3.Width = ancho;
            pictureBox3.Height = alto;
            pictureBox3.Refresh();
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            int ancho = pictureBox4.Width;
            int alto = pictureBox4.Height;
            pictureBox4.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox4.Width = ancho;
            pictureBox4.Height = alto;
            pictureBox4.Refresh();
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            int ancho = pictureBox5.Width;
            int alto = pictureBox5.Height;
            pictureBox5.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox5.Width = ancho;
            pictureBox5.Height = alto;
            pictureBox5.Refresh();
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            int ancho = pictureBox6.Width;
            int alto = pictureBox6.Height;
            pictureBox6.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox6.Width = ancho;
            pictureBox6.Height = alto;
            pictureBox6.Refresh();
        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            int ancho = pictureBox7.Width;
            int alto = pictureBox7.Height;
            pictureBox7.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox7.Width = ancho;
            pictureBox7.Height = alto;
            pictureBox7.Refresh();
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            int ancho = pictureBox8.Width;
            int alto = pictureBox8.Height;
            pictureBox8.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox8.Width = ancho;
            pictureBox8.Height = alto;
            pictureBox8.Refresh();
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            int ancho = pictureBox9.Width;
            int alto = pictureBox9.Height;
            pictureBox9.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox9.Width = ancho;
            pictureBox9.Height = alto;
            pictureBox9.Refresh();
        }*/
        private void pictureboxesEasy_Visible()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
        }
        private void pictureboxesEasy_NonVisible()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void pictureboxesEasy_Enable()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }
        private void pictureboxesEasy_NonEnable()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
        }

        private void pictureboxesNorm_Visible()
        {
            
             pictureBox10.Visible = true;
             pictureBox11.Visible = true;
             pictureBox12.Visible = true;
             pictureBox13.Visible = true;
             pictureBox14.Visible = true;
             pictureBox15.Visible = true;
             pictureBox16.Visible = true;
             pictureBox17.Visible = true;
             pictureBox18.Visible = true;
             pictureBox19.Visible = true;
             pictureBox20.Visible = true;
             pictureBox21.Visible = true;
             pictureBox22.Visible = true;
             pictureBox23.Visible = true;
             pictureBox24.Visible = true;
             pictureBox25.Visible = true;
             
        }
        private void pictureboxesNorm_NonVisible()
        {
            
             pictureBox10.Visible = false;
             pictureBox11.Visible = false;
             pictureBox12.Visible = false;
             pictureBox13.Visible = false;
             pictureBox14.Visible = false;
             pictureBox15.Visible = false;
             pictureBox16.Visible = false;
             pictureBox17.Visible = false;
             pictureBox18.Visible = false;
             pictureBox19.Visible = false;
             pictureBox20.Visible = false;
             pictureBox21.Visible = false;
             pictureBox22.Visible = false;
             pictureBox23.Visible = false;
             pictureBox24.Visible = false;
             pictureBox25.Visible = false;
                
        }

        private void pictureboxesNorm_Enable()
        {
            
             pictureBox10.Enabled = true;
             pictureBox11.Enabled = true;
             pictureBox12.Enabled = true;
             pictureBox13.Enabled = true;
             pictureBox14.Enabled = true;
             pictureBox15.Enabled = true;
             pictureBox16.Enabled = true;
             pictureBox17.Enabled = true;
             pictureBox18.Enabled= true;
             pictureBox19.Enabled = true;
             pictureBox20.Enabled = true;
             pictureBox21.Enabled = true;
             pictureBox22.Enabled = true;
             pictureBox23.Enabled = true;
             pictureBox24.Enabled = true;
             pictureBox25.Enabled = true;
             
        }
        private void pictureboxesNorm_NonEnable()
        {
            
             pictureBox10.Enabled = false;
             pictureBox11.Enabled = false;
             pictureBox12.Enabled = false;
             pictureBox13.Enabled = false;
             pictureBox14.Enabled = false;
             pictureBox15.Enabled = false;
            pictureBox16.Enabled = false;
             pictureBox17.Enabled = false;
             pictureBox18.Enabled = false;
             pictureBox19.Enabled = false;
             pictureBox20.Enabled = false;
             pictureBox21.Enabled = false;
             pictureBox22.Enabled = false;
             pictureBox23.Enabled = false;
             pictureBox24.Enabled = false;
             pictureBox25.Enabled = false;
             
        }

        private void pictureboxesHard_Visible()
        {
            
             pictureBox26.Visible = true;
             pictureBox27.Visible = true;
             pictureBox28.Visible = true;
             pictureBox29.Visible = true;
             pictureBox30.Visible = true;
             pictureBox31.Visible = true;
             pictureBox32.Visible = true;
             pictureBox33.Visible = true;
             pictureBox34.Visible = true;
             pictureBox35.Visible = true;
             pictureBox36.Visible = true;
             pictureBox37.Visible = true;
             pictureBox38.Visible = true;
             pictureBox39.Visible = true;
             pictureBox40.Visible = true;
             pictureBox41.Visible = true;
             pictureBox42.Visible = true;
             pictureBox43.Visible = true;
             pictureBox44.Visible = true;
             pictureBox45.Visible = true;
             pictureBox46.Visible = true;
             pictureBox47.Visible = true;
             pictureBox48.Visible = true;
             pictureBox49.Visible = true;
                pictureBox50.Visible = true;
            
        }
        private void pictureboxesHard_NonVisible()
        {
            
            
             pictureBox26.Visible = false;
             pictureBox27.Visible = false;
             pictureBox28.Visible = false;
             pictureBox29.Visible = false;
             pictureBox30.Visible = false;
             pictureBox31.Visible = false;
             pictureBox32.Visible = false;
             pictureBox33.Visible = false;
             pictureBox34.Visible = false;
             pictureBox35.Visible = false;
             pictureBox36.Visible = false;
             pictureBox37.Visible = false;
             pictureBox38.Visible = false;
             pictureBox39.Visible = false;
             pictureBox40.Visible = false;
             pictureBox41.Visible = false;
             pictureBox42.Visible = false;
             pictureBox43.Visible = false;
             pictureBox44.Visible = false;
             pictureBox45.Visible = false;
             pictureBox46.Visible = false;
             pictureBox47.Visible = false;
             pictureBox48.Visible = false;
             pictureBox49.Visible = false;
             pictureBox50.Visible = false;
            
        }

        private void pictureboxesHard_Enable()
        {
            
            
             pictureBox26.Enabled = true;
             pictureBox27.Enabled = true;
             pictureBox28.Enabled = true;
            pictureBox29.Enabled = true;
             pictureBox30.Enabled = true;
             pictureBox31.Enabled = true;
             pictureBox32.Enabled = true;
             pictureBox33.Enabled = true;
             pictureBox34.Enabled = true;
             pictureBox35.Enabled = true;
             pictureBox36.Enabled = true;
             pictureBox37.Enabled = true;
             pictureBox38.Enabled = true;
             pictureBox39.Enabled = true;
             pictureBox40.Enabled = true;
             pictureBox41.Enabled = true;
             pictureBox42.Enabled = true;
            pictureBox43.Enabled = true;
             pictureBox44.Enabled = true;
             pictureBox45.Enabled = true;
             pictureBox46.Enabled = true;
             pictureBox47.Enabled = true;
             pictureBox48.Enabled = true;
             pictureBox49.Enabled = true;
             pictureBox50.Enabled = true;
            
        }
        private void pictureboxesHard_NonEnable()
        {
            
            
            pictureBox26.Enabled = false;
            pictureBox27.Enabled = false;
             pictureBox28.Enabled = false;
            pictureBox29.Enabled = false;
             pictureBox30.Enabled = false;
             pictureBox31.Enabled = false;
             pictureBox32.Enabled = false;
             pictureBox33.Enabled = false;
             pictureBox34.Enabled = false;
             pictureBox35.Enabled = false;
             pictureBox36.Enabled = false;
             pictureBox37.Enabled = false;
             pictureBox38.Enabled = false;
             pictureBox39.Enabled = false;
             pictureBox40.Enabled = false;
             pictureBox41.Enabled = false;
             pictureBox42.Enabled = false;
             pictureBox43.Enabled = false;
             pictureBox44.Enabled = false;
             pictureBox45.Enabled = false;
             pictureBox46.Enabled = false;
             pictureBox47.Enabled = false;
             pictureBox48.Enabled = false;
            pictureBox49.Enabled = false;
             pictureBox50.Enabled = false;
            
        }

        private void picturebox_AllowDrop()
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;


             pictureBox10.AllowDrop = true;
             pictureBox11.AllowDrop = true;
             pictureBox12.AllowDrop = true;
             pictureBox13.AllowDrop = true;
             pictureBox14.AllowDrop = true;
             pictureBox15.AllowDrop = true;
             pictureBox16.AllowDrop = true;
             pictureBox17.AllowDrop = true;
             pictureBox18.AllowDrop = true;
             pictureBox19.AllowDrop = true;
             pictureBox20.AllowDrop = true;
             pictureBox21.AllowDrop = true;
             pictureBox22.AllowDrop = true;
             pictureBox23.AllowDrop = true;
             pictureBox24.AllowDrop = true;
             pictureBox25.AllowDrop = true;
 


            
             pictureBox26.AllowDrop = true;
             pictureBox27.AllowDrop = true;
             pictureBox28.AllowDrop = true;
             pictureBox29.AllowDrop = true;
             pictureBox30.AllowDrop = true;
             pictureBox31.AllowDrop = true;
             pictureBox32.AllowDrop = true;
             pictureBox33.AllowDrop = true;
             pictureBox34.AllowDrop = true;
             pictureBox35.AllowDrop = true;
             pictureBox36.AllowDrop = true;
             pictureBox37.AllowDrop = true;
             pictureBox38.AllowDrop = true;
             pictureBox39.AllowDrop = true;
             pictureBox40.AllowDrop = true;
             pictureBox41.AllowDrop = true;
             pictureBox42.AllowDrop = true;
             pictureBox43.AllowDrop = true;
             pictureBox44.AllowDrop = true;
             pictureBox45.AllowDrop = true;
             pictureBox46.AllowDrop = true;
             pictureBox47.AllowDrop = true;
            pictureBox48.AllowDrop = true;
            pictureBox49.AllowDrop = true;
            pictureBox50.AllowDrop = true;
            
        }

        private void pictureboxes_Null()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            pictureBox19.Image = null;
            pictureBox20.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox24.Image = null;
            pictureBox25.Image = null;
             

            
            
            pictureBox26.Image = null;
            pictureBox27.Image = null;
            pictureBox28.Image = null;
            pictureBox29.Image = null;
            pictureBox30.Image = null;
            pictureBox31.Image = null;
            pictureBox32.Image = null;
            pictureBox33.Image = null;
            pictureBox34.Image = null;
            pictureBox35.Image = null;
            pictureBox36.Image = null;
            pictureBox37.Image = null;
            pictureBox38.Image = null;
            pictureBox39.Image = null;
            pictureBox40.Image = null;
            pictureBox41.Image = null;
            pictureBox42.Image = null;
            pictureBox43.Image = null;
            pictureBox44.Image = null;
            pictureBox45.Image = null;
            pictureBox46.Image = null;
            pictureBox47.Image = null;
            pictureBox48.Image = null;
            pictureBox49.Image = null;
            pictureBox50.Image = null;
            
        }

        //Normal
        private void pictureBox10_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture0";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox10.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[0]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox11_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture1";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox11.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[1]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox11_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox12_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture2";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox12.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[2]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox12_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox13_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture3";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox13.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[3]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox13_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox14_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture4";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox14.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[4]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox14_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox15_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture5";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox15.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[5]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox15_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox16_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture6";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox16.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[6]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox16_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox17_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture7";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox17.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[7]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox17_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox18_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture8";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox18.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[8]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox18_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox19_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture9";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox19.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[9]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox19_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox20_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture10";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox20.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[10]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox20_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox21_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture11";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox21.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[11]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox21_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox22_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture12";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox22.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[12]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox22_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox23_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture13";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox23.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[13]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox23_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox24_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture14";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox24.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[14]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox24_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox25_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture15";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox25.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[15]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox25_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        //Dificil
        private void pictureBox26_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture0";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox26.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[0]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox26_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox27_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture1";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox27.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[1]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox27_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox28_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture2";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox28.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[2]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox28_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox29_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture3";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox29.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[3]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox29_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox30_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture4";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox30.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[4]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox30_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void pictureBox31_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture5";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox31.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[5]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox31_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void pictureBox32_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture6";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox32.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[6]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox32_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void pictureBox33_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture7";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox33.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[7]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox33_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void pictureBox34_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture8";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox34.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[8]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox34_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void pictureBox35_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture9";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox35.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[9]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox35_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox36_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture10";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox36.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[10]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox36_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox37_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture11";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox37.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[11]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox37_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox38_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture12";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox38.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[12]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox38_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox39_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture13";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox39.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[13]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox39_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox40_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture14";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox40.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[14]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox40_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox41_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture15";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox41.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[15]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox41_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox42_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture16";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox42.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[16]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox42_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox43_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture17";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox43.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[17]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox43_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox44_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture18";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox44.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[18]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox44_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox45_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture19";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox45.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[19]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox45_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox46_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture20";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox46.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[20]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox46_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox47_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture21";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox47.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[21]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox47_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox48_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture22";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox48.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[22]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox48_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox49_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture23";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox49.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[23]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox49_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox50_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture24";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox50.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[24]).Image = null;
                miSonido.reproducirSonido("Correcto");
            }

            else
            {
                miSonido.reproducirSonido("Incorrecto");
            }
        }

        private void pictureBox50_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        //jalara o nel hm

        public void upload(int valor)
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Puzzle set Puntos_Puzzle = (Puntos_Puzzle + " + valor + ") WHERE Id_Puzzle = @Id_Puzzle", connection);
                altas.Parameters.AddWithValue("Id_Puzzle", global.id_user);
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
