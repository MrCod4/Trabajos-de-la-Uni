using System;

namespace ejercicio6
{
    class Program
    {

        static void saludar()
        {
            System.Console.WriteLine("Hola, bienvenido");
        }

        static void saludar(string nombre)
        {
            System.Console.WriteLine("Hola, "+nombre+"Bienvenido");
        }

        static void saludar(string nombre, string titulo)
        {
            System.Console.WriteLine("Hola, "+titulo+" "+nombre+" Bienvenido");
        }
        static void Main(string[] args)
        {
            int opcion;
            string nombre;
            string titulo;

            System.Console.WriteLine("Ingrese su opcion de saludo (numero del 1 al 3)");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                saludar();
                break;

                case 2:
                System.Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                saludar(nombre);
                break;

                case 3:
                System.Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                System.Console.WriteLine("Ingrese su nombre");
                titulo = Console.ReadLine();

                saludar(nombre, titulo);

                break;

                
                default:
                System.Console.WriteLine("Ingrese un valor valido");
                break;
            }
        }
    }
}
