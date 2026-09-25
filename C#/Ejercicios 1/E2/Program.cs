/*Crea una clase Libro con Titulo , Autor y AnioPublicacion . Define un constructor para inicializar todos
los atributos y un método MostrarInformacion() . Pide los datos al usuario desde la terminal para crear la
instancia, invoca el método y diseña el diagrama UML de la clase.*/

using System;

namespace ejercicio2
{
    class Libro
    {
        public string titulo;
        public string autor;
        public int aniopublicacion;

        public Libro(string titulo, string autor, int aniopublicacion)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.aniopublicacion = aniopublicacion;

            System.Console.WriteLine("Se ha ingresado el libro correctamente");
            Thread.Sleep(500);
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Titulo del libro: {titulo}");
            System.Console.WriteLine($"nombre del autor del libro: {autor}");
            System.Console.WriteLine($"año de publicacion del libro del libro: {aniopublicacion}");
        }
    }
    class Program
    {
        static void Main()
        {
            string titulo;
            string autor;
            int aniopublicacion;

            System.Console.WriteLine("Ingrese el titulo del libro");
            titulo = Console.ReadLine();

            System.Console.WriteLine("Ingrese el nombre del autor");
            autor = Console.ReadLine();

            System.Console.WriteLine("Ingrese el año de publicacion");
            aniopublicacion = int.Parse(Console.ReadLine());

            Libro l1 = new Libro(titulo, autor, aniopublicacion);

            l1.MostrarInfo();
        }
    }
}
