using proyecto_reproductor.datos;
using proyecto_reproductor.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyecto_reproductor
{
    class Reproductor
    {

        bool play = false;
        public string[] rutas;
        public string[] archivos;
     
        List<Cancion> listaCancion = new List<Cancion>();

        string link = @"D:\Dowload\Musica\";


        public Reproductor(List<String> rutas)
        {
            List<String> todas = new List<String>();
            String una;
            foreach (var ruta in rutas)
            {
                una = link + ruta + ".mp3";
                todas.Add(una);
                una = "";
            }
            this.rutas = todas.ToArray();
        }
        public Reproductor()
        {

        }

        public void abrirArchivos()
        {
            OpenFileDialog cajaBusqueda = new OpenFileDialog();
            cajaBusqueda.Multiselect = true;

            if (cajaBusqueda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivos = cajaBusqueda.SafeFileNames;
                rutas = cajaBusqueda.FileNames;
            }
        }

        public void agregar()
        {
            DirectoryInfo directorio = new DirectoryInfo(link);

            List<string> canciones = new List<string>();
            List<string> rutascanciones = new List<string>();
            Cancion item = new Cancion();
            CapaDatos datos = new CapaDatos();
            foreach (var cancion in directorio.GetFiles())
            {
                canciones.Add(cancion.Name.Replace(".mp3", ""));
                rutascanciones.Add(link + cancion.Name);
                item.setNombre(cancion.Name.Replace(".mp3", ""));
                listaCancion.Add(item);

                if (datos.existe(item))
                {
                    datos.agregar(item);
                }

                item = new Cancion();
            }
            archivos = canciones.ToArray();
            rutas = rutascanciones.ToArray();
        }
        public void cargarDb(Cancion cancion)
        {
            CapaDatos datos = new CapaDatos();
            datos.agregar(cancion);
        }

        public void reproducirPlaylist(string nombrePlaylist)
        {
            List<string> canciones = new List<string>();
            List<string> rutas = new List<string>();
            CapaDatos datos = new CapaDatos();
            foreach(var cancion in datos.cancionesRepro(nombrePlaylist))
            {
                canciones.Add(cancion);
                rutas.Add(link + cancion + ".mp3");
            }
            archivos = canciones.ToArray();
            this.rutas = rutas.ToArray();
             
        }
        
    }
}
