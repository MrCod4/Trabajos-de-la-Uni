using System;

namespace ejercicio1
{
    public class Estudiante
    {
        public string nombre;
        public int edad;
        public string carrera;

        public Estudiante(string nombre, int edad, string carrera)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.carrera = carrera;
            System.Console.WriteLine("Se ha creado el estudiante.");
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nombre del estudiante: {nombre}");
            System.Console.WriteLine($"Edad del estudiante: {edad}");
            System.Console.WriteLine($"Carrera del estudiante: {carrera}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Estudiante estudiante1 = new Estudiante("Juan", 20, "Ingenieria en ejecución informatica");
            estudiante1.MostrarInfo();
        }
    }
}
