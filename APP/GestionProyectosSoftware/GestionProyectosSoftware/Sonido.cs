using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Windows.Forms;

namespace GestionProyectosSoftware
{
    class Sonido
    {
        public void reproducirSonido(String soundType)
        {
            //Objeto generico para obtener el recurso con el nombre de soundType
            object O = Properties.Resources.ResourceManager.GetObject(soundType);
            if (O != null)
            {
                //Se crea la variable que sera utilizada para reproducir el sonido
                var mySound = (Stream)O;
                SoundPlayer player = new SoundPlayer(mySound);
                player.Play();
                //Liberacion de los recursos utilizados
                player.Dispose();
            }

            else
                MessageBox.Show("Recurso no encontrado.");
        }
    }
}
