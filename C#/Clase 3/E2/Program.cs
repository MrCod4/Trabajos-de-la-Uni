//Confeccione un algoritmo que lea un número e indique si este es par o impar.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            if (num%2 == 0)
            {
                Console.WriteLine("Su numero es par");
            }
            else
            {
                Console.WriteLine("Su numero es impar");   
            }
        }
    }
}
