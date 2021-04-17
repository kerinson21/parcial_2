using listas;
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
        public Cancion[] canciones;
     
        List<Cancion> listaCancion = new List<Cancion>();

        string link = @"D:\Dowload\Musica\";


     
        public Reproductor()
        {

        }

        public void abrirArchivos()
        {
            /*OpenFileDialog cajaBusqueda = new OpenFileDialog();
            cajaBusqueda.Multiselect = true;

            if (cajaBusqueda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivos = cajaBusqueda.SafeFileNames;
                rutas = cajaBusqueda.FileNames;
            }*/
        }

        public void agregar()
        {
            DirectoryInfo directorio = new DirectoryInfo(link);

            Cancion cancion = new Cancion();
            CapaDatos datos = new CapaDatos();
            Lista myList = new Lista();
            foreach (var rutas in directorio.GetFiles())
            {
                cancion.nombre = rutas.Name;
                cancion.ruta = link + rutas.Name;
                TagLib.File dataCancion = TagLib.File.Create(cancion.ruta);
                cancion.album = dataCancion.Tag.Album;
                cancion.anio = dataCancion.Tag.Year.ToString();
                cancion.duracion = Convert.ToString(dataCancion.Properties.Duration);

                if (datos.existe(cancion.nombre))
                {
                    datos.agregar(cancion.nombre);
                }
                myList.add(cancion);
                cancion = new Cancion();
            }
            canciones = myList.toArreglo();
        }
        public void cargarDb(string cancion)
        {
            CapaDatos datos = new CapaDatos();
            datos.agregar(cancion);
        }

        public void reproducirPlaylist(string nombrePlaylist)
        {
            
            Lista canciones = new Lista();
            Cancion datosCancion = new Cancion();
            CapaDatos datos = new CapaDatos();
            foreach(var cancion in datos.cancionesRepro(nombrePlaylist))
            {
                
                datosCancion.nombre = cancion;
                datosCancion.ruta = link+cancion;
                
                /*datosCancion.album = rutas.Tag.Album;
                datosCancion.anio = rutas.Tag.Year.ToString();
                datosCancion.duracion = Convert.ToString(rutas.Properties.Duration);*/
                canciones.add(datosCancion);
                datosCancion = new Cancion();
            }
            this.canciones = canciones.toArreglo();
        
        }

        private string crearRuta(string nombre)
        {
            return link + nombre;
        }
        
    }
}
