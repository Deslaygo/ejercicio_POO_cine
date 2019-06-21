using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_cine
{
    public class Cine 
    {
        //Propiedades 
        public  string  Nombre { get; set; }
        public string Funcion { get; set; }
        public string Direccion { get; set; }

        //constructor
        public Cine()
        {
            Nombre = "";
            Funcion = "";
        }
        public Cine(string nombre, string funcion)
        {
            Nombre = nombre;
            Funcion = funcion;
        }

        //Método que esta asociado a largometraje
        public void reproducir(LargoMetraje largo,string horario)
        {
            Console.WriteLine("La función inicia a las: " + horario);
            Console.WriteLine("Se esta reproduciendo: "+ largo.Nombre);
            Console.WriteLine("Dirigida por: " + largo.Director);
        }

        //Metodo con referencia a largometraje
        public void mostrarCartelera(LargoMetraje largo1, LargoMetraje  largo2)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Nombre: " + largo1.Nombre);
            Console.WriteLine("Director: " + largo1.Director);
            Console.WriteLine("Duración: " + largo1.Duracion);
            Console.WriteLine("---------");
            Console.WriteLine("Nombre: " + largo2.Nombre);
            Console.WriteLine("Director: " + largo2.Director);
            Console.WriteLine("Duración: " + largo2.Duracion);
        }

    }
}
