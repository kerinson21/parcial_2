using proyecto_reproductor.datos;
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
    public partial class PlayList : Form
    {
        CapaDatos datos = new CapaDatos();
        string cancion;
 
        public PlayList(string cancion)
        {
            InitializeComponent();
            this.cancion = cancion;
            listar();
            
        }

        public void listar()
        {
            foreach (var can in datos.listasReproduccion())
            {
                list_playList.Items.Add(can);
            }
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            DataPlaylist playlist = new DataPlaylist();
            playlist.Show();
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            list_playList.Items.Clear();
            listar();
        }

        private void btn_agregarP_Click(object sender, EventArgs e)
        {
            datos.guardarReproduccion(cancion,list_playList.SelectedItem.ToString());
            ListaCancion listacancion = new ListaCancion(list_playList.SelectedItem.ToString());
            listacancion.Show();
        }

        private void tbn_reproducir_Click(object sender, EventArgs e)
        {
            Reproductor reproductor = new Reproductor();
            Form1 principal = Owner as Form1;
            principal.list_canciones.Items.Clear();
            reproductor.reproducirPlaylist(list_playList.SelectedItem.ToString());
            foreach (var cancion in reproductor.archivos)
            {
                principal.list_canciones.Items.Add(cancion);
            }
            principal.repro_umg.URL = reproductor.rutas[0];
            principal.list_canciones.SelectedIndex = 0;
            principal.lb_nombre_playlist.Text = list_playList.SelectedItem.ToString();
            principal.Show();
            this.Dispose();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaCancion listacancion = new ListaCancion(list_playList.SelectedItem.ToString());
          
            listacancion.Show();
        }
    }
}
