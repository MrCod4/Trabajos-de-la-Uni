/* Determine todos los números primos gemelos que existen entre A y B (que deben ser leídos). Dos
números son primos gemelos si son primos con una diferencia entre ellos de exactamente 2. Por
ejemplo 3 y 5 son números primos gemelos.*/
using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            System.Console.WriteLine("Ingrese el valor de a: ");
            a = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese el valor de b: ");
            b = int.Parse(Console.ReadLine());

            if ((a - b)%2 == 0)
            {
                System.Console.WriteLine("Sus numeros son primos gemelos");
            }
            else
            {
                System.Console.WriteLine("Sus numeros no son primos gemelos");
            }
        }
    }
}
