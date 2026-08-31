/*Implementa tres versiones sobrecargadas de la función CalcularArea :
CalcularArea(double lado) : calcula y retorna el área de un cuadrado.
CalcularArea(double base, double altura) : calcula y retorna el área de un rectángulo.
CalcularArea(double radio, bool esCirculo) : calcula y retorna el área de un círculo.*/

using System;

namespace ejercicio7
{
    class Program
    {
        static double CalcularArea(double lado)
        {
            return Math.Pow(lado, 2);
        }

        static double CalcularArea(double lado, double altura)
        {
            return lado*altura;
        }

        static double CalcularArea(double radio, bool esCirculo)
        {
            return 3.14*(Math.Pow(radio, 2));
        }

        static void Main()
        {
            int opcion;
            bool esCirculo;
            double lado;
            double altura;
            double radio;
            double area = 0;

            System.Console.WriteLine("Ingrese el area de la figura que desea sacar");
            System.Console.WriteLine("1. Cuadrado");
            System.Console.WriteLine("2. rectangulo");
            System.Console.WriteLine("3. Circulo");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                System.Console.WriteLine("Ingrese el lado del cuadrado");
                lado = double.Parse(Console.ReadLine());
                area = CalcularArea(lado);

                break;

                case 2:
                System.Console.WriteLine("Ingrese la base del cuadrado");
                lado = double.Parse(Console.ReadLine());

                System.Console.WriteLine("Ingrese la altura del cuadrado");
                altura = double.Parse(Console.ReadLine());
                area = CalcularArea(lado, altura);

                break;

                case 3:
                System.Console.WriteLine("Ingrese el radio del circulo");
                radio = double.Parse(Console.ReadLine());
                esCirculo = true;
                area = CalcularArea(radio, esCirculo);

                break;

                default:
                System.Console.WriteLine("Ingrese un valor valido (entre 1 y 3)");
                break;
            }
            
            System.Console.WriteLine("Area de la figura ingresada: "+area);
        }
    }
}
