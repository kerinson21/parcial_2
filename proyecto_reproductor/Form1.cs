using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyecto_reproductor
{
    public partial class Form1 : Form
    {
        public int n_cancion;
        Reproductor reproductor = new Reproductor();

        public int reproducciones = 0;
        public String playlist_name = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {
            Form playlist = new PlayList(list_canciones.SelectedItem.ToString());
            AddOwnedForm(playlist);
            playlist.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n_cancion = 0;
            if (reproducciones == 0)
            {
                reproductor.agregar();
                foreach (var cancion in reproductor.canciones)
                {
                    list_canciones.Items.Add(cancion.nombre.Replace(".mp3",""));
                }
                
            }
            repro_umg.URL = reproductor.canciones[n_cancion].ruta;
            list_canciones.SelectedIndex = n_cancion;
            labelAlbum.Text = reproductor.canciones[list_canciones.SelectedIndex].album;
            labelAnio.Text = reproductor.canciones[list_canciones.SelectedIndex].anio;
            labelDuracion.Text = reproductor.canciones[list_canciones.SelectedIndex].duracion.Substring(0,8);

            //lb_texto.Text = reproducciones == 0 ? "" : "Seguro que quieres reprodicir la playlist:";
        }

        private void list_canciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            repro_umg.URL = reproductor.canciones[list_canciones.SelectedIndex].ruta;
            labelAlbum.Text = reproductor.canciones[list_canciones.SelectedIndex].album;
            labelAnio.Text = reproductor.canciones[list_canciones.SelectedIndex].anio;
            labelDuracion.Text = reproductor.canciones[list_canciones.SelectedIndex].duracion.Substring(0,8);
        }

        private void btx_agregar_Click(object sender, EventArgs e)
        {
            Form playlist = new PlayList(list_canciones.SelectedItem.ToString());
            AddOwnedForm(playlist);
            playlist.Show();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            n_cancion++;
            if (n_cancion >= list_canciones.Items.Count)
            {
                n_cancion = 0;
            }
            repro_umg.URL = reproductor.canciones[n_cancion].ruta;
            list_canciones.SelectedIndex = n_cancion;
            labelAlbum.Text = reproductor.canciones[list_canciones.SelectedIndex].album;
            labelAnio.Text = reproductor.canciones[list_canciones.SelectedIndex].anio;
            labelDuracion.Text = reproductor.canciones[list_canciones.SelectedIndex].duracion.Substring(0,8);

        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            n_cancion--;
            repro_umg.URL = reproductor.canciones[n_cancion].ruta;
            list_canciones.SelectedIndex = n_cancion;
            if (n_cancion > list_canciones.Items.Count)
            {
                n_cancion = 0;
            }

            labelAlbum.Text = reproductor.canciones[list_canciones.SelectedIndex].album;
            labelAnio.Text = reproductor.canciones[list_canciones.SelectedIndex].anio;
            labelDuracion.Text = reproductor.canciones[list_canciones.SelectedIndex].duracion.Substring(0,8);


        }

        private void repro_umg_Enter(object sender, EventArgs e)
        {

        }
    }
}
