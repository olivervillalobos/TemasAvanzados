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

namespace GestionProyectosSoftware
{
    public partial class Menu : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=sqlservertrini.database.windows.net;Initial Catalog=appschool;Persist Security Info=True;User ID=azureuser;Password=Oliver.1999");

        public Menu()
        {
            InitializeComponent();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Colores set Veces_Jugadas = (Veces_Jugadas + 1) WHERE Id_Colores = @Id_Colores", connection);
                altas.Parameters.AddWithValue("Id_Colores", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
            this.Close();
            Form Pizarra = new Pizarra();
            Pizarra.Show();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
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
            this.Close();
            Memorama memo = new Memorama();
            memo.Show();
        }

        private void btnLetras_Click(object sender, EventArgs e)
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
            this.Close();
            Hangman Hangman = new Hangman();
            Hangman.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Agregar los updates
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
            Form frmConfirmar = new ConfirmarCierreSesion();
            frmConfirmar.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
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
        }
        //puzzle

        private void btnPuzzle_Click(object sender, EventArgs e)
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
            this.Close();
            Form Puzzle = new Puzzle();
            Puzzle.Show();
        }

        private void btnPiano_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE Piano set Veces_Jugadas = (Veces_Jugadas + 1) WHERE Id_Piano = @Id_Piano", connection);
                altas.Parameters.AddWithValue("Id_Piano", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
            this.Close();
            Form Piano = new Piano();
            Piano.Show();
        }

        private void btnCompletaFrases_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand altas = new SqlCommand("UPDATE CompletaFrases set Veces_Jugadas = (Veces_Jugadas + 1) WHERE Id_CompletaFrases = @Id_CompletaFrases", connection);
                altas.Parameters.AddWithValue("Id_CompletaFrases", global.id_user);
                altas.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
            this.Close();
            Form CompletaFrases = new TeclasDivertidas();
            CompletaFrases.Show();
        }
    }
}
