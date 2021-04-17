using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyecto_reproductor.model
{
    class Cancion
    {

        string _nombre;
        string _ruta;
        string _album;
        string _anio;
        string _duracion;


        public string nombre { get => _nombre; set => _nombre = value; }
        public string album { get => _album; set => _album = value; }
        public string anio { get => _anio; set => _anio = value; }
        public string duracion { get => _duracion; set => _duracion = value; }
        public string ruta { get => _ruta; set => _ruta = value; }

    }
}
