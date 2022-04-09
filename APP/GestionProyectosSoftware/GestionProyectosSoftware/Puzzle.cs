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
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");
        int estadoDelJuego = ((int)constantes.EstadoDelJuego.AntesInicio);
        // 2 minutos de prueba
        double minutosPartida = 2;
        
        TimeFormat formato;

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
                SqlCommand altas = new SqlCommand("UPDATE Puntajes set promedio = p.Puntos_Puzzle + k.Puntos_Piano + f.Puntos_CompletaFrases + " +
                    "c.Puntos_Colores + n.Puntos_Numeros + l.Puntos_Letras from Puzzle p, Piano k, CompletaFrases f, Colores c, Numeros n, Letras l " +
                    "WHERE (p.Id_Puzzle = Puntajes.Id_Puzzle) AND (k.Id_Piano = Puntajes.Id_Piano) AND (f.Id_CompletaFrases = Puntajes.Id_CompletaFrases) AND" +
                    " (c.Id_Colores = Puntajes.Id_Colores) AND (n.Id_Numeros = Puntajes.Id_Numeros) AND (l.Id_Letras = Puntajes.Id_Letras)", connection);
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

        private void bt21_Click(object sender, EventArgs e)
        {
            panel_puzzle.BackgroundImage = null;

            /*string folder = Application.StartupPath;
            panel_puzzle.BackgroundImage = Image.FromFile(folder + "\\bt21.jpg");
            */
            panel_puzzle.BackgroundImage = Properties.Resources.bt21;
            
        }

        private void spiderman_Click(object sender, EventArgs e)
        {
            panel_puzzle.BackgroundImage = null;

            /*
            string folder = Application.StartupPath;

            panel_puzzle.BackgroundImage = Image.FromFile(folder + "\\spiderman.jpg");
            */
            panel_puzzle.BackgroundImage = Properties.Resources.spiderman;
        }

        private void sanrio_Click(object sender, EventArgs e)
        {
            panel_puzzle.BackgroundImage = null;

            /*
            string folder = Application.StartupPath;

            panel_puzzle.BackgroundImage = Image.FromFile(folder + "\\sanrio.jpg");
            */
            panel_puzzle.BackgroundImage = Properties.Resources.sanrio;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            if (estadoDelJuego == ((int)constantes.EstadoDelJuego.Inicio))
            {
                formato.update(100);
                if (formato.GetTiempo() < 0)
                {
                    estadoDelJuego = ((int)constantes.EstadoDelJuego.GameOver);
                }
                else
                {
                    lblMinutos.Text = formato.Minutos();
                    lblSegundos.Text = formato.Segundos();
                    lblmilisegundos.Text = formato.Milisegundos();
                }
 
            }
            if (estadoDelJuego == ((int)constantes.EstadoDelJuego.AntesInicio))
            {
                double milisegundosPartida = minutosPartida * 60000;
                estadoDelJuego = ((int)constantes.EstadoDelJuego.Inicio);
                formato = new TimeFormat((int)milisegundosPartida);
            }
        }
    }
}
