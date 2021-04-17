using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyecto_reproductor.model
{
    class Cancion
    {

        int id;
        string nombre { get; set; }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public int getId()
        {
            return this.id;
        }
        public string getNombre()
        {
            return this.nombre;
        }

    }
}
