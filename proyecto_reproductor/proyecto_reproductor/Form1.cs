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
            if (reproducciones == 0)
            {
                reproductor.agregar();
                foreach (var cancion in reproductor.archivos)
                {
                    list_canciones.Items.Add(cancion);
                }
                repro_umg.URL = reproductor.rutas[0];
                list_canciones.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("HOla");
            }
                   
            //lb_texto.Text = reproducciones == 0 ? "" : "Seguro que quieres reprodicir la playlist:";
        }

        private void list_canciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            repro_umg.URL = reproductor.rutas[list_canciones.SelectedIndex];
        }

        private void btx_agregar_Click(object sender, EventArgs e)
        {
            Form playlist = new PlayList(list_canciones.SelectedItem.ToString());
            AddOwnedForm(playlist);
            playlist.Show();
        }
    }
}
