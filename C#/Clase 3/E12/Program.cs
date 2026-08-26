/*Determine todos los números enteros que sean múltiplos de 3 y que sean mayores a 0 y menores a n
(leído)*/
using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            System.Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());

            for (int i=1;i<a;i++)
            {
                if (i%3==0)
                {
                    System.Console.WriteLine(i);
                    Thread.Sleep(500);
                }
                else
                {
                    continue;
                }                    
            }
        }
    }
}