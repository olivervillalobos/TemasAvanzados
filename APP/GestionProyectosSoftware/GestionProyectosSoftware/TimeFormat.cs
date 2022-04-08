using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyectosSoftware
{
    internal class TimeFormat
    {
        /*
         * Esta clase se encarga de manejar el tiempo del timer
         * , dividirlo en minutos, sesgundos y milisegundos y 
         * obterner una representacion con un formamto mm:ss:mili
         * para deplegarse en el juego
         */
        int milisegundosPartida;
        int minutos;
        int segundos;
        int milisegundos;
        public TimeFormat(int milisegundosPartida)
        {
            this.milisegundosPartida = milisegundosPartida;
        }
        public void update(int milisegundosARestar)
        {
            milisegundosPartida -= milisegundosARestar;
            minutos = (int)milisegundosPartida / 60000;
            segundos = (int)((milisegundosPartida - minutos * 60000) / 1000);
            milisegundos = (int)(milisegundosPartida - (minutos * 60000) - (segundos * 1000));
        }
        public string Minutos()
        {
            return DosDigitos(minutos);
        }

        public string Segundos()
        {
            return DosDigitos(segundos);
        }

        public string Milisegundos()
        {
            return TresDigitos(milisegundos);
        }

        public int GetTiempo()
        {
            return milisegundosPartida;
        }

        private string DosDigitos(int numero)
        {
            string numeroString = "";
            numeroString = numero.ToString();
            if (numeroString.Length < 2)
            {
                numeroString = "0" + numeroString;
            }
            return numeroString;
             
        }

        private string TresDigitos(int numero)
        {
            string numeroString = "";
            numeroString = numero.ToString();
            if (numeroString.Length < 3)
            {
                numeroString = "0" + numeroString;
                if (numeroString.Length < 3)
                {
                    numeroString = "0" + numeroString;
                }
            }
            return numeroString;
        }
    }
}
