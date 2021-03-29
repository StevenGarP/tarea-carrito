using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_sem_6.Clases
{
    class ClsAutomovil
    {
        public String marca { get; }
        public int vel_max { get; set; }
        public int vel_min { get; set; }
        private int velocidadActual { get; set; }
        private bool encendido = false;
        public String color { get; set; }
        public int marcha_max { get; }
        public int marcha_min { get; }
        private int marchaActual { get; set; }

        public bool EstaEncendido()
        {
            return encendido;
        }
         public string MarchasAumento()
        {
            marchaActual = marchaActual + 1;
            if ( marchaActual > marcha_max)
            {
                return "vas en la marcha maxima";
            }
            else
            {
                return $"vas en la marcha {marchaActual}";
            }
        }
        public string MarchasDisminucion()
        {
            marchaActual = marchaActual - 1;
            if (marchaActual > marcha_min)
            {
                return "vas en la marcha maxima";
            }
            else
            {
                return $"vas en la marcha {marchaActual}";
            }
        }

        public string Acelerar()
        {
            if (marchaActual == 0)
            {
                vel_max = 0;
            }
            if (marchaActual == 1)
            { vel_max = 30;
            }
            if (marchaActual == 2)
            {
                vel_max = 60;
            }
            if (marchaActual == 3)
            {
                vel_max = 90;
            }
            if (marchaActual == 4)
            {
                vel_max = 120;
            }
            if (marchaActual == 5)
            {
                vel_max = 150;
            }
            velocidadActual = velocidadActual + 10;
            if (velocidadActual > vel_max)
            {
                return "vas a maxima velocidad";
            }else
            {
                return $"vas a {velocidadActual} Km/h";
            }

        }

        public string Frenar()
        {
            if (marchaActual == 0)
            {
                vel_min = 0;
            }
            if (marchaActual == 1)
            {
                vel_min = 30;
            }
            if (marchaActual == 2)
            {
                vel_min = 60;
            }
            if (marchaActual == 3)
            {
                vel_min = 90;
            }
            if (marchaActual == 4)
            {
                vel_min = 120;
            }
            if (marchaActual == 5)
            {
                vel_min = 150;
            }
            velocidadActual = velocidadActual - 10;
            if (velocidadActual <= vel_min)
            {
                return "ya estas detenido";
            }
            else
            {
                return $"vas a {velocidadActual} Km/h";
            }
        }

        public ClsAutomovil(string marcaCarro, int velocidadMx, int velocidadmin, int marchaMX, int marchaMin)
        { 
            this.marca = marcaCarro;
            this.vel_max = velocidadMx;
            this.vel_min = velocidadmin;
            this.marcha_max = marchaMX;
            this.marcha_min = marchaMin;
        }

        public String EncenderMotor()
        {
            if(encendido)
            {
                return "El carro ya esta encendido";  
            }else
            {
                encendido = true;
                velocidadActual = 0;
                marchaActual = 0;
                return "Listo!! Carro encendido";
            }
        }

        public String ApagarMotor()
        {
            if (encendido == false)
            {
                return "El carro ya esta apagado";
            }else
            {
                encendido = false;
                velocidadActual = 0;
                return "el carro ya esta apagado";
            }
        }
    }
}
