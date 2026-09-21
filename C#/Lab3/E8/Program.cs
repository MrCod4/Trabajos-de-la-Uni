/*Crea una clase Estudiante con Nombre y Nota . La nota debe estar restringida al rango entre 1.0 y 7.0
(valores como 0.5 u 8.0 no deben ser aceptados). Pide al usuario que ingrese la información desde la terminal para
probar la regla de negocio y diagrama la clase en UML.*/

using System;

namespace ejercicio8
{
    class Estudiante
    {
        private string nombre;
        private double nota;
        public string Nombre
        {
            get{ return nombre;}
            set{ nombre = value;}
        }
        public double Nota
        {
            get
            {
                return nota;
            }

            set
            {
                if(value >= 1.0 && value <= 7.0)
                {
                    nota = value;
                }
                else
                {
                    System.Console.WriteLine("Nota invalida");
                }
            }
        }

        public Estudiante(string nombre, double nota)
        {
            Nombre = nombre;
            Nota = nota;

            System.Console.WriteLine("Estudiante creado exitosamente");
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine($"Nombre del estudiante : {nombre}");
            System.Console.WriteLine($"Nota de estudiante : {nota}");
        }

    }
    class Program
    {
        static void Main()
        {
            string nombre;
            double nota;

            System.Console.WriteLine("Ingrese el nombre del estudiante");
            nombre = Console.ReadLine();

            System.Console.WriteLine("Ingre la nota del estudiante");
            nota = double.Parse(Console.ReadLine());

            Estudiante e1 = new Estudiante(nombre, nota);

            e1.MostrarInfo();
        }
    }
}
