using proyecto_reproductor.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Nodo
    {
        private Cancion _cancion;
        private Nodo _siguiente;
        private Nodo _anterior;


        public Cancion cancion { get => _cancion; set => _cancion = value; }
        public Nodo siguiete { get => _siguiente; set => _siguiente = value; }
        public Nodo anterior { get => _anterior; set => _anterior = value; }

    }
}
