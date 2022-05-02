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
                }
                else
                {
                    lblMinutos.Text = formato.Minutos();
                    lblSegundos.Text = formato.Segundos();
                    lblmilisegundos.Text = formato.Milisegundos();
                }
            }

        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            /*Cuando el juego aun no ha iniciado y presionas el botón
             comenzar, entonces comienza el juego*/
            /*Si el juego acabó, darle la oportunidad al usuario de 
            volver a comenzar el juego*/

            if (estadoDelJuego == (int)constantes.EstadoDelJuego.AntesInicio
                || estadoDelJuego == (int)constantes.EstadoDelJuego.GameOver)
            {
                IniciarTemporizador();
                estadoDelJuego = ((int)constantes.EstadoDelJuego.Inicio);
                CrearPiezas(9);
            }
        }

        private void IniciarTemporizador()
        {
            double milisegundosPartida = minutosPartida * 60000;
            formato = new TimeFormat((int)milisegundosPartida);
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);

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
		            imgArray[index] = new Bitmap(img.Width/30, img.Height/30);
                    imgArray[index].Tag = "picture" + index.ToString();
		            var graphics = Graphics.FromImage(imgArray[index]);
		            graphics.DrawImage(img, new Rectangle(0, 0, img.Width/30, img.Height/30), new Rectangle(i * img.Width/30, j * img.Height/30, img.Width/30, img.Height/30), GraphicsUnit.Pixel);
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
    }
}
