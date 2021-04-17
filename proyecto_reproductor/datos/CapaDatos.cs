using listas;
using proyecto_reproductor.db;
using proyecto_reproductor.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace proyecto_reproductor.datos
{
    class CapaDatos
    {
        Conexion cn = new Conexion();
        public bool existe(String cancion)
        {
            String query = $"SELECT * FROM canciones WHERE nombre = '{cancion}'";

            DataTable dta = cn.consultaTablaDirecta(query);

            int n = dta.Rows.Count;

            return  n== 0 ? true : false;
        }

        public void agregar(String cancion)
        {
            String query = $"INSERT INTO canciones VALUES('{cancion}')";
            cn.EjecutaSQLDirecto(query);
        }

        public String insertar(string nombre)
        {
            String query = $"INSERT INTO listas VALUES('{nombre}')";
            cn.EjecutaSQLDirecto(query);

            return "Se Guardaron Correctamente los datos";
        }


        public List<String> listasReproduccion()
        {
            String query = $"SELECT * FROM listas";
            DataTable dta = cn.consultaTablaDirecta(query);
            List<String> canciones = new List<String>();
            foreach(DataRow dr in dta.Rows)
            {
                String cancion = dr["nombre"].ToString();
                canciones.Add(cancion);
                cancion = "";
            }
            return canciones;
        }

        public void guardarReproduccion(String cancion, String lista)
        {
            String query = $"INSERT INTO lista_repro VALUES('{cancion}','{lista}')";
            cn.EjecutaSQLDirecto(query);
        }

        public List<string> cancionesRepro(string lista)
        {
            String query = $"SELECT  * FROM lista_repro WHERE nombre_lista='{lista}';";
            DataTable dta = cn.consultaTablaDirecta(query);
            List<string> canciones = new List<string>();
            foreach (DataRow dr in dta.Rows)
            {
                string cancion = dr["nombre_cancion"].ToString();
                canciones.Add(cancion);
                cancion = "";
            }
            return canciones;
        }
    }


}
