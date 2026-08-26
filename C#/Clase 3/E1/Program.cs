//1. Confeccione un algoritmo que lea un número e indique si este es positivo o negativo.
using System;
using System.Globalization;
namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            double num = double.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("Su numero es positivo");
            }
            else if(num == 0)
            {
                Console.WriteLine("Su numero es 0");
            }
            else
            {
                Console.WriteLine("Su numero es negativo");
                
            }

        }
    }
}

