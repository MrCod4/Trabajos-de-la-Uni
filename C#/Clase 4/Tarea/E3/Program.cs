/*Escribe el método Intercambiar que reciba dos números enteros por referencia y permute sus contenidos
directamente en las variables del programa principal.
*/

using System;

namespace ejercicio3
{
    class Program
    {

        static void cambio(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;

        }
        static void Main(string[] args)
        {
            int a;
            int b;

            System.Console.WriteLine("Ingrese el valor de A");
            a = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese el valor de B");
            b = int.Parse(Console.ReadLine());

            cambio(ref a, ref b);

            System.Console.WriteLine("el valor de A ahora es: "+a);
            System.Console.WriteLine("el valor de B ahora es: "+b);
        }
    }
}
