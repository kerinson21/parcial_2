using proyecto_reproductor.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Lista
    {
        Nodo cabeza = new Nodo();
        Nodo cola = new Nodo();
        int _longitud;

        public int longitud { get => _longitud; set => _longitud = value; }

        public Lista()
        {
            cabeza = null;
            cola = null;
        }

        public void add(Cancion cancion)
        {
            Nodo nuevo = new Nodo();
            nuevo.cancion = cancion;
            if (cabeza == null)
            {
                cabeza = nuevo;
                cola = nuevo;
                cabeza.siguiete = cabeza;

                cabeza.anterior = cola;
            }
            else
            {
                cola.siguiete = nuevo;
                nuevo.anterior = cola;
                nuevo.siguiete = cabeza;
                cola = nuevo;
            }

        }
        public void recorrer()
        {
            longitud = 0;
            Nodo actual = new Nodo();
            actual = cabeza;

            if (actual != null)
            {
                do
                {
                    longitud++;
                    actual = actual.siguiete;

                } while (actual != cabeza);
            }

        }
        public Cancion[] toArreglo()
        {
            recorrer();
            Cancion[] canciones = new Cancion[longitud];

            Nodo actual = new Nodo();
            actual = cabeza;
            int iterador = 0;
            if (actual != null)
            {
                do
                {
                    canciones[iterador] = actual.cancion;
                    actual = actual.siguiete;
                    iterador++;
                } while (actual != cabeza);
            }
            return canciones;
        }
    }
}
