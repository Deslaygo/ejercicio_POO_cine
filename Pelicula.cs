using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_cine
{
    public class Pelicula : LargoMetraje
    {
        //Propiedades auto implementadas
        public string Nombre_actor { get; set; }
        public int Restriccion_edad { get; set; }
        public string Fecha { get; set; }
        public string Genero { get; set; }
        //Constructores

        public Pelicula(string nombre_actor, int restriccion_edad, string fecha, string genero)
        {
            Nombre_actor = nombre_actor;
            Restriccion_edad = restriccion_edad;
            Fecha = fecha;
            Genero = genero;
        }

        public Pelicula(string nombre, double duracion, string director, decimal costo) : base(nombre, duracion, director, costo)
        {
        }

        public Pelicula()
        {
            Nombre = "";
            Duracion = 0.0;
            Director = "";
            Costo = 0.0m;
            Nombre_actor = "";
            Restriccion_edad = 0;
            Fecha = "";
            Genero = "";
        }
    
    }
}
