/*Confeccione un algoritmo que lea un número e indique si este es par positivo, 
par-negativo, impar-positivo o impar-negativo.*/
using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            System.Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            if(n%2 == 0 )
            {
                if (n > 0)
                {
                    System.Console.WriteLine("Su numero es un par positivo");
                }
                else
                {
                    System.Console.WriteLine("Su numero es un par negativo");
                }
            }
            else
            {
                if (n < 0)
                {
                    System.Console.WriteLine("Su numero es un par negativo");
                }
                else
                {
                    System.Console.WriteLine("Su numero es un par negativo");
                }
            }
        }
    }
}