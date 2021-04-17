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
    public partial class DataPlaylist : Form
    {

        CapaDatos datos = new CapaDatos();
        
        public DataPlaylist()
        {
            InitializeComponent();
          
        }

        private void btn_guardarP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(datos.insertar(txtNombreP.Text));
            this.Close();
           
        }
    }
}
