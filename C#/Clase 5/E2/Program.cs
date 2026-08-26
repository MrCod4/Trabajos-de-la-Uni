/*Complete el código C# para definir la clase Estudiante, agregue el método MostrarEstado() que evalúe si el
alumno está aprobado (nota final ≥ 4.0) e instancie 2 objetos en el Main.
*/

using System;

namespace ejercicio2
{
    class Estudiante
    {

        public string nombre;
        public string carrera;
        public double notaFinal;
        
        public void MostrarDatos()
        {
            Console.WriteLine($"Alumno: {nombre} | Carrera: {carrera} | Nota: {notaFinal}");
        }

        public void MostrarEstado()
        {
            if(notaFinal >= 4.0)
            {
                System.Console.WriteLine("Aprobo la materia");
            }
            else
            {
                System.Console.WriteLine("Reprobo el curso");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string n1;
            string c1;
            double nt1;

            string n2;
            string c2;
            double nt2;

            System.Console.WriteLine("Ingrese el nombre del estudiante 1");
            n1 = Console.ReadLine();
            
            System.Console.WriteLine("Ingrese la carrera del estudiante 1");
            c1 = Console.ReadLine();

            System.Console.WriteLine("Ingrese la nota final del estudiante 1");
            nt1 = double.Parse(Console.ReadLine());

            Estudiante e1 = new Estudiante();
            e1.nombre = n1;
            e1.carrera = c1;
            e1.notaFinal = nt1;

            System.Console.WriteLine("Ingrese el nombre del estudiante 2");
            n2 = Console.ReadLine();
            
            System.Console.WriteLine("Ingrese la carrera del estudiante 2");
            c2 = Console.ReadLine();

            System.Console.WriteLine("Ingrese la nota final del estudiante 2");
            nt2 = double.Parse(Console.ReadLine());

            Estudiante e2 = new Estudiante();
            e2.nombre = n2;
            e2.carrera = c2;
            e2.notaFinal = nt2;

            System.Console.WriteLine("--Estudiante 1--");
            e1.MostrarDatos();
            e1.MostrarEstado();

            System.Console.WriteLine("--Estudiante 2--");
            e2.MostrarDatos();
            e2.MostrarEstado();

        }
    }
}
