﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_cine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de los objetos
            //Datos de pelicula
            Pelicula pelicula = new Pelicula();
            pelicula.Nombre = "Gladiador";
            pelicula.Director = "Arturo Rosas";
            pelicula.Genero = "Acción";
            //Objeto documental
            Documental terremoto = new Documental("Terremoto de 1986", 2.30, "Omar Castelo", 200000.90m, "Catastrofe natural", "naturaleza");
            //Instancia del objeto cine
            Cine puebla = new Cine();
            puebla.Nombre = "Centro";

            //Implementamos los métodos
            puebla.Funcion = "12:30 p.m.";
            puebla.reproducir(pelicula,puebla.Funcion);
            puebla.Funcion = "4:00 p.m.";
            puebla.reproducir(terremoto,puebla.Funcion);

            puebla.mostrarCartelera(pelicula,terremoto);
            Console.ReadKey();
        }
    }
}
