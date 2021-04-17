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
    public partial class ListaCancion : Form
    {
        CapaDatos datos = new CapaDatos();
        string listaRepro;
        public ListaCancion(string lista)
        {
            InitializeComponent();
            this.listaRepro = lista;
        }

        private void ListaCancion_Load(object sender, EventArgs e)
        {
            foreach (var cancion in datos.cancionesRepro(listaRepro))
            {
                lst_can_play.Items.Add(cancion);
            }
        }
    }
}
