using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarea_sem_6.Clases;

namespace tarea_sem_6
{
    public partial class Form1 : Form
    {
        ClsAutomovil carrito = new ClsAutomovil("Meches", 150, 0, 5, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncendido_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomovil("Meches", 150, 0, 5, 0);
            carrito.color = "Blanco";
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.EncenderMotor();
            Estado.Text = respuesta;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            string respuesta2 = carrito.ApagarMotor();
            Estado.Text = respuesta2;
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if(carrito.EstaEncendido())
            {
                Velocidad.Text = carrito.Acelerar();
            }else
            {
                MessageBox.Show($"No puedes acelerar el carro {carrito.marca} esta apagado");
            }
        }

        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                Velocidad.Text = carrito.Frenar();
            }
            else
            {
                MessageBox.Show($"No puedes frenar el carro {carrito.marca} ya esta apagado");
            }
        }

        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

        private void Boxagregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;
                foreach(var ArchivoMP3 in ArchivosMP3)
                {
                    lstcanciones.Items.Add(ArchivosMP3);
                }
                player.URL = rutasArchivosMP3[0];
                lstcanciones.SelectedIndex = 0;

            }
        }

        private void lstcanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = rutasArchivosMP3[lstcanciones.SelectedIndex];
        }

        private void Cambiomas_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                marcha.Text = carrito.MarchasAumento();
            }
            else
            {
                MessageBox.Show($"no puedes cambiar de marcha");
            }
        }

        private void Cambiosmenos_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                marcha.Text = carrito.MarchasDisminucion();
            }
            else
            {
                MessageBox.Show($"no puedes cambiar de marcha");
            }
        }
    }
}
