/*Crea una clase Videojuego con Nombre , Plataforma y Precio . Utiliza un constructor para inicializar el
objeto a partir de los datos ingresados por el usuario mediante la terminal. Muestra la información por pantalla y
dibuja el diagrama UML de la clase.*/

using System;

namespace ejercicio1
{
    class Persona
    {
        public string nombre;
        public int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;

            System.Console.WriteLine("Persona ingresada correctamente");
        }
    }
    class Program
    {
        static void Main()
        {
            string nombre;
            int edad;


            System.Console.WriteLine("Ingrese el nombre de la persona");
            nombre = Console.ReadLine();

            System.Console.WriteLine("Ingrese la edad de la persona");
            edad = int.Parse(Console.ReadLine());

            Persona p1 = new Persona(nombre, edad);

            System.Console.WriteLine($"{p1.nombre}, {p1.edad} de edad");
            
        }
    }
}
