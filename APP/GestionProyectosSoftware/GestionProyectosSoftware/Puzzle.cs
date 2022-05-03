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
//using WMPLib;

namespace GestionProyectosSoftware
{
    public partial class Puzzle : Form
    {
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
            string img_temp = "";
            img_temp = "bt21";
            imagen = bt21.Image;

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
            string img_temp = "";
            img_temp = "spiderman";
            imagen = spiderman.Image;

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
            string img_temp = "";
            img_temp = "sanrio";
            imagen = sanrio.Image;

            spiderman.BorderStyle = BorderStyle.None;
            bt21.BorderStyle = BorderStyle.None;
            sanrio.BorderStyle = BorderStyle.Fixed3D;
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
                    MessageBox.Show("Game Over");
                    lblPuntos.Visible = true;
                    lblPuntos.Text = "50";
                }
                else
                {
                    lblMinutos.Text = formato.Minutos();
                    lblSegundos.Text = formato.Segundos();
                    lblmilisegundos.Text = formato.Milisegundos();
                }

                if (pictureBox1.Image != null && pictureBox2.Image != null && pictureBox3.Image != null
                && pictureBox4.Image != null && pictureBox5.Image != null &&
                pictureBox6.Image != null && pictureBox7.Image != null && pictureBox8.Image != null && pictureBox9.Image != null)
                {
                    lblPuntos.Visible = true;
                    estadoDelJuego = ((int)constantes.EstadoDelJuego.GameOver);
                    MessageBox.Show("Felicidades, completaste el rompecabezas.");
                    if(formato.GetMinuto() >= 4)
                    {
                        lblPuntos.Text = "100";
                    }
                    else if (formato.GetMinuto() >= 3)
                    {
                        lblPuntos.Text = "90";
                    }
                    else if (formato.GetMinuto() >= 2)
                    {
                        lblPuntos.Text = "80";
                    }
                    else if (formato.GetMinuto() >= 1)
                    {
                        lblPuntos.Text = "70";
                    }
                    else if (formato.GetMinuto() >= 0)
                    {
                        lblPuntos.Text = "60";
                    }

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

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            /*
            1 pictureBox10.AllowDrop = true;
            2 pictureBox11.AllowDrop = true;
            3 pictureBox12.AllowDrop = true;
            4 pictureBox13.AllowDrop = true;
            5 pictureBox14.AllowDrop = true;
            6 pictureBox15.AllowDrop = true;
            7 pictureBox16.AllowDrop = true;
            8 pictureBox17.AllowDrop = true;
            9 pictureBox18.AllowDrop = true;
            10 pictureBox19.AllowDrop = true;
            11 pictureBox20.AllowDrop = true;
            12 pictureBox21.AllowDrop = true;
            13 pictureBox22.AllowDrop = true;
            14 pictureBox23.AllowDrop = true;
            15 pictureBox24.AllowDrop = true;
            16 pictureBox25.AllowDrop = true;
             */

            /*
            1 pictureBox26.AllowDrop = true;
            2 pictureBox26.AllowDrop = true;
            3 pictureBox27.AllowDrop = true;
            4 pictureBox28.AllowDrop = true;
            5 pictureBox29.AllowDrop = true;
            6 pictureBox30.AllowDrop = true;
            7 pictureBox31.AllowDrop = true;
            8 pictureBox32.AllowDrop = true;
            9 pictureBox33.AllowDrop = true;
            10 pictureBox34.AllowDrop = true;
            11 pictureBox35.AllowDrop = true;
            12 pictureBox36.AllowDrop = true;
            13 pictureBox37.AllowDrop = true;
            14 pictureBox38.AllowDrop = true;
            15 pictureBox39.AllowDrop = true;
            16 pictureBox40.AllowDrop = true;
            17 pictureBox41.AllowDrop = true;
            18 pictureBox42.AllowDrop = true;
            19 pictureBox43.AllowDrop = true;
            20 pictureBox44.AllowDrop = true;
            21 pictureBox45.AllowDrop = true;
            22 pictureBox46.AllowDrop = true;
            23 pictureBox47.AllowDrop = true;
            24 pictureBox48.AllowDrop = true;
            25 pictureBox49.AllowDrop = true;
            */

            if (estadoDelJuego == (int)constantes.EstadoDelJuego.AntesInicio
                || estadoDelJuego == (int)constantes.EstadoDelJuego.GameOver || estadoDelJuego == (int)constantes.EstadoDelJuego.Inicio)
            {
                IniciarTemporizador();
                estadoDelJuego = ((int)constantes.EstadoDelJuego.Inicio);
            }
            if(rb_1_facil.Checked)
            {
                panel_pieces.Controls.Clear();
                CrearPiezas(9);


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
            /*else if(rb_2_normal.Checked)
            {

            }
            else if(rb_3_dificil.Checked)
            {

            }*/
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

        private void CrearPiezas(int piezas)
        {
            var imgArray = new Image[piezas];
            var img = imagen;
            
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

            for(p = 0; p < 9; p++)
            {
	            PictureBox temp = new PictureBox();
	            panel_pieces.Controls.Add(temp);
	            temp.Width = img.Width/3;
	            temp.Height = img.Height/3;
	            temp.SizeMode = PictureBoxSizeMode.StretchImage;
	            temp.BorderStyle = BorderStyle.FixedSingle;
	            temp.Top = temp.Height * (panel_pieces.Controls.Count - 1);
                //temp.Left = 30;
                temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
                temp.Image = imgArray[p];
            }
        }

        private void Puzzle_Load(object sender, EventArgs e)
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
            /*
            1 pictureBox10.AllowDrop = true;
            2 pictureBox11.AllowDrop = true;
            3 pictureBox12.AllowDrop = true;
            4 pictureBox13.AllowDrop = true;
            5 pictureBox14.AllowDrop = true;
            6 pictureBox15.AllowDrop = true;
            7 pictureBox16.AllowDrop = true;
            8 pictureBox17.AllowDrop = true;
            9 pictureBox18.AllowDrop = true;
            10 pictureBox19.AllowDrop = true;
            11 pictureBox20.AllowDrop = true;
            12 pictureBox21.AllowDrop = true;
            13 pictureBox22.AllowDrop = true;
            14 pictureBox23.AllowDrop = true;
            15 pictureBox24.AllowDrop = true;
            16 pictureBox25.AllowDrop = true;
             */

            /*
            1 pictureBox26.AllowDrop = true;
            2 pictureBox26.AllowDrop = true;
            3 pictureBox27.AllowDrop = true;
            4 pictureBox28.AllowDrop = true;
            5 pictureBox29.AllowDrop = true;
            6 pictureBox30.AllowDrop = true;
            7 pictureBox31.AllowDrop = true;
            8 pictureBox32.AllowDrop = true;
            9 pictureBox33.AllowDrop = true;
            10 pictureBox34.AllowDrop = true;
            11 pictureBox35.AllowDrop = true;
            12 pictureBox36.AllowDrop = true;
            13 pictureBox37.AllowDrop = true;
            14 pictureBox38.AllowDrop = true;
            15 pictureBox39.AllowDrop = true;
            16 pictureBox40.AllowDrop = true;
            17 pictureBox41.AllowDrop = true;
            18 pictureBox42.AllowDrop = true;
            19 pictureBox43.AllowDrop = true;
            20 pictureBox44.AllowDrop = true;
            21 pictureBox45.AllowDrop = true;
            22 pictureBox46.AllowDrop = true;
            23 pictureBox47.AllowDrop = true;
            24 pictureBox48.AllowDrop = true;
            25 pictureBox49.AllowDrop = true;
            */

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
            if(lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox1.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[0]).Image = null;
            }

        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            lp = "picture1";
            if (lp == (((Bitmap)e.Data.GetData((DataFormats.Bitmap), true)).Tag).ToString())
            {
                pictureBox2.Image = (Bitmap)e.Data.GetData((DataFormats.Bitmap), true);
                ((PictureBox)panel_pieces.Controls[1]).Image = null;
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
            }
        }

        private void pictureBox9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

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
        }

        
    }
}
