using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GestionProyectosSoftware
{
    public partial class Pizarra : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        Graphics L;
        int x = -1;
        int y = -1;
        bool Mov = false;
        Pen Lapiz;
        bool borrador = false;

        public Pizarra()
        {
            InitializeComponent();
            L = Lienzo.CreateGraphics();
            Lapiz = new Pen(Color.Black, 8);
            L.SmoothingMode = SmoothingMode.AntiAlias;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
        }

        private void Lienzo_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            x = e.X;
            y = e.Y;
            Lienzo.Cursor = Cursors.Cross;
            if (borrador == true)
            {
                Lapiz.Width = 90;
            }
        }

        private void Lienzo_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
            x = -1;
            y = -1;
            Lienzo.Cursor = Cursors.Default;
        }

        private void Lienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov && x != -1 && y != -1)
            {
                L.DrawLine(Lapiz, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Red;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Rojo";
            lblColor.ForeColor = Color.Red;
            upload();
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.CornflowerBlue;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Azul";
            lblColor.ForeColor = Color.CornflowerBlue;
            upload();
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.LimeGreen;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Verde";
            lblColor.ForeColor = Color.LimeGreen;
            upload();
        }

        private void btnNaranja_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Orange;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Naranja";
            lblColor.ForeColor = Color.Orange;
            upload();
        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Black;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Negro";
            lblColor.ForeColor = Color.Black;
            upload();
        }

        private void btnPurpura_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.MediumPurple;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Morado";
            lblColor.ForeColor = Color.MediumPurple;
            upload();
        }

        private void btnBlanco_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.White;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Blanco";
            lblColor.ForeColor = Color.White;
            upload();
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.SaddleBrown;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Café";
            lblColor.ForeColor = Color.SaddleBrown;
            upload();
        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.Yellow;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Amarillo";
            lblColor.ForeColor = Color.Yellow;
            upload();
        }

        private void btnRosa_Click(object sender, EventArgs e)
        {
            borrador = false;
            Lapiz.Color = Color.LightPink;
            Lapiz.StartCap = Lapiz.EndCap = LineCap.Round;
            lblColor.Text = "Rosa";
            lblColor.ForeColor = Color.Pink;
            upload();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
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

        private void btnCambiarFondo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(0, 5);
            string folder = Application.StartupPath;

            try
            {
                if (aleatorio == 0)
                {
                    Lienzo.BackgroundImage = Image.FromFile(folder + "\\oso.png");
                    upload();
                }
                if (aleatorio == 1)
                {
                    Lienzo.BackgroundImage = Image.FromFile(folder + "\\dino.png");
                    upload();
                }
                if (aleatorio == 2)
                {
                    Lienzo.BackgroundImage = Image.FromFile(folder + "\\frutas.png");
                    upload();
                }
                if (aleatorio == 3)
                {
                    Lienzo.BackgroundImage = Image.FromFile(folder + "\\poyo.png");
                    upload();
                }
                if (aleatorio == 4)
                {
                    Lienzo.BackgroundImage = Image.FromFile(folder + "\\flor.png");
                    upload();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void upload()
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Colores set Puntos_Colores = (Puntos_Colores + 1) WHERE Id_Colores = @Id_Colores", connection);
                altas.Parameters.AddWithValue("Id_Colores", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }
    }
}
