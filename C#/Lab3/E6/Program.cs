/*Crea una clase Persona con los atributos privados nombre y edad . La edad debe cumplir la validación Edad ≥
0; si se intenta asignar un valor negativo, el atributo debe mantener su valor previo sin modificarse. Solicita los
datos al usuario vía terminal para verificar este comportamiento y construye el diagrama UML. 
*/

using System;

namespace ejercicio6
{
    class Persona
    {
        private string nombre;
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

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                if(value >= 0)
                {
                    edad = value;
                }
                else
                {
                    System.Console.WriteLine("No se pueden ingresar valores negativos");
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Persona p1 = new Persona();
            
            System.Console.WriteLine("Ingrese el nombre de la persona");
            p1.Nombre = Console.ReadLine();

            System.Console.WriteLine("Ingrese la edad de la persona");
            p1.Edad = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Nombre de la persona : {p1.Nombre}");
            System.Console.WriteLine($"Edad de la persona : {p1.Edad}");
        }
    }
}
