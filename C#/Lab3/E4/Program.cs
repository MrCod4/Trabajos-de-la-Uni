/*Crea una clase Estudiante con los atributos privados nombre , edad y carrera . Define Properties para
acceder a ellos. Desde la consola, solicita los datos al usuario, asígnalos mediante las Properties, muestra el
resultado e incluye el diagrama UML respectivo.*/

using System;

namespace ejercicio4
{
    class Estudiante
    {
        private string nombre;
        private string carrera;
        private int edad;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Carrera
        {
            get
            {
                return carrera;
            }

            set
            {
                carrera = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Estudiante e1 = new Estudiante();

            System.Console.WriteLine("Ingrese el nombre del estudiante");
            e1.Nombre = Console.ReadLine();

            System.Console.WriteLine("Ingrese la carrera del estudiante");
            e1.Carrera = Console.ReadLine();

            System.Console.WriteLine("Ingrese la edad del estudiante");
            e1.Edad = int.Parse(Console.ReadLine());

            System.Console.WriteLine("=== Datos del estudiante ===");
            System.Console.WriteLine($"Nombre del estudiante : {e1.Nombre}");
            System.Console.WriteLine($"Carrera del estudiante : {e1.Carrera}");
            System.Console.WriteLine($"Edad del estudiante : {e1.Edad}");
        }
    }
}
